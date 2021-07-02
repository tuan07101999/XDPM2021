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

namespace Nhom9_RentingDisk_XDPM
{
    public partial class ReturnDVDForm : Form
    {
        private const string DATE_FORMAT = "dd/MM/yyyy";
        private CustomerBLL _customerBLL;
        private RecordBLL _recordBLL;
        private TitleBLL _titleBLL;
        private BindingSource _bindingSource;
        private Customer customer;
        private List<Record> records;
        private Title title;
        private Record record;
        public ReturnDVDForm()
        {
            InitializeComponent();
            _bindingSource = new BindingSource();
            _customerBLL = new CustomerBLL();
            _recordBLL = new RecordBLL();
            _titleBLL = new TitleBLL();

            customer = new Customer();
            records = new List<Record>();
            title = new Title();
        }
        private void CreateDataGridView()
        {
            dgv_listItem.ColumnCount = 5;
            dgv_listItem.MultiSelect = false;
            dgv_listItem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_listItem.Columns[0].Name="STT";
            dgv_listItem.Columns[0].Width = (int)(dgv_listItem.Width*0.1);
            dgv_listItem.Columns[1].Name = "Mã đĩa";
            dgv_listItem.Columns[1].Width = (int)(dgv_listItem.Width * 0.15);
            dgv_listItem.Columns[2].Name = "Tên tiêu đề";
            dgv_listItem.Columns[2].Width = (int)(dgv_listItem.Width * 0.35);
            dgv_listItem.Columns[3].Name = "Ngày thuê";
            dgv_listItem.Columns[3].Width = (int)(dgv_listItem.Width * 0.16);
            dgv_listItem.Columns[4].Name = "Ngày cần trả";
            dgv_listItem.Columns[4].Width = (int)(dgv_listItem.Width * 0.16);
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            dgv_listItem.Columns.Add(chk);
            chk.HeaderText = "Hủy trả";
            chk.Name = "Cancel";
            dgv_listItem.Columns["Cancel"].Width = (int)(dgv_listItem.Width * 0.15);
        }
        public void OpenFormLateCharge()
        {
            CheckLateChargeForm lateCharge;
            if (txt_numberPhone.Text != null)
            {
                lateCharge = new CheckLateChargeForm(txt_numberPhone.Text);
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
    //    string ToString(this DateTime? dt, string format)
    //=> dt == null ? "n/a" : ((DateTime)dt).ToString(format);
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
        }

        private void txt_numberPhone_TextChanged(object sender, EventArgs e)
        {
            if (txt_numberPhone.Text != null)
            {
                customer = _customerBLL.searchCustomerbyPhone(txt_numberPhone.Text.Trim());
                if (customer != null)
                {
                    txt_nameCustomer.Text = customer.name;
                    records = _recordBLL.GetAllRecordUnReturn(customer.idCustomer);
                    int i = 1;
                    CreateDataGridView();
                    if (records.Count > 0)
                    {
                        foreach (var item in records)
                        {
                            title = _titleBLL.GetItemTitleById(item.idTitle);
                            if (item.idDisk != null && item.dueDate != null && item.rentDate != null)
                            {
                                dgv_listItem.Rows.Add(i.ToString(), item.idDisk.ToString(), title.name,                 item.rentDate.ToString(), item.dueDate.ToString());
                            }
                            i++;
                        }
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
            foreach (var record in records)
            {
                Record temp = new Record();
                temp.idDisk = record.idDisk;
                temp.idTitle = record.idTitle;
                temp.idCustomer = record.idCustomer;
                idCustomer = record.idCustomer;
                temp.isPaid = false;
                temp.actualReturnDate = DateTime.Now;
                resutls.Add(_recordBLL.UpdateDateReturnAndLateFee(temp));
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
            }
            OpenCheckLateCharge(idCustomer);
        }
        private void btn_openListLateCharge_Click(object sender, EventArgs e)
        {
            OpenFormLateCharge();
        }
    }
}
