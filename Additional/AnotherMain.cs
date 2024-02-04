using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional
{
   public class AnotherMain
    {
        static void Main(string[] args)
        {
            String a = new String("nothing");
            String b = new String("nothing");

            Console.WriteLine(Equals(a,b));
            Console.WriteLine(a.Equals(b));
            Console.WriteLine(ReferenceEquals(a, b));
        }
    }
}
