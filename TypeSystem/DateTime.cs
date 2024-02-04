using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeSystem
{
    internal class DateTime
    {
        public static void Method1()
        {
            System.DateTime someDateAndTime1 = new System.DateTime(2021, 03, 28);
            System.DateTime someDateAndTime2 = new System.DateTime(2021, 3, 28);
            System.DateTime someDateAndTime3 = System.DateTime.Now;
            System.DateTime someDateAndTime4 = System.DateTime.Today;
            bool someDateAndTime5 = someDateAndTime3.IsDaylightSavingTime();


            Console.WriteLine(someDateAndTime1);
            Console.WriteLine(someDateAndTime2);
            Console.WriteLine(someDateAndTime3);
            Console.WriteLine(someDateAndTime4);
            Console.WriteLine(someDateAndTime5);

            System.DateTime startHour = System.DateTime.Now;
            TimeSpan workTime = new TimeSpan(8, 35, 0);
            System.DateTime endHour = startHour.Add(workTime);
            Console.WriteLine("statr hour : " + startHour);
            Console.WriteLine("end hour : " + endHour);
            Console.WriteLine("statr hour LongDate : " + startHour.ToLongDateString());
            Console.WriteLine("statr hour ShortDate : " + startHour.ToShortDateString());

            Console.WriteLine("end hour LongTime : " + endHour.ToLongTimeString());
            Console.WriteLine("end hour ShortTime : " + endHour.ToShortTimeString());
        }
    }
}
