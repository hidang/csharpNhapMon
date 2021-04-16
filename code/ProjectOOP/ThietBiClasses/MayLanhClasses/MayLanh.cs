using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP.ThietBiClasses.MayLanhClasses
{
    abstract class MayLanh : ThietBi
    {
        protected bool inverter = false;
        public override void Nhap()
        {
            Console.Write("\t\t\tMáy có hỗ trợ công nghệ inverter không (0 - không, 1 - có): ");
            if (Int32.Parse(Console.ReadLine()) == 1) inverter = true;
            base.Nhap();
        }
    }
}
