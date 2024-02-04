using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeSystem
{
    
    internal class Structs
    {

        public static void Method1()
        {
            Console.ForegroundColor= ConsoleColor.Cyan;
            Employee emp;
            emp.Name = "Jack";
            emp.Wage = 1234;
            emp.Work();
            UsingAStruct();
        }

        private static void UsingAStruct()
        {
            Employee empolyee;
            empolyee.Name = "Bethany";
            empolyee.Wage = 1200;
            empolyee.Work();
        }

        struct Employee
        {
            public string Name="a";
            public int Wage=10;

            
            public void Work()
            {
                Console.WriteLine($"{Name} is working now and his wage is {Wage}");
            }
        }
    }
}
