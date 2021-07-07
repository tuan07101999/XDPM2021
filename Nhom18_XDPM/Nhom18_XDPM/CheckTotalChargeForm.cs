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
    public partial class CheckTotalChargeForm : Form
    {
        private List<Disk> rentingDisk;
        public List<Disk> listRemove;
        private BindingSource bindingSource;
        public CheckTotalChargeForm()
        {
            InitializeComponent();
        }
        public CheckTotalChargeForm(List<Disk> _rentingDisk)
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            rentingDisk = new List<Disk>();
            if (_rentingDisk.Count > 0)
                rentingDisk = _rentingDisk;
            listRemove = new List<Disk>();
        }
        public void CreateButtonDataGridView()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "";
            btn.Name = "btnXoa";
            btn.Text = "Xóa";
            btn.UseColumnTextForButtonValue = true;
            dgv_WaitingForRent.Columns.Add(btn);
        }

        public void CreateDataGridView(string key)
        {
            var check = rentingDisk.Where(x => x.name.Contains(key));
            if (check.Count() != 0)
            {
                bindingSource.DataSource = check;
            }
            dgv_WaitingForRent.ClearSelection();
            dgv_WaitingForRent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_WaitingForRent.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_WaitingForRent.DataSource = bindingSource;
            dgv_WaitingForRent.MultiSelect = false;
            dgv_WaitingForRent.ReadOnly = true;
            dgv_WaitingForRent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_WaitingForRent.Rows[0].Selected = false;
            dgv_WaitingForRent.Columns["Title"].Visible = false;
            dgv_WaitingForRent.Columns["Records"].Visible = false;

            dgv_WaitingForRent.Columns["idDisk"].Width = 100;
            dgv_WaitingForRent.Columns["name"].Width = 300;
        }

        private void CheckTotalChargeForm_Load(object sender, EventArgs e)
        {
            DataBindings.Clear();
            if(rentingDisk.Count > 0)
            {
                CreateDataGridView("");
                CreateButtonDataGridView();
            }
        }

        private void dgv_WaitingForRent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var idDisk = dgv_WaitingForRent.Rows[e.RowIndex].Cells["idDisk"].Value.ToString();
            var idTitle = dgv_WaitingForRent.Rows[e.RowIndex].Cells["idTitle"].Value.ToString();
            var disk = rentingDisk.FirstOrDefault(x => x.idDisk == idDisk);

            listRemove.Add(disk);
            rentingDisk.Remove(disk);

            if (dgv_WaitingForRent.Rows.Count == 1)
            {
                dgv_WaitingForRent.DataSource = new List<Disk>();
            }
            else
            {
                CreateDataGridView("");
            }
        }
    }
}
