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

        private void btnThanhToan_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }
    }
}
