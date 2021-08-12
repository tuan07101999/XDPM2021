
namespace Nhom18_XDPM_UI
{
    partial class UC_ReturnDisk
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
            this.btnThem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIDDia = new System.Windows.Forms.TextBox();
            this.txtDiskName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvReturn = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPhiTre = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTraDia = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturn)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Active = false;
            this.btnThem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.BorderRadius = 0;
            this.btnThem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnThem.ButtonText = "THÊM";
            this.btnThem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnThem.DisabledColor = System.Drawing.Color.Gray;
            this.btnThem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThem.Iconimage = null;
            this.btnThem.Iconimage_right = null;
            this.btnThem.Iconimage_right_Selected = null;
            this.btnThem.Iconimage_Selected = null;
            this.btnThem.IconMarginLeft = 0;
            this.btnThem.IconMarginRight = 0;
            this.btnThem.IconRightVisible = true;
            this.btnThem.IconRightZoom = 0D;
            this.btnThem.IconVisible = true;
            this.btnThem.IconZoom = 70D;
            this.btnThem.IsTab = false;
            this.btnThem.Location = new System.Drawing.Point(441, 42);
            this.btnThem.Name = "btnThem";
            this.btnThem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnThem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.btnThem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThem.selected = false;
            this.btnThem.Size = new System.Drawing.Size(96, 41);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "THÊM";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnThem.Textcolor = System.Drawing.Color.White;
            this.btnThem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtIDDia);
            this.groupBox2.Controls.Add(this.txtDiskName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox2.Size = new System.Drawing.Size(567, 113);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ĐĨA";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 32);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 22);
            this.label10.TabIndex = 2;
            this.label10.Text = "ID Đĩa:";
            // 
            // txtIDDia
            // 
            this.txtIDDia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIDDia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.txtIDDia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDDia.ForeColor = System.Drawing.Color.White;
            this.txtIDDia.Location = new System.Drawing.Point(99, 29);
            this.txtIDDia.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDDia.Name = "txtIDDia";
            this.txtIDDia.Size = new System.Drawing.Size(306, 27);
            this.txtIDDia.TabIndex = 1;
            this.txtIDDia.TextChanged += new System.EventHandler(this.txtIDDia_TextChanged);
            this.txtIDDia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIDDia_KeyDown);
            this.txtIDDia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDDia_KeyPress);
            // 
            // txtDiskName
            // 
            this.txtDiskName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiskName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.txtDiskName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiskName.ForeColor = System.Drawing.Color.White;
            this.txtDiskName.Location = new System.Drawing.Point(100, 67);
            this.txtDiskName.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiskName.Name = "txtDiskName";
            this.txtDiskName.Size = new System.Drawing.Size(305, 27);
            this.txtDiskName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nhan đề:";
            // 
            // dgvReturn
            // 
            this.dgvReturn.AllowUserToAddRows = false;
            this.dgvReturn.AllowUserToDeleteRows = false;
            this.dgvReturn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.dgvReturn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReturn.Location = new System.Drawing.Point(2, 115);
            this.dgvReturn.Margin = new System.Windows.Forms.Padding(2);
            this.dgvReturn.Name = "dgvReturn";
            this.dgvReturn.ReadOnly = true;
            this.dgvReturn.RowHeadersWidth = 51;
            this.dgvReturn.RowTemplate.Height = 24;
            this.dgvReturn.Size = new System.Drawing.Size(814, 361);
            this.dgvReturn.TabIndex = 0;
            this.dgvReturn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReturn_CellClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvReturn, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.64017F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.35983F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(818, 575);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPhiTre);
            this.panel1.Controls.Add(this.btnTraDia);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 481);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 91);
            this.panel1.TabIndex = 2;
            // 
            // btnPhiTre
            // 
            this.btnPhiTre.Active = false;
            this.btnPhiTre.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.btnPhiTre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPhiTre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnPhiTre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPhiTre.BorderRadius = 0;
            this.btnPhiTre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnPhiTre.ButtonText = "THÔNG TIN PHÍ TRỄ";
            this.btnPhiTre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnPhiTre.DisabledColor = System.Drawing.Color.Gray;
            this.btnPhiTre.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPhiTre.Iconimage = null;
            this.btnPhiTre.Iconimage_right = null;
            this.btnPhiTre.Iconimage_right_Selected = null;
            this.btnPhiTre.Iconimage_Selected = null;
            this.btnPhiTre.IconMarginLeft = 0;
            this.btnPhiTre.IconMarginRight = 0;
            this.btnPhiTre.IconRightVisible = true;
            this.btnPhiTre.IconRightZoom = 0D;
            this.btnPhiTre.IconVisible = true;
            this.btnPhiTre.IconZoom = 70D;
            this.btnPhiTre.IsTab = false;
            this.btnPhiTre.Location = new System.Drawing.Point(438, 31);
            this.btnPhiTre.Name = "btnPhiTre";
            this.btnPhiTre.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnPhiTre.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.btnPhiTre.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPhiTre.selected = false;
            this.btnPhiTre.Size = new System.Drawing.Size(167, 36);
            this.btnPhiTre.TabIndex = 7;
            this.btnPhiTre.Text = "THÔNG TIN PHÍ TRỄ";
            this.btnPhiTre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPhiTre.Textcolor = System.Drawing.Color.White;
            this.btnPhiTre.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhiTre.Click += new System.EventHandler(this.btnThongTinPhiTre_Click);
            // 
            // btnTraDia
            // 
            this.btnTraDia.Active = false;
            this.btnTraDia.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.btnTraDia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTraDia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnTraDia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTraDia.BorderRadius = 0;
            this.btnTraDia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnTraDia.ButtonText = "TRẢ ĐĨA";
            this.btnTraDia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnTraDia.DisabledColor = System.Drawing.Color.Gray;
            this.btnTraDia.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTraDia.Iconimage = null;
            this.btnTraDia.Iconimage_right = null;
            this.btnTraDia.Iconimage_right_Selected = null;
            this.btnTraDia.Iconimage_Selected = null;
            this.btnTraDia.IconMarginLeft = 0;
            this.btnTraDia.IconMarginRight = 0;
            this.btnTraDia.IconRightVisible = true;
            this.btnTraDia.IconRightZoom = 0D;
            this.btnTraDia.IconVisible = true;
            this.btnTraDia.IconZoom = 70D;
            this.btnTraDia.IsTab = false;
            this.btnTraDia.Location = new System.Drawing.Point(639, 31);
            this.btnTraDia.Name = "btnTraDia";
            this.btnTraDia.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnTraDia.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.btnTraDia.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTraDia.selected = false;
            this.btnTraDia.Size = new System.Drawing.Size(150, 36);
            this.btnTraDia.TabIndex = 6;
            this.btnTraDia.Text = "TRẢ ĐĨA";
            this.btnTraDia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTraDia.Textcolor = System.Drawing.Color.White;
            this.btnTraDia.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraDia.Click += new System.EventHandler(this.btnTraDia_Click);
            // 
            // UC_ReturnDisk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_ReturnDisk";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(826, 583);
            this.Load += new System.EventHandler(this.UC_ReturnDisk_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturn)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton btnThem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIDDia;
        private System.Windows.Forms.TextBox txtDiskName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvReturn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnTraDia;
        private Bunifu.Framework.UI.BunifuFlatButton btnPhiTre;
    }
}
