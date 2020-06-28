using Newtonsoft.Json;
using QuanLyThuePhong.DungChung;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuePhong.DichVu
{
    public class DichVuFs : DungChungFs
    {
        public DichVuFs() : base() { }
        public async Task<List<DTO_DichVu>> GetDichVu()
        {
            _response = await _client.GetAsync("api/services");
            var json = await _response.Content.ReadAsStringAsync();
            var listDichVu = JsonConvert.DeserializeObject<List<DTO_DichVu>>(json);
            return listDichVu;
        }
        public void ThemDichVu(DTO_DichVu dichVu)
        {
            var tempdichVu = JsonConvert.SerializeObject(dichVu);
            var buffer = Encoding.UTF8.GetBytes(tempdichVu);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _client.PostAsync("api/services", byteContent);
        }
        public void XoaDichVu(int iD)
        {
            _client.DeleteAsync($"api/services/{iD}");
        }
        public void CapNhatDichVu(DTO_DichVu dichVu, string idService)
        {
            var _dichVu = JsonConvert.SerializeObject(dichVu);
            var buffer = Encoding.UTF8.GetBytes(_dichVu);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _client.PutAsync($"api/services/{idService}", byteContent);
        }
    }
}
