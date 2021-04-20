using ProjectOOP_DI.ThietBiClasses;
using ProjectOOP_DI.ThietBiClasses.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP.ThietBiClasses
{
    public class ThietBi
    {
        private readonly IThietBi _tb;
        public ThietBi(IThietBi tb)
        {
            _tb = tb;
        }
        private string ma;
        private string tenSanPham;
        private string noiSanXuat;

        private double gia;
        private int soLuongBanRa;

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
            _tb.Nhap(ref gia);
        }
        public string Xuat()
        {
            //init data for BaseInfoThietBi
            BaseInfoThietBiStruct tb = new BaseInfoThietBiStruct();
            tb.ma = ma;
            tb.tenSanPham = tenSanPham;
            tb.noiSanXuat = noiSanXuat;
            tb.gia = gia;
            tb.soLuongBanRa = soLuongBanRa;

            return _tb.Xuat(tb);
        }
    }
}
