using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    /// <summary>
    /// 元组 可以代替ref out Tuple<T1,T2,T3,T4,T5,T6>
    /// </summary>
    public static class _01Tuple
    {
        public static void Test()
        {
            var tuples = new Tuple<int, string, string>(1, "你好", "hellon word");
            Console.WriteLine(tuples.Item1);
            Console.WriteLine(tuples.Item3);
            Console.ReadKey();
        }

    }


}
