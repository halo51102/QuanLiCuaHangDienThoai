
namespace QuanLiCuaHangDienThoai
{
    partial class QuanLy
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
            this.tabControl_QuanLy = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView_DoanhThu = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_ThongKe = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label_TongDoanhThu = new System.Windows.Forms.Label();
            this.label_TrungBinh = new System.Windows.Forms.Label();
            this.dataGridView_SanPham = new System.Windows.Forms.DataGridView();
            this.dataGridView_DanhMuc = new System.Windows.Forms.DataGridView();
            this.dataGridView_TaiKhoan = new System.Windows.Forms.DataGridView();
            this.dataGridView_NhaCC = new System.Windows.Forms.DataGridView();
            this.tabControl_QuanLy.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DoanhThu)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DanhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NhaCC)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_QuanLy
            // 
            this.tabControl_QuanLy.Controls.Add(this.tabPage1);
            this.tabControl_QuanLy.Controls.Add(this.tabPage2);
            this.tabControl_QuanLy.Controls.Add(this.tabPage3);
            this.tabControl_QuanLy.Controls.Add(this.tabPage4);
            this.tabControl_QuanLy.Controls.Add(this.tabPage5);
            this.tabControl_QuanLy.Location = new System.Drawing.Point(54, 35);
            this.tabControl_QuanLy.Name = "tabControl_QuanLy";
            this.tabControl_QuanLy.SelectedIndex = 0;
            this.tabControl_QuanLy.Size = new System.Drawing.Size(682, 336);
            this.tabControl_QuanLy.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label_TrungBinh);
            this.tabPage1.Controls.Add(this.label_TongDoanhThu);
            this.tabPage1.Controls.Add(this.dataGridView_DoanhThu);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(674, 307);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Doanh thu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView_DoanhThu
            // 
            this.dataGridView_DoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DoanhThu.Location = new System.Drawing.Point(159, 16);
            this.dataGridView_DoanhThu.Name = "dataGridView_DoanhThu";
            this.dataGridView_DoanhThu.RowHeadersWidth = 51;
            this.dataGridView_DoanhThu.RowTemplate.Height = 24;
            this.dataGridView_DoanhThu.Size = new System.Drawing.Size(488, 186);
            this.dataGridView_DoanhThu.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_ThongKe);
            this.panel1.Location = new System.Drawing.Point(17, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(111, 268);
            this.panel1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView_SanPham);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(674, 307);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sản Phẩm";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_ThongKe
            // 
            this.button_ThongKe.Location = new System.Drawing.Point(20, 82);
            this.button_ThongKe.Name = "button_ThongKe";
            this.button_ThongKe.Size = new System.Drawing.Size(75, 53);
            this.button_ThongKe.TabIndex = 0;
            this.button_ThongKe.Text = "Thống kê";
            this.button_ThongKe.UseVisualStyleBackColor = true;
            this.button_ThongKe.Click += new System.EventHandler(this.button_ThongKe_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView_DanhMuc);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(674, 307);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Danh mục";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView_TaiKhoan);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(674, 307);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Tài khoản đăng nhập";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridView_NhaCC);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(674, 307);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Nhà cung cấp";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label_TongDoanhThu
            // 
            this.label_TongDoanhThu.AutoSize = true;
            this.label_TongDoanhThu.Location = new System.Drawing.Point(159, 220);
            this.label_TongDoanhThu.Name = "label_TongDoanhThu";
            this.label_TongDoanhThu.Size = new System.Drawing.Size(41, 17);
            this.label_TongDoanhThu.TabIndex = 2;
            this.label_TongDoanhThu.Text = "Tổng";
            // 
            // label_TrungBinh
            // 
            this.label_TrungBinh.AutoSize = true;
            this.label_TrungBinh.Location = new System.Drawing.Point(156, 253);
            this.label_TrungBinh.Name = "label_TrungBinh";
            this.label_TrungBinh.Size = new System.Drawing.Size(77, 17);
            this.label_TrungBinh.TabIndex = 3;
            this.label_TrungBinh.Text = "Trung bình";
            // 
            // dataGridView_SanPham
            // 
            this.dataGridView_SanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SanPham.Location = new System.Drawing.Point(225, 42);
            this.dataGridView_SanPham.Name = "dataGridView_SanPham";
            this.dataGridView_SanPham.RowHeadersWidth = 51;
            this.dataGridView_SanPham.RowTemplate.Height = 24;
            this.dataGridView_SanPham.Size = new System.Drawing.Size(240, 150);
            this.dataGridView_SanPham.TabIndex = 0;
            // 
            // dataGridView_DanhMuc
            // 
            this.dataGridView_DanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DanhMuc.Location = new System.Drawing.Point(286, 52);
            this.dataGridView_DanhMuc.Name = "dataGridView_DanhMuc";
            this.dataGridView_DanhMuc.RowHeadersWidth = 51;
            this.dataGridView_DanhMuc.RowTemplate.Height = 24;
            this.dataGridView_DanhMuc.Size = new System.Drawing.Size(240, 150);
            this.dataGridView_DanhMuc.TabIndex = 0;
            // 
            // dataGridView_TaiKhoan
            // 
            this.dataGridView_TaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TaiKhoan.Location = new System.Drawing.Point(165, 26);
            this.dataGridView_TaiKhoan.Name = "dataGridView_TaiKhoan";
            this.dataGridView_TaiKhoan.RowHeadersWidth = 51;
            this.dataGridView_TaiKhoan.RowTemplate.Height = 24;
            this.dataGridView_TaiKhoan.Size = new System.Drawing.Size(482, 218);
            this.dataGridView_TaiKhoan.TabIndex = 0;
            // 
            // dataGridView_NhaCC
            // 
            this.dataGridView_NhaCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_NhaCC.Location = new System.Drawing.Point(251, 88);
            this.dataGridView_NhaCC.Name = "dataGridView_NhaCC";
            this.dataGridView_NhaCC.RowHeadersWidth = 51;
            this.dataGridView_NhaCC.RowTemplate.Height = 24;
            this.dataGridView_NhaCC.Size = new System.Drawing.Size(240, 150);
            this.dataGridView_NhaCC.TabIndex = 0;
            // 
            // QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl_QuanLy);
            this.Name = "QuanLy";
            this.Text = "Quản lý";
            this.tabControl_QuanLy.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DoanhThu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DanhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NhaCC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_QuanLy;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView_DoanhThu;
        private System.Windows.Forms.Button button_ThongKe;
        private System.Windows.Forms.Label label_TrungBinh;
        private System.Windows.Forms.Label label_TongDoanhThu;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataGridView_SanPham;
        private System.Windows.Forms.DataGridView dataGridView_DanhMuc;
        private System.Windows.Forms.DataGridView dataGridView_TaiKhoan;
        private System.Windows.Forms.DataGridView dataGridView_NhaCC;
    }
}