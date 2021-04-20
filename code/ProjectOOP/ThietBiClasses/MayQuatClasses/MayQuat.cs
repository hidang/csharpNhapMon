using ProjectOOP_DI.ThietBiClasses;
using ProjectOOP_DI.ThietBiClasses.Interface;
using ProjectOOP_DI.ThietBiClasses.MayQuatClasses.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP.ThietBiClasses.MayQuatClasses
{
    public class MayQuat : IThietBi
    {
        private readonly IMayQuat _mq;
        public MayQuat(IMayQuat mq)
        {
            _mq = mq;
        }
        public void Nhap(ref double gia)
        {
            _mq.Nhap(ref gia);
        }
        public string Xuat(BaseInfoThietBiStruct tb)
        {
            return _mq.Xuat(tb);
        }
    }
}
