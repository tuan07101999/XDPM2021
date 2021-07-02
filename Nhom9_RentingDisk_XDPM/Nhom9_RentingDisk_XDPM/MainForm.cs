using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom9_RentingDisk_XDPM
{
    public partial class MainForm : Form
    {
        //private List<Disk> disks;
        public MainForm()
        {
            InitializeComponent();
            //disks = new List<Disk>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btn_customer_Click(object sender, EventArgs e)
        {
            Application.OpenForms.Cast<Form>().Where(x => !(x is MainForm))
              .ToList().ForEach(x => x.Close());
            CustomerForm CF = new CustomerForm();
            CF.TopLevel = false;
            CF.Parent = pnl_FormConnect;
            CF.Show();
            btn_customer.Normalcolor = Color.FromArgb(224,224,224);
            btn_reservationDisk.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_managementDisk.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_RentDisk.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_returnDisk.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_title.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_report.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_reportCustomer.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_reportTitle.Normalcolor = Color.FromArgb(244, 246, 248);
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            if (pnl_MenuOption.Width == 200)
            {
                btn_Menu.Location = new Point(12, 6);
                pnl_MenuOption.Width = 50;
            }
            else
            {
                btn_Menu.Location = new Point(167, 6);
                pnl_MenuOption.Width = 200;
            }
        }

        private void btn_RentDisk_Click(object sender, EventArgs e)
        {
            Application.OpenForms.Cast<Form>().Where(x => !(x is MainForm))
              .ToList().ForEach(x => x.Close());
            RentingForm rentForm = new RentingForm();
            rentForm.TopLevel = false;
            rentForm.Parent = pnl_FormConnect;
            rentForm.Show();
            btn_RentDisk.Normalcolor = Color.FromArgb(224, 224, 224);
            btn_managementDisk.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_returnDisk.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_reservationDisk.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_customer.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_title.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_report.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_reportCustomer.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_reportTitle.Normalcolor = Color.FromArgb(244, 246, 248);

        }

        private void btn_reservationDisk_Click(object sender, EventArgs e)
        {
            Application.OpenForms.Cast<Form>().Where(x => !(x is MainForm))
              .ToList().ForEach(x => x.Close());
            ReservationForm reservationForm = new ReservationForm();
            reservationForm.TopLevel = false;
            reservationForm.Parent = pnl_FormConnect;
            reservationForm.Show();

            btn_reservationDisk.Normalcolor = Color.FromArgb(224, 224, 224);
            btn_managementDisk.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_RentDisk.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_returnDisk.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_customer.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_title.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_report.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_reportCustomer.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_reportTitle.Normalcolor = Color.FromArgb(244, 246, 248);
        }

        private void pbo_closeForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbo_dropdownCD_DVD_Click(object sender, EventArgs e)
        {
            if (pnl_CD_DVD.Visible == true)
            {
                pnl_CD_DVD.Visible = false;
                pbo_dropdownCD_DVD.Image = Properties.Resources.sort_up_26px;

            }
            else
            {
                pnl_CD_DVD.Visible = true;
                pbo_dropdownCD_DVD.Image = Properties.Resources.sort_down_26px;
            }
        }

        private void btn_managementDisk_click(object sender, EventArgs e)
        {
            btn_managementDisk.Normalcolor = Color.FromArgb(224, 224, 224);
            btn_RentDisk.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_returnDisk.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_reservationDisk.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_customer.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_title.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_report.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_reportCustomer.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_reportTitle.Normalcolor = Color.FromArgb(244, 246, 248);
        }

        private void btn_returnDisk_Click(object sender, EventArgs e)
        {
            Application.OpenForms.Cast<Form>().Where(x => !(x is MainForm))
              .ToList().ForEach(x => x.Close());
            ReturnDVDForm returnDVDForm = new ReturnDVDForm();
            returnDVDForm.TopLevel = false;
            returnDVDForm.Parent = pnl_FormConnect;
            returnDVDForm.Show();

            btn_returnDisk.Normalcolor = Color.FromArgb(224, 224, 224);
            btn_managementDisk.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_RentDisk.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_reservationDisk.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_customer.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_title.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_report.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_reportCustomer.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_reportTitle.Normalcolor = Color.FromArgb(244, 246, 248);
        }

        private void btn_title_Click(object sender, EventArgs e)
        {
            Application.OpenForms.Cast<Form>().Where(x => !(x is MainForm))
           .ToList().ForEach(x => x.Close());
            TitleForm titleForm = new TitleForm();
            titleForm.TopLevel = false;
            titleForm.Parent = pnl_FormConnect;
            titleForm.Show();

            btn_title.Normalcolor = Color.FromArgb(224, 224, 224);
            btn_managementDisk.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_RentDisk.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_returnDisk.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_reservationDisk.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_customer.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_report.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_reportCustomer.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_reportTitle.Normalcolor = Color.FromArgb(244, 246, 248);
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            btn_report.Normalcolor = Color.FromArgb(224, 224, 224);
            btn_managementDisk.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_RentDisk.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_returnDisk.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_reservationDisk.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_customer.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_title.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_reportCustomer.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_reportTitle.Normalcolor = Color.FromArgb(244, 246, 248);
        }

        private void pbo_dropdownReport_Click(object sender, EventArgs e)
        {
            if (pnl_reportDetail.Visible == true)
            {
                pnl_reportDetail.Visible = false;
                pbo_dropdownReport.Image = Properties.Resources.sort_up_26px;

            }
            else
            {
                pnl_reportDetail.Visible = true;
                pbo_dropdownReport.Image = Properties.Resources.sort_down_26px;
            }
        }

        private void btn_reportCustomer_Click(object sender, EventArgs e)
        {
            btn_reportCustomer.Normalcolor = Color.FromArgb(224, 224, 224);
            btn_report.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_managementDisk.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_RentDisk.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_returnDisk.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_reservationDisk.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_customer.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_title.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_reportTitle.Normalcolor = Color.FromArgb(244, 246, 248);
            Application.OpenForms.Cast<Form>().Where(x => !(x is MainForm)).ToList().ForEach(x => x.Close());
            ReportCustomerForm CF = new ReportCustomerForm();
            CF.TopLevel = false;
            CF.Parent = pnl_FormConnect;
            CF.Show();
        }

        private void btn_reportTitle_Click(object sender, EventArgs e)
        {
            btn_reportTitle.Normalcolor = Color.FromArgb(224, 224, 224);
            btn_report.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_managementDisk.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_RentDisk.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_returnDisk.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_reservationDisk.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_customer.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_title.Normalcolor = Color.FromArgb(244, 246, 248);
            btn_reportCustomer.Normalcolor = Color.FromArgb(244, 246, 248);
            Application.OpenForms.Cast<Form>().Where(x => !(x is MainForm))
              .ToList().ForEach(x => x.Close());
            ReportTitleForm CF = new ReportTitleForm();
            CF.TopLevel = false;
            CF.Parent = pnl_FormConnect;
            CF.Show();
        }
    }

}
