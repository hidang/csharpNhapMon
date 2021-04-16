using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP.ThietBiClasses.MayQuatClasses
{
    class MayQuatDung : MayQuat
    {
        public MayQuatDung()
        {
            gia = 500;
        }
        public override void Nhap()
        {
            base.Nhap();
        }
        public override string Xuat()
        {
            string mayQuatDung = "";
            mayQuatDung += $"\tMáy quạt: {ma} Loại máy quạt (quạt đứng) {tenSanPham} {noiSanXuat} {gia*soLuongBanRa} {soLuongBanRa}\n";
            return mayQuatDung;
        }
    }
}
