using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeSystem
{
    internal class Enumeration
    {
        public static void EnumerationImplementation() {
            UsingEnemerations();

            //Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor= ConsoleColor.Green;
            //Console.WriteLine(EmployeeType.Manager);
            //Console.WriteLine(StoreType.FullPieResturant);

            EmployeeType a = EmployeeType.Manager;
            Console.WriteLine(a);
            int b = (int)StoreType.Seating;
            Console.WriteLine(b);
            StoreType c = (StoreType)b; Console.WriteLine(c);
        }
        private static void UsingEnemerations()
        {
            EmployeeType employeeType = EmployeeType.Manager;
            StoreType storeType = StoreType.Seating;
            int baseWage = 1000;
            CalcultateWage(baseWage, employeeType, storeType);
        }
        private static void CalcultateWage(int baseWage, EmployeeType employeeType, StoreType storeType)
        {
            int calculateWage = 0;

            if (employeeType == EmployeeType.Manager)
            {
                calculateWage = baseWage * 3;
            }
            else
            {
                calculateWage *= 2;
            }

            if (storeType == StoreType.FullPieResturant) //Large retail point so giving bonus
                calculateWage += 500;
            Console.WriteLine($"Calculated Wage is : {calculateWage}");

        }
    }
    enum EmployeeType
    {
        Slaes,
        Manager,
        Research,
        StoreManager
    }

    enum StoreType
    {
        PieCorner = 10,
        Seating = 20,
        FullPieResturant = 100,
        Undefined = 99,
    }
}
