using QuanLyThuePhong.DangNhap;
using QuanLyThuePhong.DungChung;
using QuanLyThuePhong.KhachHang;
using QuanLyThuePhong.Phong;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        DTO_ThuePhong _dTO_ThuePhong;

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

            _dTO_ThuePhong = new DTO_ThuePhong();
            _dTO_Phong = new DTO_Phong();

            HienThiDuLieu();
            txt_NhanVien.Text = Cls_Main.tenNhanVien;
            btn_ChonPhong.Enabled = false;
            btn_ThuePhong.Enabled = false;
        }
        private void HienThiDuLieu()
        {
            HienThiDanhSachKhachHang();
            HienThiDanhSachPhong();
            HienThiDanhSachThuePhong();
            
        }
        private async void HienThiDanhSachKhachHang()
        {
            listKhachHang = await _khachHangFs.GetKhachHang();
            dgv_KhachHang.DataSource = listKhachHang;
        }
        private async void HienThiDanhSachPhong()
        {
            listPhong = await _phongFs.GetPhong();
            dgv_Phong.DataSource = listPhong;

            List<string> a = new List<string>();
            for (int i = 0; i < dgv_Phong.RowCount; i++)
            {
                a.Add("-- Chọn loại -- ");
                a.Add(dgv_Phong.Rows[i].Cells["colRType"].Value.ToString());
            }
            List<string> b = a.Distinct().ToList();
            var rs = new BindingSource();
            rs.DataSource = b;
            cbb_LoaiPhong.DataSource = rs.DataSource;
        }
        private async void HienThiDanhSachThuePhong()
        {
            listThuePhong = await _thuePhongFs.GetThuePhong();
            dgv_ThuePhong.DataSource = listThuePhong;
        }                
        private async void btn_TimKiem_Click(object sender, EventArgs e)
        {
            if(dgv_KhachHang.RowCount > 0)
            {
                var result = await _khachHangFs.GetKhachHangById(txt_CMND.Text);
                dgv_KhachHang.DataSource = result;
            }
        }
        private void btn_ChonKhachHang_Click(object sender, EventArgs e)
        {
            _dTO_ThuePhong.IdCard = dgv_KhachHang.CurrentRow.Cells["colidCard"].Value.ToString();
            btn_ChonKhachHang.Enabled = false;
            btn_ChonPhong.Enabled = true;
        }
        private void cbb_LoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            var filtered = new List<DTO_Phong>();

            foreach (var item in listPhong)
            {
                if (item.RType.Trim().Equals(cbb_LoaiPhong.SelectedItem.ToString()) )
                {
                    filtered.Add(item);
                }
            }
            dgv_Phong.DataSource = filtered;
        }
        private void btn_ChonPhong_Click(object sender, EventArgs e)
        {    
            if(dgv_Phong.CurrentRow.Cells["colRStatus"].Value.ToString().Trim().Equals("Có khách"))
            {
                MessageBox.Show("Phòng này đã có khách!!!");
            }
            else
            {
                _dTO_ThuePhong.IdRoom = dgv_Phong.CurrentRow.Cells["colIdRoom"].Value.ToString();
                _dTO_ThuePhong.StartDate = DateTime.Now.Date.ToString();
                btn_ThuePhong.Enabled = true;
            }            
        }
        private void GanDuLieuVaoDTO_Phong()
        {
            var status = "Có khách";
            _dTO_Phong.IdRoom = dgv_Phong.CurrentRow.Cells["colIdRoom"].Value.ToString();
            _dTO_Phong.RType = dgv_Phong.CurrentRow.Cells["colRType"].Value.ToString();
            _dTO_Phong.RPrice = dgv_Phong.CurrentRow.Cells["colRPrice"].Value.ToString();
            _dTO_Phong.RStatus = status;
        }
        private async void btn_ThuePhong_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_NhanVien.Text) || string.IsNullOrEmpty(txt_IdRoomBook.Text) || string.IsNullOrEmpty(txt_NgayDi.Text))
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin thuê phòng!!!");
            }
            else
            {
                _dTO_ThuePhong.IdRoomBook = txt_IdRoomBook.Text;
                _dTO_ThuePhong.StaffName = txt_NhanVien.Text;
                _dTO_ThuePhong.EndDate = txt_NgayDi.Text;
                _thuePhongFs.ThemThuePhong(_dTO_ThuePhong);
                var listThuePhong = await _thuePhongFs.GetThuePhong();
                dgv_ThuePhong.DataSource = listThuePhong;
                GanDuLieuVaoDTO_Phong();
                _phongFs.CapNhatPhong(_dTO_Phong, dgv_Phong.CurrentRow.Cells["colIdRoom"].Value.ToString());
                listPhong = await _phongFs.GetPhong();
                dgv_Phong.DataSource = listPhong;
            }

        }
        private void btn_ThemKhachHang_Click(object sender, EventArgs e)
        {
            Frm_KhachHangModified _frm_KhachHangModified = new Frm_KhachHangModified();
            _frm_KhachHangModified.ShowDialog();
        }
    }
}
