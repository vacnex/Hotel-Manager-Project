using QuanLyThuePhong.DungChung;
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
    public partial class Frm_ThuePhongModified : Form
    {
        DTO_ThuePhong _dTO_ThuePhong;
        DTO_Phong _dTO_Phong;

        ThuePhongFs _thuePhongFs;
        PhongFs _phongFs;

        public Frm_ThuePhongModified()
        {
            InitializeComponent();
        }

        private void Frm_ThuePhongModified_Load(object sender, EventArgs e)
        {
            _dTO_ThuePhong = new DTO_ThuePhong();
            _dTO_Phong = new DTO_Phong();

            _thuePhongFs = new ThuePhongFs();
            _phongFs = new PhongFs();

            GanDuLieuVaoControl();
        }

        #region Gán dữ liệu vào Control
        public string tempIdRoomBook, tempIdCard, tempIdRoom, tempStartDate; 
        private void GanDuLieuVaoControl()
        {
            var x = Convert.ToInt32(tempIdRoomBook) + 1;
            txt_MaThuePhong.Text = x.ToString();
            txt_CMND.Text = tempIdCard;
            txt_MaPhong.Text = tempIdRoom;
            txt_NgayDen.Text = tempStartDate;
            txt_NhanVien.Text = Cls_Main.tenNhanVien;
        }
        #endregion

        #region Gán dữ liệu từ Control vào DTO_ThuePhong
        private void GanDuLieuVaoDTO_ThuePhong()
        {
            _dTO_ThuePhong.IdRoomBook = txt_MaThuePhong.Text;
            _dTO_ThuePhong.IdCard = txt_CMND.Text;
            _dTO_ThuePhong.IdRoom = txt_MaPhong.Text;
            _dTO_ThuePhong.StartDate = txt_NgayDen.Text;
            _dTO_ThuePhong.EndDate = txt_NgayDi.Text;
            _dTO_ThuePhong.StaffName = txt_NhanVien.Text;
        }
        #endregion

        #region Gán dữ liệu vào DTO_Phong để cập nhật trạng thái
        public string tempRType, tempRPrice, tempRStatus;
        private void GanDuLieuVaoDTO_Phong()
        {            
            _dTO_Phong.IdRoom = tempIdRoom;
            _dTO_Phong.RType = tempRType;
            _dTO_Phong.RPrice = tempRPrice;
            _dTO_Phong.RStatus = tempRStatus;            
        }
        #endregion

        #region Nút lưu
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txt_NgayDen.Text) || !string.IsNullOrEmpty(txt_NgayDi.Text))
            {
                GanDuLieuVaoDTO_ThuePhong();
                _thuePhongFs.ThemThuePhong(_dTO_ThuePhong);
                GanDuLieuVaoDTO_Phong();
                _phongFs.CapNhatPhong(_dTO_Phong, txt_MaPhong.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!!!");
            }
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
