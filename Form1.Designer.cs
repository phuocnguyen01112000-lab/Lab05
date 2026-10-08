namespace CourseRegistrationApp
{
    partial class FrmDangKy
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
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.chkNhanEmail = new System.Windows.Forms.CheckBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.lbSDT = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lbHoten = new System.Windows.Forms.Label();
            this.gbKhoaHoc = new System.Windows.Forms.GroupBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTongHocPhi = new System.Windows.Forms.Label();
            this.numSoThang = new System.Windows.Forms.NumericUpDown();
            this.radOffline = new System.Windows.Forms.RadioButton();
            this.radOnline = new System.Windows.Forms.RadioButton();
            this.cboKhoaHoc = new System.Windows.Forms.ComboBox();
            this.lblSoThang = new System.Windows.Forms.Label();
            this.lblHinhThuc = new System.Windows.Forms.Label();
            this.lblKhoaHoc = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.gbThongTin.SuspendLayout();
            this.gbKhoaHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoThang)).BeginInit();
            this.SuspendLayout();
            // 
            // gbThongTin
            // 
            this.gbThongTin.Controls.Add(this.chkNhanEmail);
            this.gbThongTin.Controls.Add(this.txtEmail);
            this.gbThongTin.Controls.Add(this.lblEmail);
            this.gbThongTin.Controls.Add(this.dtpNgaySinh);
            this.gbThongTin.Controls.Add(this.lblNgaySinh);
            this.gbThongTin.Controls.Add(this.txtSoDienThoai);
            this.gbThongTin.Controls.Add(this.lbSDT);
            this.gbThongTin.Controls.Add(this.txtHoTen);
            this.gbThongTin.Controls.Add(this.lbHoten);
            this.gbThongTin.Location = new System.Drawing.Point(12, 12);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(847, 320);
            this.gbThongTin.TabIndex = 0;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thong tin hoc vien";
            this.gbThongTin.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chkNhanEmail
            // 
            this.chkNhanEmail.AutoSize = true;
            this.chkNhanEmail.Location = new System.Drawing.Point(151, 208);
            this.chkNhanEmail.Name = "chkNhanEmail";
            this.chkNhanEmail.Size = new System.Drawing.Size(190, 24);
            this.chkNhanEmail.TabIndex = 8;
            this.chkNhanEmail.Text = "Nhận thông báo email";
            this.chkNhanEmail.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(151, 166);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(268, 26);
            this.txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(43, 166);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            this.lblEmail.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(151, 120);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(274, 26);
            this.dtpNgaySinh.TabIndex = 5;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(43, 125);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(82, 20);
            this.lblNgaySinh.TabIndex = 4;
            this.lblNgaySinh.Text = "Ngày sinh:";
            this.lblNgaySinh.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(151, 76);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(268, 26);
            this.txtSoDienThoai.TabIndex = 3;
            this.txtSoDienThoai.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Location = new System.Drawing.Point(43, 82);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(106, 20);
            this.lbSDT.TabIndex = 2;
            this.lbSDT.Text = "Số điện thoại:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(151, 39);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(268, 26);
            this.txtHoTen.TabIndex = 1;
            // 
            // lbHoten
            // 
            this.lbHoten.AutoSize = true;
            this.lbHoten.Location = new System.Drawing.Point(43, 39);
            this.lbHoten.Name = "lbHoten";
            this.lbHoten.Size = new System.Drawing.Size(61, 20);
            this.lbHoten.TabIndex = 1;
            this.lbHoten.Text = "Họ tên:";
            // 
            // gbKhoaHoc
            // 
            this.gbKhoaHoc.Controls.Add(this.lblTongTien);
            this.gbKhoaHoc.Controls.Add(this.lblTongHocPhi);
            this.gbKhoaHoc.Controls.Add(this.numSoThang);
            this.gbKhoaHoc.Controls.Add(this.radOffline);
            this.gbKhoaHoc.Controls.Add(this.radOnline);
            this.gbKhoaHoc.Controls.Add(this.cboKhoaHoc);
            this.gbKhoaHoc.Controls.Add(this.lblSoThang);
            this.gbKhoaHoc.Controls.Add(this.lblHinhThuc);
            this.gbKhoaHoc.Controls.Add(this.lblKhoaHoc);
            this.gbKhoaHoc.Location = new System.Drawing.Point(12, 337);
            this.gbKhoaHoc.Name = "gbKhoaHoc";
            this.gbKhoaHoc.Size = new System.Drawing.Size(847, 366);
            this.gbKhoaHoc.TabIndex = 9;
            this.gbKhoaHoc.TabStop = false;
            this.gbKhoaHoc.Text = "Thong tin khoa hoc";
            this.gbKhoaHoc.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(182, 171);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(75, 20);
            this.lblTongTien.TabIndex = 13;
            this.lblTongTien.Text = "TongTien";
            // 
            // lblTongHocPhi
            // 
            this.lblTongHocPhi.AutoSize = true;
            this.lblTongHocPhi.Location = new System.Drawing.Point(43, 172);
            this.lblTongHocPhi.Name = "lblTongHocPhi";
            this.lblTongHocPhi.Size = new System.Drawing.Size(104, 20);
            this.lblTongHocPhi.TabIndex = 12;
            this.lblTongHocPhi.Text = "Tổng học phí:";
            // 
            // numSoThang
            // 
            this.numSoThang.Location = new System.Drawing.Point(182, 125);
            this.numSoThang.Name = "numSoThang";
            this.numSoThang.Size = new System.Drawing.Size(120, 26);
            this.numSoThang.TabIndex = 10;
            this.numSoThang.ValueChanged += new System.EventHandler(this.numSoThang_ValueChanged);
            // 
            // radOffline
            // 
            this.radOffline.AutoSize = true;
            this.radOffline.Location = new System.Drawing.Point(250, 78);
            this.radOffline.Name = "radOffline";
            this.radOffline.Size = new System.Drawing.Size(95, 24);
            this.radOffline.TabIndex = 11;
            this.radOffline.TabStop = true;
            this.radOffline.Text = "Trực tiếp";
            this.radOffline.UseVisualStyleBackColor = true;
            this.radOffline.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radOnline
            // 
            this.radOnline.AutoSize = true;
            this.radOnline.Checked = true;
            this.radOnline.Location = new System.Drawing.Point(165, 78);
            this.radOnline.Name = "radOnline";
            this.radOnline.Size = new System.Drawing.Size(79, 24);
            this.radOnline.TabIndex = 10;
            this.radOnline.TabStop = true;
            this.radOnline.Text = "Online";
            this.radOnline.UseVisualStyleBackColor = true;
            // 
            // cboKhoaHoc
            // 
            this.cboKhoaHoc.FormattingEnabled = true;
            this.cboKhoaHoc.Location = new System.Drawing.Point(165, 31);
            this.cboKhoaHoc.Name = "cboKhoaHoc";
            this.cboKhoaHoc.Size = new System.Drawing.Size(176, 28);
            this.cboKhoaHoc.TabIndex = 10;
            this.cboKhoaHoc.SelectedIndexChanged += new System.EventHandler(this.cboKhoaHoc_SelectedIndexChanged);
            // 
            // lblSoThang
            // 
            this.lblSoThang.AutoSize = true;
            this.lblSoThang.Location = new System.Drawing.Point(43, 127);
            this.lblSoThang.MaximumSize = new System.Drawing.Size(550, 550);
            this.lblSoThang.Name = "lblSoThang";
            this.lblSoThang.Size = new System.Drawing.Size(133, 20);
            this.lblSoThang.TabIndex = 4;
            this.lblSoThang.Text = "Số tháng đăng ký";
            this.lblSoThang.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblHinhThuc
            // 
            this.lblHinhThuc.AutoSize = true;
            this.lblHinhThuc.Location = new System.Drawing.Point(43, 78);
            this.lblHinhThuc.Name = "lblHinhThuc";
            this.lblHinhThuc.Size = new System.Drawing.Size(107, 20);
            this.lblHinhThuc.TabIndex = 2;
            this.lblHinhThuc.Text = "Hình thức học";
            this.lblHinhThuc.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblKhoaHoc
            // 
            this.lblKhoaHoc.AutoSize = true;
            this.lblKhoaHoc.Location = new System.Drawing.Point(43, 39);
            this.lblKhoaHoc.Name = "lblKhoaHoc";
            this.lblKhoaHoc.Size = new System.Drawing.Size(116, 20);
            this.lblKhoaHoc.TabIndex = 1;
            this.lblKhoaHoc.Text = "Chọn khóa học";
            this.lblKhoaHoc.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(879, 211);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(106, 40);
            this.btnDangKy.TabIndex = 11;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(879, 292);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(106, 40);
            this.btnLamMoi.TabIndex = 12;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(879, 376);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(106, 40);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FrmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 715);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.gbKhoaHoc);
            this.Controls.Add(this.gbThongTin);
            this.Name = "FrmDangKy";
            this.Text = "ĐĂNG KÝ KHÓA HỌC";
            this.Load += new System.EventHandler(this.frmDangKy_Load);
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.gbKhoaHoc.ResumeLayout(false);
            this.gbKhoaHoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoThang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lbHoten;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.CheckBox chkNhanEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox gbKhoaHoc;
        private System.Windows.Forms.ComboBox cboKhoaHoc;
        private System.Windows.Forms.Label lblSoThang;
        private System.Windows.Forms.Label lblHinhThuc;
        private System.Windows.Forms.Label lblKhoaHoc;
        private System.Windows.Forms.RadioButton radOffline;
        private System.Windows.Forms.RadioButton radOnline;
        private System.Windows.Forms.NumericUpDown numSoThang;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label lblTongHocPhi;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnThoat;
    }
}

