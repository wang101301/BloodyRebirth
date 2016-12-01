using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory._03_抽象工厂
{
    public class SqlServerUser : IUser
    {
        public void Insert(User user)
        {
            Console.WriteLine("成功插入一条数据~~~~~~");
        }

        public User Get(int uid)
        {
            Console.WriteLine("成功查询到一条数据~~~~");
            return null;
        }
    }
}
