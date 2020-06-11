using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuePhong.Phong
{
    public partial class Frm_PhongModified : Form
    {
        public Frm_PhongModified()
        {
            InitializeComponent();
        }
        PhongFs _PhongFs;
        DTO_Phong _DTO_Phong;
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_PM_idRoom.Text) && !string.IsNullOrEmpty(txt_PM_rPrice.Text) && !string.IsNullOrEmpty(cbb_PM_rStatus.Text) && !string.IsNullOrEmpty(cbb_PM_rType.Text))
            {
                GanDuLieuVaoDTO();
                _PhongFs.ThemPhong(_DTO_Phong);
                _PhongFs.CapNhatPhong(_DTO_Phong, txt_PM_idRoom.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin phòng!!!");
            }
        }
        private void Frm_PhongModified_Load(object sender, EventArgs e)
        {
            _PhongFs = new PhongFs();
            _DTO_Phong = new DTO_Phong();
            GanDuLieuVaoTextBox();
        }
        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string tempIdRoom, tempRType, tempRPrice, tempRStatus;

        private void GanDuLieuVaoTextBox()
        {
            txt_PM_idRoom.Text = tempIdRoom;
            txt_PM_rPrice.Text = tempRPrice;
            cbb_PM_rStatus.Text = tempRStatus;
            cbb_PM_rType.Text = tempRType;
        }
        private void GanDuLieuVaoDTO()
        {
            _DTO_Phong.IdRoom = txt_PM_idRoom.Text;
            _DTO_Phong.RPrice = txt_PM_rPrice.Text;
            _DTO_Phong.RStatus = cbb_PM_rStatus.Text;
            _DTO_Phong.RType = cbb_PM_rType.Text;
        }
    }
}
