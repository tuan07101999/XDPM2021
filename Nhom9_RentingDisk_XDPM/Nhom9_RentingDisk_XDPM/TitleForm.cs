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
    public partial class TitleForm : Form
    {
        BindingSource bindingSource;
        TitleBLL titleBLL;
        DiskBLL diskBLL;
        CategoryBLL categoryBLL;
        BindingSource bindingSource2;
        public TitleForm()
        {
            InitializeComponent();
            titleBLL = new TitleBLL();
            diskBLL = new DiskBLL();
            categoryBLL = new CategoryBLL();
            bindingSource = new BindingSource();
            bindingSource2 = new BindingSource();

            CreateDataGridViewTitle();
            CreateDataGridViewDisk();
            
        }
        private void CreateDataGridViewTitle()
        {
            dgv_title.MultiSelect = false;
            dgv_title.ReadOnly = true;
            dgv_title.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_title.ClearSelection();
            
        }
        private void CustomDataGridViewTitle()
        {
            dgv_title.Columns["idTitle"].HeaderText = "Mã tiêu đề";
            dgv_title.Columns["name"].HeaderText = "Tên tiêu đề";
            dgv_title.Columns["numberOfCopies"].HeaderText = "Số bản sao";
            dgv_title.Columns["idCategory"].HeaderText = "Loại";
            dgv_title.Columns["Disks"].Visible = false;
            dgv_title.Columns["Records"].Visible = false;
            dgv_title.Columns["Category"].Visible = false;

            dgv_title.Columns["idTitle"].Width = 140;
            dgv_title.Columns["name"].Width = 380;
            dgv_title.Columns["numberOfCopies"].Width = 140;
            dgv_title.Columns["idCategory"].Width = 140;
        }
        private void TitleForm_Load(object sender, EventArgs e)
        {
            DataBindings.Clear();
            bindingSource.DataSource = titleBLL.GetListTitleByID("1");
            dgv_title.DataSource = bindingSource;
            CustomDataGridViewTitle();
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void btn_DatLaiGiaThue_Click(object sender, EventArgs e)
        {
            int typeTT = 1;
            if (cbx_titleType_updateFee.Text == "CD")
            {
                typeTT = 2;
            }
            Category category = new Category()
            {
                rentalCharge = (float)Convert.ToDecimal(txt_fee.Text.ToString()),
                rentalPeriod = Convert.ToInt32(txt_rent_date.Text),
                lateFee = 1,
                idCategory = typeTT
            };
            Result result = null;
            var taskCreate = Task.Factory.StartNew(() => result = categoryBLL.update(category));
            taskCreate.Wait();

            if (!result.isSuccess)
            {
                bindingSource.DataSource = titleBLL.GetListTitleByID("1");
                dgv_title.DataSource = bindingSource;
                CustomDataGridViewTitle();
            }
            if (result.isSuccess)
            {
                MessageBox.Show(result.message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show(result.message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            bindingSource.DataSource = titleBLL.GetItemTitleById(txt_idTitle.Text);
            dgv_title.DataSource = bindingSource;
            CustomDataGridViewTitle();
        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        public void CreateDataGridViewDisk()
        {
            dgv_disk.MultiSelect = false;
            dgv_disk.ReadOnly = true;
            dgv_disk.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_disk.ClearSelection();
        }

        private void txt_searchTitle_KeyUp(object sender, KeyEventArgs e)
        {
            string id = txt_searchTitle.Text.ToString();
            TitleCreateDataGridView(id);
        }

        private void dgv_title_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgv_title.SelectedRows.Count > 0 && dgv_title.SelectedRows[0].Cells[0].Value != null)
            {
               string id = dgv_title.SelectedRows[0].Cells[0].Value.ToString();
               DiskCreateDataGridView(id);
            }    
        }
        private void ClearTXT()
        {
            txt_idTitle.Clear();
            txt_titleName.Clear();
            txt_searchTitle.Clear();
            txt_fee.Clear();
            txt_rent_date.Clear();
        }
        private void DiskCreateDataGridView(string id)
        {
            bindingSource2.DataSource = diskBLL.GetListDiskByIDtitle(id);
            dgv_disk.DataSource = bindingSource2;
            //đang bug
        }
        private void TitleCreateDataGridView(string id)
        {
            bindingSource.DataSource = titleBLL.GetListTitleByID(id);
            dgv_title.DataSource = bindingSource;
            CustomDataGridViewTitle();
        }    

        private void btn_add_title_Click(object sender, EventArgs e)
        {
            int typeTT = 1;
            if(cbx_titleType_addTitle.Text == "CD")
            {
                typeTT = 2;
            }
            Title title = new Title()
            {
                idTitle = txt_idTitle.Text.ToString().Trim(),
                name = txt_titleName.Text.ToString().Trim(),
                numberOfCopies = 0,
                idCategory = typeTT
            };
            Result result = null;
            var taskCreate = Task.Factory.StartNew(() => result = titleBLL.addTitle(title));
            taskCreate.Wait();
         
            if (result.isSuccess)
            {
                MessageBox.Show(result.message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show(result.message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            
        }
    }
}
