using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional.Structs
{
    struct s1
    {
       public void fun() {
            Console.WriteLine("This is s1 function");
        }
    }
    struct s2 
    {
        public void fun()
        {
            Console.WriteLine("This is s2 function");
        }
    }
    struct s3 : IStruct1, IStruct3
    {
        public void fun()
        {
            Console.WriteLine("Interface inherited by a struct implicit method"); ;
        }
        void IStruct3.fun()
        {
            Console.WriteLine("Interface inherited by a struct explicit method 3"); ;

        }

        void IStruct2.fun()
        {
            Console.WriteLine("Interface inherited by a struct explicit method 2"); ;

        }
        void IStruct1.fun()
        {
            Console.WriteLine("Interface inherited by a struct explicit method 1"); ;
        }
    }
    interface IStruct1
    {
        void fun();
    }
    interface IStruct2
    {
        void fun();
    }
    interface IStruct3 : IStruct2
    {
        new void fun();
    }
}
