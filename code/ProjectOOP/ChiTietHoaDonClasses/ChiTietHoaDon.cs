using ProjectOOP.ThietBiClasses;
using ProjectOOP.ThietBiClasses.MayLanhClasses;
using ProjectOOP.ThietBiClasses.MayQuatClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP.ChiTietHoaDonClasses
{
    class ChiTietHoaDon
    {
        private ThietBi TB;
        public void NhapHoaDon()
        {
            bool trueThietBi = false;
            while (!trueThietBi)
            {
                Console.Write("\t\tChọn loại thiết bị điện(1-máy quạt, 2- máy lạnh): ");
                int typeThietBi = 0;
                try
                {
                    typeThietBi = Int32.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
                switch (typeThietBi)
                {
                    case 1:
                        ChonLoaiMayQuat();
                        trueThietBi = true;
                        break;
                    case 2:
                        ChonLoaiMayLanh();
                        trueThietBi = true;
                        break;
                    //case 3:
                    default:
                        Console.WriteLine("\t\t\tKhông đúng loại xin chọn lại");
                        typeThietBi = Int32.Parse(Console.ReadLine());
                        trueThietBi = false;
                        break;
                }
            }
            TB.Nhap();
            Console.Write("\t\tSố lượng bán ra: ");
            TB.SoLuongBanRa = Int32.Parse(Console.ReadLine());
        }
        private void ChonLoaiMayQuat()
        {
            Console.Write("\t\t\tChọn loại máy quạt(1 - máy quạt đứng, 2 - máy quạt hơi nước, 3 – máy quạt sạc điện): ");
            int typeQuat = 0;
            try
            {
                typeQuat = Int32.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }
            bool trueTypeQuay = false;

            while (!trueTypeQuay)
            {
                switch (typeQuat)
                {
                    case 1:
                        TB = new ThietBi(new MayQuat (new MayQuatDung()));
                        trueTypeQuay = true;
                        break;
                    case 2:
                        TB = new ThietBi(new MayQuat(new MayQuatHoiNuoc()));
                        trueTypeQuay = true;
                        break;
                    case 3:
                        TB = new ThietBi(new MayQuat(new MayQuatSacDien()));
                        trueTypeQuay = true;
                        break;
                    default:
                        Console.WriteLine("Không đúng loại quạt xin chọn lại");
                        typeQuat = Int32.Parse(Console.ReadLine());
                        trueTypeQuay = false;
                        break;
                }
            }
        }
        private void ChonLoaiMayLanh()
        {
            Console.Write("\t\t\tChọn loại máy lạnh (1 -máy lạnh một chiều, 2- máy lạnh hai chiều): ");
            int typeMLanh = 0;
            try
            {
                typeMLanh = Int32.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }
            bool trueTypeMLanh = false;
            while (!trueTypeMLanh)
            {
                switch (typeMLanh)
                {
                    case 1:
                        TB = new ThietBi(new MayLanh1Chieu());
                        trueTypeMLanh = true;
                        break;
                    case 2:
                        TB = new ThietBi(new MayLanh(new MayLanh2Chieu()));
                        trueTypeMLanh = true;
                        break;
                    default:
                        Console.WriteLine("Không đúng loại xin chọn lại");
                        typeMLanh = Int32.Parse(Console.ReadLine());
                        trueTypeMLanh = false;
                        break;
                }
            }
        }
        public double GetTongGiaHoaDon()
        {
            return TB.SoLuongBanRa * TB.Gia;
        }
        public string XuatDataThietBi()
        {
            string dataThietBi = "";
            dataThietBi += TB.Xuat();
            return dataThietBi;
        }
    }
}
