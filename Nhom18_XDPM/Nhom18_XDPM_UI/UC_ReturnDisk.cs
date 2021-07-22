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
    public partial class UC_ReturnDisk : UserControl
    {
        private static UC_ReturnDisk _instance;
        public static UC_ReturnDisk Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_ReturnDisk();
                return _instance;
            }
        }
        public UC_ReturnDisk()
        {
            InitializeComponent();
        }

        private void btnThongTinPhiTre_Click(object sender, EventArgs e)
        {
            
            if (!Parent.Controls.Contains(UC_CheckLateCharge.Instance))
            {
                Parent.Controls.Add(UC_CheckLateCharge.Instance);
                UC_CheckLateCharge.Instance.Dock = DockStyle.Fill;
                UC_CheckLateCharge.Instance.BringToFront();
            }
            else
                UC_CheckLateCharge.Instance.BringToFront();
        }
    }
}
