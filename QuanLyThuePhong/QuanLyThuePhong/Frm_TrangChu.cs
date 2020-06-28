using QuanLyThuePhong.DangNhap;
using QuanLyThuePhong.DichVu;
using QuanLyThuePhong.DungChung;
using QuanLyThuePhong.KhachHang;
using QuanLyThuePhong.Phong;
using QuanLyThuePhong.ThuePhong;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuePhong
{
    public partial class Frm_TrangChu : Form
    {
        public Frm_TrangChu()
        {
            InitializeComponent();
        }
        private void Frm_TrangChu_Load(object sender, EventArgs e)
        {
            Frm_DangNhap _frm_DangNhap = new Frm_DangNhap();
            _frm_DangNhap.ShowDialog();
            lbl_TenNhanVien.Text = Cls_Main.tenNhanVien;
        }

        private void mnu_QLKhachHang_Click(object sender, EventArgs e)
        {
            Frm_KhachHang _frm_KhachHang = new Frm_KhachHang();
            _frm_KhachHang.ShowDialog();
        }

        private void mnu_QLPhong_Click(object sender, EventArgs e)
        {
            Frm_Phong _frm_Phong = new Frm_Phong();
            _frm_Phong.ShowDialog();
        }

        private void mnu_QLDichVu_Click(object sender, EventArgs e)
        {
            Frm_DichVu _frm_DichVu = new Frm_DichVu();
            _frm_DichVu.ShowDialog();
        }

        private void thuêPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ThuePhong _frm_ThuePhong = new Frm_ThuePhong();
            _frm_ThuePhong.ShowDialog();
        }
    }
}
