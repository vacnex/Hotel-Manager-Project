<<<<<<< HEAD
﻿using QuanLyThuePhong.KhachHang;
using QuanLyThuePhong.Phong;
=======
﻿using QuanLyThuePhong.Phong;
>>>>>>> 4d21d20113815121a1243192c32e3aeea5ea0b02
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
    public partial class Frm_TraPhong : Form
    {
        public Frm_TraPhong()
        {
            InitializeComponent();
        }
<<<<<<< HEAD

        PhongFs _phongFs;
        ThuePhongFs _thuePhongFs;
        KhachHangFs _khachHangFs;

        DTO_KhachHang _dTO_KhachHang;
        DTO_Phong _dTO_Phong;

        List<DTO_Phong> _listPhong;
        List<DTO_ThuePhong> _listThuePhong;
        private void Frm_TraPhong_Load(object sender, EventArgs e)
        {
            _phongFs = new PhongFs();
            _thuePhongFs = new ThuePhongFs();
            _khachHangFs = new KhachHangFs();

            _dTO_KhachHang = new DTO_KhachHang();
            _dTO_Phong = new DTO_Phong();

            HienThiDuLieu();
        }

        private void HienThiDuLieu()
        {
            HienThiDanhSachPhong();
            HienThiThongTinThuePhong();
        }

        #region Hiển thị thông tin thuê phòng
        private async void HienThiThongTinThuePhong()
        {
            _listThuePhong = await _thuePhongFs.GetThuePhong();
            dgv_ThuePhong.DataSource = _listThuePhong;
        }
        #endregion

        #region Hiển thị danh sách phòng
        private async void HienThiDanhSachPhong()
        {
            _listPhong = await _phongFs.GetPhong();            
            dgv_Phong.DataSource = _listPhong;
        }
        #region Tìm phòng
=======
        PhongFs _phongFs;

        DTO_Phong _dTO_Phong;

        List<DTO_Phong> _listPhong;
        private void Frm_TraPhong_Load(object sender, EventArgs e)
        {
            _phongFs = new PhongFs();

            _dTO_Phong = new DTO_Phong();

            HienThiDanhSachPhong();
        }

        private async void HienThiDanhSachPhong()
        {
            _listPhong = await _phongFs.GetPhong();
            var filtered = new List<DTO_Phong>();

            foreach (var item in _listPhong)
            {
                if (item.RStatus.Trim().Equals("Có khách"))
                {
                    filtered.Add(item);
                }
            }
            dgv_Phong.DataSource = filtered;
        }
>>>>>>> 4d21d20113815121a1243192c32e3aeea5ea0b02
        private void HienThiPhongTheoMaPhong()
        {
            if (_phongFs.GetPhongTheoMaPhong(txt_MaPhong.Text))
            {
                var filtered = new List<DTO_Phong>();

                foreach (var item in _listPhong)
                {
                    if (item.IdRoom.Trim().Equals(txt_MaPhong.Text))
                    {
                        filtered.Add(item);
                    }
                }
                dgv_Phong.DataSource = filtered;
            }
        }
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            HienThiPhongTheoMaPhong();
        }
<<<<<<< HEAD
        #endregion
        #endregion

        #region Làm mới dữ liệu
=======

>>>>>>> 4d21d20113815121a1243192c32e3aeea5ea0b02
        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            HienThiDanhSachPhong();
        }
<<<<<<< HEAD
        #endregion

        #region Lấy thông tin khách hàng
        private void dgv_ThuePhong_Click(object sender, EventArgs e)
        {
            _dTO_KhachHang.IdCard = dgv_ThuePhong.CurrentRow.Cells["colIdCard"].Value.ToString();
            var rs =  _khachHangFs.GetKhachHangById(_dTO_KhachHang.IdCard);
            txt_CMND.Text = rs.IdCard;
            txt_HoTen.Text = rs.CusName;
            txt_DiaChi.Text = rs.CusAddress;
            txt_SDT.Text = rs.CusPhone;
            txt_GioiTinh.Text = rs.CusGender;
        }
        #endregion

        #region Nút trả phòng
        private void btn_TraPhong_Click(object sender, EventArgs e)
        {
            DateTime ngayHienTai = DateTime.Now;
            DateTime ngayDi = new DateTime();
            _dTO_Phong.IdRoom = dgv_Phong.CurrentRow.Cells["colIdRoom"].Value.ToString();
            for (int i = 0; i < dgv_ThuePhong.RowCount; i++)
            {
                if (String.Compare(dgv_ThuePhong.Rows[i].Cells["colIdRoom1"].Value.ToString(), _dTO_Phong.IdRoom, true) == 0)
                {
                    var tempNgayDi = dgv_ThuePhong.Rows[i].Cells["colEndDate"].Value.ToString();
                    ngayDi = Convert.ToDateTime(tempNgayDi);                    
                }
            }
            int cmp = ngayHienTai.CompareTo(ngayDi);
            if (cmp >= 0)
            {
                GanDuLieuVaoDTO_Phong();
                _phongFs.CapNhatPhong(_dTO_Phong, _dTO_Phong.IdRoom);
                MessageBox.Show("Hoàn tất trả phòng.");
            }
        }

        private void GanDuLieuVaoDTO_Phong()
        {
            _dTO_Phong.RType = dgv_Phong.CurrentRow.Cells["colRType"].Value.ToString();
            _dTO_Phong.RPrice = dgv_Phong.CurrentRow.Cells["colRPrice"].Value.ToString();
            _dTO_Phong.RStatus = "Trống";
        }
        #endregion

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            Frm_ThanhToan _frm_ThanhToan = new Frm_ThanhToan();
            _frm_ThanhToan.tempIdRoomBook = dgv_ThuePhong.CurrentRow.Cells["colIdRoomBook"].Value.ToString();
            _frm_ThanhToan.tempIdCard = dgv_ThuePhong.CurrentRow.Cells["colIdCard"].Value.ToString();
            _frm_ThanhToan.tempIdRoom = dgv_ThuePhong.CurrentRow.Cells["colIdRoom1"].Value.ToString();
            _frm_ThanhToan.tempStartDate = dgv_ThuePhong.CurrentRow.Cells["colStartDate"].Value.ToString();
            _frm_ThanhToan.tempEndDate = dgv_ThuePhong.CurrentRow.Cells["colEndDate"].Value.ToString();
            _frm_ThanhToan.tempStaffName = dgv_ThuePhong.CurrentRow.Cells["colStaffName"].Value.ToString();
            _frm_ThanhToan.ShowDialog();
        }
=======
>>>>>>> 4d21d20113815121a1243192c32e3aeea5ea0b02
    }
}
