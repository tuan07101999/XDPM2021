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

namespace Nhom18_XDPM
{
    public partial class ReportTitleForm : Form
    {
        private readonly TitleBLL titleBLL;

        private List<TitleReportModel> currentTitleList;
        public ReportTitleForm()
        {
            titleBLL = new TitleBLL();
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportTitleForm_Load(object sender, EventArgs e)
        {
            var titles = titleBLL.GetTitleReport();
            currentTitleList = titles;
            titleReportModelBindingSource.DataSource = titles;
        }

        private void btn_TimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            var searchText = txt_TimKiem.Text.ToLower();
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
