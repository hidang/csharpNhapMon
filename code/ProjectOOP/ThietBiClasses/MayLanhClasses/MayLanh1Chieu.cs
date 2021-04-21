using ProjectOOP_DI.ThietBiClasses;
using ProjectOOP_DI.IOServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP.ThietBiClasses.MayLanhClasses
{
    class MayLanh1Chieu : MayLanh, IInputOutputServices
    {
        public void Input()
        {
            base.CheckingInverter();
            if (base.inverter) gia = 1500;
            else gia = 1000;
        }
        public string Output()
        {
           return  $"\tMáy lạnh: {base.ma} loại máy lạnh (1 chiều) {base.tenSanPham} {base.noiSanXuat} {base.gia * base.soLuongBanRa} {(base.inverter ? "có hỗ trợ công nghệ inverter" : "không hỗ trợ công nghệ inverter")} {base.soLuongBanRa}\n";
           
        }
    }
}
