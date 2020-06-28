using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuePhong.DichVu
{
    public class DTO_DichVu
    {
        private string idService;
        private string serName;
        private string serPrice;
        private string serUnit;

        public string IdService { get => idService; set => idService = value; }
        public string SerName { get => serName; set => serName = value; }
        public string SerPrice { get => serPrice; set => serPrice = value; }
        public string SerUnit { get => serUnit; set => serUnit = value; }
    }
}
