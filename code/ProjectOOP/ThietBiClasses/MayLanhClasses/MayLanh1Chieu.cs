using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP.ThietBiClasses.MayLanhClasses
{
    class MayLanh1Chieu : MayLanh
    {
        public MayLanh1Chieu()
        {
            if (inverter) gia = 1500;
            else gia = 1000;
        }
        public override void Nhap()
        {
            base.Nhap();
        }
        public override string Xuat()
        {
            string mayQuatHoiNuoc = "";
            Console.WriteLine(ma);
            mayQuatHoiNuoc += $"\tMáy lạnh: {ma} loại máy lạnh (1 chiều) {tenSanPham} {noiSanXuat} {gia * soLuongBanRa} {(inverter? "có hỗ trợ công nghệ inverter" : "không hỗ trợ công nghệ inverter")} {soLuongBanRa}\n";
            return mayQuatHoiNuoc;
        }
    }
}
