using Microsoft.Reporting.WinForms;
using QuanLyThuePhong.KhachHang;
using QuanLyThuePhong.Phong;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuePhong.ThuePhong
{
    public partial class Frm_ThanhToan : Form
    {
        public Frm_ThanhToan()
        {
            InitializeComponent();
        }

        ThuePhongFs _thuePhongFs;
        KhachHangFs _khachHangFs;
        PhongFs _phongFs;

        DTO_ThuePhong _dTO_ThuePhong;
        DTO_KhachHang _dTO_KhachHang;
        DTO_Phong _dTO_Phong;

        private void Frm_ThanhToan_Load(object sender, EventArgs e)
        {
            _thuePhongFs = new ThuePhongFs();
            _khachHangFs = new KhachHangFs();
            _phongFs = new PhongFs();

            _dTO_ThuePhong = new DTO_ThuePhong();
            _dTO_KhachHang = new DTO_KhachHang();
            _dTO_Phong = new DTO_Phong();

            GanDuLieuVaoConTrol();
        }

        #region Lấy thông tin thuê phòng
        public string tempIdRoomBook, tempIdCard, tempIdRoom, tempStartDate, tempEndDate, tempStaffName;       

        private void GanDuLieuVaoConTrol()
        {
            txt_MaThuePhong.Text = tempIdRoomBook;
            txt_MaPhong.Text = tempIdRoom;
            txt_NgayDen.Text = Convert.ToDateTime(tempStartDate).ToShortDateString();
            txt_NgayDi.Text = Convert.ToDateTime(tempEndDate).ToShortDateString();
            txt_NhanVien.Text = tempStaffName;
            LayThongTinKhachHang();
            LayThongTinPhong();
            txt_KhachHang.Text = _dTO_KhachHang.CusName;
            txt_GiaPhong.Text = _dTO_Phong.RPrice;
            var ngayDen = txt_NgayDen.Text.Substring(2, 1);
            var ngayDi = txt_NgayDi.Text.Substring(2, 1);
            txt_SoNgayThue.Text = (Convert.ToInt32(ngayDi) - Convert.ToInt32(ngayDen) + 1).ToString();
            txt_ThanhTien.Text = (Convert.ToInt32(txt_SoNgayThue.Text) * Convert.ToInt32(txt_GiaPhong.Text)).ToString();
        }

        private void LayThongTinPhong()
        {
            var phong = _phongFs.GetPhongById(txt_MaPhong.Text);
            _dTO_Phong.RPrice = phong.RPrice;
        }

        private void LayThongTinKhachHang()
        {
            var khacHang = _khachHangFs.GetKhachHangById(tempIdCard);
            _dTO_KhachHang.CusName = khacHang.CusName;
        }
        #endregion

        #region Nút in hóa đơn       
        private void btn_InHoaDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Nút thoát
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
