using QuanLyThuePhong.DangNhap;
using QuanLyThuePhong.DungChung;
using QuanLyThuePhong.KhachHang;
using QuanLyThuePhong.Phong;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuePhong.ThuePhong
{
    public partial class Frm_ThuePhong : Form
    {
        public Frm_ThuePhong()
        {
            InitializeComponent();
        }
        DTO_Phong _dTO_Phong;

        KhachHangFs _khachHangFs;
        PhongFs _phongFs;
        ThuePhongFs _thuePhongFs;

        List<DTO_KhachHang> listKhachHang;
        List<DTO_Phong> listPhong;
        List<DTO_ThuePhong> listThuePhong;
        private void Frm_ThuePhong_Load(object sender, EventArgs e)
        {
            _khachHangFs = new KhachHangFs();
            _phongFs = new PhongFs();
            _thuePhongFs = new ThuePhongFs();

            _dTO_Phong = new DTO_Phong();
            
            HienThiDuLieu();
        }
        #region Hiển thị tất cả dữ liệu
        private void HienThiDuLieu()
        {
            HienThiDanhSachKhachHang();
            HienThiDanhSachPhong();
            HienThiDanhSachThuePhong();
        }
        #endregion
        #region Hiển thị danh sách khách hàng
        private async void HienThiDanhSachKhachHang()
        {
            listKhachHang = await _khachHangFs.GetKhachHang();
            dgv_KhachHang.DataSource = listKhachHang;
        }

        #endregion
        #region Hiển thị danh sách phòng
        private async void HienThiDanhSachPhong()
        {
            listPhong = await _phongFs.GetPhong();
            dgv_Phong.DataSource = listPhong;
            List<string> a = new List<string>();
            for (int i = 0; i < dgv_Phong.RowCount; i++)
            {
                a.Add("-- Chọn loại -- ");
                a.Add(dgv_Phong.Rows[i].Cells["colRType"].Value.ToString().ToLower());
            }
            List<string> b = a.Distinct().ToList();
            var rs = new BindingSource();
            rs.DataSource = b;
            cbb_LoaiPhong.DataSource = rs.DataSource;
        }

        #endregion
        #region Hiển thị thông tin thuê phòng
        private async void HienThiDanhSachThuePhong()
        {
            listThuePhong = await _thuePhongFs.GetThuePhong();
            dgv_ThuePhong.DataSource = listThuePhong;
        }

        #endregion
        #region Gán dữ liệu vào biến tạm để truyền Form (DTO_ThuePhong)
        private string tempIdRoomBook, tempIdCard, tempIdRoom;
        private void GanDuLieuVaoTempThuePhong()
        {
            var index = dgv_ThuePhong.RowCount - 1;
            tempIdRoomBook = dgv_ThuePhong.Rows[index].Cells["colIdRoomBook"].Value.ToString();
            tempIdCard = dgv_KhachHang.CurrentRow.Cells["colidCard"].Value.ToString();
            tempIdRoom = dgv_Phong.CurrentRow.Cells["colIdRoom"].Value.ToString();            
        }
        #endregion
        #region Gán dữ liệu vào biến tạm để truyền Form (DTO_Phong)
        private string tempRType, tempRPrice;
        private void GanDuLieuVaoTempPhong()
        {
            tempRType = dgv_Phong.CurrentRow.Cells["colRType"].Value.ToString();
            tempRPrice = dgv_Phong.CurrentRow.Cells["colRPrice"].Value.ToString();
        }
        #endregion
        #region Nút đặt phòng
        private void btn_DatPhong_Click(object sender, EventArgs e)
        {
            string a = dgv_Phong.CurrentRow.Cells["colRStatus"].Value.ToString();            
            if (String.Compare(a, "có khách", true) == 0)
            {
                MessageBox.Show("Phòng này đã có khách!!!");
            }
            else if (String.Compare(a, "đã đặt", true) == 0)
            {
                MessageBox.Show("Phòng này đã được đặt!!!");
            }
            else
            {                                
                Frm_ThuePhongModified _frm_ThuePhongModified = new Frm_ThuePhongModified();
                GanDuLieuVaoTempThuePhong();
                _frm_ThuePhongModified.tempIdRoomBook = tempIdRoomBook;
                _frm_ThuePhongModified.tempIdCard = tempIdCard;
                _frm_ThuePhongModified.tempIdRoom = tempIdRoom;
                GanDuLieuVaoTempPhong();
                _frm_ThuePhongModified.tempRType = tempRType;
                _frm_ThuePhongModified.tempRPrice = tempRPrice;
                _frm_ThuePhongModified.tempRStatus = "Đã Đặt";
                _frm_ThuePhongModified.ShowDialog();
            }            
        }
        #endregion
        #region Nút thuê phòng        
        private void btn_ThuePhong_Click(object sender, EventArgs e)
        {
            string a = dgv_Phong.CurrentRow.Cells["colRStatus"].Value.ToString();
            if (String.Compare(a, "có khách", true) == 0)
            {
                MessageBox.Show("Phòng này đã có khách!!!");
            }
            else if (String.Compare(a, "đã đặt", true) == 0)
            {
                MessageBox.Show("Phòng này đã được đặt!!!");
            }
            else
            {
                Frm_ThuePhongModified _frm_ThuePhongModified = new Frm_ThuePhongModified();
                GanDuLieuVaoTempThuePhong();
                _frm_ThuePhongModified.tempIdRoomBook = tempIdRoomBook;
                _frm_ThuePhongModified.tempIdCard = tempIdCard;
                _frm_ThuePhongModified.tempIdRoom = tempIdRoom;
                _frm_ThuePhongModified.tempStartDate = DateTime.Now.ToShortDateString();
                GanDuLieuVaoTempPhong();
                _frm_ThuePhongModified.tempRType = tempRType;
                _frm_ThuePhongModified.tempRPrice = tempRPrice;
                _frm_ThuePhongModified.tempRStatus = "Có khách";
                _frm_ThuePhongModified.ShowDialog();
            }
        }
        #endregion
        #region Combobox loại phòng
        private void cbb_LoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            var filtered = new List<DTO_Phong>();

            foreach (var item in listPhong)
            {
                if (String.Compare(item.RType.ToString(), cbb_LoaiPhong.Text, true) == 0)
                {
                    filtered.Add(item);
                }
            }
            dgv_Phong.DataSource = filtered;
        }      
        #endregion
        #region Làm mới dữ liệu
        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }
        #endregion
        #region Thêm khách hàng mới
        private void btn_ThemKhachHang_Click(object sender, EventArgs e)
        {
            Frm_KhachHangModified _frm_KhachHangModified = new Frm_KhachHangModified();
            _frm_KhachHangModified.ShowDialog();
        }      
        #endregion
        #region Tìm kiếm khách hàng
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            var filtered = new List<DTO_KhachHang>();
            if (dgv_KhachHang.RowCount > 0)
            {
                foreach (var item in listKhachHang)
                {
                    if (string.Compare(item.IdCard.ToString(),txt_CMND.Text,true) == 0)
                    {
                        filtered.Add(item);
                    }
                }
                dgv_KhachHang.DataSource = filtered;
            }
            else
            {
                MessageBox.Show("Không có dữ liệu.");
            }
        }       
        #endregion
        #region Nút nhận phòng
        private void btn_NhanPhong_Click(object sender, EventArgs e)
        {
            DateTime x = DateTime.Now;
            DateTime y = new DateTime();
            DateTime z = new DateTime();
            if (!string.IsNullOrEmpty(txt_MaThuePhong.Text))
            {
                for (int i = 0; i < dgv_ThuePhong.RowCount; i++)
                {
                    if (dgv_ThuePhong.Rows[i].Cells["colIdRoomBook"].Value.ToString().Equals(txt_MaThuePhong.Text))
                    {
                        var a = dgv_ThuePhong.Rows[i].Cells["colNgayDen"].Value.ToString();
                        var b = dgv_ThuePhong.Rows[i].Cells["colNgayDi"].Value.ToString();
                        y = DateTime.Parse(a);
                        z = DateTime.Parse(b);
                        _dTO_Phong.IdRoom = dgv_ThuePhong.Rows[i].Cells["colMaPhong"].Value.ToString();
                    }
                }
                int cmp = x.ToString().CompareTo(y.ToString());
                int cmp1 = x.ToString().CompareTo(z.ToString());
                
                if ((cmp > 0 || cmp == 0) && cmp1 < 0)
                {
                    GanDuLieuVaoDTO_Phong();
                    _phongFs.CapNhatPhong(_dTO_Phong, _dTO_Phong.IdRoom);
                    MessageBox.Show("Thành công.");
                }
                else
                {
                    MessageBox.Show("Ngày nhận phòng không hợp lệ.");
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập mã thuê phòng.");
            }
            
                 
        }

        private void GanDuLieuVaoDTO_Phong()
        {
            _dTO_Phong.RType = dgv_Phong.CurrentRow.Cells["colRType"].Value.ToString();
            _dTO_Phong.RPrice = dgv_Phong.CurrentRow.Cells["colRPrice"].Value.ToString();
            _dTO_Phong.RStatus = "Có khách";
        }
        #endregion
        #region Nút hủy đặt phòng
        private void btn_HuyDatPhong_Click(object sender, EventArgs e)
        {
            string x = DateTime.Now.ToShortDateString();
            string y = string.Empty;
            for (int i = 0; i < dgv_ThuePhong.RowCount; i++)
            {
                if (dgv_ThuePhong.Rows[i].Cells["colIdRoomBook"].Value.ToString().Equals(txt_MaThuePhong.Text))
                {
                    y = dgv_ThuePhong.Rows[i].Cells["colNgayDen"].Value.ToString();
                }
            }
            int cmp = x.CompareTo(y);
            if (cmp > 0)
            {
                GanDuLieuVaoDTO_Phong();
                _phongFs.CapNhatPhong(_dTO_Phong, _dTO_Phong.IdRoom);
            }
            else
            {
                MessageBox.Show("Ngày hủy phòng không hợp lệ.");
            }
        }
        #endregion
        #region Nút tra cứu thông tin đặt phòng
        private void btn_TraCuu_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_MaThuePhong.Text))
            {
                for (int i = 0; i < dgv_ThuePhong.RowCount; i++)
                {
                    if (dgv_ThuePhong.Rows[i].Cells["colIdRoomBook"].Value.ToString().Equals(txt_MaThuePhong.Text))
                    {
                        _dTO_Phong.IdRoom = dgv_ThuePhong.Rows[i].Cells["colMaPhong"].Value.ToString();
                        var filtered = new List<DTO_ThuePhong>();
                        foreach (var item in listThuePhong)
                        {
                            if (string.Compare(item.IdRoomBook.ToString(), txt_MaThuePhong.Text, true) == 0)
                            {
                                filtered.Add(item);
                            }
                        }
                        dgv_ThuePhong.DataSource = filtered;
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập mã thuê phòng.");
            }
        }
        #endregion
    }
}
