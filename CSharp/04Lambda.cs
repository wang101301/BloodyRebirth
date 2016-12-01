using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    /// <summary>
    /// Lambda表达式 是为了用更简单的方式 来编写匿名方法。简化了委托的使用方式，
    /// 减少了实例化委托 所需要的系统开销。
    /// =>  左边是参数列表。右边是表达式计算
    /// </summary>
    public class _04Lambda : BaseClass
    {
        /*
         *   Action Func 之类的泛型委托
         *   ERROR 字段初始值设定项无法引用非静态字段、方法或属性
         *   原因是在类内部 只能声明属性或者变量，变量不能引用变量 ，属性是用的时候分配的内存，变量是在初始化的时候分配的内存
         */
        public static void test()
        {
            int x = 100;
            Action action = () => x = x + 100;
            action();
            //Func 最后一个参数类型 是返回值的参数类型
            Func<double, int, double> actionFunc = (w, m) =>
                {
                    return w * m;
                };
            WriteLine<double>(actionFunc(100.00, 20));
            WriteLine<int>(x);


            List<int> lst = new List<int> { 1, 3, 4, 5, 76, 8, 89, 98, 98, 9 };
            var tempLst = lst.FindAll(m => m > 50);
            lst.Where(w => w > 10); //使用的就是lambda表达式
            tempLst.ForEach(f =>
            {
                WriteLine<int>(f);
            });
        }
    }
}
