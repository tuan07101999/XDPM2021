using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Business;
using DataAccess.Entities;
using DataAccess.Entities.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Nhom18_XDPM_UI
{
    public partial class UC_RentDisk : UserControl
    {
        DataTable table = new DataTable("table");
        int index;
        private DiskBLL diskBLL;
        private TitleBLL titleBLL;
        private CategoryBLL categoryBLL;
        private Customer customer;
        private CustomerBLL customerBLL;
        private List<Disk> disks;
        private BindingSource bindingSource;
        private List<Disk> rentingList;
        private RecordBLL recordBLL;
        private float totalCharge = 0;
        private float totalPhiThue = 0;
        private float phithuetam = 0;
        private List<Record> lateFeeList;
        //private CheckLateFeeForm form;
        private List<Record> pendingRecords;
        public UC_RentDisk()
        {
            InitializeComponent();
            diskBLL = new DiskBLL();
            recordBLL = new RecordBLL();
            customerBLL = new CustomerBLL();
            bindingSource = new BindingSource();
            disks = diskBLL.getDisksOnShelf();
            rentingList = new List<Disk>();
            titleBLL = new TitleBLL();
            categoryBLL = new CategoryBLL();
            lateFeeList = new List<Record>();
            pendingRecords = new List<Record>();
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
        private void AutoComplete()
        {
            var name = disks.Select(d => { return d.name;});
            AutoCompleteStringCollection sourcename = new AutoCompleteStringCollection();
            sourcename.AddRange(name.ToArray());
            txtTenDia.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTenDia.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTenDia.AutoCompleteCustomSource = sourcename;
        }

        private void btnTimKH_Click(object sender, EventArgs e)
        {
            string txt = txtIDKhachHang.Text.ToString().Trim();
            if (customer == null)
            {
                customer = new Customer();
                customer = customerBLL.searchCustomerbyId(Int32.Parse(txt));
            }
            if (customer != null)
            {
                txtTenKH.Text = customer.name;
                txtSDT.Text = customer.phoneNumber;
                lateFeeList = recordBLL.checkLateFee(Int32.Parse(txt));
                if (lateFeeList.Count > 0)
                {
                    foreach (var item in lateFeeList)
                    {
                        totalCharge += (float)item.lateFee;
                        item.isPaid = !item.isPaid;
                    }
                    MessageBox.Show("Khách hàng có phí trễ, có muốn thanh toán không?");
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng");
            }
        }
        public void CreateDataGridView()
        {
            table.Columns.Add("ID", Type.GetType("System.String"));
            table.Columns.Add("Tên đĩa", Type.GetType("System.String"));
            table.Columns.Add("Ngày trả", Type.GetType("System.String"));
            table.Columns.Add("Phí thuê", Type.GetType("System.Double"));
            dgvListItem.DataSource = table;
        }
        private void UC_RentDisk_Load(object sender, EventArgs e)
        {
            AutoComplete();
            CreateDataGridView();
            dtpNgayTra.Format = DateTimePickerFormat.Custom;
            dtpNgayTra.CustomFormat = "dd-MM-yyyy";
            txtTongTien.Text = totalCharge.ToString();
            txtTongPhiThue.Text = totalPhiThue.ToString();
            txtNgayThue.Text = DateTime.Now.Date.ToString("dd-MM-yyyy");
            txtIdDia.ReadOnly = true;
            txtPhiThue.ReadOnly = true;
        }
        private void ClearTextBox()
        {
            txtIdDia.Text = String.Empty;
            txtTenDia.Text = String.Empty;
            txtPhiThue.Text = String.Empty;
        }

        private void btnThemDia_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txtIdDia.Text, txtTenDia.Text, dtpNgayTra.Text, txtPhiThue.Text);
            totalCharge += Convert.ToInt32(txtPhiThue.Text);
            totalPhiThue += Convert.ToInt32(txtPhiThue.Text);
            txtTongTien.Text = totalCharge.ToString();
            txtTongPhiThue.Text = totalPhiThue.ToString();
            var idDia = txtIdDia.Text;
            var disk = disks.FirstOrDefault(x => x.idDisk == idDia);
            disk.status = Status.Rented;
            ClearTextBox();
        }

        private void dgvListItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dgvListItem.Rows[index];
            txtIdDia.Text = row.Cells[0].Value.ToString();
            txtTenDia.Text = row.Cells[1].Value.ToString();
            dtpNgayTra.Value = DateTime.ParseExact(row.Cells[2].Value.ToString(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            txtPhiThue.Text = row.Cells[3].Value.ToString();
            phithuetam = Convert.ToInt32(txtPhiThue.Text);
        }

        private void btnSuaDia_Click(object sender, EventArgs e)
        {
            totalCharge -= phithuetam;
            totalPhiThue -= phithuetam;
            DataGridViewRow newdata = dgvListItem.Rows[index];
            newdata.Cells[2].Value = dtpNgayTra.Text;
            newdata.Cells[3].Value = txtPhiThue.Text;
            totalCharge += Convert.ToInt32(txtPhiThue.Text);
            totalPhiThue += Convert.ToInt32(txtPhiThue.Text);
            txtTongTien.Text = totalCharge.ToString();
            txtTongPhiThue.Text = totalPhiThue.ToString();
            ClearTextBox();
        }

        private void btnXoaDia_Click(object sender, EventArgs e)
        {
            totalCharge -= Convert.ToInt32(txtPhiThue.Text);
            txtTongTien.Text = totalCharge.ToString();
            totalPhiThue -= Convert.ToInt32(txtPhiThue.Text);
            txtTongPhiThue.Text = totalPhiThue.ToString();
            index = dgvListItem.CurrentCell.RowIndex;
            dgvListItem.Rows.RemoveAt(index);
            var idDia = txtIdDia.Text;
            var disk = disks.FirstOrDefault(x => x.idDisk == idDia);
            disk.status = Status.OnShelf;
            ClearTextBox();
        }

        private void dtpNgayTra_ValueChanged(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now.Date;
            var date = dtpNgayTra.Value;
            if (date <= currentDate)
            {
                var result = MessageBox.Show("Hạn trả phải lớn hơn ngày thuê ít nhất 1 ngày!", "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    dtpNgayTra.Value = currentDate.AddDays(1);
                    var idDisk = txtIdDia.Text;
                    var id = from d in disks where (d.idDisk == idDisk) select d.idTitle;
                    var idTitle = "";
                    foreach (var item in id)
                    {
                        idTitle = item.ToString();
                    }
                    var idCategory = titleBLL.getIdCategoryByIdTitle(idTitle);
                    txtPhiThue.Text = categoryBLL.getRentalChargeById(idCategory).ToString();
                }
            }else
            {
                TimeSpan i = date.Subtract(currentDate);
                var t = i.Days;

                var idDisk = txtIdDia.Text;
                var id = from d in disks where (d.idDisk == idDisk) select d.idTitle;
                var idTitle = "";
                foreach (var item in id)
                {
                    idTitle = item.ToString();
                }
                var idCategory = titleBLL.getIdCategoryByIdTitle(idTitle);
                var phithue = categoryBLL.getRentalChargeById(idCategory) * t;
                txtPhiThue.Text = phithue.ToString();
            }
        }

        private void btnTimDia_Click(object sender, EventArgs e)
        {
            var idDia = from disk in disks where (disk.name == txtTenDia.Text) select disk.idDisk;
            foreach (var item in idDia)
            { 
                txtIdDia.Text = item.ToString(); 
            }
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
            UC_CheckLateCharge frm = new UC_CheckLateCharge();     
            frm.data = txtIDKhachHang.Text;
        }

        private void btnThue_Click(object sender, EventArgs e)
        {
           /* DialogResult dialogResult = MessageBox.Show("Xác nhận thanh toán", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (rentingList.Count > 0)
                {
                    foreach (var item in rentingList)
                    {
                        var idCategory = titleBLL.getIdCategoryByIdTitle(item.idTitle);
                        var category = categoryBLL.getCategoryById(idCategory);
                        item.status = Status.Rented;
                        diskBLL.updateStatusDisk(item);
                        var newRecord = new Record()
                        {
                            idRecord = 0,
                            idCustomer = Int32.Parse(txtIDKhachHang.Text),
                            idDisk = item.idDisk,
                            isPaid = true,
                            rentDate = DateTime.Now,
                            dueDate = DateTime.Now.AddDays(category.rentalPeriod),
                            lateFee = category.lateFee
                        };
                        var check = pendingRecords.FirstOrDefault(x => x.idCustomer == newRecord.idCustomer
                            && x.idDisk == newRecord.idDisk);
                        if (check == null)
                        {
                            recordBLL.addRecord(newRecord);
                        }
                        else
                        {
                            check.isPaid = !check.isPaid;
                            check.rentDate = DateTime.Now;
                            check.dueDate = DateTime.Now.AddDays(category.rentalPeriod);
                            recordBLL.updateRentDate(check);
                        }
                    }
                }
                if (lateFeeList.Count > 0)
                {
                    foreach (var item in lateFeeList)
                    {
                        recordBLL.UpdateIsPaid(item);
                    }
                }

                txt_CustomerName.Text = "";
                lb_TotalCharge.Text = "0";
                btn_rentDisk.Enabled = false;
                MessageBox.Show("Thanh toán thành công");*/
            }
        }
    }
