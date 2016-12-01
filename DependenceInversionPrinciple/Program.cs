using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependenceInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            AutomaticSystem automat = new AutomaticSystem(new  FordCar());
            automat.Start();
            Console.Read();
        }
    }
}
