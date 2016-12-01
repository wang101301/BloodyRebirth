using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            WorkProgram work = new WorkProgram(19, true);
            work.Work();
            Console.Read();
        }
    }
}
