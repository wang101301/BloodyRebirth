using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependenceInversionPrinciple
{
    /// <summary>
    /// 自动系统
    /// </summary>
    public class AutomaticSystem
    {
        private ICar car;
        public AutomaticSystem(ICar car)
        {
            this.car = car;
        }
        public void Start()
        {
            this.car.Start();
        }
        public void Stop()
        {
            this.car.Stop();
        }
        public void TrunOff()
        {
            this.car.TrunOff();
        }
    }
}
