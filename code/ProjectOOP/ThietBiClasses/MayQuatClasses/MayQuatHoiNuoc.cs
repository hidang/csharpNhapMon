using ProjectOOP_DI.ThietBiClasses;
using ProjectOOP_DI.ThietBiClasses.MayQuatClasses.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP.ThietBiClasses.MayQuatClasses
{
    class MayQuatHoiNuoc : IMayQuat
    {
        private double dungTichNuoc;
        public void Nhap(ref double gia)
        {
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
        public string Xuat(BaseInfoThietBiStruct tb)
        {
            string mayQuatHoiNuoc = "";
            mayQuatHoiNuoc += $"\tMáy quạt: {tb.ma} loại máy quạt (quạt hơi nước) {tb.tenSanPham} {tb.noiSanXuat} {tb.gia * tb.soLuongBanRa} {dungTichNuoc} {tb.soLuongBanRa}\n";
            return mayQuatHoiNuoc;
        }
    }
}
