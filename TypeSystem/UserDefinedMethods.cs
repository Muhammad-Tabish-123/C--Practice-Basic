using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeSystem
{
    internal class UserDefinedMethods
    {
        public static void Method1()
        {
            DisplaySum(3, 5);
            DisplaySum(5, 4);
            DisplaySum(5, 5);
            DisplaySum(10, 5);
            DisplaySum(20, 5);

            int refNum1 = 10;
            int refNum2 = 20;

            //Pass by refrence
            ChngingTwoNums(ref refNum1, ref refNum2);
            Console.WriteLine("refNum1 switched : " + refNum1); Console.WriteLine("refNum2 switched : " + refNum2);

            //Refrence pass out
            int outNum1;
            int outNum2;
            int outNum3;
            ChngingTwoNumsOut(out outNum1, out outNum2, out outNum3);
            Console.WriteLine("outNum1 switched : " + outNum1); Console.WriteLine("outNum2 switched : " + outNum2);

            //Using params
            DisplayNumbers(10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20);

            //Arrow function calling
            CSharpArrowMethod();
            Console.WriteLine(CSharpArrowMethod2());
        }
        public static void DisplaySum(int a, int b)
        {
            Console.WriteLine("Sum is : " + (a + b));
        }
        public static void ChngingTwoNums(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("a switched : " + a); Console.WriteLine("b switched : " + b);
        }
        public static void ChngingTwoNumsOut(out int a, out int b, out int c)
        {
            a = 100;
            b = 50;
            c = 40;
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("a switched : " + a); Console.WriteLine("b switched : " + b);
        }
        public static void DisplayNumbers(params int[] args)
        {
            Console.WriteLine("\nShowing params data using loop");
            foreach (int i in args) Console.WriteLine(i);
        }

        //ArrowMethod
        public static void CSharpArrowMethod() => Console.WriteLine("\nWorkingArrowFunction");

        public static string CSharpArrowMethod2() => "\nDataReturningArrowFunctionSuccess";
    }
}
