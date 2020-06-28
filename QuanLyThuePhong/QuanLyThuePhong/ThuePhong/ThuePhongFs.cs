using Newtonsoft.Json;
using QuanLyThuePhong.DungChung;
using QuanLyThuePhong.Phong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuePhong.ThuePhong
{
    public class ThuePhongFs:DungChungFs
    {
        public ThuePhongFs() : base() { }
        public async Task<List<DTO_ThuePhong>> GetThuePhong()
        {
            _response = await _client.GetAsync("api/roombook");
            var json = await _response.Content.ReadAsStringAsync();
            var listThuePhong = JsonConvert.DeserializeObject<List<DTO_ThuePhong>>(json);
            return listThuePhong;
        }
        public void ThemThuePhong(DTO_ThuePhong thuePhong)
        {
            var tempThuePhong = JsonConvert.SerializeObject(thuePhong);
            var buffer = Encoding.UTF8.GetBytes(tempThuePhong);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _client.PostAsync("api/roombook", byteContent);
        }
        public DTO_ThuePhong GetThuePhongById(string idCard)
        {
            _response = _client.GetAsync($"api/customer/{idCard}").Result;
            var json = _response.Content.ReadAsStringAsync().Result;
            var listKhachHang = JsonConvert.DeserializeObject<DTO_ThuePhong>(json);
            return listKhachHang;
        }
    }
}
