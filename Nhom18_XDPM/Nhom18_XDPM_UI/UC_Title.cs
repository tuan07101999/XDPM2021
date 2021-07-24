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
    public partial class UC_Title : UserControl
    {
        BindingSource bindingSource;
        TitleBLL titleBLL;
        DiskBLL diskBLL;
        CategoryBLL categoryBLL;
        BindingSource bindingSource2;
        private static UC_Title _instance;
        public static UC_Title Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_Title();
                return _instance;
            }
        }
        public UC_Title()
        {
            titleBLL = new TitleBLL();
            diskBLL = new DiskBLL();
            categoryBLL = new CategoryBLL();
            bindingSource = new BindingSource();
            bindingSource2 = new BindingSource();
            InitializeComponent();
            SetUp_dataGridViewTitle();

        }

        private void SetUp_dataGridViewTitle()
        {
            dgv_title.MultiSelect = false;
            dgv_title.ReadOnly = true;
            dgv_title.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgv_title.DefaultCellStyle.ForeColor = Color.Black;
            dgv_title.ClearSelection();
            ///
            dgv_disk.MultiSelect = false;
            dgv_disk.ReadOnly = true;
            dgv_disk.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgv_disk.DefaultCellStyle.ForeColor = Color.Black;
            dgv_disk.ClearSelection();

        }

        private void ReloadTitle()
        {
            DataBindings.Clear();
            bindingSource.DataSource = titleBLL.GetAlltt();
            dgv_title.DataSource = bindingSource;
            CustomDataGridViewTitle();
        }

        private void CustomDataGridViewTitle()
        {
            dgv_title.Columns["idTitle"].HeaderText = "Mã tiêu đề";
            dgv_title.Columns["name"].HeaderText = "Tên tiêu đề";
            dgv_title.Columns["numberOfCopies"].HeaderText = "Số bản sao";
            dgv_title.Columns["idCategory"].HeaderText = "Loại";
            dgv_title.Columns["Disks"].Visible = false;
            dgv_title.Columns["Category"].Visible = false;

            dgv_title.Columns["idTitle"].Width = 120;
            dgv_title.Columns["name"].Width = 240;
            dgv_title.Columns["numberOfCopies"].Width = 100;
            dgv_title.Columns["idCategory"].Width = 100;
        }

        private void btnHuyThemNhanDe_Click(object sender, EventArgs e)
        {

        }


        private void DiskCreateDataGridView(string id)
        {
            bindingSource2.DataSource = diskBLL.GetListDiskByIDtitle(id);
            dgv_disk.DataSource = bindingSource2;
        }

        private void dgv_title_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgv_title.SelectedRows.Count > 0 && dgv_title.SelectedRows[0].Cells[0].Value != null)
            {
                string id = dgv_title.SelectedRows[0].Cells[0].Value.ToString();
                DiskCreateDataGridView(id);
            }
        }

        private void pictureBoxTimKiemNhanDe_Click(object sender, EventArgs e)
        {
            ReloadTitle();
        }

        private void CleanTextBoxAddTitle()
        {
            txt_TitleID.Text = "";
            txt_TitleName.Text = "";
        }

        private void btn_AddTitle_Click(object sender, EventArgs e)
        {
            if (btn_AddTitle.Text == "Thêm")
            {
                txt_TitleID.Enabled = true;
                txt_TitleName.Enabled = true;
                btn_AddTitle.Text = "Lưu";
                btn_CancelAddTitle.Visible = true;
                CleanTextBoxAddTitle();
                btn_ChangeTitle.Enabled = true;
                btn_RemoveTitle.Enabled = true;
            }
            else
            {
                if(txt_TitleID.Text == "" || txt_TitleName.Text == "")
                {
                    MessageBox.Show("Không được bỏ trống đâu nhá");
                }
                else
                {
                    // Thực Thi Thêm Ở đây
                    int typeTT = 1;
                    if (cbx_titleType_addTitle.Text == "CD")
                    {
                        typeTT = 2;
                    }
                    Title title = new Title()
                    {
                        idTitle = txt_TitleID.Text.ToString().Trim(),
                        name = txt_TitleName.Text.ToString().Trim(),
                        numberOfCopies = 0,
                        idCategory = typeTT
                    };
                    Result result = null;
                    var taskCreate = Task.Factory.StartNew(() => result = titleBLL.addTitle(title));
                    taskCreate.Wait();

                    if (result.isSuccess)
                    {
                        MessageBox.Show(result.message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        txt_TitleID.Enabled = false;
                        txt_TitleName.Enabled = false;
                        btn_ChangeTitle.Enabled = true;
                        btn_RemoveTitle.Enabled = true;
                        btn_AddTitle.Text = "Thêm";
                        btn_CancelAddTitle.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show(result.message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                
                //
                
            }
        }

        private void btn_CancelAddTitle_Click(object sender, EventArgs e)
        {
            btn_AddTitle.Text = "Thêm";
            btn_CancelAddTitle.Visible = false;
            btn_ChangeTitle.Enabled = true;
            btn_RemoveTitle.Enabled = true;
            CleanTextBoxAddTitle();
            txt_TitleID.Enabled = false;
            txt_TitleName.Enabled = false;
        }

        private void btn_ChangeTitle_Click(object sender, EventArgs e)
        {
            if (dgv_title.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu để sửa? Hãy tải dữ liệu");
                return;
            }

            if (btn_ChangeTitle.Text == "Sửa")
            {
                btn_ChangeTitle.Text = "Lưu";
                btn_CancelUpdateTitle.Visible = true;
                btn_AddTitle.Enabled = false;
                btn_RemoveTitle.Enabled = false;
            }
            else
            {
                //if (txt_IDKhachHang.Text == "")
                //{
                //    MessageBox.Show("Bạn chưa chọn khách hàng để sửa? Hãy chọn khách hàng");
                //    return;
                //}
                ///

                ///
                btn_ChangeTitle.Text = "Sửa";
                btn_CancelUpdateTitle.Visible = false;
                btn_AddTitle.Enabled = true;
                btn_RemoveTitle.Enabled = true;
                //CleanFillTextBox();
                //CleanTextBox();
            }
        }

        private void btn_CancelUpdateTitle_Click(object sender, EventArgs e)
        {
            btn_ChangeTitle.Text = "Sửa";
            btn_CancelUpdateTitle.Visible = false;
            //CleanFillTextBox();
            //CleanTextBox();
            btn_AddTitle.Enabled = true;
            btn_RemoveTitle.Enabled = true;
            //txt_IDKhachHang.Enabled = false;
            //txt_IDKhachHang.Text = "";
        }

        private void btn_RemoveTitle_Click(object sender, EventArgs e)
        {
            if (dgv_title.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu? Hãy tải dữ liệu");
                return;
            }
            MessageBox.Show("Đang BUG");
            //DialogResult dr = MessageBox.Show("Hãy Chắc Rằng Bạn Muốn Xóa Tiêu đề này Này.\nXác Nhận Xóa Khách Hàng ?", "Xóa Khách hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //var csID = dgv_title.CurrentRow.Cells[0].Value.ToString().Trim();
            //if (dr == DialogResult.Yes && csID != null)
            //{
            //    dgv_title.Rows.RemoveAt(dgv_title.CurrentRow.Index);
            //    titleBLL.delete(Convert.ToInt32(csID));
            //}
            //else
            //{
            //    return;
            //}
        }

        private void TitleCreateDataGridView(string id)
        {
            bindingSource.DataSource = titleBLL.GetListTitleByID(id);
            dgv_title.DataSource = bindingSource;
            CustomDataGridViewTitle();
        }

        private void txt_searchTitle_KeyUp(object sender, KeyEventArgs e)
        {
            string id = txt_searchTitle.Text.ToString();
            TitleCreateDataGridView(id);
        }

        private void btn_ChangeRentFee_Click(object sender, EventArgs e)
        {
            if (btn_ChangeRentFee.Text == "Thay đổi")
            {
                txt_RentFee.Enabled = true;
                txt_RentalPeriod.Enabled = true;
                btn_ChangeRentFee.Text = "Lưu";
            }
            else
            {
                int var;
                if (txt_RentFee.Text == "" || txt_RentalPeriod.Text == "" || !int.TryParse(txt_RentFee.Text, out var) || !int.TryParse(txt_RentalPeriod.Text, out var))
                {
                    MessageBox.Show("Không được bỏ trống đâu nhá!! Nhập rồi coi lại phải số ko");
                }
                else
                {
                    int typeTT = 1;
                    if (cbx_rentalFee.Text == "CD")
                    {
                        typeTT = 2;
                    }
                    Category category = new Category()
                    {
                        rentalCharge = (float)Convert.ToDecimal(txt_RentFee.Text.ToString()),
                        rentalPeriod = Convert.ToInt32(txt_RentalPeriod.Text),
                        lateFee = 1,
                        idCategory = typeTT
                    };
                    Result result = null;
                    var taskCreate = Task.Factory.StartNew(() => result = categoryBLL.update(category));
                    taskCreate.Wait();

                    if (!result.isSuccess)
                    {
                        ReloadTitle();
                    }
                    if (result.isSuccess)
                    {
                        MessageBox.Show(result.message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        ReloadTitle();
                        txt_RentFee.Enabled = false;
                        txt_RentalPeriod.Enabled = false;
                        btn_ChangeRentFee.Text = "Thay đổi";
                    }
                    else
                    {
                        MessageBox.Show(result.message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    
                } 
            }
            
        }

        private void btn_RemoveDisk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chưa xóa được");
        }

        private void btn_AddDisk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chưa thêm đĩa được từ từ");
        }
    }
}
