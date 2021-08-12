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

            //cbx_rentalFee.Text = "DVD";
        }

        private void SetUp_dataGridViewTitle()
        {
            dgv_title.MultiSelect = false;
            dgv_title.ReadOnly = true;
            dgv_title.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgv_title.DefaultCellStyle.ForeColor = Color.Black;
            dgv_title.ClearSelection();

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

                //Load data to textbox
                string titleID = dgv_title.SelectedRows[0].Cells[0].Value.ToString();
                string titleName = dgv_title.SelectedRows[0].Cells[1].Value.ToString();
                string titleType = dgv_title.SelectedRows[0].Cells[3].Value.ToString();

                txt_TitleID.Text = titleID;
                txt_TitleName.Text = titleName;
                if (titleType.Equals("1"))
                {
                    cbx_titleType_addTitle.Text = "DVD";
                }
                else if (titleType.Equals("2"))
                {
                    cbx_titleType_addTitle.Text = "CD";
                }


            }
        }

        private void pictureBoxTimKiemNhanDe_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ReloadTitle();
            Cursor.Current = Cursors.Default;

            cbx_rentalFee.Text = "DVD";

            // Enable control
            txt_searchTitle.Enabled = true;
            btn_AddTitle.Enabled = true;
            btn_RemoveTitle.Enabled = true;

            btn_ChangeTitle.Enabled = true;

            btn_ChangeRentFee.Enabled = true;

            btn_RemoveDisk.Enabled = true;
            btn_AddDisk.Enabled = true;
        }

        private void btn_AddTitle_Click(object sender, EventArgs e)
        {
            if (btn_AddTitle.Text == "Thêm")
            {
                // Change status control
                txt_TitleID.Enabled = true;
                txt_TitleName.Enabled = true;
                cbx_titleType_addTitle.Enabled = true;
                btn_AddTitle.Text = "Lưu";
                btn_ChangeTitle.Enabled = false;
                btn_RemoveTitle.Enabled = false;
                btn_CancelUpdateTitle.Enabled = true;
                // Clear data in textbox
                txt_TitleID.Text = String.Empty;
                txt_TitleName.Text = String.Empty;

            }
            else
            {
                if (txt_TitleID.Text == "" || txt_TitleName.Text == "" || cbx_titleType_addTitle.Text == "")
                {
                    if (txt_TitleID.Text == "")
                    {
                        MessageBox.Show("Không được bỏ trống mã tiêu đề.");
                    }
                    else if (txt_TitleName.Text == "")
                    {
                        MessageBox.Show("Không được bỏ trống tên tiêu đề.");
                    }
                    else
                    {
                        MessageBox.Show("Chưa chọn loại tiêu đề.");
                    }
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

                        // Change status control
                        txt_TitleID.Enabled = false;
                        txt_TitleName.Enabled = false;
                        cbx_titleType_addTitle.Enabled = false;

                        btn_AddTitle.Text = "Thêm";
                        btn_ChangeTitle.Enabled = true;
                        btn_RemoveTitle.Enabled = true;
                        btn_CancelUpdateTitle.Enabled = false;

                    }
                    else
                    {
                        MessageBox.Show(result.message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }

            }
        }

        private void FillTextBoxTitle()
        {
            txt_TitleID.DataBindings.Clear();
            txt_TitleName.DataBindings.Clear();

            txt_TitleID.DataBindings.Add("Text", bindingSource, "idTitle");
            txt_TitleName.DataBindings.Add("Text", bindingSource, "name");
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
                // Change status control
                txt_TitleID.Enabled = false;
                txt_TitleName.Enabled = true;
                cbx_titleType_addTitle.Enabled = true;

                btn_RemoveTitle.Enabled = false;
                btn_AddTitle.Enabled = false;
                btn_CancelUpdateTitle.Enabled = true;

                FillTextBoxTitle();
            }
            else
            {
                if (txt_TitleID.Text == "")
                {
                    MessageBox.Show("Chưa có ID Tiêu đề để sửa? Hãy chọn Tiêu đề");
                    return;
                }
                ///
                DialogResult dr = MessageBox.Show("Xác nhận SỬA tiêu đề này.\nXác Nhận ?", "Không", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes && dgv_title.CurrentRow.Cells[1].Value != null)
                {
                    Title tt = new Title()
                    {
                        idTitle = dgv_title.CurrentRow.Cells[0].Value.ToString().Trim(),
                        name = txt_TitleName.Text.ToString().Trim(),
                    };
                    Result result = null;
                    var taskCreate = Task.Factory.StartNew(() => result = titleBLL.updateTitle(tt));
                    taskCreate.Wait();

                    if (result.isSuccess)
                    {
                        MessageBox.Show(result.message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        ReloadTitle();
                        btn_ChangeTitle.Text = "Sửa";
                        txt_TitleID.Enabled = false;
                        txt_TitleName.Enabled = false;
                        cbx_titleType_addTitle.Enabled = false;

                        btn_AddTitle.Enabled = true;
                        btn_ChangeTitle.Enabled = true;
                        btn_RemoveTitle.Enabled = true;
                        btn_CancelUpdateTitle.Enabled = false;

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

        private void btn_CancelUpdateTitle_Click(object sender, EventArgs e)
        {
            btn_ChangeTitle.Text = "Sửa";
            btn_AddTitle.Text = "Thêm";

            // Clear data textbox
            txt_TitleID.Text = String.Empty;
            txt_TitleName.Text = String.Empty;
            txt_TitleID.Enabled = false;
            txt_TitleName.Enabled = false;
            cbx_titleType_addTitle.Enabled = false;

            btn_ChangeTitle.Enabled = true;
            btn_RemoveTitle.Enabled = true;
            btn_AddTitle.Enabled = true;
            btn_CancelUpdateTitle.Enabled = false;
        }

        private void btn_RemoveTitle_Click(object sender, EventArgs e)
        {
            if (dgv_title.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu? Hãy tải dữ liệu");
                return;
            }
            DialogResult dr = MessageBox.Show("Hãy Chắc Rằng Bạn Muốn Xóa Tiêu đề này.\nXác nhận XÓA tiêu đề ?", "Xóa tiêu đề", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            var csID = dgv_title.CurrentRow.Cells[0].Value.ToString().Trim();
            if (dr == DialogResult.Yes && csID != null)
            {
                try
                {
                    titleBLL.delete(csID);
                    dgv_title.Rows.RemoveAt(dgv_title.CurrentRow.Index);
                }
                catch
                {
                    MessageBox.Show("Tiêu đề này đang có rất nhiều đĩa bạn phải xóa hết đĩa trước");
                }
            }
            else
            {
                return;
            }
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

                btn_CancelChangeRentalFee.Visible = true;
            }
            else
            {
                int var;

                if (txt_RentFee.Text == "" || txt_RentalPeriod.Text == "" || !int.TryParse(txt_RentFee.Text, out var) || !int.TryParse(txt_RentalPeriod.Text, out var) || cbx_rentalFee.Text == "")
                {
                    if (cbx_rentalFee.Text == "")
                    {
                        MessageBox.Show("Bạn hãy chọn loại đĩa(CD or DVD)");
                    }
                    else if (txt_RentFee.Text == "" || txt_RentalPeriod.Text == "")
                    {
                        MessageBox.Show("Không được bỏ trống đâu nhá!! Nhập rồi coi lại phải số ko");
                    }
                    else
                    {
                        MessageBox.Show("Sai định dạng!!Hãy nhập số nguyên");
                    }
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


                    if (result.isSuccess)
                    {
                        MessageBox.Show(result.message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        // Khóa trường
                        txt_RentFee.Enabled = false;
                        txt_RentalPeriod.Enabled = false;
                        btn_ChangeRentFee.Text = "Thay đổi";
                        //
                        btn_CancelChangeRentalFee.Visible = false;
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
            if (dgv_disk.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu đĩa!! Hãy chọn tiêu đề trước");
                return;
            }
            DialogResult dr = MessageBox.Show("Hãy Chắc Rằng Bạn Muốn XÓA ĐĨA này?\nXác Nhận Xóa Đĩa?", "Xóa Đĩa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            var csID = dgv_disk.CurrentRow.Cells[0].Value.ToString().Trim();
            if (dr == DialogResult.Yes && csID != null)
            {
                dgv_disk.Rows.RemoveAt(dgv_disk.CurrentRow.Index);
                var result = diskBLL.delete(csID);
                if (result.isSuccess)
                {
                    UpdateCountOfDisks(true);
                    ReloadTitle();
                }
            }
            else
            {
                return;
            }
        }

        private void btn_AddDisk_Click(object sender, EventArgs e)
        {
            if (btn_AddDisk.Text=="Thêm")
            {
                btn_AddDisk.Text = "Lưu";
                btn_CancelAddDisk.Enabled = true;
                txt_IDDisk.Enabled = true;
            }
            else
            {
                if (dgv_title.Rows.Count == 0)
                {
                    MessageBox.Show("Chưa có dữ liệu đĩa!! Hãy chọn tiêu đề trước");
                    return;
                }
                if (txt_IDDisk.Text == "")
                {
                    MessageBox.Show("ID đĩa không được bỏ trống");
                    return;
                }
                Disk disk = new Disk()
                {
                    idDisk = txt_IDDisk.Text.Trim(),
                    idTitle = dgv_title.SelectedRows[0].Cells[0].Value.ToString(),
                    name = dgv_title.SelectedRows[0].Cells[0].Value.ToString() + " - "+titleBLL.GetItemTitleById(dgv_title.SelectedRows[0].Cells[0].Value.ToString()).name,
                    status = 0
                };
                Result result = null;
                try
                {
                    var taskCreate = Task.Factory.StartNew(() => result = diskBLL.addDisk(disk));
                    taskCreate.Wait();
                }
                catch
                {
                    MessageBox.Show("Mã trùng");
                    return;
                }
                if (result.isSuccess)
                {
                    MessageBox.Show(result.message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    if (dgv_title.SelectedRows.Count > 0 && dgv_title.SelectedRows[0].Cells[0].Value != null)
                    {
                        string id = dgv_title.SelectedRows[0].Cells[0].Value.ToString();
                        DiskCreateDataGridView(id);
                        UpdateCountOfDisks(false);
                        ReloadTitle();

                        btn_AddDisk.Text = "Thêm";
                        txt_IDDisk.Clear();
                        txt_IDDisk.Enabled = false;
                        btn_CancelAddDisk.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show(result.message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void btn_HuyChangeRentalFee_Click(object sender, EventArgs e)
        {

            txt_RentFee.Enabled = false;
            txt_RentalPeriod.Enabled = false;
            btn_ChangeRentFee.Text = "Thay đổi";
            //
            btn_CancelChangeRentalFee.Visible = false;
        }

        private void cbx_rentalFee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_rentalFee.Text == "DVD")
            {
                Category ct = categoryBLL.getCategoryById(1);
                txt_RentFee.Text = ct.rentalCharge.ToString();
                txt_RentalPeriod.Text = ct.rentalPeriod.ToString();
            }
            else if (cbx_rentalFee.Text == "CD")
            {
                Category ct = categoryBLL.getCategoryById(2);
                txt_RentFee.Text = ct.rentalCharge.ToString();
                txt_RentalPeriod.Text = ct.rentalPeriod.ToString();

            }

        }

        private void UC_Title_Load(object sender, EventArgs e)
        {
            // Block all control
            txt_searchTitle.Enabled = false;
            btn_RemoveTitle.Enabled = false;

            txt_TitleID.Enabled = false;
            txt_TitleName.Enabled = false;
            cbx_titleType_addTitle.Enabled = false;
            btn_AddTitle.Enabled = false;
            btn_ChangeTitle.Enabled = false;
            btn_CancelUpdateTitle.Enabled = false;

            btn_RemoveDisk.Enabled = false;

            txt_RentalPeriod.Enabled = false;
            txt_RentFee.Enabled = false;
            cbx_rentalFee.Enabled = false;
            btn_ChangeRentFee.Enabled = false;
            btn_CancelChangeRentalFee.Enabled = false;

            txt_IDDisk.Enabled = false;
            btn_AddDisk.Enabled = false;
            btn_CancelAddDisk.Enabled = false;
        }

        private void btn_CancelChangeRentalFee_Click(object sender, EventArgs e)
        {
            btn_ChangeRentFee.Text = "Thay đổi";
            btn_CancelChangeRentalFee.Enabled = false;
            cbx_rentalFee.Text = "DVD";
        }

        /// <summary>
        /// Count up or count down the count of disk
        /// </summary>
        /// <param name="isCountDown">If true, count down, else count up</param>
        private void UpdateCountOfDisks(bool isCountDown)
        {
            var titleId = dgv_title.SelectedRows[0].Cells[0].Value.ToString();
            var title = titleBLL.GetItemTitleById(titleId);
            if (isCountDown)
            {
                title.numberOfCopies--;
            }
            else
            {
                title.numberOfCopies++;
            }

            titleBLL.updateTitle(title);
        }
    }
}
