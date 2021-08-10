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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            panelSubMenuDVD.Visible = false;
            panelSubMenuBaoCao.Visible = false;
            if (!panelRight.Controls.Contains(Uc_Home.Instance))
            {
                panelRight.Controls.Add(Uc_Home.Instance);
                Uc_Home.Instance.Dock = DockStyle.Fill;
                Uc_Home.Instance.BringToFront();
            }
            else
                Uc_Home.Instance.BringToFront();
        }

        private void btnDVD_Click(object sender, EventArgs e)
        {
            if (panelSubMenuDVD.Visible == true)
            {
                panelSubMenuDVD.Visible = false;
                

            }
            else
            {
                panelSubMenuDVD.Visible = true;
                
            }
        }

        private void btnThueDia_Click(object sender, EventArgs e)
        {
            DeactiveMenuButton();
            btnThueDia.Active = true;
            if (!panelRight.Controls.Contains(UC_RentDisk.Instance))
            {
                panelRight.Controls.Add(UC_RentDisk.Instance);
                UC_RentDisk.Instance.Dock = DockStyle.Fill;
                UC_RentDisk.Instance.BringToFront();
            }
            else
                UC_RentDisk.Instance.BringToFront();
        }

        private void btnTraDia_Click(object sender, EventArgs e)
        {
            DeactiveMenuButton();
            btnTraDia.Active = true;
            if (!panelRight.Controls.Contains(UC_ReturnDisk.Instance))
            {
                panelRight.Controls.Add(UC_ReturnDisk.Instance);
                UC_ReturnDisk.Instance.Dock = DockStyle.Fill;
                UC_ReturnDisk.Instance.BringToFront();
            }
            else
            {
                UC_ReturnDisk.Instance.BringToFront();
                UC_ReturnDisk.Instance.UC_Load();
            }
        }

        private void btnDatTruoc_Click(object sender, EventArgs e)
        {
            DeactiveMenuButton();
            btnDatTruoc.Active = true;
            if (!panelRight.Controls.Contains(UC_Reservation.Instance))
            {
                panelRight.Controls.Add(UC_Reservation.Instance);
                UC_Reservation.Instance.Dock = DockStyle.Fill;
                UC_Reservation.Instance.BringToFront();
            }
            else
            {
                UC_Reservation.Instance.BringToFront();
                UC_Reservation.Instance.LoadDgvReservation();
            }


        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            DeactiveMenuButton();
            btnKhachHang.Active = true;
            if (!panelRight.Controls.Contains(UC_Customer.Instance))
            {
                panelRight.Controls.Add(UC_Customer.Instance);
                UC_Customer.Instance.Dock = DockStyle.Fill;
                UC_Customer.Instance.BringToFront();
            }
            else
                UC_Customer.Instance.BringToFront();
        }

        private void btnNhanDe_Click(object sender, EventArgs e)
        {
            DeactiveMenuButton();
            btnNhanDe.Active = true;
            if (!panelRight.Controls.Contains(UC_Title.Instance))
            {
                panelRight.Controls.Add(UC_Title.Instance);
                UC_Title.Instance.Dock = DockStyle.Fill;
                UC_Title.Instance.BringToFront();
            }
            else
                UC_Title.Instance.BringToFront();
        }

        private void btnBaoCaoKH_Click(object sender, EventArgs e)
        {
            if (!panelRight.Controls.Contains(UC_ReportCustomer.Instance))
            {
                panelRight.Controls.Add(UC_ReportCustomer.Instance);
                UC_ReportCustomer.Instance.Dock = DockStyle.Fill;
                UC_ReportCustomer.Instance.BringToFront();
            }
            else
                UC_ReportCustomer.Instance.BringToFront();
        }

        private void btnBaoCaoNhanDe_Click(object sender, EventArgs e)
        {
            if (!panelRight.Controls.Contains(UC_ReportTitle.Instance))
            {
                panelRight.Controls.Add(UC_ReportTitle.Instance);
                UC_ReportTitle.Instance.Dock = DockStyle.Fill;
                UC_ReportTitle.Instance.BringToFront();
            }
            else
                UC_ReportTitle.Instance.BringToFront();
        }

       private void DeactiveMenuButton()
        {
            btnDVD.Active = false;
            btnKhachHang.Active = false;
            btnThueDia.Active = false;
            btnTraDia.Active = false;
            btnDatTruoc.Active = false;
            btnNhanDe.Active = false;
            btnBaoCao.Active = false;
            btnBaoCaoKH.Active = false;
            btnBaoCaoNhanDe.Active = false;
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            if (panelSubMenuBaoCao.Visible == true)
            {
                panelSubMenuBaoCao.Visible = false;


            }
            else
            {
                panelSubMenuBaoCao.Visible = true;

            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (!panelRight.Controls.Contains(Uc_Home.Instance))
            {
                panelRight.Controls.Add(Uc_Home.Instance);
                Uc_Home.Instance.Dock = DockStyle.Fill;
                Uc_Home.Instance.BringToFront();
            }
            else
                Uc_Home.Instance.BringToFront();
        }
    }
}
