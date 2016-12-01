using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependenceInversionPrinciple
{
    public class FordCar : ICar
    {
        public void Start()
        {
            Console.WriteLine("福特汽车启动了……");
        }
        public void Stop()
        {
            Console.WriteLine("福特汽车停止了……");
        }
        public void TrunOff()
        {
            Console.WriteLine("福特汽车拐弯了……");
        }
    }
}
