using ProjectOOP_DI.ThietBiClasses;
using ProjectOOP_DI.IOServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP.ThietBiClasses
{
    public class ThietBi
    {
        public readonly IInputOutputServices ioServices;
        public ThietBi(IInputOutputServices _ioServices)
        {
            ioServices = _ioServices;
        }
        public ThietBi()
        {

        }
        protected string ma;
        protected string tenSanPham;
        protected string noiSanXuat;

        protected double gia;
        protected int soLuongBanRa;

        public double Gia
        {
            get { return gia; }
            set { gia = value; }
        }
        public int SoLuongBanRa
        {
            get { return soLuongBanRa; }
            set { soLuongBanRa = value; }
        }

        public virtual void Nhap() 
        {
            Console.Write("\t\t\tNhập mã: ");
            this.ma = Console.ReadLine();
            Console.Write("\t\t\tTên sản phẩm: ");
            this.tenSanPham = Console.ReadLine();
            Console.Write("\t\t\tNơi sản xuất: ");
            this.noiSanXuat = Console.ReadLine();
            ioServices.Input();
        }
        public string Xuat()
        {
            return ioServices.Output();
        }
    }
}
