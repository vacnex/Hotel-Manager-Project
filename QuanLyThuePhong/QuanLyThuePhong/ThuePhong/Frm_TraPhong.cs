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
    public partial class Frm_TraPhong : Form
    {
        public Frm_TraPhong()
        {
            InitializeComponent();
        }
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

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            HienThiDanhSachPhong();
        }
    }
}
