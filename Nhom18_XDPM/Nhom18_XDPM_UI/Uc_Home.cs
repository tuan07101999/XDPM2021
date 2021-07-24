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
    public partial class Uc_Home : UserControl
    {
        private static Uc_Home _instance;
        public static Uc_Home Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Uc_Home();
                return _instance;
            }
        }
        public Uc_Home()
        {
            InitializeComponent();
        }

        private void Uc_Home_Load(object sender, EventArgs e)
        {

        }
    }
}
