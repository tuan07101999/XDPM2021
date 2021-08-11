namespace Nhom18_XDPM
{
    partial class ReportTitleForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.tieuDeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongSoBanSaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongSoBanSaoDangDuocThueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongSoBanSaoTrongKhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongBanSaoDangDatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleReportModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_InThongKe = new System.Windows.Forms.Label();
            this.btn_InThongKe = new System.Windows.Forms.PictureBox();
            this.txt_TimKiem = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleReportModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_InThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 47);
            this.panel1.TabIndex = 22;
            // 
            // btn_back
            // 
            this.btn_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_back.Location = new System.Drawing.Point(4, 4);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(200, 39);
            this.btn_back.TabIndex = 20;
            this.btn_back.Text = "          Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(404, 11);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(141, 24);
            this.materialLabel1.TabIndex = 17;
            this.materialLabel1.Text = "Báo cáo tiêu đề";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1087, 616);
            this.panel2.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.bunifuCustomDataGrid1);
            this.groupBox1.Controls.Add(this.lbl_InThongKe);
            this.groupBox1.Controls.Add(this.btn_InThongKe);
            this.groupBox1.Controls.Add(this.txt_TimKiem);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1079, 609);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách tiêu đề";
            // 
            // bunifuCustomDataGrid1
            // 
            this.bunifuCustomDataGrid1.AllowUserToAddRows = false;
            this.bunifuCustomDataGrid1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomDataGrid1.AutoGenerateColumns = false;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(173)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tieuDeDataGridViewTextBoxColumn,
            this.tongSoBanSaoDataGridViewTextBoxColumn,
            this.tongSoBanSaoDangDuocThueDataGridViewTextBoxColumn,
            this.tongSoBanSaoTrongKhoDataGridViewTextBoxColumn,
            this.soLuongBanSaoDangDatDataGridViewTextBoxColumn});
            this.bunifuCustomDataGrid1.DataSource = this.titleReportModelBindingSource;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(173)))), ((int)(((byte)(196)))));
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(13, 60);
            this.bunifuCustomDataGrid1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.ReadOnly = true;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid1.RowHeadersWidth = 51;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(1057, 539);
            this.bunifuCustomDataGrid1.TabIndex = 4;
            // 
            // tieuDeDataGridViewTextBoxColumn
            // 
            this.tieuDeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tieuDeDataGridViewTextBoxColumn.DataPropertyName = "TieuDe";
            this.tieuDeDataGridViewTextBoxColumn.HeaderText = "Tiêu đề";
            this.tieuDeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tieuDeDataGridViewTextBoxColumn.Name = "tieuDeDataGridViewTextBoxColumn";
            this.tieuDeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tongSoBanSaoDataGridViewTextBoxColumn
            // 
            this.tongSoBanSaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tongSoBanSaoDataGridViewTextBoxColumn.DataPropertyName = "TongSoBanSao";
            this.tongSoBanSaoDataGridViewTextBoxColumn.HeaderText = "Tổng số bản sao";
            this.tongSoBanSaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tongSoBanSaoDataGridViewTextBoxColumn.Name = "tongSoBanSaoDataGridViewTextBoxColumn";
            this.tongSoBanSaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tongSoBanSaoDangDuocThueDataGridViewTextBoxColumn
            // 
            this.tongSoBanSaoDangDuocThueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tongSoBanSaoDangDuocThueDataGridViewTextBoxColumn.DataPropertyName = "TongSoBanSaoDangDuocThue";
            this.tongSoBanSaoDangDuocThueDataGridViewTextBoxColumn.HeaderText = "Tổng số bản sao đang được thuê";
            this.tongSoBanSaoDangDuocThueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tongSoBanSaoDangDuocThueDataGridViewTextBoxColumn.Name = "tongSoBanSaoDangDuocThueDataGridViewTextBoxColumn";
            this.tongSoBanSaoDangDuocThueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tongSoBanSaoTrongKhoDataGridViewTextBoxColumn
            // 
            this.tongSoBanSaoTrongKhoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tongSoBanSaoTrongKhoDataGridViewTextBoxColumn.DataPropertyName = "TongSoBanSaoTrongKho";
            this.tongSoBanSaoTrongKhoDataGridViewTextBoxColumn.HeaderText = "Tổng số bản sao trong kho";
            this.tongSoBanSaoTrongKhoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tongSoBanSaoTrongKhoDataGridViewTextBoxColumn.Name = "tongSoBanSaoTrongKhoDataGridViewTextBoxColumn";
            this.tongSoBanSaoTrongKhoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soLuongBanSaoDangDatDataGridViewTextBoxColumn
            // 
            this.soLuongBanSaoDangDatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.soLuongBanSaoDangDatDataGridViewTextBoxColumn.DataPropertyName = "SoLuongBanSaoDangDat";
            this.soLuongBanSaoDangDatDataGridViewTextBoxColumn.HeaderText = "Tổng số lượng đặt hàng";
            this.soLuongBanSaoDangDatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soLuongBanSaoDangDatDataGridViewTextBoxColumn.Name = "soLuongBanSaoDangDatDataGridViewTextBoxColumn";
            this.soLuongBanSaoDangDatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleReportModelBindingSource
            // 
            this.titleReportModelBindingSource.DataSource = typeof(Business.Models.TitleReportModel);
            // 
            // lbl_InThongKe
            // 
            this.lbl_InThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_InThongKe.AutoSize = true;
            this.lbl_InThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InThongKe.Location = new System.Drawing.Point(975, 33);
            this.lbl_InThongKe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_InThongKe.Name = "lbl_InThongKe";
            this.lbl_InThongKe.Size = new System.Drawing.Size(90, 20);
            this.lbl_InThongKe.TabIndex = 3;
            this.lbl_InThongKe.Text = "In thống kê";
            // 
            // btn_InThongKe
            // 
            this.btn_InThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_InThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_InThongKe.Image = global::Nhom18_XDPM.Properties.Resources.print_filled_100px;
            this.btn_InThongKe.Location = new System.Drawing.Point(923, 18);
            this.btn_InThongKe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_InThongKe.Name = "btn_InThongKe";
            this.btn_InThongKe.Size = new System.Drawing.Size(40, 34);
            this.btn_InThongKe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_InThongKe.TabIndex = 2;
            this.btn_InThongKe.TabStop = false;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Depth = 0;
            this.txt_TimKiem.Hint = "";
            this.txt_TimKiem.Location = new System.Drawing.Point(13, 25);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_TimKiem.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.PasswordChar = '\0';
            this.txt_TimKiem.SelectedText = "";
            this.txt_TimKiem.SelectionLength = 0;
            this.txt_TimKiem.SelectionStart = 0;
            this.txt_TimKiem.Size = new System.Drawing.Size(512, 28);
            this.txt_TimKiem.TabIndex = 0;
            this.txt_TimKiem.Text = "Tìm kiếm";
            this.txt_TimKiem.UseSystemPasswordChar = false;
            this.txt_TimKiem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btn_TimKiem_KeyUp);
            // 
            // ReportTitleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1087, 668);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReportTitleForm";
            this.Text = "ReportForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportTitleForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleReportModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_InThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_back;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_InThongKe;
        private System.Windows.Forms.PictureBox btn_InThongKe;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_TimKiem;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tieuDeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongSoBanSaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongSoBanSaoDangDuocThueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongSoBanSaoTrongKhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongBanSaoDangDatDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource titleReportModelBindingSource;
    }
}