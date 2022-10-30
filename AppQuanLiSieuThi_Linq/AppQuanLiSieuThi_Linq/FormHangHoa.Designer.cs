
namespace AppQuanLiSieuThi_Linq
{
    partial class FormHangHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHangHoa));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtYeuCau = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.cbxThuocTinh = new System.Windows.Forms.ComboBox();
            this.dgvHangHoa = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtLoaiHang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSLKho = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNhaCC = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGiaKM = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnTTNhapHang = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnTTGiaKM = new System.Windows.Forms.Button();
            this.btnTTNCC = new System.Windows.Forms.Button();
            this.btnTTLoaiHang = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtYeuCau);
            this.panel2.Controls.Add(this.btnTim);
            this.panel2.Controls.Add(this.cbxThuocTinh);
            this.panel2.Controls.Add(this.dgvHangHoa);
            this.panel2.Location = new System.Drawing.Point(334, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(570, 604);
            this.panel2.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label9.Location = new System.Drawing.Point(193, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 50;
            this.label9.Text = "Yêu Cầu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(35, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 49;
            this.label6.Text = "Thuộc Tính";
            // 
            // txtYeuCau
            // 
            this.txtYeuCau.Location = new System.Drawing.Point(162, 37);
            this.txtYeuCau.Name = "txtYeuCau";
            this.txtYeuCau.Size = new System.Drawing.Size(127, 20);
            this.txtYeuCau.TabIndex = 48;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.btnTim.FlatAppearance.BorderSize = 0;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(335, 12);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(121, 37);
            this.btnTim.TabIndex = 46;
            this.btnTim.TabStop = false;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // cbxThuocTinh
            // 
            this.cbxThuocTinh.FormattingEnabled = true;
            this.cbxThuocTinh.Items.AddRange(new object[] {
            "All ",
            "MaHang",
            "TenHang",
            "Gia",
            "GiaKM",
            "Soluongconkho",
            "MaLoaiHang",
            "MaNCC\t"});
            this.cbxThuocTinh.Location = new System.Drawing.Point(22, 36);
            this.cbxThuocTinh.Name = "cbxThuocTinh";
            this.cbxThuocTinh.Size = new System.Drawing.Size(121, 21);
            this.cbxThuocTinh.TabIndex = 47;
            // 
            // dgvHangHoa
            // 
            this.dgvHangHoa.AllowUserToAddRows = false;
            this.dgvHangHoa.AllowUserToDeleteRows = false;
            this.dgvHangHoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHangHoa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHangHoa.BackgroundColor = System.Drawing.Color.White;
            this.dgvHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangHoa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.dgvHangHoa.Location = new System.Drawing.Point(0, 63);
            this.dgvHangHoa.MultiSelect = false;
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.ReadOnly = true;
            this.dgvHangHoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHangHoa.Size = new System.Drawing.Size(581, 541);
            this.dgvHangHoa.TabIndex = 4;
            this.dgvHangHoa.TabStop = false;
            this.dgvHangHoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangHoa_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnHuy);
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnLuu);
            this.panel3.Location = new System.Drawing.Point(1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(333, 66);
            this.panel3.TabIndex = 42;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(268, 12);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(68, 36);
            this.btnHuy.TabIndex = 45;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(139, 12);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(68, 36);
            this.btnSua.TabIndex = 33;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(3, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(68, 36);
            this.btnThem.TabIndex = 30;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(74, 12);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(68, 36);
            this.btnXoa.TabIndex = 31;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(203, 12);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(68, 36);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtLoaiHang);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtGia);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtSLKho);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txtMaHang);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtNhaCC);
            this.panel4.Controls.Add(this.txtTenHang);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.txtGiaKM);
            this.panel4.Location = new System.Drawing.Point(1, 60);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(336, 544);
            this.panel4.TabIndex = 43;
            // 
            // txtLoaiHang
            // 
            this.txtLoaiHang.Location = new System.Drawing.Point(162, 227);
            this.txtLoaiHang.Name = "txtLoaiHang";
            this.txtLoaiHang.Size = new System.Drawing.Size(148, 20);
            this.txtLoaiHang.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(12, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "Loại Hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(10, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "Giá Hàng:";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(162, 102);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(148, 20);
            this.txtGia.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Mã hàng:";
            // 
            // txtSLKho
            // 
            this.txtSLKho.Location = new System.Drawing.Point(162, 187);
            this.txtSLKho.Name = "txtSLKho";
            this.txtSLKho.Size = new System.Drawing.Size(148, 20);
            this.txtSLKho.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(10, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Số Lượng Trong Kho:";
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(162, 15);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(148, 20);
            this.txtMaHang.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(10, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "Nhà Cung Cấp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(10, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tên Hàng:";
            // 
            // txtNhaCC
            // 
            this.txtNhaCC.Location = new System.Drawing.Point(162, 267);
            this.txtNhaCC.Name = "txtNhaCC";
            this.txtNhaCC.Size = new System.Drawing.Size(148, 20);
            this.txtNhaCC.TabIndex = 28;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(162, 59);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(148, 20);
            this.txtTenHang.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label8.Location = new System.Drawing.Point(10, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 17);
            this.label8.TabIndex = 36;
            this.label8.Text = "Giá Khuyễn Mãi:";
            // 
            // txtGiaKM
            // 
            this.txtGiaKM.Location = new System.Drawing.Point(162, 145);
            this.txtGiaKM.Name = "txtGiaKM";
            this.txtGiaKM.Size = new System.Drawing.Size(148, 20);
            this.txtGiaKM.TabIndex = 24;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnTTNhapHang);
            this.panel5.Controls.Add(this.btnLoad);
            this.panel5.Controls.Add(this.btnTTGiaKM);
            this.panel5.Controls.Add(this.btnTTNCC);
            this.panel5.Controls.Add(this.btnTTLoaiHang);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(901, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(207, 600);
            this.panel5.TabIndex = 52;
            // 
            // btnTTNhapHang
            // 
            this.btnTTNhapHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.btnTTNhapHang.FlatAppearance.BorderSize = 0;
            this.btnTTNhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTTNhapHang.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTTNhapHang.ForeColor = System.Drawing.Color.White;
            this.btnTTNhapHang.Location = new System.Drawing.Point(0, 203);
            this.btnTTNhapHang.Name = "btnTTNhapHang";
            this.btnTTNhapHang.Size = new System.Drawing.Size(203, 37);
            this.btnTTNhapHang.TabIndex = 51;
            this.btnTTNhapHang.TabStop = false;
            this.btnTTNhapHang.Text = "Thông Tin Nhập Hàng";
            this.btnTTNhapHang.UseVisualStyleBackColor = false;
            this.btnTTNhapHang.Click += new System.EventHandler(this.btnTTNhapHang_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(44, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(121, 37);
            this.btnLoad.TabIndex = 50;
            this.btnLoad.TabStop = false;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnTTGiaKM
            // 
            this.btnTTGiaKM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.btnTTGiaKM.FlatAppearance.BorderSize = 0;
            this.btnTTGiaKM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTTGiaKM.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTTGiaKM.ForeColor = System.Drawing.Color.White;
            this.btnTTGiaKM.Location = new System.Drawing.Point(0, 160);
            this.btnTTGiaKM.Name = "btnTTGiaKM";
            this.btnTTGiaKM.Size = new System.Drawing.Size(203, 37);
            this.btnTTGiaKM.TabIndex = 49;
            this.btnTTGiaKM.TabStop = false;
            this.btnTTGiaKM.Text = "Thông Tin Gía KM";
            this.btnTTGiaKM.UseVisualStyleBackColor = false;
            this.btnTTGiaKM.Click += new System.EventHandler(this.btnTTGiaKM_Click);
            // 
            // btnTTNCC
            // 
            this.btnTTNCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.btnTTNCC.FlatAppearance.BorderSize = 0;
            this.btnTTNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTTNCC.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTTNCC.ForeColor = System.Drawing.Color.White;
            this.btnTTNCC.Location = new System.Drawing.Point(0, 117);
            this.btnTTNCC.Name = "btnTTNCC";
            this.btnTTNCC.Size = new System.Drawing.Size(203, 37);
            this.btnTTNCC.TabIndex = 48;
            this.btnTTNCC.TabStop = false;
            this.btnTTNCC.Text = "Thông Tin Nhà Cung Cấp";
            this.btnTTNCC.UseVisualStyleBackColor = false;
            this.btnTTNCC.Click += new System.EventHandler(this.btnTTNCC_Click);
            // 
            // btnTTLoaiHang
            // 
            this.btnTTLoaiHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.btnTTLoaiHang.FlatAppearance.BorderSize = 0;
            this.btnTTLoaiHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTTLoaiHang.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTTLoaiHang.ForeColor = System.Drawing.Color.White;
            this.btnTTLoaiHang.Location = new System.Drawing.Point(0, 73);
            this.btnTTLoaiHang.Name = "btnTTLoaiHang";
            this.btnTTLoaiHang.Size = new System.Drawing.Size(203, 37);
            this.btnTTLoaiHang.TabIndex = 47;
            this.btnTTLoaiHang.TabStop = false;
            this.btnTTLoaiHang.Text = "Thông Tin Loại Hàng";
            this.btnTTLoaiHang.UseVisualStyleBackColor = false;
            this.btnTTLoaiHang.Click += new System.EventHandler(this.btnTTLoaiHang_Click);
            // 
            // FormHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 600);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "FormHangHoa";
            this.Text = "Quản Lý Hàng Hoá";
            this.Load += new System.EventHandler(this.FormHangHoa_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtYeuCau;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.ComboBox cbxThuocTinh;
        private System.Windows.Forms.DataGridView dgvHangHoa;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtLoaiHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSLKho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNhaCC;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGiaKM;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnTTNhapHang;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnTTGiaKM;
        private System.Windows.Forms.Button btnTTNCC;
        private System.Windows.Forms.Button btnTTLoaiHang;
    }
}