using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuePhong.DungChung
{
    public class DungChungFs
    {
        protected HttpClient _client;
        protected HttpResponseMessage _response;

        public DungChungFs()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://hotelmanagerapi.azurewebsites.net/");
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
