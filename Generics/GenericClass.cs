using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class GenericClass<T>
    {
        public void isEqula(T a,T b)
        {
            Console.WriteLine(a?.Equals(b));
        } 
        public void showVlaues(T[] arr)
        {
            foreach (T t in arr) Console.WriteLine(t);
        }
        
    }
}
