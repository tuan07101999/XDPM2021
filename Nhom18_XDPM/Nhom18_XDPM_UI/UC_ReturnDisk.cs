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
            diskBLL = new DiskBLL();
            recordBLL = new RecordBLL();
            records = new List<Record>();

            //AutoComplete
            autoIDDisk = new AutoCompleteStringCollection();
            txtIDDia.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtIDDia.AutoCompleteSource = AutoCompleteSource.CustomSource;

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

        //private void btnThongTinPhiTre_Click(object sender, EventArgs e)
        //{
        //    if (!Parent.Controls.Contains(UC_CheckLateCharge.Instance))
        //    {
        //        Parent.Controls.Add(UC_CheckLateCharge.Instance);
        //        UC_CheckLateCharge.Instance.Dock = DockStyle.Fill;
        //        UC_CheckLateCharge.Instance.BringToFront();
        //    }
        //    else
        //    {
        //        UC_CheckLateCharge.Instance.BringToFront();
        //    }
        //}

        private void UC_ReturnDisk_Load(object sender, EventArgs e)
        {
            CreateDataGridView();

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
            if(String.IsNullOrWhiteSpace(txtIDDia.Text))
            {
                MessageBox.Show("Chưa nhập ID đĩa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(!diskBLL.getDisks().Contains(diskBLL.getDiskByID(txtIDDia.Text)))
            {
                MessageBox.Show("Đĩa có ID  "+ txtIDDia.Text+ "  không có trong hệ thống!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!autoIDDisk.Contains(txtIDDia.Text))
            {
                MessageBox.Show("Đĩa chưa được thuê!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var record = recordBLL.GetRecordUnReturnByDiskID(txtIDDia.Text);
            if(record != null)
            {
                records.Add(record);
                //CreateDataGridView();
                dgvReturn.Rows.Add(1, record.idDisk.ToString(), record.rentDate.ToString(), record.dueDate.ToString());

                //xoá phần từ trong AutoComplete khi thêm record vào dgv
                autoIDDisk.Remove(txtIDDia.Text);
                txtIDDia.Text = "";
            }
        }
        private void dgvReturn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            {
                DataGridViewRow row = dgvReturn.Rows[e.RowIndex];
            }
            
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
            if (records.Count == 0)
            {
                MessageBox.Show("Chưa có đĩa trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn xác nhận việc TRẢ đĩa.\nXác Nhận Trả ?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                float lateFeeTotal = 0;
                foreach (var item in records)
                {
                    //Cập nhật Record
                    item.isPaid = true;
                    item.actualReturnDate = DateTime.Now;
                    if(!(item.dueDate is null))
                    {
                        item.lateFee = LateFeeCalculation(item);

                    }
                    if(item.lateFee > 0)
                    {
                        item.isPaid = false;
                    }
                    recordBLL.updateReturnDisk(item);

                    //Tính phí trễ
                    lateFeeTotal += item.lateFee.Value;

                    //thay đổi trạng thái đĩa
                    Disk disk = diskBLL.getDiskByID(item.idDisk);
                    disk.status = DataAccess.Entities.Enum.Status.OnShelf;
                    diskBLL.updateStatusDisk(disk);
                }
                MessageBox.Show("Trả đĩa thành công! \n Phí trễ được thêm vào:  "+ lateFeeTotal+"$", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvReturn.Rows.Clear();
            }   
        }

        private float LateFeeCalculation(Record record)
        {
            if(record.actualReturnDate > record.dueDate)
            {
                return record.Disk.Title.Category.lateFee;
            }
            return 0;
        }


        public void UC_Load()
        {
            txtDiskName.Enabled = false;
            autoIDDisk.Clear();
            foreach (var item in diskBLL.getDisksRented())
            {
                autoIDDisk.Add(item.idDisk.ToString());
            }
            txtIDDia.AutoCompleteCustomSource = autoIDDisk;

            dgvReturn.Rows.Clear();
            records.Clear();
        }

        private void txtIDDia_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (String.IsNullOrWhiteSpace(txtIDDia.Text))
                {
                    MessageBox.Show("Chưa nhập ID đĩa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                btnThem_Click(sender, e);
            }
                
        }

        private void txtIDDia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Chỉ nhập số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }

        }
    }
}
