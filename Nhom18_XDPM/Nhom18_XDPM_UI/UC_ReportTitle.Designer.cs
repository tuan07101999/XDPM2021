
namespace Nhom18_XDPM_UI
{
    partial class UC_ReportTitle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ReportTitle));
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTopLeft = new System.Windows.Forms.Panel();
            this.panelTopRight = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTitle = new System.Windows.Forms.DataGridView();
            this.titleReportModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tieuDeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongSoBanSaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongSoBanSaoDangDuocThueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongSoBanSaoTrongKhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongBanSaoDangDatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTopLeft.SuspendLayout();
            this.panelTopRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleReportModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.panelTopRight);
            this.panelTop.Controls.Add(this.panelTopLeft);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1128, 76);
            this.panelTop.TabIndex = 0;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.dgvTitle);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.Location = new System.Drawing.Point(0, 76);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1128, 699);
            this.panelBottom.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(67)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.DarkGray;
            this.txtSearch.Location = new System.Drawing.Point(63, 21);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(452, 39);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "Nhập vào mã Tiêu đề cần tìm";
            this.txtSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseClick);
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(67)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(512, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelTopLeft
            // 
            this.panelTopLeft.Controls.Add(this.pictureBox1);
            this.panelTopLeft.Controls.Add(this.txtSearch);
            this.panelTopLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTopLeft.Location = new System.Drawing.Point(0, 0);
            this.panelTopLeft.Name = "panelTopLeft";
            this.panelTopLeft.Size = new System.Drawing.Size(752, 76);
            this.panelTopLeft.TabIndex = 0;
            // 
            // panelTopRight
            // 
            this.panelTopRight.Controls.Add(this.label1);
            this.panelTopRight.Controls.Add(this.pictureBox2);
            this.panelTopRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTopRight.Location = new System.Drawing.Point(752, 0);
            this.panelTopRight.Name = "panelTopRight";
            this.panelTopRight.Size = new System.Drawing.Size(376, 76);
            this.panelTopRight.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(91, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(222, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "In thống kê";
            // 
            // dgvTitle
            // 
            this.dgvTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTitle.AutoGenerateColumns = false;
            this.dgvTitle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.dgvTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTitle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTitle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tieuDeDataGridViewTextBoxColumn,
            this.tongSoBanSaoDataGridViewTextBoxColumn,
            this.tongSoBanSaoDangDuocThueDataGridViewTextBoxColumn,
            this.tongSoBanSaoTrongKhoDataGridViewTextBoxColumn,
            this.soLuongBanSaoDangDatDataGridViewTextBoxColumn});
            this.dgvTitle.DataSource = this.titleReportModelBindingSource;
            this.dgvTitle.Location = new System.Drawing.Point(17, 6);
            this.dgvTitle.Name = "dgvTitle";
            this.dgvTitle.RowHeadersWidth = 51;
            this.dgvTitle.RowTemplate.Height = 24;
            this.dgvTitle.Size = new System.Drawing.Size(1094, 668);
            this.dgvTitle.TabIndex = 0;
            // 
            // titleReportModelBindingSource
            // 
            this.titleReportModelBindingSource.DataSource = typeof(Business.Models.TitleReportModel);
            // 
            // tieuDeDataGridViewTextBoxColumn
            // 
            this.tieuDeDataGridViewTextBoxColumn.DataPropertyName = "TieuDe";
            this.tieuDeDataGridViewTextBoxColumn.HeaderText = "Tiêu Đề";
            this.tieuDeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tieuDeDataGridViewTextBoxColumn.Name = "tieuDeDataGridViewTextBoxColumn";
            this.tieuDeDataGridViewTextBoxColumn.Width = 150;
            // 
            // tongSoBanSaoDataGridViewTextBoxColumn
            // 
            this.tongSoBanSaoDataGridViewTextBoxColumn.DataPropertyName = "TongSoBanSao";
            this.tongSoBanSaoDataGridViewTextBoxColumn.HeaderText = "Tổng Số Bản Sao";
            this.tongSoBanSaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tongSoBanSaoDataGridViewTextBoxColumn.Name = "tongSoBanSaoDataGridViewTextBoxColumn";
            this.tongSoBanSaoDataGridViewTextBoxColumn.Width = 140;
            // 
            // tongSoBanSaoDangDuocThueDataGridViewTextBoxColumn
            // 
            this.tongSoBanSaoDangDuocThueDataGridViewTextBoxColumn.DataPropertyName = "TongSoBanSaoDangDuocThue";
            this.tongSoBanSaoDangDuocThueDataGridViewTextBoxColumn.HeaderText = "Tổng Số Bản Sao Đang Được Thuê";
            this.tongSoBanSaoDangDuocThueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tongSoBanSaoDangDuocThueDataGridViewTextBoxColumn.Name = "tongSoBanSaoDangDuocThueDataGridViewTextBoxColumn";
            this.tongSoBanSaoDangDuocThueDataGridViewTextBoxColumn.Width = 265;
            // 
            // tongSoBanSaoTrongKhoDataGridViewTextBoxColumn
            // 
            this.tongSoBanSaoTrongKhoDataGridViewTextBoxColumn.DataPropertyName = "TongSoBanSaoTrongKho";
            this.tongSoBanSaoTrongKhoDataGridViewTextBoxColumn.HeaderText = "Tổng Số Bản Sao Trong Kho";
            this.tongSoBanSaoTrongKhoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tongSoBanSaoTrongKhoDataGridViewTextBoxColumn.Name = "tongSoBanSaoTrongKhoDataGridViewTextBoxColumn";
            this.tongSoBanSaoTrongKhoDataGridViewTextBoxColumn.Width = 220;
            // 
            // soLuongBanSaoDangDatDataGridViewTextBoxColumn
            // 
            this.soLuongBanSaoDangDatDataGridViewTextBoxColumn.DataPropertyName = "SoLuongBanSaoDangDat";
            this.soLuongBanSaoDangDatDataGridViewTextBoxColumn.HeaderText = "Số Lượng Bản Sao Đang Đặ Trước";
            this.soLuongBanSaoDangDatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soLuongBanSaoDangDatDataGridViewTextBoxColumn.Name = "soLuongBanSaoDangDatDataGridViewTextBoxColumn";
            this.soLuongBanSaoDangDatDataGridViewTextBoxColumn.Width = 260;
            // 
            // UC_ReportTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_ReportTitle";
            this.Size = new System.Drawing.Size(1128, 775);
            this.Load += new System.EventHandler(this.UC_ReportTitle_Load);
            this.panelTop.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTopLeft.ResumeLayout(false);
            this.panelTopLeft.PerformLayout();
            this.panelTopRight.ResumeLayout(false);
            this.panelTopRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleReportModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelTopRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelTopLeft;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvTitle;
        private System.Windows.Forms.BindingSource titleReportModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn tieuDeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongSoBanSaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongSoBanSaoDangDuocThueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongSoBanSaoTrongKhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongBanSaoDangDatDataGridViewTextBoxColumn;
    }
}
