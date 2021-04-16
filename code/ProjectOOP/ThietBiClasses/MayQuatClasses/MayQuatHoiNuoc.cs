using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP.ThietBiClasses.MayQuatClasses
{
    class MayQuatHoiNuoc : MayQuat
    {
        private double dungTichNuoc;
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("\t\t\tDung tích nước: ");
            try
            {
                dungTichNuoc = double.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }
            gia = dungTichNuoc * 400;
        }
        public override string Xuat()
        {
            string mayQuatHoiNuoc = "";
            mayQuatHoiNuoc += $"\tMáy quạt: {ma} Loại máy quạt (quạt hơi nước) {tenSanPham} {noiSanXuat} {this.gia* soLuongBanRa} {dungTichNuoc} {soLuongBanRa}\n";
            return mayQuatHoiNuoc;
        }
    }
}
