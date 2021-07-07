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

namespace Nhom18_XDPM
{
    public partial class RentingForm : Form
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
        private List<Record> lateFeeList;
        private CheckLateFeeForm form;
        private List<Record> pendingRecords;

        public RentingForm()
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

        public void CreateButtonDataGridView()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "";
            btn.Name = "btnThue";
            btn.Text = "Thuê";
            btn.UseColumnTextForButtonValue = true;
            dgv_Disk.Columns.Add(btn);
        }

        public void CreateDataGridView(string key)
        {
            var check = disks.Where(x => x.name.Contains(key));
            if (check.Count() != 0)
            {
                bindingSource.DataSource = check;
            }

            dgv_Disk.ClearSelection();
            dgv_Disk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Disk.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_Disk.DataSource = bindingSource;
            dgv_Disk.MultiSelect = false;
            dgv_Disk.ReadOnly = true;
            dgv_Disk.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Disk.Rows[0].Selected = false;
            dgv_Disk.Columns["Title"].Visible = false;
            dgv_Disk.Columns["Records"].Visible = false;

            dgv_Disk.Columns["idDisk"].Width = 100;
            dgv_Disk.Columns["name"].Width = 300;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {

        }

        private void txt_numberPhone_Click(object sender, EventArgs e)
        {
            pnl_numberPhone.BackColor = Color.FromArgb(20, 173, 196);
        }

        private void txt_nameCustomer_Click(object sender, EventArgs e)
        {
            pnl_nameCustomer.BackColor = Color.FromArgb(20, 173, 196);

        }

        private void RentingForm_Load(object sender, EventArgs e)
        {
            DataBindings.Clear();
            CreateDataGridView("");
            CreateButtonDataGridView();
            btn_rentDisk.Enabled = false;
        }

        private void dgv_Disk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var idDisk = dgv_Disk.Rows[e.RowIndex].Cells["idDisk"].Value.ToString();
            var idTitle = dgv_Disk.Rows[e.RowIndex].Cells["idTitle"].Value.ToString();
            var disk = disks.FirstOrDefault(x => x.idDisk == idDisk);
            disk.status = Status.Rented;
            var idCategory = titleBLL.getIdCategoryByIdTitle(idTitle);
            totalCharge += categoryBLL.getRentalChargeById(idCategory);
            lb_TotalCharge.Text = totalCharge.ToString();

            rentingList.Add(disk);
            disks.Remove(disk);

            CreateDataGridView("");
            if(totalCharge > 0 && !String.IsNullOrEmpty(txt_CustomerName.Text))
            {
                btn_rentDisk.Enabled = true;
            }
            else
            {
                btn_rentDisk.Enabled = false;
            }
        }

        private void btnSearchCustomer_Click_1(object sender, EventArgs e)
        {
            string txt = txt_CustomerID.Text.ToString().Trim();
            if(customer == null)
            {
                customer = new Customer();
                customer = customerBLL.searchCustomerbyId(Int32.Parse(txt));
            }
            if (customer != null)
            {
                txt_CustomerName.Text = customer.name;
                lateFeeList = recordBLL.checkLateFee(Int32.Parse(txt));
                pendingRecords = recordBLL.getPendingDiskByIDCustomer(Int32.Parse(txt));
                if(pendingRecords != null && pendingRecords.Count > 0)
                {
                    foreach (var item in pendingRecords)
                    {
                        var disk = diskBLL.getDiskByID(item.idDisk);
                        var idCategory = titleBLL.getIdCategoryByIdTitle(disk.idTitle);
                        totalCharge += categoryBLL.getRentalChargeById(idCategory);
                        rentingList.Add(disk);
                    }
                    btn_rentDisk.Enabled = true;
                }
                if (lateFeeList.Count > 0)
                {
                    foreach (var item in lateFeeList)
                    {
                        totalCharge += (float)item.lateFee;
                        item.isPaid = !item.isPaid;
                    }
                    btn_rentDisk.Enabled = true;
                    MessageBox.Show("Khách hàng có phí trễ, có muốn thanh toán không?");
                }
            }
            else
            {
                btn_rentDisk.Enabled = false;
                MessageBox.Show("Không tìm thấy khách hàng");
            }
            lb_TotalCharge.Text = totalCharge.ToString();
        }

        private void btn_IMG_menu_PhiMoi_Click_1(object sender, EventArgs e)
        {
            CheckTotalChargeForm form = new CheckTotalChargeForm(rentingList);
            form.ShowDialog();
            var listRemove = form.listRemove;
            if (listRemove != null)
            {
                foreach (var item in listRemove)
                {
                    if (item != null)
                    {
                        item.status = Status.OnShelf;
                        disks.Add(item);
                        var idCategory = titleBLL.getIdCategoryByIdTitle(item.idTitle);
                        totalCharge -= categoryBLL.getRentalChargeById(idCategory);
                        lb_TotalCharge.Text = totalCharge.ToString();
                    }
                }
                CreateDataGridView("");
            }
        }

        private void btn_IMG_menu_PhiTre_Click_1(object sender, EventArgs e)
        {
            if(form == null)
            {
                form = new CheckLateFeeForm(customer.idCustomer);
            }
            form.ShowDialog();

            for (int i = 0; i < form.listRecord.Count; i++)
            {
                if (lateFeeList[i].isPaid != form.listRecord[i].isPaid)
                {
                    if (form.listRecord[i].isPaid)
                    {
                        totalCharge += (float)form.listRecord[i].lateFee;
                    }
                    else
                    {
                        totalCharge -= (float)form.listRecord[i].lateFee;
                    }
                    lateFeeList[i].isPaid = !lateFeeList[i].isPaid;
                }
            }
            //lateFeeList = form.listRecord;
            lb_TotalCharge.Text = totalCharge.ToString();
            CreateDataGridView("");
        }

        private void txt_searchDisk_TextChanged_1(object sender, EventArgs e)
        {
            string txt = txt_searchDisk.Text.ToString().Trim();
            CreateDataGridView(txt);
        }

        private void btn_rentDisk_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Xác nhận thanh toán", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                if(rentingList.Count > 0)
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
                            idCustomer = Int32.Parse(txt_CustomerID.Text),
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
                if(lateFeeList.Count > 0)
                {
                    foreach (var item in lateFeeList)
                    {
                        recordBLL.UpdateIsPaid(item);
                    }
                }
                
                txt_CustomerName.Text = "";
                lb_TotalCharge.Text = "0";
                btn_rentDisk.Enabled = false;
                MessageBox.Show("Thanh toán thành công");
            }
        }

        private void txt_CustomerID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btn_IMG_menu_PhiTre_Click(object sender, EventArgs e)
        {

        }
    }
}
