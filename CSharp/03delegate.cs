using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class _03delegate : BaseClass
    {
        /// <summary>
        /// 委托就是把方法当做参数 来处理的
        /// 泛型委托使用   Func必须有返回值  Action 没有返回值 
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="actionFun"></param>
        /// <returns></returns>
        public static string BindData(string msg, Func<string> actionFun)
        {
            return actionFun();
        }
        public static string BindData111(string msg, Func<string, string> actionFun,string parm)
        {
            return actionFun(parm);
        }


        public static void BindData(Action act)
        {
            act();
        }
        public static void Test3()
        {
            WriteLine<string>("111111");
        }
        public static string Test1()
        {
            return "123";
        }
        public static string Test2()
        {
            return "ABC";
        }

        public static string Test2222(string str)
        {
            return "ABC" + str;
        }
    }
}
