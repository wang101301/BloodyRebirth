using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory._03_抽象工厂
{
    public interface IUser
    {
        void Insert(User user);
        User Get(int uid);
    }
}
