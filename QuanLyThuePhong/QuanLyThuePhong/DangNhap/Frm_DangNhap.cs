using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuePhong.DangNhap
{
    public partial class Frm_DangNhap : Form
    {
        public Frm_DangNhap()
        {
            InitializeComponent();
        }
        TaiKhoanFs _taiKhoanFs;
        DTO_TaiKhoan _dTO_TaiKhoan;
        private void Frm_DangNhap_Load(object sender, EventArgs e)
        {
            _taiKhoanFs = new TaiKhoanFs();
            _dTO_TaiKhoan = new DTO_TaiKhoan();
        }
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            _dTO_TaiKhoan = _taiKhoanFs.GetTaiKhoanTheoTenDangNhap(txt_TenDangNhap.Text);

            if (txt_TenDangNhap.Text == _dTO_TaiKhoan.Username && txt_MatKhau.Text == _dTO_TaiKhoan.Pass)
            {
                this.Close();
                MessageBox.Show("Đăng nhập thành công!!!");
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!!!");
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }        
    }
}
