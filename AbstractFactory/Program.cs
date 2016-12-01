using AbstractFactory._02_工厂模式;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// 抽象工程模式
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            #region 原始版
            //User user = new User();
            //SqlServerUser.Insert(user);
            //SqlServerUser.Get(user.Uid); 
            #endregion

            #region 工厂模式版
            //工厂模式：声明一个创建对象的接口，让子类决定具体实例化那个类
            //var factory = new SqlServerFactory();
            //var serverUser = factory.CreteUser();
            //serverUser.Get(user.Uid);
            //serverUser.Insert(user);
            #endregion
            var www = decimal.Round(3.92323m,0,MidpointRounding.AwayFromZero);
            var date= DateTime.Now;
            Console.WriteLine(date);
            Thread.Sleep(3*1000);

            Console.WriteLine(date + "==" + DateTime.Now);
            Console.Read();
        }
    }
}
