using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFlow
{
    internal class SwitchWhen
    {
        public static void method1()
        {
            Console.WriteLine();
            int discountId = 25;
            switch (discountId)
            {
                case int id when id < 10:
                    Console.Write("Id in when is less than 10");
                    break;
                case int id when id > 10 && id <= 20:
                    Console.Write("Id in when is between 10 and 20");
                    break;
                default:
                    Console.WriteLine("id in when greter than 20");
                    break;
            }
        }
        
}
}
