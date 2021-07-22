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
    public partial class UC_RentDisk : UserControl
    {
        public UC_RentDisk()
        {
            InitializeComponent();
        }

        private static UC_RentDisk _instance;
        public static UC_RentDisk Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_RentDisk();
                return _instance;
            }
        }
        

        

        private void btnDatDia_Click(object sender, EventArgs e)
        {
            if (!Parent.Controls.Contains(UC_Reservation.Instance))
            {
                Parent.Controls.Add(UC_Reservation.Instance);
                UC_Reservation.Instance.Dock = DockStyle.Fill;
                UC_Reservation.Instance.BringToFront();
            }
            else
                UC_Reservation.Instance.BringToFront();
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
