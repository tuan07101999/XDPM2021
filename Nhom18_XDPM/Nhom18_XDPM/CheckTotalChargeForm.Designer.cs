namespace Nhom18_XDPM
{
    partial class CheckTotalChargeForm
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
            this.lb_Title = new System.Windows.Forms.Label();
            this.dgv_WaitingForRent = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_WaitingForRent)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Title
            // 
            this.lb_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.Location = new System.Drawing.Point(0, 0);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_Title.Size = new System.Drawing.Size(800, 36);
            this.lb_Title.TabIndex = 1;
            this.lb_Title.Text = "Danh Sách Đĩa Đang Chờ Thuê";
            this.lb_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_WaitingForRent
            // 
            this.dgv_WaitingForRent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_WaitingForRent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_WaitingForRent.Location = new System.Drawing.Point(0, 0);
            this.dgv_WaitingForRent.Name = "dgv_WaitingForRent";
            this.dgv_WaitingForRent.Size = new System.Drawing.Size(800, 414);
            this.dgv_WaitingForRent.TabIndex = 0;
            this.dgv_WaitingForRent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_WaitingForRent_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_WaitingForRent);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 414);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_Title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 36);
            this.panel1.TabIndex = 4;
            // 
            // CheckTotalChargeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CheckTotalChargeForm";
            this.Text = "CheckTotalChargeForm";
            this.Load += new System.EventHandler(this.CheckTotalChargeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_WaitingForRent)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.DataGridView dgv_WaitingForRent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}