using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuePhong.DichVu
{
    public partial class Frm_DichVu : Form
    {
        public Frm_DichVu()
        {
            InitializeComponent();
        }

        DichVuFs _DichVuFs;
        private void Frm_DichVu_Load(object sender, EventArgs e)
        {
            _DichVuFs = new DichVuFs();
            HienThiDuLieuLenDGV();
        }
        private async void HienThiDuLieuLenDGV()
        {
            var listDichVu = await _DichVuFs.GetDichVu();
            dgv_DichVu.DataSource = listDichVu;
        }
        private void dgv_DichVu_Click(object sender, EventArgs e)
        {
            GanDuLieuVaoTextBox();
            GanDuLieuVaoDTO();
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            Frm_DichVuModified _frm_DichVuModified = new Frm_DichVuModified();
            _frm_DichVuModified.ShowDialog();
            HienThiDuLieuLenDGV();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var idCardSelected = Convert.ToInt32(txt_IdService.Text);
            _DichVuFs.XoaDichVu(idCardSelected);
            HienThiDuLieuLenDGV();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            //var idCardSelected = Convert.ToInt32(txt_idCard.Text);
            if (!string.IsNullOrEmpty(tempIdService))
            {
                Frm_DichVuModified _frm_DichVuModified = new Frm_DichVuModified();
                _frm_DichVuModified.tempIdService = tempIdService;
                _frm_DichVuModified.tempSerName = tempSerName;
                _frm_DichVuModified.tempSerUnit = tempSerUnit;
                _frm_DichVuModified.tempSerPrice = tempSerPrice;
                _frm_DichVuModified.Show(this);
                HienThiDuLieuLenDGV();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn thông tin khách hàng cần sửa!!!");
            }
        }

        private void GanDuLieuVaoTextBox()
        {
            if (dgv_DichVu.Rows.Count > 0)
            {
                txt_IdService.Text = dgv_DichVu.CurrentRow.Cells["colIdService"].Value.ToString();
                txt_SerName.Text = dgv_DichVu.CurrentRow.Cells["colSerName"].Value.ToString();
                txt_SerUnit.Text = dgv_DichVu.CurrentRow.Cells["colSerUnit"].Value.ToString();
                txt_SerPrice.Text = dgv_DichVu.CurrentRow.Cells["colSerPrice"].Value.ToString();
                txt_IdService.ReadOnly = true;
                txt_SerName.ReadOnly = true;
                txt_SerUnit.ReadOnly = true;
                txt_SerPrice.ReadOnly = true;
            }
        }
        private string tempIdService, tempSerName, tempSerUnit, tempSerPrice;

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GanDuLieuVaoDTO()
        {
            if (dgv_DichVu.Rows.Count > 0)
            {
                tempIdService = dgv_DichVu.CurrentRow.Cells["colIdService"].Value.ToString();
                tempSerName = dgv_DichVu.CurrentRow.Cells["colSerName"].Value.ToString();
                tempSerUnit = dgv_DichVu.CurrentRow.Cells["colSerUnit"].Value.ToString();
                tempSerPrice = dgv_DichVu.CurrentRow.Cells["colSerPrice"].Value.ToString();
            }
        }
    }
}
