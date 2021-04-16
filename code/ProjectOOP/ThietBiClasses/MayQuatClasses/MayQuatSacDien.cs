using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP.ThietBiClasses.MayQuatClasses
{
    class MayQuatSacDien : MayQuat
    {
        private double dungTichPin;
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("\t\t\tDung lượng pin: ");
            try
            {
                dungTichPin = double.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }
            gia = dungTichPin * 500;
        }
        public override string Xuat()
        {
            string mayQuatHoiNuoc = "";
            mayQuatHoiNuoc += $"\tMáy quạt: {ma} Loại máy quạt (quạt sạc điện) {tenSanPham} {noiSanXuat} {gia * soLuongBanRa} {dungTichPin} {soLuongBanRa}\n";
            return mayQuatHoiNuoc;
        }
    }
}
