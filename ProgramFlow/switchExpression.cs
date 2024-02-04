using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFlow
{
    internal class switchExpression
    {
        public static void method1()
        {
            Console.WriteLine();
            var categoryid = "3";
            var productId = categoryid switch
            {
                "1" => 1,
                "2" => 2,
                "3" => 3,
                "9" => 9,
                _ => 0,
            };
            Console.WriteLine($"given id : {categoryid}");
            Console.WriteLine($"Assigned from switch : {productId}");

        }
    }
}
