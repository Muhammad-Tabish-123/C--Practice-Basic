using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects.HR
{
    public abstract class Employee: IEmployee
    {


        private string firstName;
        private string lastName;
        private string email;

        private int workedHours;
        private double wage;
        private double ? hourlyRate; //NullAble
        private DateTime birthDay;

        //Properties
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set { firstName = value; }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set { lastName = value; }
        }
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
            }
        }
        public int WorkedHours
        {
            get { return workedHours; }
            set
            {
                workedHours = value;
            }
        }
        public double Wage
        {
            get { return wage; }
            set { wage = value; }
        }
        public double HourlyRate
        {
            get { return hourlyRate.Value; } //fixing return errors for nullAble .Value
            set { hourlyRate = value; }
        }
        public DateTime BirthDay
        {
            get { return birthDay; }
            set { birthDay = value; }
        }

        public string Name { get => "sjsl;askd"; }

        //Constructor
        public Employee(string first, string last, string em, double rate, DateTime bd)
        {
            Console.WriteLine($"\nCreating employee {first}\n");
            firstName = first;
            lastName = last;
            email = em;
            hourlyRate = rate;
            birthDay = bd;
        }
        //Constructor Overloading
        public Employee(string first, string last, string em, DateTime bd) : this(first, last, em, 0, bd)
        {

        }
        public void performWork()
        {
            workedHours++;
            Console.WriteLine($"{firstName} {lastName} is now working!");
        }

        public void stopWorking()
        {
            Console.WriteLine($"${firstName} {lastName} has stopped working!");
        }
        public abstract double receiveWage();
        //{
        //    wage = workedHours * hourlyRate.Value; //fixing type errors for nullAble .Value
        //    Console.WriteLine($"The wage for {workedHours} hours is {wage}");
        //    workedHours = 0;
        //    return wage;
        //}
        public void DisplayEmployeeDetils()
        {
            Console.WriteLine($"\nFirst name: {firstName}\nLast name: {lastName}\nEmail: {email}\nBirthDay: " +
                $"{birthDay.ToShortDateString()}\n");
        }
        public void GiveComplement()
        {
            Console.WriteLine("Interface member implemented");
        }
    }
}
