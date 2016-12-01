using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory._02_工厂模式
{
    /// <summary>
    /// 工厂模式  就是为定义一个创建对象的接口，让子类决定实例化那个类
    /// </summary>
    public interface IFactory
    {
        IUser CreteUser();
    }
}
