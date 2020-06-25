using Newtonsoft.Json;
using QuanLyThuePhong.DungChung;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuePhong.Phong
{
    public class PhongFs : DungChungFs
    {
        public PhongFs() : base() { }

        public async Task<List<DTO_Phong>> GetPhong()
        {
            _response = await _client.GetAsync("api/room");
            var json = await _response.Content.ReadAsStringAsync();
            var listPhong = JsonConvert.DeserializeObject<List<DTO_Phong>>(json);
            return listPhong;
        }
        public void ThemPhong(DTO_Phong phong)
        {
            var tempPhong = JsonConvert.SerializeObject(phong);
            var buffer = Encoding.UTF8.GetBytes(tempPhong);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _client.PostAsync("api/room", byteContent);
        }
        public void XoaPhong(string iD)
        {
            _client.DeleteAsync($"api/room/{iD}");
        }
        public void CapNhatPhong(DTO_Phong phong, string idRoom)
        {
            var tempPhong = JsonConvert.SerializeObject(phong);
            var buffer = Encoding.UTF8.GetBytes(tempPhong);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _client.PutAsync($"api/room/{idRoom}", byteContent);
        }
    }
}
