using Business;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom18_XDPM_UI
{
    public partial class UC_ReturnDisk : UserControl
    {
        private static UC_ReturnDisk _instance;
        //Quoc
        BindingSource bindingSource;
        CustomerBLL customerBLL;
        DiskBLL diskBLL;
        RecordBLL recordBLL;
        AutoCompleteStringCollection autoIDDisk;
        List<Record> records;


        public static UC_ReturnDisk Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_ReturnDisk();
                return _instance;
            }
        }
        public UC_ReturnDisk()
        {
            InitializeComponent();
            //Quoc
            customerBLL = new CustomerBLL();
            diskBLL = new DiskBLL();
            recordBLL = new RecordBLL();
            records = new List<Record>();

            //AutoComplete
            autoIDDisk = new AutoCompleteStringCollection();
            txtIDDia.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtIDDia.AutoCompleteSource = AutoCompleteSource.CustomSource;

            CreateDataGridView();
            dgvReturn.DefaultCellStyle.Font = new Font("microsoft sans serif", 11);
            dgvReturn.ColumnHeadersDefaultCellStyle.Font = new Font("microsoft sans serif", 13);
            dgvReturn.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        private void CreateDataGridView()
        {

            dgvReturn.ColumnCount = 4;
            dgvReturn.MultiSelect = false;
            dgvReturn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReturn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvReturn.Columns[0].Name = "STT";
            dgvReturn.Columns[0].Width = (int)(dgvReturn.Width * 0.1);
            dgvReturn.Columns[1].Name = "Mã đĩa";
            dgvReturn.Columns[1].Width = (int)(dgvReturn.Width * 0.2);
            dgvReturn.Columns[2].Name = "Ngày thuê";
            dgvReturn.Columns[2].Width = (int)(dgvReturn.Width * 0.3);
            dgvReturn.Columns[3].Name = "Ngày cần trả";
            dgvReturn.Columns[3].Width = (int)(dgvReturn.Width * 0.3);
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dgvReturn.Columns.Add(btn);
            btn.HeaderText = "Huỷ bỏ";
            btn.Text = "Huỷ";
            btn.Name = "btn_Detele";
            btn.UseColumnTextForButtonValue = true;
            dgvReturn.Columns["btn_Detele"].Width = (int)(dgvReturn.Width * 0.1);


        }

        public void LoadDataGridView(List<Record> records)
        {
            int i = 1;
            foreach (var item in records)
            {
                dgvReturn.Rows.Add(i.ToString(), item.idDisk.ToString(), item.rentDate.ToString(), item.dueDate.ToString(), true);
            }
            i++;
        }

        private void btnThongTinPhiTre_Click(object sender, EventArgs e)
        {
            
            if (!Parent.Controls.Contains(UC_CheckLateCharge.Instance))
            {
                Parent.Controls.Add(UC_CheckLateCharge.Instance);
                UC_CheckLateCharge.Instance.Dock = DockStyle.Fill;
                UC_CheckLateCharge.Instance.BringToFront();
            }
            else
                UC_CheckLateCharge.Instance.BringToFront();
        }

        private void UC_ReturnDisk_Load(object sender, EventArgs e)
        {
            txtDiskName.Enabled = false;

            foreach (var item in diskBLL.getDisksRented())
            {
                autoIDDisk.Add(item.idDisk.ToString());
            }
            txtIDDia.AutoCompleteCustomSource = autoIDDisk;
        }

        private void txtIDDia_TextChanged(object sender, EventArgs e)
        {
            txtDiskName.Text = "";
            foreach (var item in autoIDDisk)
            {
                if(txtIDDia.Text.Trim() == item.ToString().Trim())
                {
                    txtDiskName.Text = diskBLL.getDiskByID(txtIDDia.Text).name;
                    break;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!autoIDDisk.Contains(txtIDDia.Text))
            {
                MessageBox.Show("Chỉ nhập giá trị trong gợi ý!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var record = recordBLL.GetRecordUnReturnByDiskID(txtIDDia.Text);
            if(record != null)
            {
                records.Add(record);
                CreateDataGridView();
                dgvReturn.Rows.Add(1, record.idDisk.ToString(), record.rentDate.ToString(), record.dueDate.ToString());

                //xoá phần từ trong AutoComplete khi thêm record vào dgv
                autoIDDisk.Remove(txtIDDia.Text);
                txtIDDia.Text = "";
            }
        }

        private void dgvReturn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                DialogResult dr = MessageBox.Show("Bạn muốn HỦY đĩa này .\nXác Nhận Hủy ?", "Hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                var diskID = dgvReturn.Rows[e.RowIndex].Cells["Mã Đĩa"].Value.ToString().Trim();
                if (dr == DialogResult.Yes && diskID != null)
                {
                    var record = recordBLL.GetRecordUnReturnByDiskID(diskID);

                    dgvReturn.Rows.RemoveAt(dgvReturn.Rows[e.RowIndex].Index);
                    records.Remove(record);
                    autoIDDisk.Add(diskID);
                }
                else
                {
                    return;
                }
            }
        }

        private void btnTraDia_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn xác nhận việc TRẢ đĩa.\nXác Nhận Hủy ?", "Hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                foreach (var item in records)
                {
                    //Cập nhật Record
                    item.isPaid = true;
                    item.actualReturnDate = DateTime.Now;
                    recordBLL.updateReturnDisk(item);
                    //thay đổi trạng thái đĩa
                    Disk disk = diskBLL.getDiskByID(item.idDisk);
                    disk.status = DataAccess.Entities.Enum.Status.OnShelf;
                    diskBLL.updateStatusDisk(disk);

                    autoAssignDisk(disk);
                }
                MessageBox.Show("Trả đĩa thành công!");
                dgvReturn.Rows.Clear();
            }
            
        }

        private void autoAssignDisk(Disk disk)
        {

        }
    }
}
