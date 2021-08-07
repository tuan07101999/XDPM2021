using Business;
using Business.Models;
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
    public partial class UC_Reservation : UserControl
    {
        private static UC_Reservation _instance;
        BindingSource bindingSource;
        CustomerBLL customerBLL;
        TitleBLL titleBLL;
        HoldingBLL holdingBLL;
        DiskBLL diskBLL;
        RecordBLL recordBLL;
        AutoCompleteStringCollection autoIDKhachHang;
        AutoCompleteStringCollection autoIDTieuDe;

        //check button
        int check;

        public static UC_Reservation Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_Reservation();
                return _instance;
            }
        }
        public UC_Reservation()
        {
            InitializeComponent();
            customerBLL = new CustomerBLL();
            titleBLL = new TitleBLL();
            holdingBLL = new HoldingBLL();
            diskBLL = new DiskBLL();
            recordBLL = new RecordBLL();

            //AutoComplete
            autoIDKhachHang = new AutoCompleteStringCollection();
            txtIDKhachHang.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtIDKhachHang.AutoCompleteSource = AutoCompleteSource.CustomSource;
            autoIDTieuDe = new AutoCompleteStringCollection();
            txtIDNhanDe.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtIDNhanDe.AutoCompleteSource = AutoCompleteSource.CustomSource;

            //Load dgvReservation
            dgvReservation.DefaultCellStyle.Font = new Font("microsoft sans serif", 11);
            dgvReservation.ColumnHeadersDefaultCellStyle.Font = new Font("microsoft sans serif", 13);
            dgvReservation.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            bindingSource = new BindingSource();
            LoadDgvReservation();

            // tạo mới btn trên DGV
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dgvReservation.Columns.Add(btn);
            btn.HeaderText = "Hủy Đặt";
            btn.Name = "btn_Detele";
            btn.Text = "Hủy";
            btn.UseColumnTextForButtonValue = true;
            // tạo mới btn trên DGV
            DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
            dgvReservation.Columns.Add(btn2);
            btn2.HeaderText = "Xác nhận thuê";
            btn2.Text = "Xác nhận";
            btn2.Name = "btn_Comfirm";
            btn2.UseColumnTextForButtonValue = true;

            //Default check button
            check = 0;
        }

        private void UC_Reservation_Load(object sender, EventArgs e)
        {
            btnHuyThem.Enabled = false;
            txtIDKhachHang.Enabled = false;
            txtTenKH.Enabled = false;
            txtPhone.Enabled = false;
            txtNhanDe.Enabled = false;
            txtNgayDat.Enabled = false;
            txtIDNhanDe.Enabled = false;


            //Add autocomplete
            foreach (var item in customerBLL.GetAllCustomer())
            {
                autoIDKhachHang.Add(item.idCustomer.ToString());
            }
            txtIDKhachHang.AutoCompleteCustomSource = autoIDKhachHang;

            foreach (var item in titleBLL.GetAlltt())
            {
                autoIDTieuDe.Add(item.idTitle.ToString());
            }
            txtIDNhanDe.AutoCompleteCustomSource = autoIDTieuDe;
        }

        public void LoadDgvReservation()
        {
            bindingSource.DataSource = holdingBLL.GetAllHodingModels().Reverse<HoldingModel>();
            dgvReservation.DataSource = bindingSource;

            dgvReservation.MultiSelect = false;
            dgvReservation.ReadOnly = true;
            dgvReservation.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dataGridView_customer.Columns["idCustomer"].Visible = false;
            ////dataGridView_customer.Columns["Orders"].Visible = false;
            dgvReservation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReservation.ClearSelection();
            dgvReservation.Rows[0].Selected = false;
        }

        private void btnHuyThem_Click(object sender, EventArgs e)
        {
            if (check == 1)
            {
                btnDat.Text = "ĐẶT ĐĨA";
                btnHuyThem.Enabled = false;
                txtIDKhachHang.Enabled = false;
                txtIDNhanDe.Enabled = false;
                check = 0;
            }
        }

        private void txtIDKhachHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!(int.TryParse(txtIDKhachHang.Text, out int i) && customerBLL.searchCustomerbyId(Convert.ToInt32(txtIDKhachHang.Text)) != null))
                {
                    return;
                }
                txtTenKH.Text = customerBLL.searchCustomerbyId(Convert.ToInt32(txtIDKhachHang.Text)).name;
                txtPhone.Text = customerBLL.searchCustomerbyId(Convert.ToInt32(txtIDKhachHang.Text)).phoneNumber;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {           
            if(check == 0){
                btnDat.Text = "LƯU";
                btnHuyThem.Enabled = true;
                txtIDKhachHang.Enabled = true;
                txtIDNhanDe.Enabled = true;
                check = 1;
                return;
            }
            else if(check == 1)
            {
                //check chưa nhập dữ liệu
                if (String.IsNullOrWhiteSpace(txtIDKhachHang.Text) || String.IsNullOrWhiteSpace(txtIDNhanDe.Text))
                {
                    MessageBox.Show("Chưa nhập ID khách hàng hoặc ID tiêu đề!", "Nhập thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult dr = MessageBox.Show("Xác nhận đặt đĩa này.\nXác Nhận ?", "Không", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    Holding cus = new Holding()
                    {
                        idCustomer = Convert.ToInt32(txtIDKhachHang.Text),
                        idTitle = txtIDNhanDe.Text,
                        reservationTime = DateTime.Now
                    };
                    Result result = null;
                    var taskCreate = Task.Factory.StartNew(() => result = holdingBLL.add(cus));
                    taskCreate.Wait();

                    if (result.isSuccess)
                    {
                        MessageBox.Show(result.message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        bindingSource.DataSource = holdingBLL.GetAllHodingModels().Reverse<HoldingModel>();
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
                btnHuyThem_Click(sender, e);
            }
            
        }

        private void txtIDKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Chỉ nhập số!", "Nhập sai", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }  
        }

        private void txtIDNhanDe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Chỉ nhập số!", "Nhập sai", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txtIDNhanDe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (titleBLL.GetItemTitleById(txtIDNhanDe.Text) == null)
                {
                    return;
                }
                txtNhanDe.Text = titleBLL.GetItemTitleById(txtIDNhanDe.Text.Trim()).name;
                txtNgayDat.Text = DateTime.Now.ToString();
            }
        }

        private void dgvReservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DialogResult dr = MessageBox.Show("Bạn muốn HỦY đơn đặt hàng này .\nXác Nhận Hủy ?", "Hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                var csID = dgvReservation.Rows[e.RowIndex].Cells["idHolding"].Value.ToString().Trim();
                if (dr == DialogResult.Yes && csID != null)
                {
                    dgvReservation.Rows.RemoveAt(dgvReservation.Rows[e.RowIndex].Index);
                    holdingBLL.delete(Convert.ToInt32(csID));
                }
                else
                {
                    return;
                }
            }
            else if (e.ColumnIndex == 1)
            {
                DialogResult dr = MessageBox.Show("Xác nhận thuê đĩa này ?", "Thuê đĩa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                var csID = dgvReservation.Rows[e.RowIndex].Cells["idHolding"].Value.ToString().Trim();
                var titleID = dgvReservation.Rows[e.RowIndex].Cells["idTitle"].Value.ToString().Trim();

                if (titleID == null)
                {
                    MessageBox.Show("title NULL");
                    return;
                }
                if (diskBLL.GetONEDiskByIDtitle(titleID) == null)
                {
                    MessageBox.Show("Không có đĩa thuộc tiêu đề này");
                    return;
                }

                if(diskBLL.GetONEDiskOnshelftByIDtitle(titleID) is null)
                {
                    MessageBox.Show("Đĩa đã hết!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var diskID = diskBLL.GetONEDiskOnshelftByIDtitle(titleID).idDisk;
                var cusID = dgvReservation.Rows[e.RowIndex].Cells["idCustomer"].Value.ToString().Trim();
                if (dr == DialogResult.Yes && csID != null && diskID != null && cusID != null)
                {
                    Record record = new Record()
                    {
                        idDisk = diskID,
                        idCustomer = Convert.ToInt32(cusID),
                        isPaid = false
                    };
                    Result result = null;
                    var taskCreate = Task.Factory.StartNew(() => result = recordBLL.add(record));
                    taskCreate.Wait();
                    dgvReservation.Rows.RemoveAt(dgvReservation.Rows[e.RowIndex].Index);
                    holdingBLL.delete(Convert.ToInt32(csID));

                    //update disk statust
                    var disk = diskBLL.GetONEDiskOnshelftByIDtitle(titleID);
                    disk.status = DataAccess.Entities.Enum.Status.OnHold;
                    diskBLL.updateStatusDisk(disk);

                    
                    if (result.isSuccess)
                    {
                        MessageBox.Show(result.message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
        }

        private void txtIDKhachHang_Leave(object sender, EventArgs e)
        {
            if (!(int.TryParse(txtIDKhachHang.Text, out int i) && customerBLL.searchCustomerbyId(Convert.ToInt32(txtIDKhachHang.Text)) != null))
            {
                return;
            }
            txtTenKH.Text = customerBLL.searchCustomerbyId(Convert.ToInt32(txtIDKhachHang.Text)).name;
            txtPhone.Text = customerBLL.searchCustomerbyId(Convert.ToInt32(txtIDKhachHang.Text)).phoneNumber;
        }

        private void txtIDNhanDe_Leave(object sender, EventArgs e)
        {
            if (titleBLL.GetItemTitleById(txtIDNhanDe.Text) == null)
            {
                return;
            }
            txtNhanDe.Text = titleBLL.GetItemTitleById(txtIDNhanDe.Text.Trim()).name;
            txtNgayDat.Text = DateTime.Now.ToString();
        }

    }
}
