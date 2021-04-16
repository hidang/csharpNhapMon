using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP.ThietBiClasses
{
    //interface IThietBi
    //{
    //    public string Ma { get; set; }
    //    public string TenSanPham { get; set; }
    //    public string NoiSanXuat { get; set; }

    //    protected double Gia { get; set; }
    //    protected int SoLuongBanRa { get; set; }
    //}
    abstract class ThietBi
    {
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
        }
        public abstract string Xuat();
    }
}
