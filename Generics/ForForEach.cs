using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class ForForEach
    {
        public void GenericMethod<T>(T[] arr)
        {
            Console.WriteLine();
            Console.WriteLine(typeof(T));
            Console.WriteLine("For loop");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("For Each loop");
            foreach (T i in arr)
            {
                Console.WriteLine(i);
            }
        }
        public void GenericMethodCall<T>(T[] Arr)
        {
            GenericMethod(Arr);
            GenericMethod(Arr);
            GenericMethod(Arr);

        }
    }
}
