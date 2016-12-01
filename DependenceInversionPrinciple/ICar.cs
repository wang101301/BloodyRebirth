using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependenceInversionPrinciple
{
    /// <summary>
    /// 车类 父接口
    /// </summary>
    public interface ICar
    {
        void Start();
        void Stop();
        void TrunOff();
    }
}
