using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuePhong.ThuePhong
{
    public class DTO_ThuePhong
    {
        private string idRoomBook;
        private string idCard;
        private string idRoom;
        private string startDate;
        private string endDate;
        private string staffName;


        public string IdRoomBook { get => idRoomBook; set => idRoomBook = value; }
        public string IdCard { get => idCard; set => idCard = value; }
        public string IdRoom { get => idRoom; set => idRoom = value; }
        public string StartDate { get => startDate; set => startDate = value; }
        public string EndDate { get => endDate; set => endDate = value; }
        public string StaffName { get => staffName; set => staffName = value; }
    }
}
