using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuePhong.DangNhap
{
    public class DTO_TaiKhoan
    {
        //private string tenDangNhap;
        //private string matKhau;
        //private string tenNhanVien;

        //public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        //public string MatKhau { get => matKhau; set => matKhau = value; }
        //public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }

        private string username;
        private string pass;
        private string name;

        public string Username { get => username; set => username = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Name { get => name; set => name = value; }
    }
}
