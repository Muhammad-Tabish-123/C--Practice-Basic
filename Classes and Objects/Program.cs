// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Classes_and_Objects.Accounting;
using Classes_and_Objects.HR;

namespace Classes_and_Objects
{
    class program
    {
        static void Main(string[] args)
        {
            //Creating Objects
            Employee bethany = new Developer("Bethany", "Smith", "bethany@gmail.com", 25, new DateTime(1979, 1, 6));
            bethany.DisplayEmployeeDetils();
            Console.WriteLine("Working hours are: " + bethany.WorkedHours);
            bethany.receiveWage();
            bethany.performWork();
            bethany.performWork();
            bethany.performWork();
            bethany.performWork();
            bethany.performWork();
            bethany.performWork();
            bethany.performWork();
            //bethany.WorkedHours = 0;
            Console.WriteLine("Working hours are: " + bethany.WorkedHours);
            bethany.receiveWage();



            //Classes in different namesspace
            Customers cutomer = new Customers();

            //Null value
            int? MyNull = null;

            /////////////////////////////////////////////////////////
            ///Inheritence
            Manager mary=new Manager("Mary","Jonas","mary@snowball.be", 30,new DateTime(1965,1,16));
            mary.DisplayEmployeeDetils();
            mary.performWork();
            mary.performWork();
            mary.performWork();
            mary.receiveWage();

            mary.attendManagemwntMeeting();


            //Abstract classes
            //object as base class
            Object o1 = new Manager("Jonas", "Smith", "jonas@snowball.be", 100, new DateTime(1965, 1, 16));
            //01.attendManagemwntMeeting();


            ////////////////////////////////////////////////////////////////
            ///Interfaces
        }
    }
}
