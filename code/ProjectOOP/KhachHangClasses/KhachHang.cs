using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP.KhachHangClasses
{
    class KhachHang
    {
        private string ma;
        private string ten;
        private string diaChi;
        private string soDienThoai;
        public string Ma
        {
            get { return ma; }
        }
        public string Ten
        {
            get { return ten; }
        }
        public string DiaChi
        {
            get { return diaChi; }
        }
        public string SoDienThoai
        {
            get { return soDienThoai; }
        }
        public void NhapKhachHang()
        {
            Console.WriteLine("\tThông tin khách hàng: ");
            Console.Write("\tMã khách hàng: ");
            ma = Console.ReadLine();
            Console.Write("\tTên khách hàng: ");
            ten = Console.ReadLine();
            Console.Write("\tĐịa chỉ: ");
            diaChi = Console.ReadLine();
            Console.Write("\tSố điện thoại: ");
            soDienThoai = Console.ReadLine();
        }
    }
}
