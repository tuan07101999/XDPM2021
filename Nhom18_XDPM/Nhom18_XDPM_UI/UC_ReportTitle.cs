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
            InitializeComponent();
        }

        private void UC_ReportTitle_Load(object sender, EventArgs e)
        {

        }
    }
}
