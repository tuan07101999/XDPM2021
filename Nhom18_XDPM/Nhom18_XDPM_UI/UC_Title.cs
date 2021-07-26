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

        private void UC_Title_Load(object sender, EventArgs e)
        {
            // Enabled false button
            btnRemoveTitle.Enabled = false;
            btnUpdateTitle.Enabled = false;
            btnCancelTitle.Enabled = false;
            btnRemoveDisk.Enabled = false;

            // Enabled false textbox
            txtTitleID.Enabled = false;
            txtTitleName.Enabled = false;
            cbxTitleType_AddTitle.Enabled = false;
            txtRentalPeriod.Enabled = false;
            txtRentFee.Enabled = false;
            cbxRentalFee.Enabled = false;
            txtDiskName.Enabled = false;
        }

        #region Load Data To dgvTitle
        /// <summary>
        /// Set up data to dgvTitle
        /// </summary>
        private void SetUp_dataGridViewTitle()
        {
            dgvTitle.MultiSelect = false;
            dgvTitle.ReadOnly = true;
            dgvTitle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvTitle.DefaultCellStyle.ForeColor = Color.Black;
            dgvTitle.ClearSelection();
            ///
            dgvDisk.MultiSelect = false;
            dgvDisk.ReadOnly = true;
            dgvDisk.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvDisk.DefaultCellStyle.ForeColor = Color.Black;
            dgvDisk.ClearSelection();

        }

        /// <summary>
        /// Load dgvTitle
        /// </summary>
        private void ReloadTitle()
        {
            DataBindings.Clear();
            bindingSource.DataSource = titleBLL.GetAlltt();
            dgvTitle.DataSource = bindingSource;
            CustomDataGridViewTitle();
        }

        /// <summary>
        /// Create Haeder text Title
        /// </summary>
        private void CustomDataGridViewTitle()
        {
            dgvTitle.Columns["idTitle"].HeaderText = "Mã tiêu đề";
            dgvTitle.Columns["name"].HeaderText = "Tên tiêu đề";
            dgvTitle.Columns["numberOfCopies"].HeaderText = "Số bản sao";
            dgvTitle.Columns["idCategory"].HeaderText = "Loại";
            dgvTitle.Columns["Disks"].Visible = false;
            dgvTitle.Columns["Category"].Visible = false;

            dgvTitle.Columns["idTitle"].Width = 120;
            dgvTitle.Columns["name"].Width = 240;
            dgvTitle.Columns["numberOfCopies"].Width = 100;
            dgvTitle.Columns["idCategory"].Width = 100;
        }

        #endregion

        #region Load Data to dgvDisk
        /// <summary>
        /// Load data to dgvDisk from ID title
        /// </summary>
        /// <param name="id"></param>
        private void DiskCreateDataGridView(string id)
        {
            bindingSource2.DataSource = diskBLL.GetListDiskByIDtitle(id);
            dgvDisk.DataSource = bindingSource2;
        }




        #endregion

        #region Event Datagridview of Title
        private void dgvTitle_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgvTitle.SelectedRows.Count > 0 && dgvTitle.SelectedRows[0].Cells[0].Value != null)
            {
                string id = dgvTitle.SelectedRows[0].Cells[0].Value.ToString();
                DiskCreateDataGridView(id);
            }
        }
        #endregion

        #region Event button of Title
        /// <summary>
        /// 
        /// </summary>

        private void pictureBoxUpdateTitle_Click(object sender, EventArgs e)
        {
            ReloadTitle();
        }

        private void btnRemoveTitle_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnAddTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelTitle_Click(object sender, EventArgs e)
        {

        }
        
        #endregion

        #region Event Textbox of Title
        private void txtSearchTitle_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearchTitle.Text = string.Empty;
        }

        
        #endregion

        #region Event Datagridview of Disk

        #endregion

        #region Event button of Disk


        #endregion

        #region Event Textbox of Disk

        #endregion


        //private void dgv_title_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        //{
        //    if (dgvTitle.SelectedRows.Count > 0 && dgvTitle.SelectedRows[0].Cells[0].Value != null)
        //    {
        //        string id = dgvTitle.SelectedRows[0].Cells[0].Value.ToString();
        //        DiskCreateDataGridView(id);
        //    }
        //}



        //private void CleanTextBoxAddTitle()
        //{
        //    txtTitleID.Text = "";
        //    txtTitleName.Text = "";
        //}

        //private void btn_AddTitle_Click(object sender, EventArgs e)
        //{
        //    if (btnAddTitle.Text == "Thêm")
        //    {
        //        txtTitleID.Enabled = true;
        //        txtTitleName.Enabled = true;
        //        btnAddTitle.Text = "Lưu";

        //        CleanTextBoxAddTitle();
        //        btnUpdateTitle.Enabled = true;
        //        btnRemoveTitle.Enabled = true;
        //    }
        //    else
        //    {
        //        if(txtTitleID.Text == "" || txtTitleName.Text == "")
        //        {
        //            MessageBox.Show("Không được bỏ trống đâu nhá");
        //        }
        //        else
        //        {
        //            // Thực Thi Thêm Ở đây
        //            int typeTT = 1;
        //            if (cbxTitleType_AddTitle.Text == "CD")
        //            {
        //                typeTT = 2;
        //            }
        //            Title title = new Title()
        //            {
        //                idTitle = txtTitleID.Text.ToString().Trim(),
        //                name = txtTitleName.Text.ToString().Trim(),
        //                numberOfCopies = 0,
        //                idCategory = typeTT
        //            };
        //            Result result = null;
        //            var taskCreate = Task.Factory.StartNew(() => result = titleBLL.addTitle(title));
        //            taskCreate.Wait();

        //            if (result.isSuccess)
        //            {
        //                MessageBox.Show(result.message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        //                txtTitleID.Enabled = false;
        //                txtTitleName.Enabled = false;
        //                btnUpdateTitle.Enabled = true;
        //                btnRemoveTitle.Enabled = true;
        //                btnAddTitle.Text = "Thêm";

        //            }
        //            else
        //            {
        //                MessageBox.Show(result.message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        //            }
        //        }

        //        //

        //    }
        //}

        //private void btn_CancelAddTitle_Click(object sender, EventArgs e)
        //{
        //    btnAddTitle.Text = "Thêm";

        //    btnUpdateTitle.Enabled = true;
        //    btnRemoveTitle.Enabled = true;
        //    CleanTextBoxAddTitle();
        //    txtTitleID.Enabled = false;
        //    txtTitleName.Enabled = false;
        //}

        //private void btn_ChangeTitle_Click(object sender, EventArgs e)
        //{
        //    if (dgvTitle.Rows.Count == 0)
        //    {
        //        MessageBox.Show("Chưa có dữ liệu để sửa? Hãy tải dữ liệu");
        //        return;
        //    }

        //    if (btnUpdateTitle.Text == "Sửa")
        //    {
        //        btnUpdateTitle.Text = "Lưu";
        //        btnCancelTitle.Visible = true;
        //        btnAddTitle.Enabled = false;
        //        btnRemoveTitle.Enabled = false;
        //    }
        //    else
        //    {
        //        //if (txt_IDKhachHang.Text == "")
        //        //{
        //        //    MessageBox.Show("Bạn chưa chọn khách hàng để sửa? Hãy chọn khách hàng");
        //        //    return;
        //        //}
        //        ///

        //        ///
        //        btnUpdateTitle.Text = "Sửa";
        //        btnCancelTitle.Visible = false;
        //        btnAddTitle.Enabled = true;
        //        btnRemoveTitle.Enabled = true;
        //        //CleanFillTextBox();
        //        //CleanTextBox();
        //    }
        //}

        //private void btn_CancelUpdateTitle_Click(object sender, EventArgs e)
        //{
        //    btnUpdateTitle.Text = "Sửa";
        //    btnCancelTitle.Visible = false;
        //    //CleanFillTextBox();
        //    //CleanTextBox();
        //    btnAddTitle.Enabled = true;
        //    btnRemoveTitle.Enabled = true;
        //    //txt_IDKhachHang.Enabled = false;
        //    //txt_IDKhachHang.Text = "";
        //}

        //private void btn_RemoveTitle_Click(object sender, EventArgs e)
        //{
        //    if (dgvTitle.Rows.Count == 0)
        //    {
        //        MessageBox.Show("Chưa có dữ liệu? Hãy tải dữ liệu");
        //        return;
        //    }
        //    MessageBox.Show("Đang BUG");
        //    //DialogResult dr = MessageBox.Show("Hãy Chắc Rằng Bạn Muốn Xóa Tiêu đề này Này.\nXác Nhận Xóa Khách Hàng ?", "Xóa Khách hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        //    //var csID = dgv_title.CurrentRow.Cells[0].Value.ToString().Trim();
        //    //if (dr == DialogResult.Yes && csID != null)
        //    //{
        //    //    dgv_title.Rows.RemoveAt(dgv_title.CurrentRow.Index);
        //    //    titleBLL.delete(Convert.ToInt32(csID));
        //    //}
        //    //else
        //    //{
        //    //    return;
        //    //}
        //}

        //private void TitleCreateDataGridView(string id)
        //{
        //    bindingSource.DataSource = titleBLL.GetListTitleByID(id);
        //    dgvTitle.DataSource = bindingSource;
        //    CustomDataGridViewTitle();
        //}

        //private void txt_searchTitle_KeyUp(object sender, KeyEventArgs e)
        //{
        //    string id = txtSearchTitle.Text.ToString();
        //    TitleCreateDataGridView(id);
        //}

        //private void btn_ChangeRentFee_Click(object sender, EventArgs e)
        //{
        //    if (btnUpdateRentFee.Text == "Thay đổi")
        //    {
        //        txtRentFee.Enabled = true;
        //        txtRentalPeriod.Enabled = true;
        //        btnUpdateRentFee.Text = "Lưu";
        //    }
        //    else
        //    {
        //        int var;
        //        if (txtRentFee.Text == "" || txtRentalPeriod.Text == "" || !int.TryParse(txtRentFee.Text, out var) || !int.TryParse(txtRentalPeriod.Text, out var))
        //        {
        //            MessageBox.Show("Không được bỏ trống đâu nhá!! Nhập rồi coi lại phải số ko");
        //        }
        //        else
        //        {
        //            int typeTT = 1;
        //            if (cbxRentalFee.Text == "CD")
        //            {
        //                typeTT = 2;
        //            }
        //            Category category = new Category()
        //            {
        //                rentalCharge = (float)Convert.ToDecimal(txtRentFee.Text.ToString()),
        //                rentalPeriod = Convert.ToInt32(txtRentalPeriod.Text),
        //                lateFee = 1,
        //                idCategory = typeTT
        //            };
        //            Result result = null;
        //            var taskCreate = Task.Factory.StartNew(() => result = categoryBLL.update(category));
        //            taskCreate.Wait();

        //            if (!result.isSuccess)
        //            {
        //                ReloadTitle();
        //            }
        //            if (result.isSuccess)
        //            {
        //                MessageBox.Show(result.message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        //                ReloadTitle();
        //                txtRentFee.Enabled = false;
        //                txtRentalPeriod.Enabled = false;
        //                btnUpdateRentFee.Text = "Thay đổi";
        //            }
        //            else
        //            {
        //                MessageBox.Show(result.message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        //            }

        //        } 
        //    }

        //}

        //private void btn_RemoveDisk_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Chưa xóa được");
        //}

        //private void btn_AddDisk_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Chưa thêm đĩa được từ từ");
        //}

        //private void txt_searchTitle_MouseClick(object sender, MouseEventArgs e)
        //{
        //    txtSearchTitle.Text = string.Empty;
        //}

        //private void UC_Title_Load(object sender, EventArgs e)
        //{
        //    btnUpdateTitle.Enabled = true;
        //    btnCancelTitle.Enabled = true;
        //}

        //private void dgvTitle_SelectionChanged(object sender, EventArgs e)
        //{
        //    btnAddTitle.Enabled = true;
        //    btnUpdateTitle.Enabled = false;

        //}

    }
}
