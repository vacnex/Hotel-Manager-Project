using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuePhong.KhachHang
{
    public class DTO_KhachHang
    {
        private string idCard;
        private string cusName;
        private string cusAddress;
        private string cusGender;
        private string cusPhone;

        public string IdCard { get => idCard; set => idCard = value; }
        public string CusName { get => cusName; set => cusName = value; }
        public string CusAddress { get => cusAddress; set => cusAddress = value; }
        public string CusGender { get => cusGender; set => cusGender = value; }
        public string CusPhone { get => cusPhone; set => cusPhone = value; }
    }
}
