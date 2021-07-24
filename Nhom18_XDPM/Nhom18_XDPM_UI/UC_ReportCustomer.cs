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
    public partial class UC_ReportCustomer : UserControl
    {
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
            InitializeComponent();
        }

        private void UC_ReportCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
