// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace ExtensioMethods
{
    class Program
    {
       
        static void Main(string[] args) {
            //Console.WriteLine("Now executing Extension Methods");
            ExtensionRequire obj = new ExtensionRequire();
            obj.fun1();
            obj.fun2();
            obj.fun3();
            int i = 20;
            bool b = i.isGreterThan(10);
            Console.WriteLine("is greater than result is " + b);
        }
    }
}