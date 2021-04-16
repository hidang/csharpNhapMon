using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP.ThietBiClasses.MayLanhClasses
{
    class MayLanh2Chieu : MayLanh
    {
        private bool khangKhuan = false;
        private bool khuMui = false;

        public MayLanh2Chieu()
        {
            if (inverter) gia = 2500;
            else gia = 2000;
        }
        public override void Nhap() 
        {
            base.Nhap();
            Console.Write("\t\t\tCó sử dụng công nghệ kháng khuẩn không(0 - không, 1 - có): ");
            try
            {
                if (Int32.Parse(Console.ReadLine()) == 1)
                {
                    gia += 500;
                    khangKhuan = true;
                }

                Console.Write("\t\t\tCó sử dụng công nghệ khử mùi không(0 - không, 1 - có): ");
                if (Int32.Parse(Console.ReadLine()) == 1)
                {
                    gia += 500;
                    khuMui = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }

        }
        public override string Xuat()
        {
            string mayQuatHoiNuoc = "";
            mayQuatHoiNuoc += $"\tMáy lạnh: {ma} loại máy lạnh (1 chiều) {tenSanPham} {noiSanXuat} {gia * soLuongBanRa} {(inverter ? "có hỗ trợ công nghệ inverter" : "không hỗ trợ công nghệ inverter")} " +
                $"{(khangKhuan? "có công nghệ kháng khuẩn": "không có công nghệ kháng khuẩn")} {(khuMui? "có công nghệ khử mùi" : "không có công nghệ khử mùi")} {soLuongBanRa}\n";
            return mayQuatHoiNuoc;
        }
    }
}
