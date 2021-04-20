using ProjectOOP.ThietBiClasses;
using ProjectOOP.ThietBiClasses.MayLanhClasses;
using ProjectOOP_DI.ThietBiClasses.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP_DI.ThietBiClasses.MayLanhClasses.Interface
{
    public interface IMayLanh
    {
        void Nhap(ref double gia, bool inverter);
        string Xuat(BaseInfoThietBiStruct tb);
    }
}
