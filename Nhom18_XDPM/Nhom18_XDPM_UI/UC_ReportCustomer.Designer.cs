
namespace Nhom18_XDPM_UI
{
    partial class UC_ReportCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ReportCustomer));
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelTopRight = new System.Windows.Forms.Panel();
            this.lblPrintReport = new System.Windows.Forms.Label();
            this.pictureBoxPrint = new System.Windows.Forms.PictureBox();
            this.panelTopLeft = new System.Windows.Forms.Panel();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.customerFilterTypeObjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblReportType = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelButtonBottom = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalLateFee = new System.Windows.Forms.TextBox();
            this.lblTotalLateFee = new System.Windows.Forms.Label();
            this.panelListCustomer = new System.Windows.Forms.Panel();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDienThoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDiaThueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDiaQuaHanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lateFeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerReportModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBoxSearch = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.recordModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hasOverdueModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelTop.SuspendLayout();
            this.panelTopRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrint)).BeginInit();
            this.panelTopLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerFilterTypeObjectBindingSource)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.panelButtonBottom.SuspendLayout();
            this.panelListCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerReportModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hasOverdueModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.panelTopRight);
            this.panelTop.Controls.Add(this.panelTopLeft);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(842, 63);
            this.panelTop.TabIndex = 0;
            // 
            // panelTopRight
            // 
            this.panelTopRight.Controls.Add(this.lblPrintReport);
            this.panelTopRight.Controls.Add(this.pictureBoxPrint);
            this.panelTopRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTopRight.Location = new System.Drawing.Point(572, 0);
            this.panelTopRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTopRight.Name = "panelTopRight";
            this.panelTopRight.Size = new System.Drawing.Size(270, 63);
            this.panelTopRight.TabIndex = 1;
            // 
            // lblPrintReport
            // 
            this.lblPrintReport.AutoSize = true;
            this.lblPrintReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrintReport.ForeColor = System.Drawing.Color.White;
            this.lblPrintReport.Location = new System.Drawing.Point(141, 27);
            this.lblPrintReport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrintReport.Name = "lblPrintReport";
            this.lblPrintReport.Size = new System.Drawing.Size(89, 20);
            this.lblPrintReport.TabIndex = 1;
            this.lblPrintReport.Text = "In thống kê";
            // 
            // pictureBoxPrint
            // 
            this.pictureBoxPrint.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPrint.Image")));
            this.pictureBoxPrint.Location = new System.Drawing.Point(88, 6);
            this.pictureBoxPrint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxPrint.Name = "pictureBoxPrint";
            this.pictureBoxPrint.Size = new System.Drawing.Size(48, 52);
            this.pictureBoxPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPrint.TabIndex = 0;
            this.pictureBoxPrint.TabStop = false;
            // 
            // panelTopLeft
            // 
            this.panelTopLeft.Controls.Add(this.cmbType);
            this.panelTopLeft.Controls.Add(this.lblReportType);
            this.panelTopLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTopLeft.Location = new System.Drawing.Point(0, 0);
            this.panelTopLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTopLeft.Name = "panelTopLeft";
            this.panelTopLeft.Size = new System.Drawing.Size(572, 63);
            this.panelTopLeft.TabIndex = 0;
            // 
            // cmbType
            // 
            this.cmbType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(67)))));
            this.cmbType.DataSource = this.customerFilterTypeObjectBindingSource;
            this.cmbType.DisplayMember = "Text";
            this.cmbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.ForeColor = System.Drawing.Color.DarkGray;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(137, 20);
            this.cmbType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(320, 28);
            this.cmbType.TabIndex = 1;
            this.cmbType.ValueMember = "Type";
            this.cmbType.SelectedValueChanged += new System.EventHandler(this.cmbType_SelectedValueChanged);
            // 
            // customerFilterTypeObjectBindingSource
            // 
            this.customerFilterTypeObjectBindingSource.DataSource = typeof(Business.Models.CustomerFilterTypeObject);
            // 
            // lblReportType
            // 
            this.lblReportType.AutoSize = true;
            this.lblReportType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportType.ForeColor = System.Drawing.Color.White;
            this.lblReportType.Location = new System.Drawing.Point(32, 20);
            this.lblReportType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReportType.Name = "lblReportType";
            this.lblReportType.Size = new System.Drawing.Size(109, 20);
            this.lblReportType.TabIndex = 0;
            this.lblReportType.Text = "Loại thống kê:";
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.panelButtonBottom);
            this.panelBottom.Controls.Add(this.panelListCustomer);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.Location = new System.Drawing.Point(0, 63);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(842, 559);
            this.panelBottom.TabIndex = 1;
            // 
            // panelButtonBottom
            // 
            this.panelButtonBottom.Controls.Add(this.label4);
            this.panelButtonBottom.Controls.Add(this.txtTotalLateFee);
            this.panelButtonBottom.Controls.Add(this.lblTotalLateFee);
            this.panelButtonBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtonBottom.Location = new System.Drawing.Point(0, 505);
            this.panelButtonBottom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelButtonBottom.Name = "panelButtonBottom";
            this.panelButtonBottom.Size = new System.Drawing.Size(842, 54);
            this.panelButtonBottom.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(334, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "$";
            // 
            // txtTotalLateFee
            // 
            this.txtTotalLateFee.Location = new System.Drawing.Point(155, 11);
            this.txtTotalLateFee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotalLateFee.Multiline = true;
            this.txtTotalLateFee.Name = "txtTotalLateFee";
            this.txtTotalLateFee.Size = new System.Drawing.Size(164, 29);
            this.txtTotalLateFee.TabIndex = 1;
            // 
            // lblTotalLateFee
            // 
            this.lblTotalLateFee.AutoSize = true;
            this.lblTotalLateFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLateFee.ForeColor = System.Drawing.Color.White;
            this.lblTotalLateFee.Location = new System.Drawing.Point(41, 11);
            this.lblTotalLateFee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalLateFee.Name = "lblTotalLateFee";
            this.lblTotalLateFee.Size = new System.Drawing.Size(97, 20);
            this.lblTotalLateFee.TabIndex = 0;
            this.lblTotalLateFee.Text = "Tổng phí trễ:";
            // 
            // panelListCustomer
            // 
            this.panelListCustomer.Controls.Add(this.dgvCustomer);
            this.panelListCustomer.Controls.Add(this.pictureBoxSearch);
            this.panelListCustomer.Controls.Add(this.txtSearch);
            this.panelListCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelListCustomer.Location = new System.Drawing.Point(0, 0);
            this.panelListCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelListCustomer.Name = "panelListCustomer";
            this.panelListCustomer.Size = new System.Drawing.Size(842, 505);
            this.panelListCustomer.TabIndex = 0;
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomer.AutoGenerateColumns = false;
            this.dgvCustomer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.dgvCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.hoTenDataGridViewTextBoxColumn,
            this.soDienThoaiDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.soDiaThueDataGridViewTextBoxColumn,
            this.soDiaQuaHanDataGridViewTextBoxColumn,
            this.lateFeeDataGridViewTextBoxColumn});
            this.dgvCustomer.DataSource = this.customerReportModelBindingSource;
            this.dgvCustomer.Location = new System.Drawing.Point(19, 65);
            this.dgvCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.RowTemplate.Height = 24;
            this.dgvCustomer.Size = new System.Drawing.Size(810, 424);
            this.dgvCustomer.TabIndex = 2;
            this.dgvCustomer.SelectionChanged += new System.EventHandler(this.dgvCustomer_SelectionChanged);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "Họ Tên";
            this.hoTenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            this.hoTenDataGridViewTextBoxColumn.ReadOnly = true;
            this.hoTenDataGridViewTextBoxColumn.Width = 160;
            // 
            // soDienThoaiDataGridViewTextBoxColumn
            // 
            this.soDienThoaiDataGridViewTextBoxColumn.DataPropertyName = "SoDienThoai";
            this.soDienThoaiDataGridViewTextBoxColumn.HeaderText = "Số Điện Thoại";
            this.soDienThoaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soDienThoaiDataGridViewTextBoxColumn.Name = "soDienThoaiDataGridViewTextBoxColumn";
            this.soDienThoaiDataGridViewTextBoxColumn.ReadOnly = true;
            this.soDienThoaiDataGridViewTextBoxColumn.Width = 150;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "Địa Chỉ";
            this.diaChiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.ReadOnly = true;
            this.diaChiDataGridViewTextBoxColumn.Width = 230;
            // 
            // soDiaThueDataGridViewTextBoxColumn
            // 
            this.soDiaThueDataGridViewTextBoxColumn.DataPropertyName = "SoDiaThue";
            this.soDiaThueDataGridViewTextBoxColumn.HeaderText = "Số Đĩa Thuê";
            this.soDiaThueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soDiaThueDataGridViewTextBoxColumn.Name = "soDiaThueDataGridViewTextBoxColumn";
            this.soDiaThueDataGridViewTextBoxColumn.ReadOnly = true;
            this.soDiaThueDataGridViewTextBoxColumn.Width = 125;
            // 
            // soDiaQuaHanDataGridViewTextBoxColumn
            // 
            this.soDiaQuaHanDataGridViewTextBoxColumn.DataPropertyName = "SoDiaQuaHan";
            this.soDiaQuaHanDataGridViewTextBoxColumn.HeaderText = "Số Đĩa Quá Hạn";
            this.soDiaQuaHanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soDiaQuaHanDataGridViewTextBoxColumn.Name = "soDiaQuaHanDataGridViewTextBoxColumn";
            this.soDiaQuaHanDataGridViewTextBoxColumn.ReadOnly = true;
            this.soDiaQuaHanDataGridViewTextBoxColumn.Width = 140;
            // 
            // lateFeeDataGridViewTextBoxColumn
            // 
            this.lateFeeDataGridViewTextBoxColumn.DataPropertyName = "LateFee";
            this.lateFeeDataGridViewTextBoxColumn.HeaderText = "Phí Trễ";
            this.lateFeeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lateFeeDataGridViewTextBoxColumn.Name = "lateFeeDataGridViewTextBoxColumn";
            this.lateFeeDataGridViewTextBoxColumn.ReadOnly = true;
            this.lateFeeDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerReportModelBindingSource
            // 
            this.customerReportModelBindingSource.DataSource = typeof(Business.Models.CustomerReportModel);
            // 
            // pictureBoxSearch
            // 
            this.pictureBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(67)))));
            this.pictureBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSearch.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSearch.Image")));
            this.pictureBoxSearch.Location = new System.Drawing.Point(439, 15);
            this.pictureBoxSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxSearch.Name = "pictureBoxSearch";
            this.pictureBoxSearch.Size = new System.Drawing.Size(42, 34);
            this.pictureBoxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxSearch.TabIndex = 1;
            this.pictureBoxSearch.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(67)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.DarkGray;
            this.txtSearch.Location = new System.Drawing.Point(51, 15);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(391, 34);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "Nhập vào mã khách hàng cần tìm";
            this.txtSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseClick);
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // recordModelBindingSource
            // 
            this.recordModelBindingSource.DataSource = typeof(Business.Models.RecordModel);
            // 
            // hasOverdueModelBindingSource
            // 
            this.hasOverdueModelBindingSource.DataSource = typeof(Business.Models.HasOverdueModel);
            // 
            // UC_ReportCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UC_ReportCustomer";
            this.Size = new System.Drawing.Size(842, 622);
            this.Load += new System.EventHandler(this.UC_ReportCustomer_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTopRight.ResumeLayout(false);
            this.panelTopRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrint)).EndInit();
            this.panelTopLeft.ResumeLayout(false);
            this.panelTopLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerFilterTypeObjectBindingSource)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelButtonBottom.ResumeLayout(false);
            this.panelButtonBottom.PerformLayout();
            this.panelListCustomer.ResumeLayout(false);
            this.panelListCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerReportModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hasOverdueModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelTopRight;
        private System.Windows.Forms.Panel panelTopLeft;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelButtonBottom;
        private System.Windows.Forms.Panel panelListCustomer;
        private System.Windows.Forms.Label lblPrintReport;
        private System.Windows.Forms.PictureBox pictureBoxPrint;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblReportType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalLateFee;
        private System.Windows.Forms.Label lblTotalLateFee;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.PictureBox pictureBoxSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.BindingSource customerFilterTypeObjectBindingSource;
        private System.Windows.Forms.BindingSource customerReportModelBindingSource;
        private System.Windows.Forms.BindingSource recordModelBindingSource;
        private System.Windows.Forms.BindingSource hasOverdueModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDienThoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDiaThueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDiaQuaHanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lateFeeDataGridViewTextBoxColumn;
    }
}
