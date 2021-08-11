using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Business;
using DataAccess.Entities;
using DataAccess.Entities.Enum;
using System.Windows.Forms;
using DataAccess.DTO;

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
         private float totalPhiTre = 0;
        private List<Record> lateFeeList;
        private List<Record> pendingRecords;
        public List<RecordDTO> listRecord;
        AutoCompleteStringCollection sourcename, sourceNameCustomer;
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

            sourcename = new AutoCompleteStringCollection();
            txtIdDia.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtIdDia.AutoCompleteSource = AutoCompleteSource.CustomSource;

            sourceNameCustomer = new AutoCompleteStringCollection();
            txtIDKhachHang.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtIDKhachHang.AutoCompleteSource = AutoCompleteSource.CustomSource;
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
            dgvListItem.Columns["Status"].Visible = false;

            dgvListItem.Columns["idDisk"].Width = 100;
            dgvListItem.Columns["name"].Width = 300;
        }

        private void UC_RentDisk_Load(object sender, EventArgs e)
        {
            var id = disks.Select(d => { return d.idDisk; });
            sourcename.AddRange(id.ToArray());
            txtIdDia.AutoCompleteCustomSource = sourcename;

            
            foreach (var item in customerBLL.GetAllCustomer())
            {
                sourceNameCustomer.Add(item.idCustomer.ToString());
            }
            txtIDKhachHang.AutoCompleteCustomSource = sourceNameCustomer;

            DataBindings.Clear();
            if (rentingList.Count > 0)
            {
                CreateDataGridView(""); 
            }
            CreateButtonDataGridView();

            txtTongTien.Text = totalCharge.ToString();
            txtPhiTre.Text = totalPhiTre.ToString();
            txtTongPhiThue.Text = totalPhiThue.ToString();
            txtNgayThue.Text = DateTime.Now.Date.ToString("dd-MM-yyyy");

            txtTenDia.Enabled = false;
            txtTenKH.Enabled = false;
            txtSDT.Enabled = false;

            txtNgayThue.Enabled = false;
            txtPhiTre.Enabled = false;
            txtTongPhiThue.Enabled = false;
            txtTongTien.Enabled = false;

            btnThue.Enabled = false;
            btnThongTinPhiTre.Enabled = false;
        }
        private void ClearTextBox()
        {
            txtIdDia.Text = String.Empty;
            txtTenDia.Text = String.Empty;
        }

        private void btnThemDia_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtIdDia.Text))
            {
                MessageBox.Show("Chưa nhập ID đĩa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!sourcename.Contains(txtIdDia.Text))
            {
                MessageBox.Show("Đĩa không tồn tại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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

            sourcename.Remove(txtIdDia.Text);
            ClearTextBox();
        }
        private void btnThongTinPhiTre_Click(object sender, EventArgs e)
        {
           
            if (String.IsNullOrWhiteSpace(txtIDKhachHang.Text))
            {
                MessageBox.Show("Chưa nhập ID khách hàng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (!Parent.Controls.Contains(UC_CheckLateCharge.Instance))
                {
                    Parent.Controls.Add(UC_CheckLateCharge.Instance);
                    UC_CheckLateCharge.Instance.Dock = DockStyle.Fill;
                    UC_CheckLateCharge.Instance.BringToFront();
                }
                else
                    UC_CheckLateCharge.Instance.BringToFront();
                UC_CheckLateCharge.Instance.GetIdCustomerFromRentDisk(Int32.Parse(txtIDKhachHang.Text));
            }
            
        }
        public void listLateFeeIsPaid(List<RecordDTO> list, float totalLateFee)
        {
            listRecord = list;
            foreach (var item in lateFeeList)
            {
                foreach (var item2 in listRecord)
                {
                    if (item.idRecord == item2.idRecord)
                        item.isPaid = item2.isPaid;
                }
            }
            totalPhiTre = totalLateFee;
            txtPhiTre.Text = totalPhiTre.ToString();

            totalCharge += totalPhiTre;
            txtTongTien.Text = totalCharge.ToString();
        }

        private void btnThue_Click(object sender, EventArgs e)
        {
            if(totalCharge > 0)
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
                                dgvListItem.Rows.Clear();
                                dgvListItem.Refresh();
                            }
                            else
                            {
                                check.isPaid = !check.isPaid;
                                check.rentDate = DateTime.Now;
                                check.dueDate = DateTime.Now.AddDays(category.rentalPeriod);
                                recordBLL.updateRentDate(check);
                                dgvListItem.Rows.Clear();
                                dgvListItem.Refresh();
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
                    txtPhiTre.Text = "0";

                    totalPhiThue = 0;
                    totalPhiTre = 0;
                    totalCharge = 0;
                    rentingList.Clear();
                    btnThue.Enabled = false;
                    MessageBox.Show("Thanh toán thành công");
                }
            }  else
            {
                MessageBox.Show("Tổng tiền: 0 !!!");
                return;
            }                
            
        }

        private void dgvListItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            {
                DataGridViewRow row = dgvListItem.Rows[e.RowIndex];
            }

            if (e.ColumnIndex == 0)
            {
                var idDisk = dgvListItem.Rows[e.RowIndex].Cells["idDisk"].Value.ToString();
                var idTitle = dgvListItem.Rows[e.RowIndex].Cells["idTitle"].Value.ToString();
                var disk = rentingList.FirstOrDefault(x => x.idDisk == idDisk);

                rentingList.Remove(disk);
                disk.status = Status.OnShelf;
                disks.Add(disk);
                sourcename.Add(txtIdDia.Text);
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
            else return;
           
        }

        private void txtIDKhachHang_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (!(int.TryParse(txtIDKhachHang.Text, out int i) && customerBLL.searchCustomerbyId(Convert.ToInt32(txtIDKhachHang.Text)) != null))
                {
                    MessageBox.Show("Không tìm thấy khách hàng");
                    return;
                }
                txtTenKH.Text = customerBLL.searchCustomerbyId(Convert.ToInt32(txtIDKhachHang.Text)).name;
                txtSDT.Text = customerBLL.searchCustomerbyId(Convert.ToInt32(txtIDKhachHang.Text)).phoneNumber;

                string txt = txtIDKhachHang.Text.ToString().Trim();
                if (customer == null)
                {
                    customer = new Customer();
                    customer = customerBLL.searchCustomerbyId(Int32.Parse(txt));
                }
                if (customer != null)
                {
                    lateFeeList = recordBLL.checkLateFee(Int32.Parse(txt));
                    pendingRecords = recordBLL.getPendingDiskByIDCustomer(Int32.Parse(txt));
                    if (pendingRecords != null && pendingRecords.Count > 0)
                    {
                        foreach (var item in pendingRecords)
                        {
                            var disk = diskBLL.getDiskByID(item.idDisk);
                            var idCategory = titleBLL.getIdCategoryByIdTitle(disk.idTitle);
                            totalCharge += categoryBLL.getRentalChargeById(idCategory);
                            rentingList.Add(disk);
                        }
                        btnThue.Enabled = true;
                    }
                    if (lateFeeList.Count > 0)
                    {
                        btnThue.Enabled = true;
                        MessageBox.Show("Khách hàng có phí trễ !");
                    }
                }
            }
            btnThue.Enabled = true;
            btnThongTinPhiTre.Enabled = true;
        }

        private void txtIDKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Chỉ nhập số!", "Nhập sai", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txtIdDia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (String.IsNullOrWhiteSpace(txtIdDia.Text))
                {
                    MessageBox.Show("Chưa nhập ID đĩa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (diskBLL.getDiskByID(txtIdDia.Text) == null)
                {
                    MessageBox.Show("Đĩa không tồn tại !");
                    txtTenDia.Text = "";
                    return;
                }
                txtTenDia.Text = diskBLL.getDiskByID(txtIdDia.Text).name;
            }
        }

        private void txtIdDia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Chỉ nhập số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }

        }
    }
}
