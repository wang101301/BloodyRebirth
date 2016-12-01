using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public  class BaseClass
    {
        public static  void WriteLine<T>(T data)
        {
            Console.WriteLine(data);
        }

    }
}
