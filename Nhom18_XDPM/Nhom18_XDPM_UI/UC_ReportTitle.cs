using Business;
using Business.Models;
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
    public partial class UC_ReportTitle : UserControl
    {
        private readonly TitleBLL titleBLL;
        private List<TitleReportModel> currentTitleList;

        private static UC_ReportTitle _instance;
        public static UC_ReportTitle Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_ReportTitle();
                return _instance;
            }
        }
        public UC_ReportTitle()
        {
            titleBLL = new TitleBLL();
            InitializeComponent();
            Dock = DockStyle.Fill;
            SetUp_dataGridView();
        }

        private void SetUp_dataGridView()
        {
            dgvTitle.MultiSelect = false;
            dgvTitle.ReadOnly = true;
            dgvTitle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


        }

        private void UC_ReportTitle_Load(object sender, EventArgs e)
        {
            var titles = titleBLL.GetTitleReport();
            currentTitleList = titles;
            titleReportModelBindingSource.DataSource = titles;
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Text = String.Empty;
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            var searchText = txtSearch.Text.ToLower();
            if (currentTitleList != null)
            {
                if (string.IsNullOrEmpty(searchText.Trim()))
                {
                    titleReportModelBindingSource.DataSource = currentTitleList;
                    return;
                }
                var searchResult = currentTitleList.Where(cus => cus.TieuDe.ToLower().Contains(searchText)).ToList();
                titleReportModelBindingSource.DataSource = searchResult;
            }
        }
    }
}
