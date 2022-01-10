
namespace QuanLyQuanCafe
{
    partial class fTableManager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.MnLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmMónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsvTable = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbbGopBan = new System.Windows.Forms.ComboBox();
            this.btnGopBan = new System.Windows.Forms.Button();
            this.tbTotalPrice = new System.Windows.Forms.TextBox();
            this.btnSwitchTable = new System.Windows.Forms.Button();
            this.cbbSwitchTable = new System.Windows.Forms.ComboBox();
            this.nmDiscount = new System.Windows.Forms.NumericUpDown();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbbFood = new System.Windows.Forms.ComboBox();
            this.nmFoodCount = new System.Windows.Forms.NumericUpDown();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.lbUser = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinToolStripMenuItem,
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.BackColor = System.Drawing.Color.LavenderBlush;
            this.adminToolStripMenuItem.Image = global::QuanLyQuanCafe.Properties.Resources.h21;
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.BackColor = System.Drawing.Color.LavenderBlush;
            this.thôngTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnInfo,
            this.MnLogOut});
            this.thôngTinToolStripMenuItem.Image = global::QuanLyQuanCafe.Properties.Resources.h17__4_;
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.thôngTinToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // MnInfo
            // 
            this.MnInfo.BackColor = System.Drawing.Color.LavenderBlush;
            this.MnInfo.Image = global::QuanLyQuanCafe.Properties.Resources.h17__4_;
            this.MnInfo.Name = "MnInfo";
            this.MnInfo.Size = new System.Drawing.Size(180, 22);
            this.MnInfo.Text = "Thông tin cá nhân";
            this.MnInfo.Click += new System.EventHandler(this.MnInfo_Click);
            // 
            // MnLogOut
            // 
            this.MnLogOut.BackColor = System.Drawing.Color.LavenderBlush;
            this.MnLogOut.Image = global::QuanLyQuanCafe.Properties.Resources.h17__5_;
            this.MnLogOut.Name = "MnLogOut";
            this.MnLogOut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Tab)));
            this.MnLogOut.Size = new System.Drawing.Size(180, 22);
            this.MnLogOut.Text = "Đăng xuất";
            this.MnLogOut.Click += new System.EventHandler(this.MnLogOut_Click);
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.BackColor = System.Drawing.Color.LavenderBlush;
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmMónToolStripMenuItem,
            this.thanhToánToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Image = global::QuanLyQuanCafe.Properties.Resources.a9__2_;
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // thêmMónToolStripMenuItem
            // 
            this.thêmMónToolStripMenuItem.BackColor = System.Drawing.Color.LavenderBlush;
            this.thêmMónToolStripMenuItem.Image = global::QuanLyQuanCafe.Properties.Resources.a9__7_;
            this.thêmMónToolStripMenuItem.Name = "thêmMónToolStripMenuItem";
            this.thêmMónToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.thêmMónToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.thêmMónToolStripMenuItem.Text = "Thêm món";
            this.thêmMónToolStripMenuItem.Click += new System.EventHandler(this.thêmMónToolStripMenuItem_Click);
            // 
            // thanhToánToolStripMenuItem
            // 
            this.thanhToánToolStripMenuItem.BackColor = System.Drawing.Color.LavenderBlush;
            this.thanhToánToolStripMenuItem.Image = global::QuanLyQuanCafe.Properties.Resources.h17__4_;
            this.thanhToánToolStripMenuItem.Name = "thanhToánToolStripMenuItem";
            this.thanhToánToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.thanhToánToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.thanhToánToolStripMenuItem.Text = "Thanh toán";
            this.thanhToánToolStripMenuItem.Click += new System.EventHandler(this.thanhToánToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvTable);
            this.panel2.Location = new System.Drawing.Point(3, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(425, 228);
            this.panel2.TabIndex = 2;
            // 
            // lsvTable
            // 
            this.lsvTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvTable.GridLines = true;
            this.lsvTable.HideSelection = false;
            this.lsvTable.Location = new System.Drawing.Point(1, 0);
            this.lsvTable.Name = "lsvTable";
            this.lsvTable.Size = new System.Drawing.Size(420, 224);
            this.lsvTable.TabIndex = 0;
            this.lsvTable.UseCompatibleStateImageBehavior = false;
            this.lsvTable.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 147;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 83;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 79;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 107;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbbGopBan);
            this.panel3.Controls.Add(this.btnGopBan);
            this.panel3.Controls.Add(this.tbTotalPrice);
            this.panel3.Controls.Add(this.btnSwitchTable);
            this.panel3.Controls.Add(this.cbbSwitchTable);
            this.panel3.Controls.Add(this.nmDiscount);
            this.panel3.Controls.Add(this.btnCheckOut);
            this.panel3.Location = new System.Drawing.Point(3, 333);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(425, 75);
            this.panel3.TabIndex = 3;
            // 
            // cbbGopBan
            // 
            this.cbbGopBan.FormattingEnabled = true;
            this.cbbGopBan.Location = new System.Drawing.Point(218, 42);
            this.cbbGopBan.Name = "cbbGopBan";
            this.cbbGopBan.Size = new System.Drawing.Size(100, 26);
            this.cbbGopBan.TabIndex = 12;
            // 
            // btnGopBan
            // 
            this.btnGopBan.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnGopBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGopBan.Location = new System.Drawing.Point(218, 6);
            this.btnGopBan.Name = "btnGopBan";
            this.btnGopBan.Size = new System.Drawing.Size(100, 30);
            this.btnGopBan.TabIndex = 11;
            this.btnGopBan.Text = "Gộp bàn";
            this.btnGopBan.UseVisualStyleBackColor = false;
            this.btnGopBan.Click += new System.EventHandler(this.btnGopBan_Click);
            // 
            // tbTotalPrice
            // 
            this.tbTotalPrice.ForeColor = System.Drawing.Color.Red;
            this.tbTotalPrice.Location = new System.Drawing.Point(112, 9);
            this.tbTotalPrice.Name = "tbTotalPrice";
            this.tbTotalPrice.ReadOnly = true;
            this.tbTotalPrice.Size = new System.Drawing.Size(100, 25);
            this.tbTotalPrice.TabIndex = 10;
            this.tbTotalPrice.Text = "0";
            this.tbTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSwitchTable
            // 
            this.btnSwitchTable.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSwitchTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSwitchTable.Location = new System.Drawing.Point(321, 6);
            this.btnSwitchTable.Name = "btnSwitchTable";
            this.btnSwitchTable.Size = new System.Drawing.Size(100, 30);
            this.btnSwitchTable.TabIndex = 8;
            this.btnSwitchTable.Text = "Chuyển bàn";
            this.btnSwitchTable.UseVisualStyleBackColor = false;
            this.btnSwitchTable.Click += new System.EventHandler(this.btnSwitchTable_Click);
            // 
            // cbbSwitchTable
            // 
            this.cbbSwitchTable.FormattingEnabled = true;
            this.cbbSwitchTable.Location = new System.Drawing.Point(321, 42);
            this.cbbSwitchTable.Name = "cbbSwitchTable";
            this.cbbSwitchTable.Size = new System.Drawing.Size(100, 26);
            this.cbbSwitchTable.TabIndex = 9;
            // 
            // nmDiscount
            // 
            this.nmDiscount.Location = new System.Drawing.Point(112, 41);
            this.nmDiscount.Name = "nmDiscount";
            this.nmDiscount.Size = new System.Drawing.Size(100, 25);
            this.nmDiscount.TabIndex = 7;
            this.nmDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckOut.Location = new System.Drawing.Point(3, 9);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(103, 57);
            this.btnCheckOut.TabIndex = 5;
            this.btnCheckOut.Text = "Thanh Toán";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbbFood);
            this.panel4.Controls.Add(this.nmFoodCount);
            this.panel4.Controls.Add(this.btnAddFood);
            this.panel4.Controls.Add(this.cbbCategory);
            this.panel4.Location = new System.Drawing.Point(4, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(425, 72);
            this.panel4.TabIndex = 4;
            // 
            // cbbFood
            // 
            this.cbbFood.FormattingEnabled = true;
            this.cbbFood.Location = new System.Drawing.Point(3, 38);
            this.cbbFood.Name = "cbbFood";
            this.cbbFood.Size = new System.Drawing.Size(220, 26);
            this.cbbFood.TabIndex = 5;
            // 
            // nmFoodCount
            // 
            this.nmFoodCount.Location = new System.Drawing.Point(340, 25);
            this.nmFoodCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmFoodCount.Name = "nmFoodCount";
            this.nmFoodCount.Size = new System.Drawing.Size(80, 25);
            this.nmFoodCount.TabIndex = 4;
            this.nmFoodCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddFood
            // 
            this.btnAddFood.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnAddFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFood.Location = new System.Drawing.Point(230, 12);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(100, 50);
            this.btnAddFood.TabIndex = 3;
            this.btnAddFood.Text = "Thêm món";
            this.btnAddFood.UseVisualStyleBackColor = false;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // cbbCategory
            // 
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(4, 6);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(220, 26);
            this.cbbCategory.TabIndex = 1;
            this.cbbCategory.SelectedIndexChanged += new System.EventHandler(this.cbbCategory_SelectedIndexChanged);
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.Location = new System.Drawing.Point(435, 25);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(450, 385);
            this.flpTable.TabIndex = 5;
            // 
            // lbUser
            // 
            this.lbUser.BackColor = System.Drawing.Color.LavenderBlush;
            this.lbUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbUser.Cursor = System.Windows.Forms.Cursors.No;
            this.lbUser.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.ForeColor = System.Drawing.Color.Red;
            this.lbUser.Location = new System.Drawing.Point(675, 2);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(200, 20);
            this.lbUser.TabIndex = 6;
            this.lbUser.Text = "Chào Mừng ";
            this.lbUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(884, 411);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý quán cafe Healer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnInfo;
        private System.Windows.Forms.ToolStripMenuItem MnLogOut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lsvTable;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbbSwitchTable;
        private System.Windows.Forms.Button btnSwitchTable;
        private System.Windows.Forms.NumericUpDown nmDiscount;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown nmFoodCount;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox tbTotalPrice;
        private System.Windows.Forms.ComboBox cbbFood;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmMónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thanhToánToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbbGopBan;
        private System.Windows.Forms.Button btnGopBan;
    }
}