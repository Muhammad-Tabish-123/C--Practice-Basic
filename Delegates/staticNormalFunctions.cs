using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    //Q:Can a static method invoke other member functions of its class -> Yes if called through object
    //Static testing
    class MyClass1
    {
        void myNormalFun()
        {
            Console.WriteLine("I swear this is just some text");
        }
        public static void myStaticfun()
        {

            //Object refrence to remove error
            MyClass1 class1 = new MyClass1();
            class1.myNormalFun();
            //myNormalFun();
        }
    }

}
