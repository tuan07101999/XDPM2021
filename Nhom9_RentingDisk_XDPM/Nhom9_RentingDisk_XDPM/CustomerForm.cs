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
    public partial class CustomerForm : Form
    {
        BindingSource bindingSource;
        CustomerBLL customerBLL;
        public CustomerForm()
        {
            customerBLL = new CustomerBLL();
            bindingSource = new BindingSource();
            InitializeComponent();
            CreateDataGridView();
            Clear_TextBox();
            CustomDataGridViewCustomer();
        }
        private void CustomDataGridViewCustomer()
        {
            // Sửa tên header dgv
            dataGridView_customer.Columns["idCustomer"].HeaderText = "Mã khách hàng";
            dataGridView_customer.Columns["name"].HeaderText = "Tên Khách hàng";
            dataGridView_customer.Columns["address"].HeaderText = "Địa chỉ";
            dataGridView_customer.Columns["phoneNumber"].HeaderText = "Số điện thoại";
            dataGridView_customer.Columns["birthDate"].HeaderText = "Ngày sinh";
            // ẩn bảng phụ
            dataGridView_customer.Columns["Records"].Visible = false;
            // set chiều dài
            dataGridView_customer.Columns["idCustomer"].Width = 120;
            dataGridView_customer.Columns["name"].Width = 140;
            dataGridView_customer.Columns["address"].Width = 160;
            dataGridView_customer.Columns["phoneNumber"].Width = 110;
            dataGridView_customer.Columns["birthDate"].Width = 150;
            dataGridView_customer.Columns["email"].Width = 140;
        }
        private void CreateDataGridView()
        {
            bindingSource.DataSource = customerBLL.GetAllCustomer();
            dataGridView_customer.DataSource = bindingSource;

            dataGridView_customer.MultiSelect = false;
            dataGridView_customer.ReadOnly = true;
            dataGridView_customer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dataGridView_customer.Columns["idCustomer"].Visible = false;
            ////dataGridView_customer.Columns["Orders"].Visible = false;

            dataGridView_customer.ClearSelection();
            dataGridView_customer.Rows[0].Selected = false;
        }

        private void Clear_TextBox()
        {
            txt_customerName.Clear();
            txt_addressName.Clear();
            txt_email.Clear();
            txt_numberPhone.Clear();
            txt_dateBirth.Value = DateTime.Now;
        }
        
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_searchItem_KeyUp(object sender, KeyEventArgs e)
        {
            // lỗi không đúng format
            if(txt_searchItem.Text != "")
            {
                int txt = Convert.ToInt32(txt_searchItem.Text.ToString().Trim());
                CreateDataGridView();
                bindingSource.DataSource = customerBLL.searchCustomerbyId(txt);
            }
            else
            {
                return;
            }
            
        }
        private void FillTextBox()
        {
            txt_addressName.DataBindings.Clear();
            txt_customerName.DataBindings.Clear();
            txt_email.DataBindings.Clear();
            txt_numberPhone.DataBindings.Clear();
            txt_dateBirth.DataBindings.Clear();

            txt_addressName.DataBindings.Add("Text", bindingSource, "address");
            txt_customerName.DataBindings.Add("Text", bindingSource, "name");
            txt_email.DataBindings.Add("Text", bindingSource, "email");
            txt_numberPhone.DataBindings.Add("Text", bindingSource, "phoneNumber");
            txt_dateBirth.DataBindings.Add("Value", bindingSource, "birthDate");
        }
        private void dataGridView_customer_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if(btn_updateCustomer.LabelText == "Lưu")
            {
                FillTextBox();
            }    
        }

        private void btn_addCustomer_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Xác nhận thêm Khách Hàng này.\nXác Nhận ?", "Không", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                Customer cus = new Customer()
                {
                    name = txt_customerName.Text.ToString().Trim(),
                    phoneNumber = txt_numberPhone.Text.ToString().Trim(),
                    address = txt_addressName.Text.ToString().Trim(),
                    email = txt_email.Text.ToString().Trim(),
                    birthDate = txt_dateBirth.Value
                };
                Result result = null;
                var taskCreate = Task.Factory.StartNew(() => result = customerBLL.add(cus));
                taskCreate.Wait();

                if (result.isSuccess)
                {
                    MessageBox.Show(result.message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    bindingSource.DataSource = customerBLL.searchCustomerbyId(cus.idCustomer);
                    dataGridView_customer.DataSource = bindingSource;
                }
                else
                {
                    MessageBox.Show(result.message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                
            }
            else
            {
                return;
            }
        }

        private void btn_updateCustomer_Click(object sender, EventArgs e)
        {
            if (btn_updateCustomer.LabelText == "Sửa")
            {
                btn_updateCustomer.LabelText = "Lưu";
            }
            else
            {
                DialogResult dr = MessageBox.Show("Xác nhận Sửa Khách Hàng này.\nXác Nhận ?", "Không", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes && dataGridView_customer.CurrentRow.Cells[1].Value != null)
                {
                    Customer cus = new Customer()
                    {
                        idCustomer = Convert.ToInt32(dataGridView_customer.CurrentRow.Cells[0].Value.ToString().Trim()),
                        name = txt_customerName.Text.ToString().Trim(),
                        phoneNumber = txt_numberPhone.Text.ToString().Trim(),
                        address = txt_addressName.Text.ToString().Trim(),
                        email = txt_email.Text.ToString().Trim(),
                        birthDate = txt_dateBirth.Value
                    };
                    Result result = null;
                    var taskCreate = Task.Factory.StartNew(() => result = customerBLL.update(cus));
                    taskCreate.Wait();

                    if (result.isSuccess)
                    {
                        MessageBox.Show(result.message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        bindingSource.DataSource = customerBLL.searchCustomerbyId(cus.idCustomer);
                        dataGridView_customer.DataSource = bindingSource;
                    }
                    else
                    {
                        MessageBox.Show(result.message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    
                    
                }
                else
                {
                    return;
                }
                btn_updateCustomer.LabelText = "Sửa";
            }
        }

        private void btn_deleteCustomer_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Hãy Chắc Rằng Bạn Muốn Xóa Khách Hàng Này.\nXác Nhận Xóa Khách Hàng ?", "Xóa Khách hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            var csID = dataGridView_customer.CurrentRow.Cells[0].Value.ToString().Trim();
            if (dr == DialogResult.Yes && csID != null)
            {
                dataGridView_customer.Rows.RemoveAt(dataGridView_customer.CurrentRow.Index);
                customerBLL.delete(Convert.ToInt32(csID));
            }
            else
            {
                return;
            }
        }
    }
}
