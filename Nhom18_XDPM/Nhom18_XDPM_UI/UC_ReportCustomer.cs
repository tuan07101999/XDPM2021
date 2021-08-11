using Business;
using Business.Enums;
using Business.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom18_XDPM_UI
{
    public partial class UC_ReportCustomer : UserControl
    {
        private readonly CustomerBLL _customerBLL;
        private readonly RecordBLL _recordBLL;
        private List<CustomerReportModel> currentCustomers;
        private List<RecordModel> currentCustomerRecords;
        private List<HasOverdueModel> currentCustomerOverdueRecords;

        private static UC_ReportCustomer _instance;
        public static UC_ReportCustomer Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_ReportCustomer();
                return _instance;
            }
        }
        public UC_ReportCustomer()
        {
            _customerBLL = new CustomerBLL();
            _recordBLL = new RecordBLL();

            InitializeComponent();

            SetUp_dataGridView();

            var filterTypeDataSource = new List<CustomerFilterTypeObject>()
            {
                new CustomerFilterTypeObject()
                {
                    Type = (int)CustomerFilterTypeEnum.All,
                    Text = "Tất cả khách hàng"
                },
                new CustomerFilterTypeObject()
                {
                    Type = (int)CustomerFilterTypeEnum.HasOverdue,
                    Text = "Khách hàng có đĩa quá hạn"
                },
                new CustomerFilterTypeObject()
                {
                    Type = (int)CustomerFilterTypeEnum.HasDebt,
                    Text = "Khách hàng đang có nợ phí"
                }
            };
            customerFilterTypeObjectBindingSource.DataSource = filterTypeDataSource;

            this.Dock = DockStyle.Fill;
        }

        private void SetUp_dataGridView()
        {
            dgvCustomer.MultiSelect = false;
            dgvCustomer.ReadOnly = true;
            dgvCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            

        }

        private void GenerateBindingSource(CustomerFilterTypeEnum customerFilterTypeEnum)
        {
            var customerReportList = _customerBLL.GetCustomersReport(customerFilterTypeEnum);
            currentCustomers = customerReportList;
            this.customerReportModelBindingSource.DataSource = customerReportList;
        }

        private void UC_ReportCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                GenerateBindingSource(CustomerFilterTypeEnum.All);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load data");
            }
        }

        private void cmbType_SelectedValueChanged(object sender, EventArgs e)
        {
            var comboBox = (ComboBox)sender;
            if (comboBox.SelectedValue != null && _customerBLL != null)
            {
                var selectedValue = (int)comboBox.SelectedValue;
                switch (selectedValue)
                {
                    case (int)CustomerFilterTypeEnum.All:
                        GenerateBindingSource(CustomerFilterTypeEnum.All);
                        break;
                    case (int)CustomerFilterTypeEnum.HasOverdue:
                        GenerateBindingSource(CustomerFilterTypeEnum.HasOverdue);
                        break;
                    case (int)CustomerFilterTypeEnum.HasDebt:
                        GenerateBindingSource(CustomerFilterTypeEnum.HasDebt);
                        break;
                }
            }
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Text = String.Empty;
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            var textBox = (TextBox)sender;
            var searchText = textBox.Text.ToLower();
            if (currentCustomers != null)
            {
                if (string.IsNullOrEmpty(searchText.Trim()))
                {
                    customerReportModelBindingSource.DataSource = currentCustomers;
                    return;
                }
                var searchResult = currentCustomers.Where(cus =>                    
                    cus.ID.ToString().Contains(searchText)).ToList();
                customerReportModelBindingSource.DataSource = searchResult;
            }
        }

        private void dgvCustomer_SelectionChanged(object sender, EventArgs e)
        {
            var selectedRows = dgvCustomer.SelectedRows;
            if (selectedRows.Count > 0)
            {
                var idCustomer = (int)selectedRows[0].Cells[0].Value;
                var titleList = _recordBLL.GetRecordsOfCustomer(idCustomer);
                var overdueList = _recordBLL.GetOverdueRecords(idCustomer);
                currentCustomerRecords = titleList;
                currentCustomerOverdueRecords = overdueList;

                recordModelBindingSource.DataSource = titleList;
                hasOverdueModelBindingSource.DataSource = overdueList;

                try
                {
                    txtTotalLateFee.Text = overdueList.Sum(item => item.SoTien).ToString("C0", CultureInfo.GetCultureInfo("vi-vn"));
                }
                catch
                {
                    return;
                }
            }
        }
    }
}
