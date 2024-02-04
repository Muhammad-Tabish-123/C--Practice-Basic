using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFlow
{
    internal class SwitchExample
    {
        public static void method1()
        {
            Console.WriteLine();
            int myVarSwitch = 9;

            switch (myVarSwitch)
            {
                case 0:
                    Console.WriteLine("myVarSwitch is 0");
                    break;
                case 1:
                    Console.WriteLine("myVarSwitch is 1");
                    break;
                case 5:
                    Console.WriteLine("myVarSwitch is 5");
                    break;
                default:
                    Console.WriteLine("myVarSwitch is Error");
                    break;

            }
        }
    }
}
