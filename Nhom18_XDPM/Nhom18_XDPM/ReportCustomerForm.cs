using Business;
using Business.Enums;
using Business.Models;
using MaterialSkin.Controls;
using Microsoft.VisualBasic;
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

namespace Nhom18_XDPM
{
    public partial class ReportCustomersForm : Form
    {
        private readonly CustomerBLL _customerBLL;
        private readonly RecordBLL _recordBLL;
        private List<CustomerReportModel> currentCustomers;
        private List<RecordModel> currentCustomerRecords;
        private List<HasOverdueModel> currentCustomerOverdueRecords;

        public ReportCustomersForm()
        {
            _customerBLL = new CustomerBLL();
            _recordBLL = new RecordBLL();

            InitializeComponent();

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

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GenerateBindingSource(CustomerFilterTypeEnum customerFilterTypeEnum)
        {
            var customerReportList = _customerBLL.GetCustomersReport(customerFilterTypeEnum);
            currentCustomers = customerReportList;
            this.customerReportModelBindingSource.DataSource = customerReportList;
        }

        private void ReportCustomersForm_Load(object sender, EventArgs e)
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

        private void cmb_LoaiThongKe_SelectedValueChanged(object sender, EventArgs e)
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

        private void txt_Timkiem1_KeyUp(object sender, KeyEventArgs e)
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
                    cus.HoTen.ToLower().Contains(searchText) ||
                    cus.SoDienThoai.ToLower().Contains(searchText) ||
                    cus.ID.ToString().Contains(searchText) ||
                    cus.DiaChi.ToLower().Contains(searchText)).ToList();
                customerReportModelBindingSource.DataSource = searchResult;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgv_KhachHang_SelectionChanged(object sender, EventArgs e)
        {
            var selectedRows = dgv_KhachHang.SelectedRows;
            if (selectedRows.Count > 0)
            {
                var idCustomer = (int)selectedRows[0].Cells[0].Value;
                var titleList = _recordBLL.GetRecordsOfCustomer(idCustomer);
                var overdueList = _recordBLL.GetOverdueRecords(idCustomer);
                currentCustomerRecords = titleList;
                currentCustomerOverdueRecords = overdueList;

                recordModelBindingSource.DataSource = titleList;
                hasOverdueModelBindingSource.DataSource = overdueList;

                lblTongPhiTreHan.Text =  overdueList.Sum(item => item.SoTien).ToString("C0", CultureInfo.GetCultureInfo("vi-vn"));
            }
        }

        private void txt_Timkiem2_KeyUp(object sender, KeyEventArgs e)
        {
            var textBox = (TextBox)sender;
            var searchText = textBox.Text.ToLower();
            if (currentCustomerRecords != null)
            {
                if (string.IsNullOrEmpty(searchText.Trim()))
                {
                    recordModelBindingSource.DataSource = currentCustomerRecords;
                    return;
                }
                var searchResult = currentCustomerRecords.Where(cus =>
                        cus.TieuDe.ToLower().Contains(searchText) ||
                        cus.NgayDenHan.ToShortDateString().ToLower().Contains(searchText))
                    .ToList();
                recordModelBindingSource.DataSource = searchResult;
            }
        }

        private void txt_Timkiem3_KeyUp(object sender, KeyEventArgs e)
        {
            var textBox = (TextBox)sender;
            var searchText = textBox.Text.ToLower();
            if (currentCustomerOverdueRecords != null)
            {
                if (string.IsNullOrEmpty(searchText.Trim()))
                {
                    hasOverdueModelBindingSource.DataSource = currentCustomerOverdueRecords;
                    return;
                }
                var searchResult = currentCustomerOverdueRecords.Where(cus =>
                        cus.TieuDe.ToLower().Contains(searchText) ||
                        cus.NgayDenHan.ToShortDateString().ToLower().Contains(searchText) ||
                        cus.NgayTra.ToShortDateString().ToLower().Contains(searchText) ||
                        cus.SoTien.ToString().Contains(searchText))
                    .ToList();
                hasOverdueModelBindingSource.DataSource = searchResult;
            }
        }
    }
}
