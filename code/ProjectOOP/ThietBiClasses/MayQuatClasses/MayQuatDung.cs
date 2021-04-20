using ProjectOOP_DI.ThietBiClasses;
using ProjectOOP_DI.ThietBiClasses.MayQuatClasses.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP.ThietBiClasses.MayQuatClasses
{
    class MayQuatDung : IMayQuat
    {
        public void Nhap(ref double gia)
        {
            gia = 500;
        }
        public string Xuat(BaseInfoThietBiStruct tb)
        {
            string mayQuatDung = "";
            mayQuatDung += $"\tMáy quạt: {tb.ma} loại máy quạt (quạt đứng) {tb.tenSanPham} {tb.noiSanXuat} {tb.gia * tb.soLuongBanRa} {tb.soLuongBanRa}\n";
            return mayQuatDung;
        }
    }
}
