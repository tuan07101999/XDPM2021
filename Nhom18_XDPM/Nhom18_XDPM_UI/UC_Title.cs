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
    public partial class UC_Title : UserControl
    {
        private static UC_Title _instance;
        public static UC_Title Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_Title();
                return _instance;
            }
        }
        public UC_Title()
        {
            InitializeComponent();
        }

        private void btnHuyThemNhanDe_Click(object sender, EventArgs e)
        {

        }

        
    }
}
