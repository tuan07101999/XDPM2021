using Business;
using DataAccess.DTO;
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
    public partial class UC_CheckLateCharge : UserControl
    {
        public List<RecordDTO> listRecord;
        private BindingSource bindingSource;
        private RecordBLL recordBLL;
        private int idCustomer;
        private CustomerBLL customerBLL;
        private DiskBLL diskBLL;
        private static UC_CheckLateCharge _instance;
        float totalLateFee = 0;
        public static UC_CheckLateCharge Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_CheckLateCharge();
                return _instance;
            }
        }
        public UC_CheckLateCharge()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            recordBLL = new RecordBLL();
            customerBLL = new CustomerBLL();
            diskBLL = new DiskBLL();
            totalLateFee = 0;
        }
        public void GetIdCustomerFromRentDisk(int _idCustomer)
        {
            idCustomer = _idCustomer;
            txtTimKiem.Text = idCustomer.ToString();
        }
        public void CreateButtonDataGridView()
        {  
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "";
            btn.Name = "btnXoa";
            btn.Text = "Xóa";
            btn.UseColumnTextForButtonValue = true;
            dgvListItem.Columns.Add(btn);
        }
        public void CreateDataGridView(string key)
        {
            bindingSource.DataSource = listRecord;
            dgvListItem.ClearSelection();
            dgvListItem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListItem.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListItem.DataSource = bindingSource;
            dgvListItem.MultiSelect = false;
            dgvListItem.ReadOnly = true;
            dgvListItem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (listRecord.Count > 0)
            {
                dgvListItem.Rows[0].Selected = false;
                dgvListItem.Columns["nameCustomer"].Visible = false;
                dgvListItem.Columns["idRecord"].Visible = false;
                dgvListItem.Columns["isPaid"].HeaderText = "Xác nhận thanh toán";
            }
        }
        private void CheckLateFeeForm_Load(object sender, EventArgs e)
        {
            DataBindings.Clear();
            CreateDataGridView("");
            txtTimKiem.Text = idCustomer.ToString();
            txtTongTien.Text = totalLateFee.ToString();
            txtTongTien.Enabled = false;
            btnThanhToan.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (!Parent.Controls.Contains(UC_RentDisk.Instance))
            {
                Parent.Controls.Add(UC_RentDisk.Instance);
                UC_RentDisk.Instance.Dock = DockStyle.Fill;
                UC_RentDisk.Instance.BringToFront();
            }
            else
                UC_RentDisk.Instance.BringToFront();


            dgvListItem.Rows.Clear();
            dgvListItem.Refresh();
            totalLateFee = 0;
            txtTongTien.Text = "0";
            listRecord = null;
        }

        private void pictureBoxTimKiem_Click(object sender, EventArgs e)
        {
            DataBindings.Clear();
            dgvListItem.Columns.Clear();
            if (listRecord == null)
            {
                listRecord = new List<RecordDTO>();
                var listTemp = recordBLL.checkLateFee(idCustomer);
                foreach (var item in listTemp)
                {
                    listRecord.Add(new RecordDTO()
                    {
                        idRecord = item.idRecord,
                        nameCustomer = customerBLL.searchCustomerbyId(item.idCustomer).name,
                        nameDisk = diskBLL.getDiskByID(item.idDisk).name,
                        rentDate = item.rentDate,
                        dueDate = item.dueDate,
                        actualReturnDate = item.actualReturnDate,
                        lateFee = (float)item.lateFee,
                        isPaid = item.isPaid
                    });
                }
                CreateDataGridView("");
                CreateButtonDataGridView();
            }
            if (listRecord.Count > 0)
            {
                CreateDataGridView("");
            }
            if (listRecord.Count == 0)
            {
                dgvListItem.DataSource = new List<RecordDTO>();
                CreateDataGridView("");
            }
        }
        private void dgvListItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListItem.Columns[e.ColumnIndex].HeaderText.Equals("Xác nhận thanh toán"))
            {
                var value = bool.Parse(dgvListItem.Rows[e.RowIndex].Cells["isPaid"].Value.ToString());
                var idRecord = dgvListItem.Rows[e.RowIndex].Cells["idRecord"].Value.ToString();
                var record = listRecord.FirstOrDefault(x => x.idRecord == Int32.Parse(idRecord));
                if (value == false)
                {
                    totalLateFee += float.Parse(dgvListItem.Rows[e.RowIndex].Cells["lateFee"].Value.ToString());
                    record.isPaid = true;
                }
                else
                {
                    totalLateFee -= float.Parse(dgvListItem.Rows[e.RowIndex].Cells["lateFee"].Value.ToString());
                    record.isPaid = false;
                }
                txtTongTien.Text = totalLateFee.ToString();
                if (totalLateFee > 0) btnThanhToan.Enabled = true;
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dgvListItem.SelectedRows.Count > 0 && dgvListItem.SelectedRows[0].Cells[0].Value != null)
            {
                if (!Parent.Controls.Contains(UC_RentDisk.Instance))
                {
                    Parent.Controls.Add(UC_RentDisk.Instance);
                    UC_RentDisk.Instance.Dock = DockStyle.Fill;
                    UC_RentDisk.Instance.BringToFront();
                }
                else
                    UC_RentDisk.Instance.BringToFront();
                UC_RentDisk.Instance.listLateFeeIsPaid(listRecord, totalLateFee);

                dgvListItem.Rows.Clear();
                dgvListItem.Refresh();
                totalLateFee = 0;
                txtTongTien.Text = "0";
                listRecord = null;
            }    
        }

        private void dgvListItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            {
                DataGridViewRow row = dgvListItem.Rows[e.RowIndex];
            }

            if (e.ColumnIndex == 8)
            {
                DialogResult dr = MessageBox.Show("Bạn muốn HỦY đĩa này .\nXác Nhận Hủy ?", "Hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                var idRecord = dgvListItem.Rows[e.RowIndex].Cells["idRecord"].Value.ToString();
                if (dr == DialogResult.Yes && idRecord != null)
                {
                    var record = listRecord.FirstOrDefault(x => x.idRecord == Int32.Parse(idRecord));
                    dgvListItem.Rows.RemoveAt(dgvListItem.Rows[e.RowIndex].Index);
                    listRecord.Remove(record);
                    recordBLL.CancelLateCharge(Int32.Parse(idRecord));
                }
                else return;
               
            }
        }
    }
}
