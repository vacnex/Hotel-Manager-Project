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
    public partial class Frm_KhachHang : Form
    {
        public Frm_KhachHang()
        {
            InitializeComponent();
        }
        KhachHangFs _khachHangFs;
        private void Frm_KhachHang_Load(object sender, EventArgs e)
        {
            _khachHangFs = new KhachHangFs();
            HienThiDuLieuLenDGV();
        }
        public async void HienThiDuLieuLenDGV()
        {
            var listKhachHang = await _khachHangFs.GetKhachHang();
            dgv_KhachHang.DataSource = listKhachHang;
        }
        private void dgv_KhachHang_Click(object sender, EventArgs e)
        {
            GanDuLieuVaoTextBox();
            GanDuLieuVaoDTO();
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            Frm_KhachHangModified _frm_KhachHangModified = new Frm_KhachHangModified();
            _frm_KhachHangModified.ShowDialog();
            HienThiDuLieuLenDGV();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var idCardSelected = Convert.ToInt32(txt_idCard.Text);
            _khachHangFs.XoaKhachHang(idCardSelected);
            HienThiDuLieuLenDGV();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            //var idCardSelected = Convert.ToInt32(txt_idCard.Text);
            if (!string.IsNullOrEmpty(tempIdCard))
            {
                Frm_KhachHangModified _frm_KhachHangModified = new Frm_KhachHangModified();
                _frm_KhachHangModified.tempIdCard = tempIdCard;
                _frm_KhachHangModified.tempCusName = tempCusName;
                _frm_KhachHangModified.tempCusAddress = tempCusAddress;
                _frm_KhachHangModified.tempCusGender = tempCusGender;
                _frm_KhachHangModified.tempCusPhone = tempCusPhone;
                _frm_KhachHangModified.Show(this);
                HienThiDuLieuLenDGV();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn thông tin khách hàng cần sửa!!!");
            }
        }

        private void GanDuLieuVaoTextBox()
        {
            if (dgv_KhachHang.Rows.Count > 0)
            {
                txt_idCard.Text = dgv_KhachHang.CurrentRow.Cells["colidCard"].Value.ToString();
                txt_cusName.Text = dgv_KhachHang.CurrentRow.Cells["colcusName"].Value.ToString();
                txt_cusAddress.Text = dgv_KhachHang.CurrentRow.Cells["colcusAddress"].Value.ToString();
                cbb_cusGender.Text = dgv_KhachHang.CurrentRow.Cells["colcusGender"].Value.ToString();
                txt_cusPhone.Text = dgv_KhachHang.CurrentRow.Cells["colcusPhone"].Value.ToString();
                txt_idCard.ReadOnly = true;
                txt_cusName.ReadOnly = true;
                txt_cusAddress.ReadOnly = true;
                txt_cusPhone.ReadOnly = true;
                cbb_cusGender.Enabled = false;
            }
        }
        private string tempIdCard, tempCusName, tempCusAddress, tempCusGender, tempCusPhone;

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GanDuLieuVaoDTO()
        {
            if (dgv_KhachHang.Rows.Count > 0)
            {
                tempIdCard = dgv_KhachHang.CurrentRow.Cells["colidCard"].Value.ToString();
                tempCusName = dgv_KhachHang.CurrentRow.Cells["colcusName"].Value.ToString();
                tempCusAddress = dgv_KhachHang.CurrentRow.Cells["colcusAddress"].Value.ToString();
                tempCusGender = dgv_KhachHang.CurrentRow.Cells["colcusGender"].Value.ToString();
                tempCusPhone = dgv_KhachHang.CurrentRow.Cells["colcusPhone"].Value.ToString();
            }
        }
    }
}
