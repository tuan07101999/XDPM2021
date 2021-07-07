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

namespace Nhom18_XDPM
{
    public partial class CheckLateFeeForm : Form
    {
        public List<RecordDTO> listRecord;
        private BindingSource bindingSource;
        private RecordBLL recordBLL;
        private int idCustomer;
        private CustomerBLL customerBLL;
        private DiskBLL diskBLL;

        public CheckLateFeeForm(int _idCustomer)
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
            dgv_LateFee.Columns.Add(btn);
        }
        public void CreateDataGridView(string key)
        {
            bindingSource.DataSource = listRecord;
            dgv_LateFee.ClearSelection();
            dgv_LateFee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_LateFee.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_LateFee.DataSource = bindingSource;
            dgv_LateFee.MultiSelect = false;
            dgv_LateFee.ReadOnly = true;
            dgv_LateFee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if(listRecord.Count > 0)
            {
                dgv_LateFee.Rows[0].Selected = false;
                dgv_LateFee.Columns["idRecord"].Visible = false;
                dgv_LateFee.Columns["isPaid"].HeaderText = "Xác nhận thanh toán";
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
            if(listRecord.Count == 0)
            {
                dgv_LateFee.DataSource = new List<RecordDTO>();
                CreateDataGridView("");
            }
        }

        private void dgv_LateFee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10)
            {
                //var value = bool.Parse(dgv_LateFee.Rows[e.RowIndex].Cells["isPaid"].Value.ToString());
                ////dgv_LateFee.Rows[e.RowIndex].Cells["isPaid"].Value = !value;
                //var idRecord = dgv_LateFee.Rows[e.RowIndex].Cells["idRecord"].Value.ToString();
                ////var record = recordBLL.getRecordByID(Int32.Parse(idRecord));
                //listRecord.FirstOrDefault(x => x.idRecord == Int32.Parse(idRecord)).isPaid = !value;
            }
        }

        private void dgv_LateFee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_LateFee.Columns[e.ColumnIndex].HeaderText.Equals("Xác nhận thanh toán"))
            {
                var value = bool.Parse(dgv_LateFee.Rows[e.RowIndex].Cells["isPaid"].Value.ToString());
                var idRecord = dgv_LateFee.Rows[e.RowIndex].Cells["idRecord"].Value.ToString();
                var record = listRecord.FirstOrDefault(x => x.idRecord == Int32.Parse(idRecord));
                record.isPaid = !value;
            }
        }
    }
}
