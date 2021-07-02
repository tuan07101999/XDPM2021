using Business;
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
    public partial class RentingForm : Form
    {
        private DiskBLL diskBLL;
        private List<Disk> disks;
        BindingSource bindingSource;

        public RentingForm()
        {
            InitializeComponent();
            diskBLL = new DiskBLL();
            bindingSource = new BindingSource();

        }
        public void CreateDataGridView()
        {
            bindingSource.DataSource = diskBLL.getDisks();
            dgv_Disk.DataSource = bindingSource;
            dgv_Disk.MultiSelect = false;
            dgv_Disk.ReadOnly = true;
            dgv_Disk.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Disk.ClearSelection();
            dgv_Disk.Rows[0].Selected = false;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {

        }

        private void txt_numberPhone_Click(object sender, EventArgs e)
        {
            pnl_numberPhone.BackColor = Color.FromArgb(20, 173, 196);
        }

        private void txt_nameCustomer_Click(object sender, EventArgs e)
        {
            pnl_nameCustomer.BackColor = Color.FromArgb(20, 173, 196);

        }

        private void txt_searchItem_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RentingForm_Load(object sender, EventArgs e)
        {
            CreateDataGridView();
        }
    }
}
