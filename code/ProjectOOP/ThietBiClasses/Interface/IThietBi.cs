using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP_DI.ThietBiClasses.Interface
{
    public interface IThietBi
    {
        void Nhap(ref double gia);
        string Xuat(BaseInfoThietBiStruct tb);
    }
}
