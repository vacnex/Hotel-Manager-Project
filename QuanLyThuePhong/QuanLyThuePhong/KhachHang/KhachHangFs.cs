using Newtonsoft.Json;
using QuanLyThuePhong.DungChung;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuePhong.KhachHang
{
    public class KhachHangFs : DungChungFs
    {
        public KhachHangFs() : base() { }
        public async Task<List<DTO_KhachHang>> GetKhachHang()
        {
            _response = await _client.GetAsync("api/customer");
            var json = await _response.Content.ReadAsStringAsync();
            var listKhachHang = JsonConvert.DeserializeObject<List<DTO_KhachHang>>(json);
            return listKhachHang;
        }
        public void ThemKhachHang(DTO_KhachHang khachHang)
        {
            var tempKhachHang = JsonConvert.SerializeObject(khachHang);
            var buffer = Encoding.UTF8.GetBytes(tempKhachHang);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _client.PostAsync("api/customer", byteContent);
        }
        public void XoaKhachHang(int iD)
        {
            _client.DeleteAsync($"api/customer/{iD}");
        }
        public void CapNhatKhachHang(DTO_KhachHang khachHang, string idCard)
        {
            var _khachHang = JsonConvert.SerializeObject(khachHang);
            var buffer = Encoding.UTF8.GetBytes(_khachHang);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _client.PutAsync($"api/customer/{idCard}", byteContent);
        }
    }
}
