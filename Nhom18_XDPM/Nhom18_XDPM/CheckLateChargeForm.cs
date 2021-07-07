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
    public partial class CheckLateChargeForm : Form
    {
        private const string DATE_FORMAT = "dd/MM/yyyy";
        private CustomerBLL _customerBLL;
        private RecordBLL _recordBLL;

        private Customer customer;
        private List<Record> recordUnPaid, recordPaid;
        int tong = 0;

        private int _sendReturn;
        public CheckLateChargeForm()
        {
            InitializeComponent();
            _customerBLL = new CustomerBLL();
            _recordBLL = new RecordBLL();

            recordUnPaid = new List<Record>();
            recordPaid = new List<Record>();
            lbl_lateFee.Text = tong.ToString() + " VND";

        }
        public CheckLateChargeForm(int idCustomer)
        {
            InitializeComponent();
            _customerBLL = new CustomerBLL();
            _recordBLL = new RecordBLL();

            recordUnPaid = new List<Record>();
            recordPaid = new List<Record>();

            _sendReturn = idCustomer;
            txt_numberPhone.Text = _sendReturn.ToString(); 
            lbl_lateFee.Text = tong.ToString() + " VND";

        }
        private void CreateDataGridView()
        {
            dgv_listItem.ColumnCount = 5;
            dgv_listItem.MultiSelect = false;
            dgv_listItem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_listItem.Columns[0].Name = "STT";
            dgv_listItem.Columns[0].Width = (int)(dgv_listItem.Width * 0.1);
            dgv_listItem.Columns[1].Name = "Mã đĩa";
            dgv_listItem.Columns[1].Width = (int)(dgv_listItem.Width * 0.15);
            dgv_listItem.Columns[2].Name = "Ngày thuê";
            dgv_listItem.Columns[2].Width = (int)(dgv_listItem.Width * 0.2);
            dgv_listItem.Columns[3].Name = "Ngày cần trả";
            dgv_listItem.Columns[3].Width = (int)(dgv_listItem.Width * 0.2);
            dgv_listItem.Columns[4].Name = "Ngày trả thực";
            dgv_listItem.Columns[4].Width = (int)(dgv_listItem.Width * 0.2);
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            dgv_listItem.Columns.Add(chk);
            chk.HeaderText = "Hủy trả";
            chk.Name = "Cancel";
            dgv_listItem.Columns["Cancel"].Width = (int)(dgv_listItem.Width * 0.15);

        }
        public void LoadDataGridView(List<Record> records)
        {
            int i = 1;
            foreach (var item in records)
            {
                if (item.idDisk != null && item.dueDate != null && item.rentDate != null && item.actualReturnDate != null)
                {
                    dgv_listItem.Rows.Add(i.ToString(), item.idDisk.ToString(),
                        item.rentDate.ToString(), item.dueDate.ToString(), item.actualReturnDate);
                }
                i++;
            }
            tong = (i - 1) * 1;
            lbl_lateFee.Text = tong.ToString() + " VND";
        }
        private void txt_numberPhone_TextChanged(object sender, EventArgs e)
        {
            customer = new Customer();
            if (txt_numberPhone.Text.Length > 0)
            {
                dgv_listItem.Rows.Clear();
                customer = _customerBLL.searchCustomerbyId(Convert.ToInt32(txt_numberPhone.Text.Trim()));
                if (customer != null)
                {
                    txt_nameCustomer.Text = customer.name;
                    recordUnPaid = _recordBLL.GetAllRecordUnPaid(customer.idCustomer);
                    recordPaid = recordUnPaid;
                    if (recordUnPaid.Count > 0)
                    {
                        CreateDataGridView();
                        LoadDataGridView(recordUnPaid);
                    }
                    else
                    {
                        MessageBox.Show("Khách hàng không nợ phí trả trễ");
                    }

                }
            }
            
        }
        private void dgv_listItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Record record = new Record();
            if (e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                //Reference the GridView Row.
                DataGridViewRow row = dgv_listItem.Rows[e.RowIndex];

                //Set the CheckBox selection.
                row.Cells["Cancel"].Value = !Convert.ToBoolean(row.Cells["Cancel"].EditedFormattedValue);

                //If CheckBox is checked, display Message Box.
                if (Convert.ToBoolean(row.Cells["Cancel"].Value))
                {
                    tong += 1;
                    lbl_lateFee.Text = tong.ToString() + " VND";
                    record.idDisk = row.Cells[1].Value.ToString();
                    record.idCustomer = 0;
                    record.isPaid = true;
                    record.rentDate = DateTime.Parse(row.Cells[2].Value.ToString());
                    record.dueDate = DateTime.Parse(row.Cells[3].Value.ToString());
                    record.actualReturnDate = DateTime.Parse(row.Cells[4].Value.ToString());
                    recordPaid.Add(record);
                }
                else
                {
                    tong -= 1;
                    lbl_lateFee.Text = tong.ToString() + " VND";
                    for (int item=0; item< recordPaid.Count;item++)
                    {
                        if (row.Cells[1].Value.ToString() == recordPaid[item].idDisk)
                            recordPaid.RemoveAt(item);
                    }
                }
            }
        }

        private void btn_thanhToan_Click(object sender, EventArgs e)
        {
            List<Result> results = new List<Result>();
            foreach (var item in recordUnPaid)
            {
                foreach (var update in recordPaid)
                {
                    if(item.idDisk==update.idDisk && item.rentDate==update.rentDate && item.dueDate== update.dueDate && item.actualReturnDate==update.actualReturnDate)
                    {
                        results.Add(_recordBLL.UpdateIsPaid(update));

                    }
                }
            }
            int count = 0;
            foreach (var item in results)
            {
                if (item.message.Equals("Cập nhật thành công"))
                    count++;
            }
            if (count == results.Count)
            {
                dgv_listItem.Rows.Clear();
                LoadDataGridView(recordPaid);

                MessageBox.Show("Thanh toán thành công");
            }
            
        }
    }
}
