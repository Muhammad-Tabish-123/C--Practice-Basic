using System;
using System.Security.Cryptography;

namespace WorkingWithNulls{
    class Program
    {
        static void Main(string[] args) {
            //nO ERRORS
            //string s1 = "SomeText";
            //Console.WriteLine(s1.Length);
            //int lengthS1=s1.Length;
            //Console.WriteLine(lengthS1);
            //Console.WriteLine(s1.ToUpperInvariant());
            //string upperNameS1=s1.ToUpperInvariant();
            //Console.WriteLine(upperNameS1);

            //eRROR hANDLING
            NullExample.errorHandlingFunction();


            
        }

        

    }
}