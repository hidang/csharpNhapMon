using ProjectOOP_DI.ThietBiClasses;
using ProjectOOP_DI.IOServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP.ThietBiClasses.MayLanhClasses
{
    public class MayLanh : ThietBi
    {
        protected bool inverter = false;

        public MayLanh():base()
        {

        }
        public void CheckingInverter()
        {
            Console.Write("\t\t\tMáy có hỗ trợ công nghệ inverter không (0 - không, 1 - có): ");
            if (Int32.Parse(Console.ReadLine()) == 1) inverter = true;
        }
    }
}
