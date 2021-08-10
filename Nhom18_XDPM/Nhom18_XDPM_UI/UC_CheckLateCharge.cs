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
    public partial class UC_CheckLateCharge : UserControl
    {
        public List<RecordDTO> listRecord;
        private BindingSource bindingSource;
        private RecordBLL recordBLL;
        private int idCustomer;
        private CustomerBLL customerBLL;
        private DiskBLL diskBLL;
        private static UC_CheckLateCharge _instance;
        public static UC_CheckLateCharge Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_CheckLateCharge();
                return _instance;
            }
        }
   
        public UC_CheckLateCharge()
        {
            InitializeComponent();
        }
        public UC_CheckLateCharge(int _idCustomer)
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            recordBLL = new RecordBLL();
            customerBLL = new CustomerBLL();
            idCustomer = _idCustomer;
            diskBLL = new DiskBLL();
        }
        public void CreateButtonDataGridView()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "";
            btn.Name = "btnXoa";
            btn.Text = "Xóa";
            btn.UseColumnTextForButtonValue = true;
            dgvListItem.Columns.Add(btn);
        }
        public void CreateDataGridView(string key)
        {
            bindingSource.DataSource = listRecord;
            dgvListItem.ClearSelection();
            dgvListItem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListItem.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListItem.DataSource = bindingSource;
            dgvListItem.MultiSelect = false;
            dgvListItem.ReadOnly = true;
            dgvListItem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (listRecord.Count > 0)
            {
                dgvListItem.Rows[0].Selected = false;
                dgvListItem.Columns["idRecord"].Visible = false;
                dgvListItem.Columns["isPaid"].HeaderText = "Xác nhận thanh toán";
            }
        }

        private void CheckLateFeeForm_Load(object sender, EventArgs e)
        {
          
            DataBindings.Clear();
            if (listRecord == null)
            {
                listRecord = new List<RecordDTO>();
                var listTemp = recordBLL.checkLateFee(idCustomer);
                foreach (var item in listTemp)
                {
                    listRecord.Add(new RecordDTO()
                    {
                        idRecord = item.idRecord,
                        nameCustomer = customerBLL.searchCustomerbyId(item.idCustomer).name,
                        nameDisk = diskBLL.getDiskByID(item.idDisk).name,
                        rentDate = item.rentDate,
                        dueDate = item.dueDate,
                        actualReturnDate = item.actualReturnDate,
                        lateFee = (float)item.lateFee,
                        isPaid = item.isPaid
                    });
                }
                foreach (var item in listRecord)
                {
                    item.isPaid = !item.isPaid;
                }
                CreateDataGridView("");
                CreateButtonDataGridView();
            }
            if (listRecord.Count > 0)
            {
                CreateDataGridView("");
            }
            if (listRecord.Count == 0)
            {
                dgvListItem.DataSource = new List<RecordDTO>();
                CreateDataGridView("");
            }
        }

        private void dgv_LateFee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListItem.Columns[e.ColumnIndex].HeaderText.Equals("Xác nhận thanh toán"))
            {
                var value = bool.Parse(dgvListItem.Rows[e.RowIndex].Cells["isPaid"].Value.ToString());
                var idRecord = dgvListItem.Rows[e.RowIndex].Cells["idRecord"].Value.ToString();
                var record = listRecord.FirstOrDefault(x => x.idRecord == Int32.Parse(idRecord));
                record.isPaid = !value;
            }
        }
    }
}
