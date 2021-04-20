using ProjectOOP_DI.ThietBiClasses;
using ProjectOOP_DI.ThietBiClasses.MayQuatClasses.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP.ThietBiClasses.MayQuatClasses
{
    class MayQuatSacDien : IMayQuat
    {
        private double dungTichPin;
        public void Nhap(ref double gia)
        {
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
        public string Xuat(BaseInfoThietBiStruct tb)
        {
            string mayQuatHoiNuoc = "";
            mayQuatHoiNuoc += $"\tMáy quạt: {tb.ma} loại máy quạt (quạt sạc điện) {tb.tenSanPham} {tb.noiSanXuat} {tb.gia * tb.soLuongBanRa} {dungTichPin} {tb.soLuongBanRa}\n";
            return mayQuatHoiNuoc;
        }
    }
}
