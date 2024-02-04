// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
namespace Interfaces
{
    class program
    {
        static void Main(string[] args)
        {
            InterfaceManager m1= new InterfaceManager();
            ((i1)m1).show();
            ((i2)m1).show();
            i1 inter = new InterfaceManager();  

            i1 m2= new InterfaceManager();
            m2.show();
            i2 m3= new InterfaceManager();
            m3.show();

            //Console.WriteLine(InterfaceManager().hide2());
        }
    }
}