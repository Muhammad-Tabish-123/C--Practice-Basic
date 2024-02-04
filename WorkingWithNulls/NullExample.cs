using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithNulls
{
    internal class NullExample
    {
        
        public static void errorHandlingFunction()
        {
            string s1 = "SomeText";
            string? s2 = null;

            Console.WriteLine(s1?.Length);
            //int? lengthS2 = s2.Length;
            //Console.WriteLine(lengthS2);
            Console.WriteLine(s2?.Length);
            Console.WriteLine(s2?.ToUpperInvariant());
            //string upperNameS2 = s2.ToUpperInvariant();
            Console.WriteLine(s2?.ToUpperInvariant());

            // Starting Operators
            string s3 = 1 > 0 ? "True" : "Fasle";
            Console.WriteLine(s3);
            int n3 = 1 > 0 ? 1 : -1;
            Console.WriteLine(n3);
            bool b3 = 1 > 0 ? true : false;
            Console.WriteLine(b3);


            string? nullString = null;
            //nullString = nullString ?? "SomeText";
            nullString ??= "SomeText??=";
            Console.WriteLine(nullString);

            Player?[] arr = {
                new Player{ PName="Sara"},
                new Player(),
                null,
            };


            int? p1 = arr?[0]?.PName?.Length;
            int? p2 = arr?[1]?.PName?.Length;
            int? p3 = arr?[2]?.PName?.Length;

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);

            //for (int i =0; i<arr.Length;i++) Console.WriteLine(arr?[i]);

        }

    }
}
