using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class UnitTest
    {
        static void Main(string[] args)
        {
            string s1 = "   ";
            //当字符串又空字符串组成的时候。IsNullOrEmpty返回false, IsNullOrWhiteSpace返回true
            Console.WriteLine("IsNullOrEmpty:======"+string.IsNullOrEmpty(s1));
            Console.WriteLine("IsNullOrWhiteSpace:======" + string.IsNullOrWhiteSpace(s1));
            Console.Read();
        }
    }
}
