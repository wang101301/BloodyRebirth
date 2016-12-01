using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory._02_工厂模式
{
    public class SqlServerFactory : IFactory
    {
        public IUser CreteUser()
        {
            return new SqlServerUser();
        }
    }
}
