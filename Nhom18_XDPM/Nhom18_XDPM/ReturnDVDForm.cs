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

namespace Nhom18_XDPM
{
    public partial class ReturnDVDForm : Form
    {
        private const string DATE_FORMAT = "dd/MM/yyyy";
        private CustomerBLL _customerBLL;
        private RecordBLL _recordBLL;
        private Customer customer;
        private List<Record> records,recordsTitle;
        public ReturnDVDForm()
        {
            InitializeComponent();
            _customerBLL = new CustomerBLL();
            _recordBLL = new RecordBLL();

            customer = new Customer();
            records = new List<Record>();
            recordsTitle = new List<Record>();
         
        }
        private void CreateDataGridView()
        {
            dgv_listItem.ColumnCount = 4;
            dgv_listItem.MultiSelect = false;
            dgv_listItem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_listItem.Columns[0].Name="STT";
            dgv_listItem.Columns[0].Width = (int)(dgv_listItem.Width*0.1);
            dgv_listItem.Columns[1].Name = "Mã đĩa";
            dgv_listItem.Columns[1].Width = (int)(dgv_listItem.Width * 0.15);
            dgv_listItem.Columns[2].Name = "Ngày thuê";
            dgv_listItem.Columns[2].Width = (int)(dgv_listItem.Width * 0.3);
            dgv_listItem.Columns[3].Name = "Ngày cần trả";
            dgv_listItem.Columns[3].Width = (int)(dgv_listItem.Width * 0.3);
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            dgv_listItem.Columns.Add(chk);
            chk.HeaderText = "Hủy trả";
            chk.Name = "Cancel";
            dgv_listItem.Columns["Cancel"].Width = (int)(dgv_listItem.Width * 0.15);
        }
        public void OpenFormLateCharge()
        {
            CheckLateChargeForm lateCharge;
            if (txt_numberPhone.Text.Length >0)
            {
                lateCharge = new CheckLateChargeForm(Convert.ToInt32(txt_numberPhone.Text.Trim()));
            }
            else
                lateCharge = new CheckLateChargeForm();

            this.Controls.Clear();
            Panel panel = new Panel();
            this.Controls.Add(panel);
            panel.Dock = DockStyle.Fill;
            lateCharge.TopLevel = false;
            lateCharge.Parent = panel;
            lateCharge.Show();
        }
        public void OpenCheckLateCharge(int idCustomer)
        {
            List<Record> listPaid = new List<Record>();
            listPaid = _recordBLL.GetAllRecordUnPaid(idCustomer);
            if (listPaid.Count > 0)
            {
                DialogResult result1 = MessageBox.Show("Khách hàng có khoản trễ hạn. Có muốn thực hiện thanh toán không?", "Phí trễ hạn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result1 == DialogResult.Yes)
                {
                    OpenFormLateCharge();
                }
            }
        }
        public void LoadDataGridView(List<Record> records)
        {
            int i = 1;
            foreach (var item in records)
            {
                if (item.idDisk != null && item.dueDate != null && item.rentDate != null)
                {
                    dgv_listItem.Rows.Add(i.ToString(), item.idDisk.ToString(), item.rentDate.ToString(), item.dueDate.ToString());
                }
                i++;
            }
        }
        private void txt_numberPhone_Click(object sender, EventArgs e)
        {
            pnl_numberPhone.BackColor = Color.FromArgb(20, 173, 196);
        }

        private void txt_nameCustomer_Click(object sender, EventArgs e)
        {
            pnl_nameCustomer.BackColor = Color.FromArgb(20, 173, 196);
        }

        private void txt_searchDiskReturn_Click(object sender, EventArgs e)
        {
            pnl_searchItemReturn.BackColor = Color.FromArgb(20, 173, 196);
            txt_searchDiskReturn.Clear();
        }

        private void txt_numberPhone_TextChanged(object sender, EventArgs e)
        {
            if (txt_numberPhone.Text != "")
            {
                dgv_listItem.Rows.Clear();
                customer = _customerBLL.searchCustomerbyId(Convert.ToInt32(txt_numberPhone.Text.Trim()));
                if (customer != null)
                {
                    txt_nameCustomer.Text = customer.name;
                    records = _recordBLL.GetAllRecordUnReturn(customer.idCustomer);
                    int i = 1;
                    CreateDataGridView();
                    if (records.Count > 0)
                    {
                        LoadDataGridView(records);
                    }
                    else
                    {
                        MessageBox.Show("Khách hàng không có đĩa trả");
                        OpenCheckLateCharge(customer.idCustomer);
                    }

                }
            }
        }

        private void btn_TraHang_Click(object sender, EventArgs e)
        {
            List<Result> resutls = new List<Result>();
            int idCustomer = 0;
            if(records.Count > 0)
            {
                foreach (var record in records)
                {
                    Record temp = new Record();
                    temp.idDisk = record.idDisk;
                    temp.idCustomer = record.idCustomer;
                    idCustomer = record.idCustomer;
                    temp.isPaid = false;
                    temp.actualReturnDate = DateTime.Now;
                    resutls.Add(_recordBLL.UpdateDateReturnAndLateFee(temp));
                }
            }
            else if(recordsTitle.Count > 0)
            {
                foreach (var record in recordsTitle)
                {
                    Record temp = new Record();
                    temp.idDisk = record.idDisk;
                    temp.idCustomer = record.idCustomer;
                    idCustomer = record.idCustomer;
                    temp.isPaid = false;
                    temp.actualReturnDate = DateTime.Now;
                    resutls.Add(_recordBLL.UpdateDateReturnAndLateFee(temp));
                }
            }
            
            int count = 0;
            foreach (var item in resutls)
            {
                if (item.message.Equals("Cập nhật thành công"))
                    count++;
            }
            if (count == resutls.Count)
            {
                dgv_listItem.Rows.Clear();
                MessageBox.Show("Trả hàng thành công");
            }
            if(records.Count > 0)
                LoadDataGridView(records);

            OpenCheckLateCharge(idCustomer);
        }
        private void btn_openListLateCharge_Click(object sender, EventArgs e)
        {
            OpenFormLateCharge();
        }
        int i = 0;

        private void dgv_listItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Record record = new Record();
            if (e.RowIndex >= 0 && e.ColumnIndex == 4)
            {
                DataGridViewRow row = dgv_listItem.Rows[e.RowIndex];
                row.Cells["Cancel"].Value = !Convert.ToBoolean(row.Cells["Cancel"].EditedFormattedValue);
                if (Convert.ToBoolean(row.Cells["Cancel"].Value))
                {
                    record.idDisk = row.Cells[1].Value.ToString();
                    record.idCustomer = 0;
                    record.isPaid = true;
                    record.rentDate = DateTime.Parse(row.Cells[2].Value.ToString());
                    record.dueDate = DateTime.Parse(row.Cells[3].Value.ToString());
                    records.Add(record);
                }
                else
                {
                    for (int item = 0; item < records.Count; item++)
                    {
                        if (row.Cells[1].Value.ToString() == records[item].idDisk)
                            records.RemoveAt(item);
                    }
                }
            }
        }

        private void txt_searchDiskReturn_TextChanged(object sender, EventArgs e)
        {
            Record disk = new Record();
            disk = _recordBLL.GetDiskById(txt_searchDiskReturn.Text.Trim());
            if (disk != null)
            {
                i += 1;
                CreateDataGridView();
                dgv_listItem.Rows.Add(i.ToString(), disk.idDisk.ToString(), disk.rentDate.ToString(), disk.dueDate.ToString());
                recordsTitle.Add(disk);
            }
        }

    }
}
