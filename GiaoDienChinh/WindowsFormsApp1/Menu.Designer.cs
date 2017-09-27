namespace WindowsFormsApp1
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gb_thunhap = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmGiaoDịchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thuNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiTiêuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mượnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.choMượnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muaSắmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaChữaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêThuChiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thángToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tuầnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theoMụcThuChiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đặtKếHoạchTiếtKiệmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bảoMậtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_xem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gb_thunhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.gb_thunhap);
            this.groupBox1.Controls.Add(this.vScrollBar1);
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Location = new System.Drawing.Point(92, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 321);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // gb_thunhap
            // 
            this.gb_thunhap.Controls.Add(this.bt_xem);
            this.gb_thunhap.Controls.Add(this.dataGridView1);
            this.gb_thunhap.Controls.Add(this.button1);
            this.gb_thunhap.Location = new System.Drawing.Point(208, 34);
            this.gb_thunhap.Name = "gb_thunhap";
            this.gb_thunhap.Size = new System.Drawing.Size(361, 248);
            this.gb_thunhap.TabIndex = 11;
            this.gb_thunhap.TabStop = false;
            this.gb_thunhap.Text = "Thu nhập";
            this.gb_thunhap.Visible = false;
            this.gb_thunhap.Enter += new System.EventHandler(this.gb_thunhap_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(97, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(3, 16);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 302);
            this.vScrollBar1.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.aToolStripMenuItem1,
            this.bảoMậtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 16);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(126, 302);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmGiaoDịchToolStripMenuItem,
            this.thốngKêThuChiToolStripMenuItem,
            this.đặtKếHoạchTiếtKiệmToolStripMenuItem});
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(122, 19);
            this.aToolStripMenuItem.Text = "Quản lí chi tiêu";
            // 
            // thêmGiaoDịchToolStripMenuItem
            // 
            this.thêmGiaoDịchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thuNhậpToolStripMenuItem,
            this.chiTiêuToolStripMenuItem,
            this.mượnToolStripMenuItem,
            this.choMượnToolStripMenuItem,
            this.muaSắmToolStripMenuItem,
            this.sửaChữaToolStripMenuItem});
            this.thêmGiaoDịchToolStripMenuItem.Name = "thêmGiaoDịchToolStripMenuItem";
            this.thêmGiaoDịchToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.thêmGiaoDịchToolStripMenuItem.Text = "Thêm giao dịch";
            // 
            // thuNhậpToolStripMenuItem
            // 
            this.thuNhậpToolStripMenuItem.Name = "thuNhậpToolStripMenuItem";
            this.thuNhậpToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.thuNhậpToolStripMenuItem.Text = "Thu nhập";
            this.thuNhậpToolStripMenuItem.Click += new System.EventHandler(this.thuNhậpToolStripMenuItem_Click);
            // 
            // chiTiêuToolStripMenuItem
            // 
            this.chiTiêuToolStripMenuItem.Name = "chiTiêuToolStripMenuItem";
            this.chiTiêuToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.chiTiêuToolStripMenuItem.Text = "Chi tiêu";
            // 
            // mượnToolStripMenuItem
            // 
            this.mượnToolStripMenuItem.Name = "mượnToolStripMenuItem";
            this.mượnToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.mượnToolStripMenuItem.Text = "Mượn";
            // 
            // choMượnToolStripMenuItem
            // 
            this.choMượnToolStripMenuItem.Name = "choMượnToolStripMenuItem";
            this.choMượnToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.choMượnToolStripMenuItem.Text = "Cho mượn";
            // 
            // muaSắmToolStripMenuItem
            // 
            this.muaSắmToolStripMenuItem.Name = "muaSắmToolStripMenuItem";
            this.muaSắmToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.muaSắmToolStripMenuItem.Text = "Mua sắm";
            // 
            // sửaChữaToolStripMenuItem
            // 
            this.sửaChữaToolStripMenuItem.Name = "sửaChữaToolStripMenuItem";
            this.sửaChữaToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.sửaChữaToolStripMenuItem.Text = "Sửa chữa";
            // 
            // thốngKêThuChiToolStripMenuItem
            // 
            this.thốngKêThuChiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thángToolStripMenuItem,
            this.tuầnToolStripMenuItem,
            this.theoMụcThuChiToolStripMenuItem});
            this.thốngKêThuChiToolStripMenuItem.Name = "thốngKêThuChiToolStripMenuItem";
            this.thốngKêThuChiToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.thốngKêThuChiToolStripMenuItem.Text = "Thống kê thu chi";
            // 
            // thángToolStripMenuItem
            // 
            this.thángToolStripMenuItem.Name = "thángToolStripMenuItem";
            this.thángToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.thángToolStripMenuItem.Text = "Tháng";
            // 
            // tuầnToolStripMenuItem
            // 
            this.tuầnToolStripMenuItem.Name = "tuầnToolStripMenuItem";
            this.tuầnToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.tuầnToolStripMenuItem.Text = "Tuần";
            // 
            // theoMụcThuChiToolStripMenuItem
            // 
            this.theoMụcThuChiToolStripMenuItem.Name = "theoMụcThuChiToolStripMenuItem";
            this.theoMụcThuChiToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.theoMụcThuChiToolStripMenuItem.Text = "Theo mục thu chi";
            // 
            // đặtKếHoạchTiếtKiệmToolStripMenuItem
            // 
            this.đặtKếHoạchTiếtKiệmToolStripMenuItem.Name = "đặtKếHoạchTiếtKiệmToolStripMenuItem";
            this.đặtKếHoạchTiếtKiệmToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.đặtKếHoạchTiếtKiệmToolStripMenuItem.Text = "Đặt kế hoạch tiết kiệm";
            // 
            // aToolStripMenuItem1
            // 
            this.aToolStripMenuItem1.Name = "aToolStripMenuItem1";
            this.aToolStripMenuItem1.Size = new System.Drawing.Size(122, 19);
            this.aToolStripMenuItem1.Text = "Thông báo";
            // 
            // bảoMậtToolStripMenuItem
            // 
            this.bảoMậtToolStripMenuItem.Name = "bảoMậtToolStripMenuItem";
            this.bảoMậtToolStripMenuItem.Size = new System.Drawing.Size(122, 19);
            this.bảoMậtToolStripMenuItem.Text = "Bảo mật";
            // 
            // bt_xem
            // 
            this.bt_xem.Location = new System.Drawing.Point(16, 36);
            this.bt_xem.Name = "bt_xem";
            this.bt_xem.Size = new System.Drawing.Size(75, 23);
            this.bt_xem.TabIndex = 13;
            this.bt_xem.Text = "Xem";
            this.bt_xem.UseVisualStyleBackColor = true;
            this.bt_xem.Click += new System.EventHandler(this.bt_xem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.backgr;
            this.ClientSize = new System.Drawing.Size(774, 456);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = "Menu";
            this.groupBox1.ResumeLayout(false);
            this.gb_thunhap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thêmGiaoDịchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thuNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêThuChiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đặtKếHoạchTiếtKiệmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bảoMậtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thángToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tuầnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theoMụcThuChiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chiTiêuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mượnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem choMượnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muaSắmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaChữaToolStripMenuItem;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.GroupBox gb_thunhap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button bt_xem;
    }
}