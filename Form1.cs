using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseRegistrationApp
{
    public partial class FrmDangKy : Form
    {
        private readonly Dictionary<string, decimal> _hocPhi = new Dictionary<string, decimal>
        {
            { "C# WinForms cơ bản", 800000 },
            { "SQL Server cơ bản", 700000 },
            { "Web Frontend cơ bản", 750000 },
            { "Lập trình Python cơ bản", 650000 }
        };
        private readonly CultureInfo _vi = new CultureInfo("vi-VN");
        public FrmDangKy()
        {
            InitializeComponent();  
        }
        private void frmDangKy_Load(object sender, EventArgs e)
        {
            numSoThang.Minimum = 1;
            numSoThang.Maximum = 12;
            numSoThang.Value = 1;

            cboKhoaHoc.Items.Clear();
            foreach (string tenKhoa in _hocPhi.Keys)
                cboKhoaHoc.Items.Add(tenKhoa);
            cboKhoaHoc.SelectedIndex = 0;

            radOnline.Checked = true;
            CapNhatTongTien();
        }
        private decimal TinhTongTien()
        {
            if (cboKhoaHoc.SelectedIndex < 0) return 0;
            string tenKhoa = cboKhoaHoc.SelectedItem.ToString();
            return _hocPhi[tenKhoa] * numSoThang.Value;
        }

        private void CapNhatTongTien()
        {
            lblTongTien.Text = TinhTongTien().ToString("N0", _vi) + " VNĐ";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void cboKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatTongTien();
        }

        private void numSoThang_ValueChanged(object sender, EventArgs e)
        {
            CapNhatTongTien();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            string soDienThoai = txtSoDienThoai.Text.Trim();

            if (hoTen == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên.", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }
            if (soDienThoai == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại.", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDienThoai.Focus();
                return;
            }
            if (cboKhoaHoc.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn khóa học.", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboKhoaHoc.Focus();
                return;
            }

            string hinhThuc = radOnline.Checked ? "Online" : "Trực tiếp";
            string nhanEmail = chkNhanEmail.Checked ? "Có" : "Không";

            string phieu =
                "Họ tên: " + hoTen + Environment.NewLine +
                "Số điện thoại: " + soDienThoai + Environment.NewLine +
                "Ngày sinh: " + dtpNgaySinh.Value.ToString("dd/MM/yyyy") + Environment.NewLine +
                "Khóa học: " + cboKhoaHoc.SelectedItem + Environment.NewLine +
                "Hình thức: " + hinhThuc + Environment.NewLine +
                "Số tháng: " + numSoThang.Value + Environment.NewLine +
                "Tổng tiền: " + TinhTongTien().ToString("N0", _vi) + " VNĐ" + Environment.NewLine +
                "Nhận email thông báo: " + nhanEmail;

            MessageBox.Show(phieu, "PHIẾU ĐĂNG KÝ",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            txtSoDienThoai.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            chkNhanEmail.Checked = false;
            cboKhoaHoc.SelectedIndex = 0;
            radOnline.Checked = true;
            numSoThang.Value = 1;
            CapNhatTongTien();
            txtHoTen.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc muốn thoát chương trình?",
                "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
                this.Close();
        }

    }
}
