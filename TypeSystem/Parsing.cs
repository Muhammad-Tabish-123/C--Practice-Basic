using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeSystem
{
    internal class Parsing
    {
        public static void Simple()
        {
            //Parsing
            string w = "1300";
            double wage = double.Parse(w);
            bool active = bool.Parse("true");
            Console.WriteLine(wage);
            Console.WriteLine(active);
        }
        public static void Tryparse()
        {
            //Tryparse
            string enteredText = "true";
            if (bool.TryParse(enteredText, out bool enteredTextTry))  //Trypass to avoid runtime error
            {
                Console.WriteLine($"Thsi value is {enteredTextTry}");
            }
        }
        public static void DateParsing()
        {
            //Date parsing
            string hireDateString = "16/1/23";
            System.DateTime hireDate = System.DateTime.Parse(hireDateString);
            Console.WriteLine("Parsed date : " + hireDate);

            var cultureInfo = new CultureInfo("nl-BE");
            string birthDayStringDetch = "28 Maart 1948";//Dutch spoken in belgium
            System.DateTime birthDay = System.DateTime.Parse(birthDayStringDetch, cultureInfo);
            Console.WriteLine("BirthDAY : " + birthDay);
        }
    }
}
