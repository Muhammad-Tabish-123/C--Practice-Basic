using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class GenericAdd
    {
        public void addTwoWhatever<T>(T a, T b)
        {
            //int aNew2 = (int)a;
            //int bNew2= int.Parse(b);
            ///Start Here
            dynamic aNew = a;
            dynamic bNew = b;
            var result = aNew + bNew;
            Console.WriteLine(result);
        }
        public void GenericMethodCall()
        {
            addTwoWhatever(1,5);
            addTwoWhatever("ag", "bd");
        }

    }
}
