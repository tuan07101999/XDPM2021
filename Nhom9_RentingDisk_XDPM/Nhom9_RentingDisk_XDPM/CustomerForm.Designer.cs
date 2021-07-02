namespace Nhom9_RentingDisk_XDPM
{
    partial class CustomerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_customerInfo = new System.Windows.Forms.Panel();
            this.dataGridView_customer = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txt_searchItem = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Back = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_dateBirth = new System.Windows.Forms.DateTimePicker();
            this.txt_email = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_addressName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_numberPhone = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_customerName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_updateCustomer = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_deleteCustomer = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_addCustomer = new Bunifu.Framework.UI.BunifuTileButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnl_customerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_customerInfo
            // 
            this.pnl_customerInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_customerInfo.Controls.Add(this.dataGridView_customer);
            this.pnl_customerInfo.Controls.Add(this.txt_searchItem);
            this.pnl_customerInfo.Controls.Add(this.pictureBox1);
            this.pnl_customerInfo.Controls.Add(this.btn_Back);
            this.pnl_customerInfo.Location = new System.Drawing.Point(0, 0);
            this.pnl_customerInfo.Name = "pnl_customerInfo";
            this.pnl_customerInfo.Size = new System.Drawing.Size(615, 660);
            this.pnl_customerInfo.TabIndex = 0;
            // 
            // dataGridView_customer
            // 
            this.dataGridView_customer.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView_customer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_customer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_customer.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView_customer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_customer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(173)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_customer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_customer.DoubleBuffered = true;
            this.dataGridView_customer.EnableHeadersVisualStyles = false;
            this.dataGridView_customer.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(173)))), ((int)(((byte)(196)))));
            this.dataGridView_customer.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridView_customer.Location = new System.Drawing.Point(13, 40);
            this.dataGridView_customer.Name = "dataGridView_customer";
            this.dataGridView_customer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_customer.Size = new System.Drawing.Size(594, 579);
            this.dataGridView_customer.TabIndex = 26;
            this.dataGridView_customer.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView_customer_RowStateChanged);
            // 
            // txt_searchItem
            // 
            this.txt_searchItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_searchItem.Depth = 0;
            this.txt_searchItem.Hint = "Tìm kiếm mã khách hàng";
            this.txt_searchItem.Location = new System.Drawing.Point(36, 12);
            this.txt_searchItem.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_searchItem.Name = "txt_searchItem";
            this.txt_searchItem.PasswordChar = '\0';
            this.txt_searchItem.SelectedText = "";
            this.txt_searchItem.SelectionLength = 0;
            this.txt_searchItem.SelectionStart = 0;
            this.txt_searchItem.Size = new System.Drawing.Size(571, 23);
            this.txt_searchItem.TabIndex = 25;
            this.txt_searchItem.UseSystemPasswordChar = false;
            this.txt_searchItem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_searchItem_KeyUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Nhom9_RentingDisk_XDPM.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(9, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Back
            // 
            this.btn_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Back.Image = global::Nhom9_RentingDisk_XDPM.Properties.Resources.double_left_26px;
            this.btn_Back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Back.Location = new System.Drawing.Point(0, 625);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(150, 32);
            this.btn_Back.TabIndex = 5;
            this.btn_Back.Text = "          Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_dateBirth);
            this.panel2.Controls.Add(this.txt_email);
            this.panel2.Controls.Add(this.txt_addressName);
            this.panel2.Controls.Add(this.txt_numberPhone);
            this.panel2.Controls.Add(this.txt_customerName);
            this.panel2.Controls.Add(this.btn_updateCustomer);
            this.panel2.Controls.Add(this.btn_deleteCustomer);
            this.panel2.Controls.Add(this.btn_addCustomer);
            this.panel2.Controls.Add(this.materialLabel2);
            this.panel2.Controls.Add(this.materialLabel5);
            this.panel2.Controls.Add(this.materialLabel4);
            this.panel2.Controls.Add(this.materialLabel3);
            this.panel2.Controls.Add(this.materialLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(615, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 660);
            this.panel2.TabIndex = 1;
            // 
            // txt_dateBirth
            // 
            this.txt_dateBirth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_dateBirth.Location = new System.Drawing.Point(12, 234);
            this.txt_dateBirth.Name = "txt_dateBirth";
            this.txt_dateBirth.Size = new System.Drawing.Size(236, 20);
            this.txt_dateBirth.TabIndex = 29;
            // 
            // txt_email
            // 
            this.txt_email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_email.Depth = 0;
            this.txt_email.Hint = "VD : NgAn4679@gmail.com";
            this.txt_email.Location = new System.Drawing.Point(12, 186);
            this.txt_email.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.SelectedText = "";
            this.txt_email.SelectionLength = 0;
            this.txt_email.SelectionStart = 0;
            this.txt_email.Size = new System.Drawing.Size(236, 23);
            this.txt_email.TabIndex = 28;
            this.txt_email.UseSystemPasswordChar = false;
            // 
            // txt_addressName
            // 
            this.txt_addressName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_addressName.Depth = 0;
            this.txt_addressName.Hint = "VD: 12 Nguyễn Văn Bảo , Quận gò vấp";
            this.txt_addressName.Location = new System.Drawing.Point(12, 138);
            this.txt_addressName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_addressName.Name = "txt_addressName";
            this.txt_addressName.PasswordChar = '\0';
            this.txt_addressName.SelectedText = "";
            this.txt_addressName.SelectionLength = 0;
            this.txt_addressName.SelectionStart = 0;
            this.txt_addressName.Size = new System.Drawing.Size(236, 23);
            this.txt_addressName.TabIndex = 28;
            this.txt_addressName.UseSystemPasswordChar = false;
            // 
            // txt_numberPhone
            // 
            this.txt_numberPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_numberPhone.Depth = 0;
            this.txt_numberPhone.Hint = "VD : 0946841267";
            this.txt_numberPhone.Location = new System.Drawing.Point(12, 90);
            this.txt_numberPhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_numberPhone.Name = "txt_numberPhone";
            this.txt_numberPhone.PasswordChar = '\0';
            this.txt_numberPhone.SelectedText = "";
            this.txt_numberPhone.SelectionLength = 0;
            this.txt_numberPhone.SelectionStart = 0;
            this.txt_numberPhone.Size = new System.Drawing.Size(236, 23);
            this.txt_numberPhone.TabIndex = 28;
            this.txt_numberPhone.UseSystemPasswordChar = false;
            // 
            // txt_customerName
            // 
            this.txt_customerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_customerName.Depth = 0;
            this.txt_customerName.Hint = "VD: Nguyễn Văn An";
            this.txt_customerName.Location = new System.Drawing.Point(12, 42);
            this.txt_customerName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_customerName.Name = "txt_customerName";
            this.txt_customerName.PasswordChar = '\0';
            this.txt_customerName.SelectedText = "";
            this.txt_customerName.SelectionLength = 0;
            this.txt_customerName.SelectionStart = 0;
            this.txt_customerName.Size = new System.Drawing.Size(236, 23);
            this.txt_customerName.TabIndex = 28;
            this.txt_customerName.UseSystemPasswordChar = false;
            // 
            // btn_updateCustomer
            // 
            this.btn_updateCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_updateCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(173)))), ((int)(((byte)(196)))));
            this.btn_updateCustomer.color = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(173)))), ((int)(((byte)(196)))));
            this.btn_updateCustomer.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(135)))), ((int)(((byte)(205)))));
            this.btn_updateCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_updateCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateCustomer.ForeColor = System.Drawing.Color.White;
            this.btn_updateCustomer.Image = null;
            this.btn_updateCustomer.ImagePosition = 17;
            this.btn_updateCustomer.ImageZoom = 50;
            this.btn_updateCustomer.LabelPosition = 30;
            this.btn_updateCustomer.LabelText = "Sửa";
            this.btn_updateCustomer.Location = new System.Drawing.Point(12, 501);
            this.btn_updateCustomer.Margin = new System.Windows.Forms.Padding(5);
            this.btn_updateCustomer.Name = "btn_updateCustomer";
            this.btn_updateCustomer.Size = new System.Drawing.Size(237, 40);
            this.btn_updateCustomer.TabIndex = 21;
            this.btn_updateCustomer.Click += new System.EventHandler(this.btn_updateCustomer_Click);
            // 
            // btn_deleteCustomer
            // 
            this.btn_deleteCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_deleteCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(173)))), ((int)(((byte)(196)))));
            this.btn_deleteCustomer.color = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(173)))), ((int)(((byte)(196)))));
            this.btn_deleteCustomer.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(135)))), ((int)(((byte)(205)))));
            this.btn_deleteCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deleteCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteCustomer.ForeColor = System.Drawing.Color.White;
            this.btn_deleteCustomer.Image = null;
            this.btn_deleteCustomer.ImagePosition = 17;
            this.btn_deleteCustomer.ImageZoom = 50;
            this.btn_deleteCustomer.LabelPosition = 30;
            this.btn_deleteCustomer.LabelText = "Xóa";
            this.btn_deleteCustomer.Location = new System.Drawing.Point(12, 551);
            this.btn_deleteCustomer.Margin = new System.Windows.Forms.Padding(5);
            this.btn_deleteCustomer.Name = "btn_deleteCustomer";
            this.btn_deleteCustomer.Size = new System.Drawing.Size(237, 40);
            this.btn_deleteCustomer.TabIndex = 21;
            this.btn_deleteCustomer.Click += new System.EventHandler(this.btn_deleteCustomer_Click);
            // 
            // btn_addCustomer
            // 
            this.btn_addCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(173)))), ((int)(((byte)(196)))));
            this.btn_addCustomer.color = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(173)))), ((int)(((byte)(196)))));
            this.btn_addCustomer.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(135)))), ((int)(((byte)(205)))));
            this.btn_addCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addCustomer.ForeColor = System.Drawing.Color.White;
            this.btn_addCustomer.Image = null;
            this.btn_addCustomer.ImagePosition = 17;
            this.btn_addCustomer.ImageZoom = 50;
            this.btn_addCustomer.LabelPosition = 30;
            this.btn_addCustomer.LabelText = "Thêm";
            this.btn_addCustomer.Location = new System.Drawing.Point(12, 606);
            this.btn_addCustomer.Margin = new System.Windows.Forms.Padding(5);
            this.btn_addCustomer.Name = "btn_addCustomer";
            this.btn_addCustomer.Size = new System.Drawing.Size(237, 40);
            this.btn_addCustomer.TabIndex = 21;
            this.btn_addCustomer.Click += new System.EventHandler(this.btn_addCustomer_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(6, 68);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(98, 19);
            this.materialLabel2.TabIndex = 16;
            this.materialLabel2.Text = "Số điện thoại";
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(8, 212);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(75, 19);
            this.materialLabel5.TabIndex = 15;
            this.materialLabel5.Text = "Ngày sinh";
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(8, 164);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(47, 19);
            this.materialLabel4.TabIndex = 15;
            this.materialLabel4.Text = "Email";
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(8, 116);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(55, 19);
            this.materialLabel3.TabIndex = 15;
            this.materialLabel3.Text = "Địa chỉ";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(8, 20);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(54, 19);
            this.materialLabel1.TabIndex = 17;
            this.materialLabel1.Text = "Họ tên";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(613, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 660);
            this.panel4.TabIndex = 24;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(875, 660);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_customerInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_customerInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_customerInfo;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Bunifu.Framework.UI.BunifuTileButton btn_updateCustomer;
        private Bunifu.Framework.UI.BunifuTileButton btn_deleteCustomer;
        private Bunifu.Framework.UI.BunifuTileButton btn_addCustomer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridView_customer;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_searchItem;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_customerName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_email;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_addressName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_numberPhone;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.DateTimePicker txt_dateBirth;
    }
}