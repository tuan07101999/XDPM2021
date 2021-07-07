using Business;
using DataAccess.DTO;
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

namespace Nhom18_XDPM
{
    public partial class ReservationForm : Form
    {
        BindingSource bindingSource;
        CustomerBLL customerBLL;
        TitleBLL titleBLL;
        DiskBLL diskBLL;
        RecordBLL recordBLL;
        HoldingBLL holdingBLL;
        AutoCompleteStringCollection autoText;
        AutoCompleteStringCollection autoText2;

        public ReservationForm()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            customerBLL = new CustomerBLL();
            diskBLL = new DiskBLL();
            recordBLL = new RecordBLL();
            titleBLL = new TitleBLL();
            holdingBLL = new HoldingBLL();
            //Load Dữ liệu lên DGV
            CreateDataGridView();
            // AutoComplete
            autoText = new AutoCompleteStringCollection();
            autoText2 = new AutoCompleteStringCollection();

            // tạo mới btn trên DGV
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dgv_Reservation.Columns.Add(btn);
            btn.HeaderText = "Hủy Đặt";
            btn.Name = "btn_Detele";
            btn.Text = "Hủy";
            btn.UseColumnTextForButtonValue = true;
            // tạo mới btn trên DGV
            DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
            dgv_Reservation.Columns.Add(btn2);
            btn2.HeaderText = "Xác nhận thuê";
            btn2.Text = "Thuê Đĩa";
            btn2.Name = "btn_Comfirm";
            btn2.UseColumnTextForButtonValue = true;

        }
        private void CreateDataGridView()
        {
            bindingSource.DataSource = holdingBLL.GetAllHoding().Reverse<Holding>();
            dgv_Reservation.DataSource = bindingSource;

            dgv_Reservation.MultiSelect = false;
            dgv_Reservation.ReadOnly = true;
            dgv_Reservation.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dataGridView_customer.Columns["idCustomer"].Visible = false;
            ////dataGridView_customer.Columns["Orders"].Visible = false;
            dgv_Reservation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Reservation.ClearSelection();
            dgv_Reservation.Rows[0].Selected = false;
            
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_searchItem_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_searchItem.Text != "")
            {
                if (!(int.TryParse(txt_searchItem.Text, out int i) && holdingBLL.getListReservationByCustomerID(Convert.ToInt32(txt_searchItem.Text)) != null))
                {
                    return;
                }
                int txt = Convert.ToInt32(txt_searchItem.Text.ToString().Trim());
                CreateDataGridView();
                bindingSource.DataSource = holdingBLL.getListReservationByCustomerID(txt);
            }
            else
            {
                return;
            }
        }

        

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            foreach (var item in customerBLL.GetAllCustomer())
            {
                autoText.Add(item.idCustomer.ToString());
            }
            txt_customerID.AutoCompleteCustomSource = autoText;

            foreach (var item in titleBLL.GetAlltt())
            {
                autoText2.Add(item.idTitle.ToString());
            }
            txt_titleID.AutoCompleteCustomSource = autoText2;
        }

        private void txt_customerID_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                
                if (!(int.TryParse(txt_customerID.Text, out int i) && customerBLL.searchCustomerbyId(Convert.ToInt32(txt_customerID.Text)) != null))
                {
                    return;
                }
                txt_customerName.Text = customerBLL.searchCustomerbyId(Convert.ToInt32(txt_customerID.Text)).name;
                txt_numberPhone.Text = customerBLL.searchCustomerbyId(Convert.ToInt32(txt_customerID.Text)).phoneNumber;
            }
        }

        private void txt_titleID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(titleBLL.GetItemTitleById(txt_titleID.Text) == null)
                {
                    return;
                }    
                txt_titleName.Text = titleBLL.GetItemTitleById(txt_titleID.Text.Trim()).name;
            }
        }

        private void btn_DatHang_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Xác nhận đặt đĩa này.\nXác Nhận ?", "Không", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                Holding cus = new Holding()
                {
                    idCustomer = Convert.ToInt32(txt_customerID.Text),
                    idTitle = txt_titleID.Text,
                    reservationTime = DateTime.Now
                };
                Result result = null;
                var taskCreate = Task.Factory.StartNew(() => result = holdingBLL.add(cus));
                taskCreate.Wait();

                if (result.isSuccess)
                {
                    MessageBox.Show(result.message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    bindingSource.DataSource = holdingBLL.GetAllHoding().Reverse<Holding>();
                    dgv_Reservation.DataSource = bindingSource;
                }
                else
                {
                    MessageBox.Show(result.message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

            }
            else
            {
                return;
            }
        }

        private void dgv_Reservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // thay đôi cột phải sửa
            if(e.ColumnIndex == 0)
            {
                DialogResult dr = MessageBox.Show("Bạn muốn HỦY đơn đặt hàng này .\nXác Nhận Hủy ?", "Hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                var csID = dgv_Reservation.Rows[e.RowIndex].Cells["idHolding"].Value.ToString().Trim();
                if (dr == DialogResult.Yes && csID != null)
                {
                    dgv_Reservation.Rows.RemoveAt(dgv_Reservation.Rows[e.RowIndex].Index);
                    holdingBLL.delete(Convert.ToInt32(csID));
                }
                else
                {
                    return;
                }
            }
            else if (e.ColumnIndex == 1)
            {
                DialogResult dr = MessageBox.Show("Xác nhận thuê đĩa này ?", "Thuê đĩa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                var csID = dgv_Reservation.Rows[e.RowIndex].Cells["idHolding"].Value.ToString().Trim();
                var titleID = dgv_Reservation.Rows[e.RowIndex].Cells["idTitle"].Value.ToString().Trim();

                if(titleID == null)
                {
                    MessageBox.Show("title NULL");
                    return;
                }    
                if(diskBLL.GetONEDiskByIDtitle(titleID) == null)
                {
                    MessageBox.Show("Không có đĩa thuộc tiêu đề này");
                    return;
                }    
                var diskID = diskBLL.GetONEDiskByIDtitle(titleID).idDisk;
                var cusID = dgv_Reservation.Rows[e.RowIndex].Cells["idCustomer"].Value.ToString().Trim();
                if (dr == DialogResult.Yes && csID != null  && diskID != null && cusID != null)
                {
                    Record record = new Record()
                    {
                        idDisk = diskID,
                        idCustomer = Convert.ToInt32(cusID),
                        isPaid = false
                    };
                    Result result = null;
                    var taskCreate = Task.Factory.StartNew(() => result = recordBLL.add(record));
                    taskCreate.Wait();
                    dgv_Reservation.Rows.RemoveAt(dgv_Reservation.Rows[e.RowIndex].Index);
                    holdingBLL.delete(Convert.ToInt32(csID));
                    if (result.isSuccess)
                    {
                        MessageBox.Show(result.message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show(result.message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                else
                {
                    return;
                }
            }
        }
    }
}
