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
    public partial class UC_Customer : UserControl
    {
        private static UC_Customer _instance;
        public static UC_Customer Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_Customer();
                return _instance;
            }
        }
        public UC_Customer()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        
    }
}
