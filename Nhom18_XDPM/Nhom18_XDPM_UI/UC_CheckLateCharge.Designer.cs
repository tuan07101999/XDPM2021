
namespace Nhom18_XDPM_UI
{
    partial class UC_CheckLateCharge
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_CheckLateCharge));
            this.dgvListItem = new System.Windows.Forms.DataGridView();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnThanhToan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxTimKiem = new System.Windows.Forms.PictureBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListItem)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListItem
            // 
            this.dgvListItem.AllowUserToDeleteRows = false;
            this.dgvListItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListItem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.dgvListItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvListItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListItem.Location = new System.Drawing.Point(21, 84);
            this.dgvListItem.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListItem.Name = "dgvListItem";
            this.dgvListItem.RowHeadersWidth = 51;
            this.dgvListItem.RowTemplate.Height = 24;
            this.dgvListItem.Size = new System.Drawing.Size(783, 424);
            this.dgvListItem.TabIndex = 2;
            this.dgvListItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListItem_CellClick);
            this.dgvListItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListItem_CellContentClick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(829, 579);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtTongTien);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnBack);
            this.panel3.Controls.Add(this.btnThanhToan);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 521);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(829, 58);
            this.panel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(296, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "$";
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(67)))));
            this.txtTongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(112, 21);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongTien.Multiline = true;
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(180, 21);
            this.txtTongTien.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "TỔNG:";
            // 
            // btnBack
            // 
            this.btnBack.Active = false;
            this.btnBack.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.BorderRadius = 0;
            this.btnBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnBack.ButtonText = "<< THUÊ";
            this.btnBack.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnBack.DisabledColor = System.Drawing.Color.Gray;
            this.btnBack.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBack.Iconimage = null;
            this.btnBack.Iconimage_right = null;
            this.btnBack.Iconimage_right_Selected = null;
            this.btnBack.Iconimage_Selected = null;
            this.btnBack.IconMarginLeft = 0;
            this.btnBack.IconMarginRight = 0;
            this.btnBack.IconRightVisible = true;
            this.btnBack.IconRightZoom = 0D;
            this.btnBack.IconVisible = true;
            this.btnBack.IconZoom = 70D;
            this.btnBack.IsTab = false;
            this.btnBack.Location = new System.Drawing.Point(707, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnBack.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.btnBack.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBack.selected = false;
            this.btnBack.Size = new System.Drawing.Size(79, 36);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "<< THUÊ";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBack.Textcolor = System.Drawing.Color.White;
            this.btnBack.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Active = false;
            this.btnThanhToan.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.btnThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnThanhToan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThanhToan.BorderRadius = 0;
            this.btnThanhToan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnThanhToan.ButtonText = "THANH TOÁN";
            this.btnThanhToan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnThanhToan.DisabledColor = System.Drawing.Color.Gray;
            this.btnThanhToan.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThanhToan.Iconimage = null;
            this.btnThanhToan.Iconimage_right = null;
            this.btnThanhToan.Iconimage_right_Selected = null;
            this.btnThanhToan.Iconimage_Selected = null;
            this.btnThanhToan.IconMarginLeft = 0;
            this.btnThanhToan.IconMarginRight = 0;
            this.btnThanhToan.IconRightVisible = true;
            this.btnThanhToan.IconRightZoom = 0D;
            this.btnThanhToan.IconVisible = true;
            this.btnThanhToan.IconZoom = 70D;
            this.btnThanhToan.IsTab = false;
            this.btnThanhToan.Location = new System.Drawing.Point(572, 6);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnThanhToan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.btnThanhToan.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThanhToan.selected = false;
            this.btnThanhToan.Size = new System.Drawing.Size(104, 36);
            this.btnThanhToan.TabIndex = 8;
            this.btnThanhToan.Text = "THANH TOÁN";
            this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThanhToan.Textcolor = System.Drawing.Color.White;
            this.btnThanhToan.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvListItem);
            this.panel1.Controls.Add(this.pictureBoxTimKiem);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 521);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxTimKiem
            // 
            this.pictureBoxTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(67)))));
            this.pictureBoxTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTimKiem.Image")));
            this.pictureBoxTimKiem.Location = new System.Drawing.Point(579, 23);
            this.pictureBoxTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxTimKiem.Name = "pictureBoxTimKiem";
            this.pictureBoxTimKiem.Size = new System.Drawing.Size(53, 37);
            this.pictureBoxTimKiem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxTimKiem.TabIndex = 1;
            this.pictureBoxTimKiem.TabStop = false;
            this.pictureBoxTimKiem.Click += new System.EventHandler(this.pictureBoxTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(67)))));
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.LightGray;
            this.txtTimKiem.Location = new System.Drawing.Point(98, 23);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(485, 37);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.Text = "    ";
            // 
            // UC_CheckLateCharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_CheckLateCharge";
            this.Size = new System.Drawing.Size(829, 579);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListItem)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTimKiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListItem;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnBack;
        private Bunifu.Framework.UI.BunifuFlatButton btnThanhToan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
    }
}
