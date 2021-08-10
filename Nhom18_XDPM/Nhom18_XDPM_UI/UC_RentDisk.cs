using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Business;
using DataAccess.Entities;
using DataAccess.Entities.Enum;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Nhom18_XDPM_UI
{
    public partial class UC_RentDisk : UserControl
    {
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
        private List<Record> lateFeeList;
        private UC_CheckLateCharge form;
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


        public void CreateButtonDataGridView()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "";
            btn.Name = "btnXoa";
            btn.Text = "Xóa";
            btn.UseColumnTextForButtonValue = true;
            dgvListItem.Columns.Add(btn);
        }

        public void CreateDataGridView(string key)
        {
            var check = rentingList.Where(x => x.name.Contains(key));
            if (check.Count() != 0)
            {
                bindingSource.DataSource = check;
            }
            dgvListItem.ClearSelection();
            dgvListItem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListItem.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListItem.DataSource = bindingSource;
            dgvListItem.MultiSelect = false;
            dgvListItem.ReadOnly = true;
            dgvListItem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvListItem.Columns["Title"].Visible = false;
            dgvListItem.Columns["Records"].Visible = false;

            dgvListItem.Columns["idDisk"].Width = 100;
            dgvListItem.Columns["name"].Width = 300;
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
            var name = disks.Select(d => { return d.name; });
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
                    btnThue.Enabled = true;
                    MessageBox.Show("Khách hàng có phí trễ, có muốn thanh toán không?");
                }
            }
            else
            {
               btnThue.Enabled = false;
                MessageBox.Show("Không tìm thấy khách hàng");
            }
        }
        private void UC_RentDisk_Load(object sender, EventArgs e)
        {
            AutoComplete();

            DataBindings.Clear();
            if (rentingList.Count > 0)
            {
                CreateDataGridView(""); 
            }
            CreateButtonDataGridView();

            txtTongTien.Text = totalCharge.ToString();
            txtTongPhiThue.Text = totalPhiThue.ToString();
            txtNgayThue.Text = DateTime.Now.Date.ToString("dd-MM-yyyy");
            txtIdDia.ReadOnly = true;

            btnThue.Enabled = false;
        }
        private void ClearTextBox()
        {
            txtIdDia.Text = String.Empty;
            txtTenDia.Text = String.Empty;
        }

        private void btnThemDia_Click(object sender, EventArgs e)
        {
            var idDisk = txtIdDia.Text;
            var disk = disks.FirstOrDefault(x => x.idDisk == idDisk);
            disk.status = Status.Rented;
            var id = from d in disks where (d.idDisk == idDisk) select d.idTitle;
            var idTitle = "";
            foreach (var item in id)
            {
                idTitle = item.ToString();
            }
            var idCategory = titleBLL.getIdCategoryByIdTitle(idTitle);
            totalPhiThue += categoryBLL.getRentalChargeById(idCategory);
            totalCharge += categoryBLL.getRentalChargeById(idCategory);
            txtTongPhiThue.Text = totalPhiThue.ToString();
            txtTongTien.Text = totalCharge.ToString();

            rentingList.Add(disk);
            disks.Remove(disk);

            CreateDataGridView("");
            if (totalCharge > 0 && !String.IsNullOrEmpty(txtTenKH.Text))
            {
                btnThue.Enabled = true;
            }
            else
            {
                btnThue.Enabled = false;
            }

            var idDia = txtIdDia.Text;
            ClearTextBox();
        }


        private void btnTimDia_Click(object sender, EventArgs e)
        {
            var idDisk = from disk in disks where (disk.name == txtTenDia.Text) select disk.idDisk;
            foreach (var item in idDisk)
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

            //if (form == null)
            //{
            //    form = new UC_CheckLateCharge(customer.idCustomer);
            //}

            //for (int i = 0; i < form.listRecord.Count; i++)
            //{
            //    if (lateFeeList[i].isPaid != form.listRecord[i].isPaid)
            //    {
            //        if (form.listRecord[i].isPaid)
            //        {
            //            totalCharge += (float)form.listRecord[i].lateFee;
            //        }
            //        else
            //        {
            //            totalCharge -= (float)form.listRecord[i].lateFee;
            //        }
            //        lateFeeList[i].isPaid = !lateFeeList[i].isPaid;
            //    }
            //}
            //lateFeeList = form.listRecord;
            //txtTongTien.Text = totalCharge.ToString();
            //CreateDataGridView("");
        }

        private void btnThue_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Xác nhận thanh toán", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                            idCustomer = Int32.Parse(txtIDKhachHang.Text),
                            idDisk = item.idDisk,
                            isPaid = true,
                            rentDate = DateTime.Now,
                            dueDate = DateTime.Now.AddDays(category.rentalPeriod),
                            lateFee = 0
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

                txtTenKH.Text = "";
                txtIDKhachHang.Text = "";
                txtSDT.Text = "";
                txtTongPhiThue.Text = "0";
                txtTongTien.Text = "0";
                btnThue.Enabled = false;
                dgvListItem.Rows.Clear();
                dgvListItem.Refresh();
                MessageBox.Show("Thanh toán thành công");
            }
        }

        private void dgvListItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var idDisk = dgvListItem.Rows[e.RowIndex].Cells["idDisk"].Value.ToString();
            var idTitle = dgvListItem.Rows[e.RowIndex].Cells["idTitle"].Value.ToString();
            var disk = rentingList.FirstOrDefault(x => x.idDisk == idDisk);

            rentingList.Remove(disk);
            disk.status = Status.OnShelf;
            disks.Add(disk);
            var idCategory = titleBLL.getIdCategoryByIdTitle(disk.idTitle);
            totalPhiThue -= categoryBLL.getRentalChargeById(idCategory);
            totalCharge -= categoryBLL.getRentalChargeById(idCategory);
            txtTongPhiThue.Text = totalPhiThue.ToString();
            txtTongTien.Text = totalCharge.ToString();

            if (dgvListItem.Rows.Count == 1)
            {
                dgvListItem.DataSource = new List<Disk>();
            }
            else
            {
                CreateDataGridView("");
            }
        }
    }
}
