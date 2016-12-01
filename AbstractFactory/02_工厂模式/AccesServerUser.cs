using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory._02_工厂模式
{
    public class AccesServerUser : IUser
    {
        public  void Insert(User user)
        {
            Console.WriteLine("AccesServer成功插入一条数据~~~~~~");
        }
        public User Get(int uid)
        {
            Console.WriteLine("AccesServer成功查询到一条数据~~~~");
            return null;
        }
    }
}
