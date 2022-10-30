
namespace QuanLyCafe
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lv_Bill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.tb_totalPrice = new System.Windows.Forms.TextBox();
            this.nm_disCount = new System.Windows.Forms.NumericUpDown();
            this.btn_swicthTable = new System.Windows.Forms.Button();
            this.cb_switchTable = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_disCount = new System.Windows.Forms.Button();
            this.btn_check = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nm_foodCount = new System.Windows.Forms.NumericUpDown();
            this.btn_addFood = new System.Windows.Forms.Button();
            this.cb_Food = new System.Windows.Forms.ComboBox();
            this.cb_Category = new System.Windows.Forms.ComboBox();
            this.flp_Talble = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_disCount)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_foodCount)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thoongToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(954, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thoongToolStripMenuItem
            // 
            this.thoongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thoongToolStripMenuItem.Name = "thoongToolStripMenuItem";
            this.thoongToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.thoongToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lv_Bill);
            this.panel2.Location = new System.Drawing.Point(525, 123);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 350);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(110, 158);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 176);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lv_Bill
            // 
            this.lv_Bill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lv_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Bill.GridLines = true;
            this.lv_Bill.HideSelection = false;
            this.lv_Bill.Location = new System.Drawing.Point(13, 13);
            this.lv_Bill.Margin = new System.Windows.Forms.Padding(2);
            this.lv_Bill.Name = "lv_Bill";
            this.lv_Bill.Size = new System.Drawing.Size(382, 130);
            this.lv_Bill.TabIndex = 0;
            this.lv_Bill.UseCompatibleStateImageBehavior = false;
            this.lv_Bill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên đồ uống";
            this.columnHeader1.Width = 127;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 82;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.tb_totalPrice);
            this.panel3.Controls.Add(this.nm_disCount);
            this.panel3.Controls.Add(this.btn_swicthTable);
            this.panel3.Controls.Add(this.cb_switchTable);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btn_disCount);
            this.panel3.Controls.Add(this.btn_check);
            this.panel3.Location = new System.Drawing.Point(525, 477);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(408, 76);
            this.panel3.TabIndex = 3;
            // 
            // tb_totalPrice
            // 
            this.tb_totalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_totalPrice.Location = new System.Drawing.Point(212, 49);
            this.tb_totalPrice.Margin = new System.Windows.Forms.Padding(2);
            this.tb_totalPrice.Name = "tb_totalPrice";
            this.tb_totalPrice.ReadOnly = true;
            this.tb_totalPrice.Size = new System.Drawing.Size(86, 22);
            this.tb_totalPrice.TabIndex = 3;
            this.tb_totalPrice.Text = "0";
            this.tb_totalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nm_disCount
            // 
            this.nm_disCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_disCount.Location = new System.Drawing.Point(110, 50);
            this.nm_disCount.Margin = new System.Windows.Forms.Padding(2);
            this.nm_disCount.Name = "nm_disCount";
            this.nm_disCount.Size = new System.Drawing.Size(86, 22);
            this.nm_disCount.TabIndex = 2;
            this.nm_disCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_swicthTable
            // 
            this.btn_swicthTable.BackColor = System.Drawing.Color.Brown;
            this.btn_swicthTable.Font = new System.Drawing.Font("iCiel Mijas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_swicthTable.ForeColor = System.Drawing.Color.White;
            this.btn_swicthTable.Location = new System.Drawing.Point(3, 10);
            this.btn_swicthTable.Margin = new System.Windows.Forms.Padding(2);
            this.btn_swicthTable.Name = "btn_swicthTable";
            this.btn_swicthTable.Size = new System.Drawing.Size(86, 34);
            this.btn_swicthTable.TabIndex = 1;
            this.btn_swicthTable.Text = "Chuyển bàn";
            this.btn_swicthTable.UseVisualStyleBackColor = false;
            this.btn_swicthTable.Click += new System.EventHandler(this.btn_swicthTable_Click);
            // 
            // cb_switchTable
            // 
            this.cb_switchTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_switchTable.FormattingEnabled = true;
            this.cb_switchTable.Location = new System.Drawing.Point(3, 50);
            this.cb_switchTable.Margin = new System.Windows.Forms.Padding(2);
            this.cb_switchTable.Name = "cb_switchTable";
            this.cb_switchTable.Size = new System.Drawing.Size(86, 24);
            this.cb_switchTable.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.Font = new System.Drawing.Font("iCiel Mijas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(212, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tổng";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_disCount
            // 
            this.btn_disCount.BackColor = System.Drawing.Color.Brown;
            this.btn_disCount.Font = new System.Drawing.Font("iCiel Mijas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_disCount.ForeColor = System.Drawing.Color.White;
            this.btn_disCount.Location = new System.Drawing.Point(110, 10);
            this.btn_disCount.Margin = new System.Windows.Forms.Padding(2);
            this.btn_disCount.Name = "btn_disCount";
            this.btn_disCount.Size = new System.Drawing.Size(86, 34);
            this.btn_disCount.TabIndex = 1;
            this.btn_disCount.Text = "Giảm giá";
            this.btn_disCount.UseVisualStyleBackColor = false;
            // 
            // btn_check
            // 
            this.btn_check.BackColor = System.Drawing.Color.Brown;
            this.btn_check.Font = new System.Drawing.Font("iCiel Brush Up", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_check.ForeColor = System.Drawing.Color.White;
            this.btn_check.Location = new System.Drawing.Point(320, 5);
            this.btn_check.Margin = new System.Windows.Forms.Padding(2);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(86, 66);
            this.btn_check.TabIndex = 1;
            this.btn_check.Text = "Thanh toán";
            this.btn_check.UseVisualStyleBackColor = false;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.nm_foodCount);
            this.panel4.Controls.Add(this.btn_addFood);
            this.panel4.Controls.Add(this.cb_Food);
            this.panel4.Controls.Add(this.cb_Category);
            this.panel4.Location = new System.Drawing.Point(525, 48);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(408, 60);
            this.panel4.TabIndex = 4;
            // 
            // nm_foodCount
            // 
            this.nm_foodCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_foodCount.Location = new System.Drawing.Point(213, 34);
            this.nm_foodCount.Margin = new System.Windows.Forms.Padding(2);
            this.nm_foodCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nm_foodCount.Name = "nm_foodCount";
            this.nm_foodCount.Size = new System.Drawing.Size(50, 22);
            this.nm_foodCount.TabIndex = 2;
            this.nm_foodCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_addFood
            // 
            this.btn_addFood.BackColor = System.Drawing.Color.Brown;
            this.btn_addFood.Font = new System.Drawing.Font("iCiel Brush Up", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addFood.ForeColor = System.Drawing.Color.White;
            this.btn_addFood.Location = new System.Drawing.Point(282, 4);
            this.btn_addFood.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addFood.Name = "btn_addFood";
            this.btn_addFood.Size = new System.Drawing.Size(124, 53);
            this.btn_addFood.TabIndex = 1;
            this.btn_addFood.Text = "Thêm món";
            this.btn_addFood.UseVisualStyleBackColor = false;
            this.btn_addFood.Click += new System.EventHandler(this.btn_addFood_Click);
            // 
            // cb_Food
            // 
            this.cb_Food.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Food.FormattingEnabled = true;
            this.cb_Food.Location = new System.Drawing.Point(3, 33);
            this.cb_Food.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Food.Name = "cb_Food";
            this.cb_Food.Size = new System.Drawing.Size(193, 24);
            this.cb_Food.TabIndex = 0;
            this.cb_Food.SelectedIndexChanged += new System.EventHandler(this.cb_Food_SelectedIndexChanged);
            // 
            // cb_Category
            // 
            this.cb_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Category.FormattingEnabled = true;
            this.cb_Category.Location = new System.Drawing.Point(3, 3);
            this.cb_Category.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Category.Name = "cb_Category";
            this.cb_Category.Size = new System.Drawing.Size(193, 24);
            this.cb_Category.TabIndex = 0;
            this.cb_Category.SelectedIndexChanged += new System.EventHandler(this.cb_Category_SelectedIndexChanged);
            // 
            // flp_Talble
            // 
            this.flp_Talble.AutoScroll = true;
            this.flp_Talble.BackColor = System.Drawing.Color.Silver;
            this.flp_Talble.BackgroundImage = global::QuanLyCafe.Properties.Resources.Picture3;
            this.flp_Talble.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flp_Talble.Location = new System.Drawing.Point(22, 48);
            this.flp_Talble.Margin = new System.Windows.Forms.Padding(2);
            this.flp_Talble.Name = "flp_Talble";
            this.flp_Talble.Size = new System.Drawing.Size(482, 505);
            this.flp_Talble.TabIndex = 5;
            this.flp_Talble.Paint += new System.Windows.Forms.PaintEventHandler(this.flp_Talble_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(22, 526);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 27);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(370, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vui lòng chọn bàn, chọn đồ uống và click \'THÊM MÓN\'";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyCafe.Properties.Resources.back4;
            this.ClientSize = new System.Drawing.Size(954, 575);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flp_Talble);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mền quản lý quán Cà phê";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fTableManager_FormClosing);
            this.Load += new System.EventHandler(this.fTableManager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_disCount)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nm_foodCount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lv_Bill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cb_Category;
        private System.Windows.Forms.NumericUpDown nm_disCount;
        private System.Windows.Forms.Button btn_swicthTable;
        private System.Windows.Forms.ComboBox cb_switchTable;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.NumericUpDown nm_foodCount;
        private System.Windows.Forms.Button btn_addFood;
        private System.Windows.Forms.ComboBox cb_Food;
        private System.Windows.Forms.FlowLayoutPanel flp_Talble;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox tb_totalPrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_disCount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}