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
    public partial class UC_Reservation : UserControl
    {
        private static UC_Reservation _instance;
        public static UC_Reservation Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_Reservation();
                return _instance;
            }
        }
        public UC_Reservation()
        {
            InitializeComponent();
        }

        private void btnHuyThem_Click(object sender, EventArgs e)
        {

        }
    }
}
