using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// 第一版 不同数据库
    /// </summary>
    public class SqlServerUser
    {
        public static void Insert(User user)
        {
            Console.WriteLine("成功插入一条数据~~~~~~");
        }
        public static void Get(int uid)
        {
            Console.WriteLine("成功查询到一条数据~~~~");
        }
    }

  
}
