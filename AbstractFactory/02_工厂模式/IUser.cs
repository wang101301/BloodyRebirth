using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory._02_工厂模式
{
    public interface IUser
    {
        void Insert(User user);
        User Get(int uid);
    }
}
