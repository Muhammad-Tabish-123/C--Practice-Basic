using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects.HR
{
    internal class Manager : Employee
    {
        public Manager(string first, string last, string em, double rate, DateTime bd) : base(first, last, em, rate, bd)
        {
        }
        public void attendManagemwntMeeting()
        {
            WorkedHours += 10;
            Console.WriteLine($"{FirstName} {LastName} is now attending management vmeeting");
        }

        public override double receiveWage()
        {
            Wage = WorkedHours * HourlyRate; //fixing type errors for nullable .value
            Console.WriteLine($"the wage for {WorkedHours} hours is {Wage}");
            WorkedHours = 0;
            return Wage;
        }
    }
}
