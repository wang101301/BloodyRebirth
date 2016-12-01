using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatterns
{
    public class WorkProgram
    {
        public int hour { get; set; }
        public bool WorkFinshed { get; set; }
        public WorkProgram(int hour, bool workFinshed)
        {
            this.hour = hour;
            this.WorkFinshed = workFinshed;

        }
        public void Work()
        {
            if (hour < 9)
            {
                Console.WriteLine("起床模式……没睡醒" + hour);
            }
            else if (hour < 11)
            {
                Console.WriteLine("精神饱满 ……写代码杠杠的" + hour);
            }
            else if (hour < 14)
            {
                Console.WriteLine("午休模式 ……没力气写代码" + hour);
            }
            else if (hour < 16)
            {
                Console.WriteLine("恢复模式 ……渐渐有了力气写代码" + hour);
            }
            else if (hour < 18)
            {
                Console.WriteLine("午休模式 ……没力气写代码" + hour);
            }
            else
            {
                if (WorkFinshed)
                {
                    Console.WriteLine("下班……" + hour);
                }
                else if (hour < 21)
                {
                    Console.WriteLine("累瘫了……" + hour);
                }
                else
                {
                    Console.WriteLine("表说话……" + hour);
                }
            }
        }
    }
}
