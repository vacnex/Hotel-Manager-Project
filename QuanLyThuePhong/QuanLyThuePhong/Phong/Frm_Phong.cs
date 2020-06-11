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
    public partial class Frm_Phong : Form
    {
        public Frm_Phong()
        {
            InitializeComponent();
        }
        PhongFs _PhongFs;
        private void Frm_Phong_Load(object sender, EventArgs e)
        {
            _PhongFs = new PhongFs();
            HienThiDuLieuLenDGV();
        }
        private async void HienThiDuLieuLenDGV()
        {
            var listPhong = await _PhongFs.GetPhong();
            dgv_Phong.DataSource = listPhong;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            Frm_PhongModified _Frm_PhongModified = new Frm_PhongModified();
            _Frm_PhongModified.ShowDialog();
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var idRoomSelected = txt_QLP_idRoom.Text;
            _PhongFs.XoaPhong(idRoomSelected);
            HienThiDuLieuLenDGV();
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tempIdRoom))
            {
                Frm_PhongModified _Frm_PhongModified = new Frm_PhongModified();
                _Frm_PhongModified.tempIdRoom = tempIdRoom;
                _Frm_PhongModified.tempRType = tempRType;
                _Frm_PhongModified.tempRPrice = tempRPrice;
                _Frm_PhongModified.tempRStatus = tempRStatus;
                _Frm_PhongModified.Show(this);
                HienThiDuLieuLenDGV();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn thông tin khách hàng cần sửa!!!");
            }
        }
        private void GanDuLieuVaoTextBox()
        {
            if (dgv_Phong.Rows.Count > 0)
            {
                txt_QLP_idRoom.Text = dgv_Phong.CurrentRow.Cells["colIdRoom"].Value.ToString();
                txt_QLP_rPrice.Text = dgv_Phong.CurrentRow.Cells["colRPrice"].Value.ToString();
                cbb_QLP_rType.Text = dgv_Phong.CurrentRow.Cells["colRType"].Value.ToString();
                cbb_QLP_rStatus.Text = dgv_Phong.CurrentRow.Cells["colRStatus"].Value.ToString();
                txt_QLP_idRoom.ReadOnly = true;
                txt_QLP_rPrice.ReadOnly = true;
                cbb_QLP_rType.Enabled = false;
                cbb_QLP_rStatus.Enabled = false;
            }
        }
        private string tempIdRoom, tempRType, tempRPrice, tempRStatus;        
        private void dgv_Phong_Click(object sender, EventArgs e)
        {
            GanDuLieuVaoTextBox();
            GanDuLieuVaoDTO();
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void GanDuLieuVaoDTO()
        {
            if (dgv_Phong.Rows.Count > 0)
            {
                tempIdRoom = dgv_Phong.CurrentRow.Cells["colIdRoom"].Value.ToString();
                tempRType = dgv_Phong.CurrentRow.Cells["colRType"].Value.ToString();
                tempRPrice = dgv_Phong.CurrentRow.Cells["colRPrice"].Value.ToString();
                tempRStatus = dgv_Phong.CurrentRow.Cells["colRStatus"].Value.ToString();
            }
        }
    }
}
