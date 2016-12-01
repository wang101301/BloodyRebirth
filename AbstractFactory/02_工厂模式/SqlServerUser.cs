using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory._02_工厂模式
{
    public class SqlServerUser : IUser
    {
        public void Insert(User user)
        {
            Console.WriteLine("SqlServer成功插入一条数据~~~~~~");
        }
        public User  Get(int uid)
        {
            Console.WriteLine("SqlServer成功查询到一条数据~~~~");
            return null;
        }
    }
}
