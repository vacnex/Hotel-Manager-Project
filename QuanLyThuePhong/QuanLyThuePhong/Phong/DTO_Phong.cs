using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuePhong.Phong
{
    public class DTO_Phong
    {
        private string idRoom;
        private string rType;
        private string rPrice;
        private string rStatus;

        public string IdRoom { get => idRoom; set => idRoom = value; }
        public string RType { get => rType; set => rType = value; }
        public string RPrice { get => rPrice; set => rPrice = value; }
        public string RStatus { get => rStatus; set => rStatus = value; }
    }
}
