
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory._03_抽象工厂
{
    /// <summary>
    /// 利用简单工厂模式 ：提供一个类 解决创建对象的问题
    /// </summary>
    public class DataAccessFactory
    {
        private static readonly string DdType = "SqlServer";
        public static IUser CreateUserDbType()
        {
            IUser user = null;
            switch (DdType)
            {
                case "SqlServer":
                    user = new SqlServerUser();
                    break;
                case "Access":
                    break;
            }
            return user;
        }
    }
}
