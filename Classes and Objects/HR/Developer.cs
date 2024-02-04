using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects.HR
{
    //Sealed
    public sealed class Developer : Employee
    {
        public Developer(string first, string last, string em, double rate, DateTime bd) : base(first, last, em, rate, bd)
        {
        }

        public override double receiveWage()
        {
            Console.WriteLine("Abstrated method receiveWage() is implemente");
            Wage = WorkedHours * HourlyRate; //fixing type errors for nullAble .Value
            //Console.WriteLine($"The wage for {workedHours} hours is {wage}");
            WorkedHours = 0;
            return Wage;
        }
    }
}

//public class JuniorDeveloper: JuniorDeveloper
//{
//    public JuniorDeveloper(string first, string last, string em, double rate, DateTime bd) : base(first, last, em, rate, bd)
//    {

//    }
//}
