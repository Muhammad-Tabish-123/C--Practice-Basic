using RecordExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordExample
{
    internal class RecordsExample
    {
        public static void implementationExample()
        {
            Record1 r1 = new Record1("Tim", "Corey");
            Record1 r2 = new Record1("Tim", "Corey");
            Record1 r3 = new Record1("Sue", "Strom");

            //Console.WriteLine(r1.FirstName);
            //Console.WriteLine(r1.LastName);
            //Console.WriteLine(r2.FirstName);
            //Console.WriteLine(r2.LastName);
            //Console.WriteLine(r3.FirstName);
            //Console.WriteLine(r3.LastName);
            Console.WriteLine(r1);
            Console.WriteLine(r2);
            Console.WriteLine(r3);

            Console.WriteLine("-------Equal----------");
            Console.WriteLine(Equals(r1, r1));
            Console.WriteLine(Equals(r1, r2));
            Console.WriteLine(Equals(r2, r3));

            Console.WriteLine("-------RefEqual----------");
            Console.WriteLine(ReferenceEquals(r1, r1));
            Console.WriteLine(ReferenceEquals(r1, r2));
            Console.WriteLine(ReferenceEquals(r2, r3));

            Console.WriteLine("-------Inheritence----------");
            Record2 r201 = new Record2(123);
            Console.WriteLine(r201);

            Console.WriteLine("-------Cloning----------");
            Record2 clone = r201 with { FirstName = "Name1", LastName = "Nmae2" };
            Console.WriteLine(clone);
            Console.WriteLine(ReferenceEquals(clone, r201));
            Console.WriteLine(Equals(clone, r201));
        }
    }
}
