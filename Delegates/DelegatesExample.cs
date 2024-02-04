using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class DelegatesExample
    {
        public void addition(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Additon is " + result);
        }
        public void subtration(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Subtration is " + result);
        }
        public void multiplaction(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("Multiplication is " + result);
        }
        public void division(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("Division is " + result);
        }
        delegate void Calculation(int a, int b);

        public void implementationExample()
        {
            DelegatesExample p = new DelegatesExample();
            Calculation calc = new Calculation(p.addition);
            calc.Invoke(10, 20);
            calc(10, 40);
            calc = p.subtration;
            calc(10, 20);
            calc = p.multiplaction;
            calc(10, 20);
            calc = p.division;
            calc(10, 5);

            Calculation calc1 = new Calculation(p.multiplaction);
            calc1(5, 6);
            Calculation calc2 = new Calculation(p.subtration);
            calc2(5, 6);
            Calculation calc3 = new Calculation(p.division);
            calc3(20, 2);
            calc3(20, 3);
            //MyClass1.myStaticfun(); 
        }
    }
}
