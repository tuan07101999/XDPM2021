
namespace Nhom18_XDPM_UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelSubMenuBaoCao = new System.Windows.Forms.Panel();
            this.btnBaoCaoKH = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBaoCaoNhanDe = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBaoCao = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnKhachHang = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNhanDe = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelSubMenuDVD = new System.Windows.Forms.Panel();
            this.btnDatTruoc = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTraDia = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnThueDia = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDVD = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelProfile = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnProfile = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelLeft.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelSubMenuBaoCao.SuspendLayout();
            this.panelSubMenuDVD.SuspendLayout();
            this.panelProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.panelLeft.Controls.Add(this.panelMenu);
            this.panelLeft.Controls.Add(this.panelProfile);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(356, 953);
            this.panelLeft.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.panelSubMenuBaoCao);
            this.panelMenu.Controls.Add(this.btnBaoCao);
            this.panelMenu.Controls.Add(this.btnKhachHang);
            this.panelMenu.Controls.Add(this.btnNhanDe);
            this.panelMenu.Controls.Add(this.panelSubMenuDVD);
            this.panelMenu.Controls.Add(this.btnDVD);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 285);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(356, 668);
            this.panelMenu.TabIndex = 1;
            // 
            // panelSubMenuBaoCao
            // 
            this.panelSubMenuBaoCao.Controls.Add(this.btnBaoCaoKH);
            this.panelSubMenuBaoCao.Controls.Add(this.btnBaoCaoNhanDe);
            this.panelSubMenuBaoCao.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuBaoCao.Location = new System.Drawing.Point(0, 494);
            this.panelSubMenuBaoCao.Name = "panelSubMenuBaoCao";
            this.panelSubMenuBaoCao.Size = new System.Drawing.Size(356, 127);
            this.panelSubMenuBaoCao.TabIndex = 9;
            // 
            // btnBaoCaoKH
            // 
            this.btnBaoCaoKH.Active = false;
            this.btnBaoCaoKH.Activecolor = System.Drawing.Color.Black;
            this.btnBaoCaoKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnBaoCaoKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBaoCaoKH.BorderRadius = 0;
            this.btnBaoCaoKH.ButtonText = "   Báo cáo Khách hàng";
            this.btnBaoCaoKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaoCaoKH.DisabledColor = System.Drawing.Color.Gray;
            this.btnBaoCaoKH.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBaoCaoKH.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBaoCaoKH.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBaoCaoKH.Iconimage")));
            this.btnBaoCaoKH.Iconimage_right = null;
            this.btnBaoCaoKH.Iconimage_right_Selected = null;
            this.btnBaoCaoKH.Iconimage_Selected = null;
            this.btnBaoCaoKH.IconMarginLeft = 50;
            this.btnBaoCaoKH.IconMarginRight = 0;
            this.btnBaoCaoKH.IconRightVisible = true;
            this.btnBaoCaoKH.IconRightZoom = 0D;
            this.btnBaoCaoKH.IconVisible = true;
            this.btnBaoCaoKH.IconZoom = 70D;
            this.btnBaoCaoKH.IsTab = false;
            this.btnBaoCaoKH.Location = new System.Drawing.Point(0, 60);
            this.btnBaoCaoKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBaoCaoKH.Name = "btnBaoCaoKH";
            this.btnBaoCaoKH.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnBaoCaoKH.OnHovercolor = System.Drawing.Color.Black;
            this.btnBaoCaoKH.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBaoCaoKH.selected = false;
            this.btnBaoCaoKH.Size = new System.Drawing.Size(356, 60);
            this.btnBaoCaoKH.TabIndex = 3;
            this.btnBaoCaoKH.Text = "   Báo cáo Khách hàng";
            this.btnBaoCaoKH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCaoKH.Textcolor = System.Drawing.Color.White;
            this.btnBaoCaoKH.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCaoKH.Click += new System.EventHandler(this.btnBaoCaoKH_Click);
            // 
            // btnBaoCaoNhanDe
            // 
            this.btnBaoCaoNhanDe.Active = false;
            this.btnBaoCaoNhanDe.Activecolor = System.Drawing.Color.Black;
            this.btnBaoCaoNhanDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnBaoCaoNhanDe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBaoCaoNhanDe.BorderRadius = 0;
            this.btnBaoCaoNhanDe.ButtonText = "   Báo cáo Nhan đề";
            this.btnBaoCaoNhanDe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaoCaoNhanDe.DisabledColor = System.Drawing.Color.Gray;
            this.btnBaoCaoNhanDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBaoCaoNhanDe.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBaoCaoNhanDe.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBaoCaoNhanDe.Iconimage")));
            this.btnBaoCaoNhanDe.Iconimage_right = null;
            this.btnBaoCaoNhanDe.Iconimage_right_Selected = null;
            this.btnBaoCaoNhanDe.Iconimage_Selected = null;
            this.btnBaoCaoNhanDe.IconMarginLeft = 50;
            this.btnBaoCaoNhanDe.IconMarginRight = 0;
            this.btnBaoCaoNhanDe.IconRightVisible = true;
            this.btnBaoCaoNhanDe.IconRightZoom = 0D;
            this.btnBaoCaoNhanDe.IconVisible = true;
            this.btnBaoCaoNhanDe.IconZoom = 70D;
            this.btnBaoCaoNhanDe.IsTab = false;
            this.btnBaoCaoNhanDe.Location = new System.Drawing.Point(0, 0);
            this.btnBaoCaoNhanDe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBaoCaoNhanDe.Name = "btnBaoCaoNhanDe";
            this.btnBaoCaoNhanDe.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnBaoCaoNhanDe.OnHovercolor = System.Drawing.Color.Black;
            this.btnBaoCaoNhanDe.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBaoCaoNhanDe.selected = false;
            this.btnBaoCaoNhanDe.Size = new System.Drawing.Size(356, 60);
            this.btnBaoCaoNhanDe.TabIndex = 4;
            this.btnBaoCaoNhanDe.Text = "   Báo cáo Nhan đề";
            this.btnBaoCaoNhanDe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCaoNhanDe.Textcolor = System.Drawing.Color.White;
            this.btnBaoCaoNhanDe.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCaoNhanDe.Click += new System.EventHandler(this.btnBaoCaoNhanDe_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Active = false;
            this.btnBaoCao.Activecolor = System.Drawing.Color.Black;
            this.btnBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnBaoCao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBaoCao.BorderRadius = 0;
            this.btnBaoCao.ButtonText = "       BÁO CÁO";
            this.btnBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaoCao.DisabledColor = System.Drawing.Color.Gray;
            this.btnBaoCao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBaoCao.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBaoCao.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBaoCao.Iconimage")));
            this.btnBaoCao.Iconimage_right = null;
            this.btnBaoCao.Iconimage_right_Selected = null;
            this.btnBaoCao.Iconimage_Selected = null;
            this.btnBaoCao.IconMarginLeft = 20;
            this.btnBaoCao.IconMarginRight = 0;
            this.btnBaoCao.IconRightVisible = true;
            this.btnBaoCao.IconRightZoom = 0D;
            this.btnBaoCao.IconVisible = true;
            this.btnBaoCao.IconZoom = 50D;
            this.btnBaoCao.IsTab = false;
            this.btnBaoCao.Location = new System.Drawing.Point(0, 434);
            this.btnBaoCao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnBaoCao.OnHovercolor = System.Drawing.Color.Black;
            this.btnBaoCao.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBaoCao.selected = false;
            this.btnBaoCao.Size = new System.Drawing.Size(356, 60);
            this.btnBaoCao.TabIndex = 8;
            this.btnBaoCao.Text = "       BÁO CÁO";
            this.btnBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCao.Textcolor = System.Drawing.Color.White;
            this.btnBaoCao.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Active = false;
            this.btnKhachHang.Activecolor = System.Drawing.Color.Black;
            this.btnKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnKhachHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKhachHang.BorderRadius = 0;
            this.btnKhachHang.ButtonText = "     KHÁCH HÀNG";
            this.btnKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhachHang.DisabledColor = System.Drawing.Color.Gray;
            this.btnKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhachHang.Iconcolor = System.Drawing.Color.Transparent;
            this.btnKhachHang.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.Iconimage")));
            this.btnKhachHang.Iconimage_right = null;
            this.btnKhachHang.Iconimage_right_Selected = null;
            this.btnKhachHang.Iconimage_Selected = null;
            this.btnKhachHang.IconMarginLeft = 20;
            this.btnKhachHang.IconMarginRight = 0;
            this.btnKhachHang.IconRightVisible = true;
            this.btnKhachHang.IconRightZoom = 0D;
            this.btnKhachHang.IconVisible = true;
            this.btnKhachHang.IconZoom = 70D;
            this.btnKhachHang.IsTab = false;
            this.btnKhachHang.Location = new System.Drawing.Point(0, 374);
            this.btnKhachHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnKhachHang.OnHovercolor = System.Drawing.Color.Black;
            this.btnKhachHang.OnHoverTextColor = System.Drawing.Color.White;
            this.btnKhachHang.selected = false;
            this.btnKhachHang.Size = new System.Drawing.Size(356, 60);
            this.btnKhachHang.TabIndex = 6;
            this.btnKhachHang.Text = "     KHÁCH HÀNG";
            this.btnKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.Textcolor = System.Drawing.Color.White;
            this.btnKhachHang.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnNhanDe
            // 
            this.btnNhanDe.Active = false;
            this.btnNhanDe.Activecolor = System.Drawing.Color.Black;
            this.btnNhanDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnNhanDe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNhanDe.BorderRadius = 0;
            this.btnNhanDe.ButtonText = "     NHAN ĐỀ DVD/CD";
            this.btnNhanDe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhanDe.DisabledColor = System.Drawing.Color.Gray;
            this.btnNhanDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhanDe.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNhanDe.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNhanDe.Iconimage")));
            this.btnNhanDe.Iconimage_right = null;
            this.btnNhanDe.Iconimage_right_Selected = null;
            this.btnNhanDe.Iconimage_Selected = null;
            this.btnNhanDe.IconMarginLeft = 20;
            this.btnNhanDe.IconMarginRight = 0;
            this.btnNhanDe.IconRightVisible = true;
            this.btnNhanDe.IconRightZoom = 0D;
            this.btnNhanDe.IconVisible = true;
            this.btnNhanDe.IconZoom = 70D;
            this.btnNhanDe.IsTab = false;
            this.btnNhanDe.Location = new System.Drawing.Point(0, 314);
            this.btnNhanDe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNhanDe.Name = "btnNhanDe";
            this.btnNhanDe.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnNhanDe.OnHovercolor = System.Drawing.Color.Black;
            this.btnNhanDe.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNhanDe.selected = false;
            this.btnNhanDe.Size = new System.Drawing.Size(356, 60);
            this.btnNhanDe.TabIndex = 7;
            this.btnNhanDe.Text = "     NHAN ĐỀ DVD/CD";
            this.btnNhanDe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanDe.Textcolor = System.Drawing.Color.White;
            this.btnNhanDe.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanDe.Click += new System.EventHandler(this.btnNhanDe_Click);
            // 
            // panelSubMenuDVD
            // 
            this.panelSubMenuDVD.Controls.Add(this.btnDatTruoc);
            this.panelSubMenuDVD.Controls.Add(this.btnTraDia);
            this.panelSubMenuDVD.Controls.Add(this.btnThueDia);
            this.panelSubMenuDVD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuDVD.Location = new System.Drawing.Point(0, 123);
            this.panelSubMenuDVD.Name = "panelSubMenuDVD";
            this.panelSubMenuDVD.Size = new System.Drawing.Size(356, 191);
            this.panelSubMenuDVD.TabIndex = 5;
            // 
            // btnDatTruoc
            // 
            this.btnDatTruoc.Active = false;
            this.btnDatTruoc.Activecolor = System.Drawing.Color.Black;
            this.btnDatTruoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnDatTruoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDatTruoc.BorderRadius = 0;
            this.btnDatTruoc.ButtonText = "   Đặt Trước";
            this.btnDatTruoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDatTruoc.DisabledColor = System.Drawing.Color.Gray;
            this.btnDatTruoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDatTruoc.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDatTruoc.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDatTruoc.Iconimage")));
            this.btnDatTruoc.Iconimage_right = null;
            this.btnDatTruoc.Iconimage_right_Selected = null;
            this.btnDatTruoc.Iconimage_Selected = null;
            this.btnDatTruoc.IconMarginLeft = 50;
            this.btnDatTruoc.IconMarginRight = 0;
            this.btnDatTruoc.IconRightVisible = true;
            this.btnDatTruoc.IconRightZoom = 0D;
            this.btnDatTruoc.IconVisible = true;
            this.btnDatTruoc.IconZoom = 70D;
            this.btnDatTruoc.IsTab = false;
            this.btnDatTruoc.Location = new System.Drawing.Point(0, 120);
            this.btnDatTruoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDatTruoc.Name = "btnDatTruoc";
            this.btnDatTruoc.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnDatTruoc.OnHovercolor = System.Drawing.Color.Black;
            this.btnDatTruoc.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDatTruoc.selected = false;
            this.btnDatTruoc.Size = new System.Drawing.Size(356, 60);
            this.btnDatTruoc.TabIndex = 5;
            this.btnDatTruoc.Text = "   Đặt Trước";
            this.btnDatTruoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatTruoc.Textcolor = System.Drawing.Color.White;
            this.btnDatTruoc.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatTruoc.Click += new System.EventHandler(this.btnDatTruoc_Click);
            // 
            // btnTraDia
            // 
            this.btnTraDia.Active = false;
            this.btnTraDia.Activecolor = System.Drawing.Color.Black;
            this.btnTraDia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnTraDia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTraDia.BorderRadius = 0;
            this.btnTraDia.ButtonText = "   Trả Đĩa";
            this.btnTraDia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTraDia.DisabledColor = System.Drawing.Color.Gray;
            this.btnTraDia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTraDia.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTraDia.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTraDia.Iconimage")));
            this.btnTraDia.Iconimage_right = null;
            this.btnTraDia.Iconimage_right_Selected = null;
            this.btnTraDia.Iconimage_Selected = null;
            this.btnTraDia.IconMarginLeft = 50;
            this.btnTraDia.IconMarginRight = 0;
            this.btnTraDia.IconRightVisible = true;
            this.btnTraDia.IconRightZoom = 0D;
            this.btnTraDia.IconVisible = true;
            this.btnTraDia.IconZoom = 70D;
            this.btnTraDia.IsTab = false;
            this.btnTraDia.Location = new System.Drawing.Point(0, 60);
            this.btnTraDia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTraDia.Name = "btnTraDia";
            this.btnTraDia.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnTraDia.OnHovercolor = System.Drawing.Color.Black;
            this.btnTraDia.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTraDia.selected = false;
            this.btnTraDia.Size = new System.Drawing.Size(356, 60);
            this.btnTraDia.TabIndex = 4;
            this.btnTraDia.Text = "   Trả Đĩa";
            this.btnTraDia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraDia.Textcolor = System.Drawing.Color.White;
            this.btnTraDia.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraDia.Click += new System.EventHandler(this.btnTraDia_Click);
            // 
            // btnThueDia
            // 
            this.btnThueDia.Active = false;
            this.btnThueDia.Activecolor = System.Drawing.Color.Black;
            this.btnThueDia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnThueDia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThueDia.BorderRadius = 0;
            this.btnThueDia.ButtonText = "   Thuê Đĩa";
            this.btnThueDia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThueDia.DisabledColor = System.Drawing.Color.Gray;
            this.btnThueDia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThueDia.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThueDia.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnThueDia.Iconimage")));
            this.btnThueDia.Iconimage_right = null;
            this.btnThueDia.Iconimage_right_Selected = null;
            this.btnThueDia.Iconimage_Selected = null;
            this.btnThueDia.IconMarginLeft = 50;
            this.btnThueDia.IconMarginRight = 0;
            this.btnThueDia.IconRightVisible = true;
            this.btnThueDia.IconRightZoom = 0D;
            this.btnThueDia.IconVisible = true;
            this.btnThueDia.IconZoom = 70D;
            this.btnThueDia.IsTab = false;
            this.btnThueDia.Location = new System.Drawing.Point(0, 0);
            this.btnThueDia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThueDia.Name = "btnThueDia";
            this.btnThueDia.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnThueDia.OnHovercolor = System.Drawing.Color.Black;
            this.btnThueDia.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThueDia.selected = false;
            this.btnThueDia.Size = new System.Drawing.Size(356, 60);
            this.btnThueDia.TabIndex = 3;
            this.btnThueDia.Text = "   Thuê Đĩa";
            this.btnThueDia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThueDia.Textcolor = System.Drawing.Color.White;
            this.btnThueDia.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThueDia.Click += new System.EventHandler(this.btnThueDia_Click);
            // 
            // btnDVD
            // 
            this.btnDVD.Active = false;
            this.btnDVD.Activecolor = System.Drawing.Color.Black;
            this.btnDVD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnDVD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDVD.BorderRadius = 0;
            this.btnDVD.ButtonText = "       DVD/CD";
            this.btnDVD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDVD.DisabledColor = System.Drawing.Color.Gray;
            this.btnDVD.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDVD.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDVD.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDVD.Iconimage")));
            this.btnDVD.Iconimage_right = null;
            this.btnDVD.Iconimage_right_Selected = null;
            this.btnDVD.Iconimage_Selected = null;
            this.btnDVD.IconMarginLeft = 20;
            this.btnDVD.IconMarginRight = 0;
            this.btnDVD.IconRightVisible = false;
            this.btnDVD.IconRightZoom = 0D;
            this.btnDVD.IconVisible = true;
            this.btnDVD.IconZoom = 50D;
            this.btnDVD.IsTab = false;
            this.btnDVD.Location = new System.Drawing.Point(0, 62);
            this.btnDVD.Margin = new System.Windows.Forms.Padding(6);
            this.btnDVD.Name = "btnDVD";
            this.btnDVD.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnDVD.OnHovercolor = System.Drawing.Color.Black;
            this.btnDVD.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDVD.selected = false;
            this.btnDVD.Size = new System.Drawing.Size(356, 61);
            this.btnDVD.TabIndex = 4;
            this.btnDVD.Text = "       DVD/CD";
            this.btnDVD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDVD.Textcolor = System.Drawing.Color.White;
            this.btnDVD.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDVD.Click += new System.EventHandler(this.btnDVD_Click);
            // 
            // btnHome
            // 
            this.btnHome.Active = false;
            this.btnHome.Activecolor = System.Drawing.Color.Black;
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.BorderRadius = 0;
            this.btnHome.ButtonText = "     HOME";
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.DisabledColor = System.Drawing.Color.Gray;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHome.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHome.Iconimage")));
            this.btnHome.Iconimage_right = null;
            this.btnHome.Iconimage_right_Selected = null;
            this.btnHome.Iconimage_Selected = null;
            this.btnHome.IconMarginLeft = 20;
            this.btnHome.IconMarginRight = 0;
            this.btnHome.IconRightVisible = false;
            this.btnHome.IconRightZoom = 0D;
            this.btnHome.IconVisible = true;
            this.btnHome.IconZoom = 70D;
            this.btnHome.IsTab = false;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnHome.OnHovercolor = System.Drawing.Color.Black;
            this.btnHome.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHome.selected = false;
            this.btnHome.Size = new System.Drawing.Size(356, 62);
            this.btnHome.TabIndex = 10;
            this.btnHome.Text = "     HOME";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Textcolor = System.Drawing.Color.White;
            this.btnHome.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelProfile
            // 
            this.panelProfile.Controls.Add(this.pictureBox1);
            this.panelProfile.Controls.Add(this.btnProfile);
            this.panelProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProfile.Location = new System.Drawing.Point(0, 0);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(356, 285);
            this.panelProfile.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnProfile
            // 
            this.btnProfile.Active = false;
            this.btnProfile.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProfile.BorderRadius = 0;
            this.btnProfile.ButtonText = "USER NAME";
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.DisabledColor = System.Drawing.Color.Gray;
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnProfile.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProfile.Iconimage = null;
            this.btnProfile.Iconimage_right = null;
            this.btnProfile.Iconimage_right_Selected = null;
            this.btnProfile.Iconimage_Selected = null;
            this.btnProfile.IconMarginLeft = 0;
            this.btnProfile.IconMarginRight = 0;
            this.btnProfile.IconRightVisible = true;
            this.btnProfile.IconRightZoom = 0D;
            this.btnProfile.IconVisible = true;
            this.btnProfile.IconZoom = 90D;
            this.btnProfile.IsTab = false;
            this.btnProfile.Location = new System.Drawing.Point(0, 225);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnProfile.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnProfile.OnHoverTextColor = System.Drawing.Color.White;
            this.btnProfile.selected = false;
            this.btnProfile.Size = new System.Drawing.Size(356, 60);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.Text = "USER NAME";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProfile.Textcolor = System.Drawing.Color.White;
            this.btnProfile.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(356, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(10);
            this.panelRight.Size = new System.Drawing.Size(826, 953);
            this.panelRight.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 953);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.MinimumSize = new System.Drawing.Size(1200, 900);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelSubMenuBaoCao.ResumeLayout(false);
            this.panelSubMenuDVD.ResumeLayout(false);
            this.panelProfile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelProfile;
        private System.Windows.Forms.Panel panelSubMenuBaoCao;
        private Bunifu.Framework.UI.BunifuFlatButton btnBaoCaoNhanDe;
        private Bunifu.Framework.UI.BunifuFlatButton btnBaoCaoKH;
        private Bunifu.Framework.UI.BunifuFlatButton btnBaoCao;
        private Bunifu.Framework.UI.BunifuFlatButton btnNhanDe;
        private Bunifu.Framework.UI.BunifuFlatButton btnKhachHang;
        private System.Windows.Forms.Panel panelSubMenuDVD;
        private Bunifu.Framework.UI.BunifuFlatButton btnDatTruoc;
        private Bunifu.Framework.UI.BunifuFlatButton btnTraDia;
        private Bunifu.Framework.UI.BunifuFlatButton btnThueDia;
        private Bunifu.Framework.UI.BunifuFlatButton btnDVD;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnProfile;
        private Bunifu.Framework.UI.BunifuFlatButton btnHome;
    }
}