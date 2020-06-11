using Newtonsoft.Json;
using QuanLyThuePhong.DungChung;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuePhong.DangNhap
{
    public class TaiKhoanFs : DungChungFs
    {
        public TaiKhoanFs() : base() { }
        public async Task<List<DTO_TaiKhoan>> GetTaiKhoan()
        {
            _response = await _client.GetAsync("api/account");
            var json = await _response.Content.ReadAsStringAsync();
            var listTaiKhoan = JsonConvert.DeserializeObject<List<DTO_TaiKhoan>>(json);
            return listTaiKhoan;
        }
        public DTO_TaiKhoan GetTaiKhoanTheoTenDangNhap(string tenDangNhap)
        {
            _response = _client.GetAsync("api/account/" + tenDangNhap).Result;
            var json = _response.Content.ReadAsStringAsync().Result;
            var listTaiKhoanTheoTenDangNhap = JsonConvert.DeserializeObject<DTO_TaiKhoan>(json);
            return listTaiKhoanTheoTenDangNhap;
        }
    }
}
