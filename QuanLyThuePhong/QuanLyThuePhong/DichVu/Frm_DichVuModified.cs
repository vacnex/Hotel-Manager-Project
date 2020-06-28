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
    public partial class Frm_DichVuModified : Form
    {
        public Frm_DichVuModified()
        {
            InitializeComponent();
        }
        DichVuFs _DichVuFs;
        DTO_DichVu _dTO_DichVu;
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_DVM_IdService.Text) && !string.IsNullOrEmpty(txt_DVM_SerName.Text) && !string.IsNullOrEmpty(txt_DVM_SerUnit.Text) && !string.IsNullOrEmpty(txt_DVM_SerPrice.Text))
            {
                GanDuLieuVaoDTO();
                _DichVuFs.ThemDichVu(_dTO_DichVu);
                _DichVuFs.CapNhatDichVu(_dTO_DichVu, txt_DVM_IdService.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin khách hàng!!!");
            }
        }
        private void Frm_DichVuModified_Load(object sender, EventArgs e)
        {
            _DichVuFs = new DichVuFs();
            _dTO_DichVu = new DTO_DichVu();
            GanDuLieuVaoTextBox();
        }
        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string tempIdService, tempSerName, tempSerUnit, tempSerPrice;

        

        private void GanDuLieuVaoTextBox()
        {
            txt_DVM_IdService.Text = tempIdService;
            txt_DVM_SerName.Text = tempSerName;
            txt_DVM_SerUnit.Text = tempSerUnit;
            txt_DVM_SerPrice.Text = tempSerPrice;
        }
        private void GanDuLieuVaoDTO()
        {
            _dTO_DichVu.IdService = txt_DVM_IdService.Text;
            _dTO_DichVu.SerName = txt_DVM_SerName.Text;
            _dTO_DichVu.SerUnit = txt_DVM_SerUnit.Text;
            _dTO_DichVu.SerPrice = txt_DVM_SerPrice.Text;
        }
    }
}
