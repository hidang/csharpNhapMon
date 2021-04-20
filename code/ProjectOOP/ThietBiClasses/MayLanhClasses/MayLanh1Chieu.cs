using ProjectOOP_DI.ThietBiClasses;
using ProjectOOP_DI.ThietBiClasses.Interface;
using ProjectOOP_DI.ThietBiClasses.MayLanhClasses.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP.ThietBiClasses.MayLanhClasses
{
    class MayLanh1Chieu : IMayLanh
    {
        private bool inverter;
        public void Nhap(ref double gia, bool inverter)
        {
            this.inverter = inverter;
            if (inverter) gia = 1500;
            else gia = 1000;
        }
        public string Xuat(BaseInfoThietBiStruct tb)
        {
            string mayLanh1Chieu = "";
            mayLanh1Chieu += $"\tMáy lạnh: {tb.ma} loại máy lạnh (1 chiều) {tb.tenSanPham} {tb.noiSanXuat} {tb.gia * tb.soLuongBanRa} {(inverter? "có hỗ trợ công nghệ inverter" : "không hỗ trợ công nghệ inverter")} {tb.soLuongBanRa}\n";
            return mayLanh1Chieu;
        }
    }
}
