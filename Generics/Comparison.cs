using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Comparison
    {
        public void GenericMethodComparison<T>(T a, T b)
        {
            bool result = a.Equals(b);
            Console.WriteLine(result);
        }
        public void GenericMethodCall()
        {
            GenericMethodComparison(10, 10);
            GenericMethodComparison("Alpha", "Alpha");
            GenericMethodComparison('a', 'a');
            GenericMethodComparison(10, 15);
            GenericMethodComparison("alpha", "ALPHA");
            GenericMethodComparison('A', 'a');
            GenericMethodComparison("alpha", "ALPHA");
            GenericMethodComparison(true, true);
            GenericMethodComparison(false, false);

        }
    }
}
