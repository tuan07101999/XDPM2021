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
    public partial class UC_Customer : UserControl
    {
        BindingSource bindingSource;
        CustomerBLL customerBLL;
        private static UC_Customer _instance;
        public static UC_Customer Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_Customer();
                return _instance;
            }
        }
        public UC_Customer()
        {
            InitializeComponent();
            customerBLL = new CustomerBLL();
            bindingSource = new BindingSource();
            
        }

        private void CreateDataGridView()
        {
            bindingSource.DataSource = customerBLL.GetAllCustomer();
            dgv_ListKhachHang.DataSource = bindingSource;

            dgv_ListKhachHang.MultiSelect = false;
            dgv_ListKhachHang.ReadOnly = true;
            dgv_ListKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dataGridView_customer.Columns["idCustomer"].Visible = false;
            ////dataGridView_customer.Columns["Orders"].Visible = false;

            dgv_ListKhachHang.ClearSelection();
            dgv_ListKhachHang.Rows[0].Selected = false;
        }

        private void CustomDataGridViewCustomer()
        {
            // Sửa tên header dgv
            dgv_ListKhachHang.Columns["idCustomer"].HeaderText = "Mã khách hàng";
            dgv_ListKhachHang.Columns["name"].HeaderText = "Tên Khách hàng";
            dgv_ListKhachHang.Columns["address"].HeaderText = "Địa chỉ";
            dgv_ListKhachHang.Columns["phoneNumber"].HeaderText = "Số điện thoại";
            dgv_ListKhachHang.Columns["birthDate"].HeaderText = "Ngày sinh";
            // ẩn bảng phụ
            dgv_ListKhachHang.Columns["Records"].Visible = false;
            // set chiều dài
            //dgv_ListKhachHang.Columns["idCustomer"].Width = 120;
            //dgv_ListKhachHang.Columns["name"].Width = 140;
            //dgv_ListKhachHang.Columns["address"].Width = 160;
            //dgv_ListKhachHang.Columns["phoneNumber"].Width = 110;
            //dgv_ListKhachHang.Columns["birthDate"].Width = 150;
            //dgv_ListKhachHang.Columns["email"].Width = 140;
        }

        private void CleanTextBox()
        {
            txt_IDKhachHang.Text = "";
            txt_TenKH.Text = "";
            txt_SDT.Text = "";
            txt_DiaChi.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(btnThem.Text == "Thêm")
            {
                btnThem.Text = "Lưu";
                btn_HuyThem.Visible = true;
                CleanTextBox();
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            else
            {
                if (txt_TenKH.Text == "")
                {
                    MessageBox.Show("Gì chứ tên khách hàng là bắt buộc nha!");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Xác nhận thêm Khách Hàng này.\nXác Nhận ?", "Không", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {
                        Customer cus = new Customer()
                        {
                            name = txt_TenKH.Text.ToString().Trim(),
                            phoneNumber = txt_SDT.Text.ToString().Trim(),
                            address = txt_DiaChi.Text.ToString().Trim(),
                            email = "tuan7101999@gmail.com",
                            birthDate = datePicker_NgaySinh.Value
                        };
                        Result result = null;
                        var taskCreate = Task.Factory.StartNew(() => result = customerBLL.add(cus));
                        taskCreate.Wait();

                        if (result.isSuccess)
                        {
                            MessageBox.Show(result.message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            bindingSource.DataSource = customerBLL.searchCustomerbyId(cus.idCustomer);
                            dgv_ListKhachHang.DataSource = bindingSource;
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
                    //
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnThem.Text = "Thêm";
                    btn_HuyThem.Visible = false;
                    // Thực Thi Thêm Ở đây
                }

            }
        }

        private void btn_HuyThem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn muốn HỦY thêm Khách Hàng này.\nXác Nhận ?", "Không", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                btnThem.Text = "Thêm";
                btn_HuyThem.Visible = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                CleanTextBox();
            }
            else
            {
                return;
            }
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtTimKiem.Text != "")
            {
                if (!(int.TryParse(txtTimKiem.Text, out int i) && customerBLL.searchCustomerbyId(Convert.ToInt32(txtTimKiem.Text)) != null))
                {
                    return;
                }
                int txt = Convert.ToInt32(txtTimKiem.Text.ToString().Trim());
                CreateDataGridView();
                bindingSource.DataSource = customerBLL.searchCustomerbyId(txt);
            }
            else
            {
                return;
            }
        }

        private void pictureBoxTimKiem_Click(object sender, EventArgs e)
        {
            //Reload
            CreateDataGridView();
            CustomDataGridViewCustomer();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgv_ListKhachHang.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu khách hàng để sửa? Hãy tải dữ liệu");
                return;
            }
                
            if (btnSua.Text == "Sửa")
            {
                btnSua.Text = "Lưu";
                btn_HuySua.Visible = true;
                //txt_IDKhachHang.Enabled = true;
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
            }
            else
            {
                if (txt_IDKhachHang.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn khách hàng để sửa? Hãy chọn khách hàng");
                    return;
                }
                ///
                DialogResult dr = MessageBox.Show("Xác nhận Sửa Khách Hàng này.\nXác Nhận ?", "Không", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes && dgv_ListKhachHang.CurrentRow.Cells[1].Value != null)
                {
                    Customer cus = new Customer()
                    {
                        idCustomer = Convert.ToInt32(dgv_ListKhachHang.CurrentRow.Cells[0].Value.ToString().Trim()),
                        name = txt_TenKH.Text.ToString().Trim(),
                        phoneNumber = txt_SDT.Text.ToString().Trim(),
                        address = txt_DiaChi.Text.ToString().Trim(),
                        email = "Tuan7101999@gmail.com",
                        birthDate = datePicker_NgaySinh.Value
                    };
                    Result result = null;
                    var taskCreate = Task.Factory.StartNew(() => result = customerBLL.update(cus));
                    taskCreate.Wait();

                    if (result.isSuccess)
                    {
                        MessageBox.Show(result.message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        bindingSource.DataSource = customerBLL.searchCustomerbyId(cus.idCustomer);
                        dgv_ListKhachHang.DataSource = bindingSource;
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
                ///
                btnSua.Text = "Sửa";
                btn_HuySua.Visible = false;
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                CleanFillTextBox();
                CleanTextBox();
            }
            
        }

        private void btn_HuySua_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn muốn HỦY SỬA Khách Hàng này.\nXác Nhận ?", "Không", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                btnSua.Text = "Sửa";
                btn_HuySua.Visible = false;
                CleanFillTextBox();
                CleanTextBox();
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                txt_IDKhachHang.Enabled = false;
                txt_IDKhachHang.Text = "";
            }
            else
            {
                return;
            }
        }
        private void CleanFillTextBox()
        {
            txt_IDKhachHang.DataBindings.Clear();
            txt_TenKH.DataBindings.Clear();
            txt_SDT.DataBindings.Clear();
            txt_DiaChi.DataBindings.Clear();
            datePicker_NgaySinh.DataBindings.Clear();
        }

        private void FillTextBox()
        {
           txt_IDKhachHang.DataBindings.Clear();
            txt_TenKH.DataBindings.Clear();
            txt_SDT.DataBindings.Clear();
            txt_DiaChi.DataBindings.Clear();
            datePicker_NgaySinh.DataBindings.Clear();

            txt_IDKhachHang.DataBindings.Add("Text", bindingSource, "idCustomer");
            txt_TenKH.DataBindings.Add("Text", bindingSource, "name");
            txt_SDT.DataBindings.Add("Text", bindingSource, "phoneNumber");
            txt_DiaChi.DataBindings.Add("Text", bindingSource, "address");
            datePicker_NgaySinh.DataBindings.Add("Value", bindingSource, "birthDate");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dgv_ListKhachHang.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu ? Hãy tải dữ liệu");
                return;
            }    
            DialogResult dr = MessageBox.Show("Hãy Chắc Rằng Bạn Muốn Xóa Khách Hàng Này.\nXác Nhận Xóa Khách Hàng ?", "Xóa Khách hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            var csID = dgv_ListKhachHang.CurrentRow.Cells[0].Value.ToString().Trim();
            if (dr == DialogResult.Yes && csID != null)
            {
                dgv_ListKhachHang.Rows.RemoveAt(dgv_ListKhachHang.CurrentRow.Index);
                customerBLL.delete(Convert.ToInt32(csID));
            }
            else
            {
                return;
            }
        }

        private void dgv_ListKhachHang_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if(btnSua.Text == "Lưu")
            {
                FillTextBox();
            }    
        }

        private void btn_TTPhiTre_Click(object sender, EventArgs e)
        {
            Parent.Controls.Add(UC_CheckLateCharge.Instance);
            UC_CheckLateCharge.Instance.Dock = DockStyle.Fill;
            UC_CheckLateCharge.Instance.BringToFront();
        }
    }
}
