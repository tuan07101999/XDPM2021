namespace Nhom9_RentingDisk_XDPM
{
    partial class RentingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentingForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Back = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pnl_nameCustomer = new System.Windows.Forms.Panel();
            this.pnl_numberPhone = new System.Windows.Forms.Panel();
            this.txt_CustomerName = new System.Windows.Forms.TextBox();
            this.txt_CustomerID = new System.Windows.Forms.TextBox();
            this.btn_IMG_delete_PhiMoi = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_IMG_Delete_PhiTre = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_IMG_menu_PhiMoi = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_IMG_menu_PhiTre = new Bunifu.Framework.UI.BunifuImageButton();
            this.lb_CustomerName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_CustomerID = new System.Windows.Forms.Label();
            this.btn_rentDisk = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_searchDisk = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dgv_Disk = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_IMG_delete_PhiMoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_IMG_Delete_PhiTre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_IMG_menu_PhiMoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_IMG_menu_PhiTre)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Disk)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgv_Disk);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btn_Back);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 450);
            this.panel1.TabIndex = 2;
            // 
            // btn_Back
            // 
            this.btn_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Back.Image = global::Nhom9_RentingDisk_XDPM.Properties.Resources.double_left_26px;
            this.btn_Back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Back.Location = new System.Drawing.Point(3, 415);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(131, 32);
            this.btn_Back.TabIndex = 19;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.pnl_nameCustomer);
            this.panel2.Controls.Add(this.pnl_numberPhone);
            this.panel2.Controls.Add(this.txt_CustomerName);
            this.panel2.Controls.Add(this.txt_CustomerID);
            this.panel2.Controls.Add(this.btn_IMG_delete_PhiMoi);
            this.panel2.Controls.Add(this.btn_IMG_Delete_PhiTre);
            this.panel2.Controls.Add(this.btn_IMG_menu_PhiMoi);
            this.panel2.Controls.Add(this.btn_IMG_menu_PhiTre);
            this.panel2.Controls.Add(this.lb_CustomerName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lb_CustomerID);
            this.panel2.Controls.Add(this.btn_rentDisk);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(538, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 450);
            this.panel2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(204, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "label6";
            // 
            // pnl_nameCustomer
            // 
            this.pnl_nameCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_nameCustomer.BackColor = System.Drawing.Color.DarkGray;
            this.pnl_nameCustomer.Location = new System.Drawing.Point(7, 131);
            this.pnl_nameCustomer.Name = "pnl_nameCustomer";
            this.pnl_nameCustomer.Size = new System.Drawing.Size(247, 1);
            this.pnl_nameCustomer.TabIndex = 15;
            // 
            // pnl_numberPhone
            // 
            this.pnl_numberPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_numberPhone.BackColor = System.Drawing.Color.DarkGray;
            this.pnl_numberPhone.Location = new System.Drawing.Point(7, 60);
            this.pnl_numberPhone.Name = "pnl_numberPhone";
            this.pnl_numberPhone.Size = new System.Drawing.Size(247, 1);
            this.pnl_numberPhone.TabIndex = 15;
            // 
            // txt_CustomerName
            // 
            this.txt_CustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_CustomerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CustomerName.Location = new System.Drawing.Point(7, 110);
            this.txt_CustomerName.Multiline = true;
            this.txt_CustomerName.Name = "txt_CustomerName";
            this.txt_CustomerName.Size = new System.Drawing.Size(247, 22);
            this.txt_CustomerName.TabIndex = 1;
            this.txt_CustomerName.Click += new System.EventHandler(this.txt_nameCustomer_Click);
            // 
            // txt_CustomerID
            // 
            this.txt_CustomerID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_CustomerID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_CustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CustomerID.Location = new System.Drawing.Point(7, 39);
            this.txt_CustomerID.Multiline = true;
            this.txt_CustomerID.Name = "txt_CustomerID";
            this.txt_CustomerID.Size = new System.Drawing.Size(247, 22);
            this.txt_CustomerID.TabIndex = 1;
            this.txt_CustomerID.Click += new System.EventHandler(this.txt_numberPhone_Click);
            // 
            // btn_IMG_delete_PhiMoi
            // 
            this.btn_IMG_delete_PhiMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_IMG_delete_PhiMoi.BackColor = System.Drawing.Color.White;
            this.btn_IMG_delete_PhiMoi.Image = ((System.Drawing.Image)(resources.GetObject("btn_IMG_delete_PhiMoi.Image")));
            this.btn_IMG_delete_PhiMoi.ImageActive = null;
            this.btn_IMG_delete_PhiMoi.Location = new System.Drawing.Point(226, 257);
            this.btn_IMG_delete_PhiMoi.Name = "btn_IMG_delete_PhiMoi";
            this.btn_IMG_delete_PhiMoi.Size = new System.Drawing.Size(30, 30);
            this.btn_IMG_delete_PhiMoi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_IMG_delete_PhiMoi.TabIndex = 12;
            this.btn_IMG_delete_PhiMoi.TabStop = false;
            this.btn_IMG_delete_PhiMoi.Zoom = 10;
            // 
            // btn_IMG_Delete_PhiTre
            // 
            this.btn_IMG_Delete_PhiTre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_IMG_Delete_PhiTre.BackColor = System.Drawing.Color.White;
            this.btn_IMG_Delete_PhiTre.Image = ((System.Drawing.Image)(resources.GetObject("btn_IMG_Delete_PhiTre.Image")));
            this.btn_IMG_Delete_PhiTre.ImageActive = null;
            this.btn_IMG_Delete_PhiTre.Location = new System.Drawing.Point(226, 213);
            this.btn_IMG_Delete_PhiTre.Name = "btn_IMG_Delete_PhiTre";
            this.btn_IMG_Delete_PhiTre.Size = new System.Drawing.Size(30, 30);
            this.btn_IMG_Delete_PhiTre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_IMG_Delete_PhiTre.TabIndex = 12;
            this.btn_IMG_Delete_PhiTre.TabStop = false;
            this.btn_IMG_Delete_PhiTre.Zoom = 10;
            // 
            // btn_IMG_menu_PhiMoi
            // 
            this.btn_IMG_menu_PhiMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_IMG_menu_PhiMoi.BackColor = System.Drawing.Color.White;
            this.btn_IMG_menu_PhiMoi.Image = global::Nhom9_RentingDisk_XDPM.Properties.Resources.list_24px;
            this.btn_IMG_menu_PhiMoi.ImageActive = null;
            this.btn_IMG_menu_PhiMoi.Location = new System.Drawing.Point(190, 257);
            this.btn_IMG_menu_PhiMoi.Name = "btn_IMG_menu_PhiMoi";
            this.btn_IMG_menu_PhiMoi.Size = new System.Drawing.Size(30, 30);
            this.btn_IMG_menu_PhiMoi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_IMG_menu_PhiMoi.TabIndex = 13;
            this.btn_IMG_menu_PhiMoi.TabStop = false;
            this.btn_IMG_menu_PhiMoi.Zoom = 10;
            // 
            // btn_IMG_menu_PhiTre
            // 
            this.btn_IMG_menu_PhiTre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_IMG_menu_PhiTre.BackColor = System.Drawing.Color.White;
            this.btn_IMG_menu_PhiTre.Image = global::Nhom9_RentingDisk_XDPM.Properties.Resources.list_24px;
            this.btn_IMG_menu_PhiTre.ImageActive = null;
            this.btn_IMG_menu_PhiTre.Location = new System.Drawing.Point(190, 213);
            this.btn_IMG_menu_PhiTre.Name = "btn_IMG_menu_PhiTre";
            this.btn_IMG_menu_PhiTre.Size = new System.Drawing.Size(30, 30);
            this.btn_IMG_menu_PhiTre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_IMG_menu_PhiTre.TabIndex = 13;
            this.btn_IMG_menu_PhiTre.TabStop = false;
            this.btn_IMG_menu_PhiTre.Zoom = 10;
            // 
            // lb_CustomerName
            // 
            this.lb_CustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_CustomerName.AutoSize = true;
            this.lb_CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CustomerName.Location = new System.Drawing.Point(10, 82);
            this.lb_CustomerName.Name = "lb_CustomerName";
            this.lb_CustomerName.Size = new System.Drawing.Size(123, 20);
            this.lb_CustomerName.TabIndex = 6;
            this.lb_CustomerName.Text = "Tên khách hàng";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tổng tiền";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phí thuê mới";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Phí trễ";
            // 
            // lb_CustomerID
            // 
            this.lb_CustomerID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_CustomerID.AutoSize = true;
            this.lb_CustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CustomerID.Location = new System.Drawing.Point(10, 11);
            this.lb_CustomerID.Name = "lb_CustomerID";
            this.lb_CustomerID.Size = new System.Drawing.Size(118, 20);
            this.lb_CustomerID.TabIndex = 9;
            this.lb_CustomerID.Text = "ID Khách Hàng";
            // 
            // btn_rentDisk
            // 
            this.btn_rentDisk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_rentDisk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(173)))), ((int)(((byte)(196)))));
            this.btn_rentDisk.color = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(173)))), ((int)(((byte)(196)))));
            this.btn_rentDisk.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(135)))), ((int)(((byte)(205)))));
            this.btn_rentDisk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rentDisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rentDisk.ForeColor = System.Drawing.Color.White;
            this.btn_rentDisk.Image = null;
            this.btn_rentDisk.ImagePosition = 20;
            this.btn_rentDisk.ImageZoom = 50;
            this.btn_rentDisk.LabelPosition = 32;
            this.btn_rentDisk.LabelText = "Thanh toán";
            this.btn_rentDisk.Location = new System.Drawing.Point(14, 396);
            this.btn_rentDisk.Margin = new System.Windows.Forms.Padding(6);
            this.btn_rentDisk.Name = "btn_rentDisk";
            this.btn_rentDisk.Size = new System.Drawing.Size(242, 40);
            this.btn_rentDisk.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(536, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 450);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txt_searchDisk);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(539, 38);
            this.panel4.TabIndex = 22;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBox2.Image = global::Nhom9_RentingDisk_XDPM.Properties.Resources.search;
            this.pictureBox2.Location = new System.Drawing.Point(12, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // txt_searchDisk
            // 
            this.txt_searchDisk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_searchDisk.Depth = 0;
            this.txt_searchDisk.Hint = "Search Disk";
            this.txt_searchDisk.Location = new System.Drawing.Point(39, 8);
            this.txt_searchDisk.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_searchDisk.Name = "txt_searchDisk";
            this.txt_searchDisk.PasswordChar = '\0';
            this.txt_searchDisk.SelectedText = "";
            this.txt_searchDisk.SelectionLength = 0;
            this.txt_searchDisk.SelectionStart = 0;
            this.txt_searchDisk.Size = new System.Drawing.Size(480, 23);
            this.txt_searchDisk.TabIndex = 22;
            this.txt_searchDisk.UseSystemPasswordChar = false;
            // 
            // dgv_Disk
            // 
            this.dgv_Disk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Disk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Disk.Location = new System.Drawing.Point(0, 38);
            this.dgv_Disk.Name = "dgv_Disk";
            this.dgv_Disk.Size = new System.Drawing.Size(539, 412);
            this.dgv_Disk.TabIndex = 23;
            // 
            // RentingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RentingForm";
            this.Text = "RentingForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RentingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_IMG_delete_PhiMoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_IMG_Delete_PhiTre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_IMG_menu_PhiMoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_IMG_menu_PhiTre)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Disk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton btn_IMG_Delete_PhiTre;
        private Bunifu.Framework.UI.BunifuImageButton btn_IMG_menu_PhiTre;
        private System.Windows.Forms.Label lb_CustomerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_CustomerID;
        private Bunifu.Framework.UI.BunifuTileButton btn_rentDisk;
        private Bunifu.Framework.UI.BunifuImageButton btn_IMG_delete_PhiMoi;
        private Bunifu.Framework.UI.BunifuImageButton btn_IMG_menu_PhiMoi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.TextBox txt_CustomerID;
        private System.Windows.Forms.Panel pnl_numberPhone;
        private System.Windows.Forms.Panel pnl_nameCustomer;
        private System.Windows.Forms.TextBox txt_CustomerName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_searchDisk;
        private System.Windows.Forms.DataGridView dgv_Disk;
    }
}