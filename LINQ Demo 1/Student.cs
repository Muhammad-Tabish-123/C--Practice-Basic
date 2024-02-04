using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Demo_1
{
    internal class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }

    }
    internal class StudentForJoin : Student
    {
        public int StandardID{ get; set; }
    }
    internal class StandardForJoin : StudentForJoin
    {
        public string StandardName{ get; set; }
    }
}
