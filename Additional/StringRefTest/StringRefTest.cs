using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional.StringRefTest
{
    internal class StringRefTestClass
    {
        
        public StringRefTestClass() 
        {
            //string a = "ALPHA";
            //string b = "ALPHA";
            //string c = "ALPHA";

            String a = new String( "ALPHA");
            String b = new String( "ALPHA");
            String c = new String( "ALPHA");



            Console.WriteLine("---------StringTest-------------");
            //Console.WriteLine(ReferenceEquals(a, b));
            if (ReferenceEquals(a, b))
            {
                Console.WriteLine(ReferenceEquals(a, b));
                Console.WriteLine("a and b strings refEqual");
            }
            else
            {
                Console.WriteLine("No ref equal a and b");
            }
            if (ReferenceEquals(b, c))
            {
                Console.WriteLine(ReferenceEquals(b, c));
                Console.WriteLine("b and c strings refEqual");
            }
            else
            {
                Console.WriteLine("Not ref Equal b and c");
            }

            //Console.WriteLine(Equals(a, b));
            if (Equals(a, b))
            {
                Console.WriteLine(Equals(a, b));
                Console.WriteLine("a and b strings Equal");
            }
            else
            {
                Console.WriteLine("No equal a and b");
            }
            if (Equals(b, c))
            {
                Console.WriteLine(Equals(b, c));
                Console.WriteLine("b and c strings Equal");
            }
            else
            {
                Console.WriteLine("Not Equal b and c");
            }
        }
    }
}
