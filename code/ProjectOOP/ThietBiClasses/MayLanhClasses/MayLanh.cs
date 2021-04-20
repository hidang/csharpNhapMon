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
    public class MayLanh : IThietBi
    {
        private bool inverter = false;
        private readonly IMayLanh _ml;
        public MayLanh(IMayLanh ml)
        {
            _ml = ml;
        }

        public void Nhap(ref double gia)
        {
            Console.Write("\t\t\tMáy có hỗ trợ công nghệ inverter không (0 - không, 1 - có): ");
            if (Int32.Parse(Console.ReadLine()) == 1) inverter = true;
            _ml.Nhap(ref gia, inverter);
        }
        public string Xuat(BaseInfoThietBiStruct tb)
        {
            return _ml.Xuat(tb);
        }
    }
}
