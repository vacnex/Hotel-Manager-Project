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

namespace QuanLyThuePhong.KhachHang
{
    public partial class Frm_KhachHangModified : Form
    {
        public Frm_KhachHangModified()
        {
            InitializeComponent();
        }
        KhachHangFs _khachHangFs;
        DTO_KhachHang _dTO_KhachHang;
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_KHM_idCard.Text) && !string.IsNullOrEmpty(txt_KHM_cusName.Text) && !string.IsNullOrEmpty(txt_KHM_cusAddress.Text) && !string.IsNullOrEmpty(cbb_KHM_cusGender.Text) && !string.IsNullOrEmpty(txt_KHM_cusPhone.Text))
            {
                GanDuLieuVaoDTO();
                _khachHangFs.ThemKhachHang(_dTO_KhachHang);
                _khachHangFs.CapNhatKhachHang(_dTO_KhachHang, txt_KHM_idCard.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin khách hàng!!!");
            }
        }

        

        private void Frm_KhachHangModified_Load(object sender, EventArgs e)
        {
            _khachHangFs = new KhachHangFs();
            _dTO_KhachHang = new DTO_KhachHang();
            GanDuLieuVaoTextBox();
        }
        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string tempIdCard, tempCusName, tempCusAddress, tempCusGender, tempCusPhone;
        private void GanDuLieuVaoTextBox()
        {
            txt_KHM_idCard.Text = tempIdCard;
            //txt_idCard.ReadOnly = true;
            txt_KHM_cusName.Text = tempCusName;
            //txt_cusName.ReadOnly = true;
            txt_KHM_cusAddress.Text = tempCusAddress;
            cbb_KHM_cusGender.Text = tempCusGender;
            //cbb_cusGender.Enabled = false;
            txt_KHM_cusPhone.Text = tempCusPhone;
        }
        private void GanDuLieuVaoDTO()
        {
            _dTO_KhachHang.IdCard = txt_KHM_idCard.Text;
            _dTO_KhachHang.CusName = txt_KHM_cusName.Text;
            _dTO_KhachHang.CusAddress = txt_KHM_cusAddress.Text;
            _dTO_KhachHang.CusPhone = txt_KHM_cusPhone.Text;
            _dTO_KhachHang.CusGender = cbb_KHM_cusGender.Text;
        }
    }
}
