using Additional.ClassInheritence;
using Additional.Structs;
using System;
using Additional.StringRefTest;
namespace Additional
{
    class Program
    {
        static void Main(string[] args) {
            // Testing structs and inheritence
            s1 s1 = new s1();
            s1.fun();
            s2 s2 = new s2();
            s2.fun();
            s3 s3 = new s3();
            s3.fun();

            //IStruct1 s4 = new s3();
            //s4.fun();

            ((IStruct3)s3).fun();
            ((IStruct2)s3).fun();
            ((IStruct1)s3).fun();

            // Testing classes and inheritence
            Class3 obj1= new Class3();
            obj1.fun();

            ((Class2)obj1).fun();
            ((Class1)obj1).fun();


            //Testing Ref Strings
            StringRefTestClass stringRefTestObj=new StringRefTestClass();
        }
    }
}