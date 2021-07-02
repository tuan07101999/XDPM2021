namespace Nhom9_RentingDisk_XDPM
{
    partial class CheckLateChargeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_listItem = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_nameCustomer = new System.Windows.Forms.Panel();
            this.txt_nameCustomer = new System.Windows.Forms.TextBox();
            this.pnl_numberPhone = new System.Windows.Forms.Panel();
            this.txt_numberPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_lateFee = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_thanhToan = new Bunifu.Framework.UI.BunifuTileButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listItem)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_listItem
            // 
            this.dgv_listItem.AllowUserToAddRows = false;
            this.dgv_listItem.AllowUserToDeleteRows = false;
            this.dgv_listItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_listItem.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_listItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_listItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_listItem.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_listItem.GridColor = System.Drawing.Color.LightGray;
            this.dgv_listItem.Location = new System.Drawing.Point(12, 22);
            this.dgv_listItem.Name = "dgv_listItem";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_listItem.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_listItem.RowHeadersVisible = false;
            this.dgv_listItem.Size = new System.Drawing.Size(760, 415);
            this.dgv_listItem.TabIndex = 24;
            this.dgv_listItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listItem_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 450);
            this.panel1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnl_nameCustomer);
            this.panel2.Controls.Add(this.txt_nameCustomer);
            this.panel2.Controls.Add(this.pnl_numberPhone);
            this.panel2.Controls.Add(this.txt_numberPhone);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lbl_lateFee);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_thanhToan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(790, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 450);
            this.panel2.TabIndex = 26;
            // 
            // pnl_nameCustomer
            // 
            this.pnl_nameCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_nameCustomer.BackColor = System.Drawing.Color.DarkGray;
            this.pnl_nameCustomer.Location = new System.Drawing.Point(6, 133);
            this.pnl_nameCustomer.Name = "pnl_nameCustomer";
            this.pnl_nameCustomer.Size = new System.Drawing.Size(246, 1);
            this.pnl_nameCustomer.TabIndex = 31;
            // 
            // txt_nameCustomer
            // 
            this.txt_nameCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nameCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nameCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nameCustomer.Location = new System.Drawing.Point(6, 112);
            this.txt_nameCustomer.Multiline = true;
            this.txt_nameCustomer.Name = "txt_nameCustomer";
            this.txt_nameCustomer.Size = new System.Drawing.Size(246, 22);
            this.txt_nameCustomer.TabIndex = 30;
            // 
            // pnl_numberPhone
            // 
            this.pnl_numberPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_numberPhone.BackColor = System.Drawing.Color.DarkGray;
            this.pnl_numberPhone.Location = new System.Drawing.Point(8, 62);
            this.pnl_numberPhone.Name = "pnl_numberPhone";
            this.pnl_numberPhone.Size = new System.Drawing.Size(246, 1);
            this.pnl_numberPhone.TabIndex = 29;
            // 
            // txt_numberPhone
            // 
            this.txt_numberPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_numberPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_numberPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numberPhone.Location = new System.Drawing.Point(6, 41);
            this.txt_numberPhone.Multiline = true;
            this.txt_numberPhone.Name = "txt_numberPhone";
            this.txt_numberPhone.Size = new System.Drawing.Size(246, 22);
            this.txt_numberPhone.TabIndex = 28;
            this.txt_numberPhone.TextChanged += new System.EventHandler(this.txt_numberPhone_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tổng phí";
            // 
            // lbl_lateFee
            // 
            this.lbl_lateFee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_lateFee.AutoSize = true;
            this.lbl_lateFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lateFee.Location = new System.Drawing.Point(196, 337);
            this.lbl_lateFee.Name = "lbl_lateFee";
            this.lbl_lateFee.Size = new System.Drawing.Size(56, 20);
            this.lbl_lateFee.TabIndex = 22;
            this.lbl_lateFee.Text = "0 VND";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tên khách hàng";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Số điện thoại";
            // 
            // btn_thanhToan
            // 
            this.btn_thanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_thanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(173)))), ((int)(((byte)(196)))));
            this.btn_thanhToan.color = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(173)))), ((int)(((byte)(196)))));
            this.btn_thanhToan.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(135)))), ((int)(((byte)(205)))));
            this.btn_thanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_thanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thanhToan.ForeColor = System.Drawing.Color.White;
            this.btn_thanhToan.Image = null;
            this.btn_thanhToan.ImagePosition = 20;
            this.btn_thanhToan.ImageZoom = 50;
            this.btn_thanhToan.LabelPosition = 30;
            this.btn_thanhToan.LabelText = "Thanh toán";
            this.btn_thanhToan.Location = new System.Drawing.Point(8, 397);
            this.btn_thanhToan.Margin = new System.Windows.Forms.Padding(6);
            this.btn_thanhToan.Name = "btn_thanhToan";
            this.btn_thanhToan.Size = new System.Drawing.Size(246, 40);
            this.btn_thanhToan.TabIndex = 20;
            this.btn_thanhToan.Click += new System.EventHandler(this.btn_thanhToan_Click);
            // 
            // CheckLateChargeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1051, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_listItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckLateChargeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckLateChargeForm";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listItem)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_listItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl_nameCustomer;
        private System.Windows.Forms.TextBox txt_nameCustomer;
        private System.Windows.Forms.Panel pnl_numberPhone;
        private System.Windows.Forms.TextBox txt_numberPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_lateFee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuTileButton btn_thanhToan;
    }
}