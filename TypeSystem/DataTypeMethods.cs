using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeSystem
{
    internal class DataTypeMethods
    {
        public static void DataType()
        {
            int c = int.MaxValue; int d = int.MinValue;
            double e = double.MaxValue;
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);

            char myChar = 'a';
            bool isWhiteSpace = char.IsWhiteSpace(myChar);
            Console.WriteLine(isWhiteSpace);
            bool isDigit = char.IsDigit(myChar);
            Console.WriteLine(isDigit);
            Console.WriteLine(char.ToUpper(myChar));

            Console.WriteLine(char.IsLetterOrDigit(myChar));
        }
    }
}
