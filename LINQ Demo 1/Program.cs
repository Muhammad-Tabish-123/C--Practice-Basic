using System;
using System.Collections;

namespace LINQ_Demo_1{ 
class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------Q1 Working with integers-------------");
            int[] array1= { 10, 20,30,300, 400,500,200,100,99 }; 
            //Order by can be placed before or after where
            var Query1=from i in array1  where i>30 orderby i descending select i;
            foreach (var x in Query1)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("----------Q2 working with strings-------------");
            string[] array2 = { "Aslam","Akram","Ali","Bilal","Ahmad" };
            //Order by can be placed before or after where
            var Query2 = from i in array2 where i.StartsWith("B") orderby i select i;
            foreach (var x in Query2)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("----------Q3 student Class-------------");
            List<Student> studentList = new List<Student>() {
        new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
        new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
    };

            //LINQ Query Syntax to find out teenager students
            var teenAgerStudent = from s in studentList
                                  where s.Age > 12 && s.Age < 20
                                  select s;
            foreach (var s in teenAgerStudent)
            {
                Console.WriteLine($"{s.StudentID} {s.StudentName} {s.Age}");
            }

            //LINQ Method Syntax to find out teenager students
            Console.WriteLine("----------Q3 student Class Method syntax-------------");
            var teenAgerStuden2 = studentList.Where(s=>  s.Age > 12 && s.Age < 20);
            foreach (var s in teenAgerStuden2)
            {
                Console.WriteLine($"{s.StudentID} {s.StudentName} {s.Age}");
            }


            //OfType
            Console.WriteLine("----------OfType QUERY-------------");
            ArrayList mixedArray = new ArrayList()
            {
                "ab",
                "cd",
                1,
                2,
                12.00,
                13.00,
                'a',
                'b',
            };
            var stringResults = from s in mixedArray.OfType<string>() select s;
            foreach(string s in stringResults) { Console.WriteLine(s); }

            var intResults = from n in mixedArray.OfType<int>() select n;
            foreach (int n in intResults) { Console.WriteLine(n); }

            Console.WriteLine("----------OfType Method-------------");
            var stringResultsM = mixedArray.OfType<string>();
            foreach (string s in stringResultsM) { Console.WriteLine(s); }

            var intResultsM = mixedArray.OfType<int>();
            foreach (int n in intResultsM) { Console.WriteLine(n); }

            //OrderBy method
            Console.WriteLine("----------OrderBy Method-------------");
            var teenAgerStudentM =studentList.Where(s=> s.Age > 12 && s.Age < 20).OrderByDescending(s=>s.Age);
            foreach (var s in teenAgerStudentM)
            {
                Console.WriteLine($"{s.StudentID} {s.StudentName} {s.Age}");
            }


            List<Student> studentList2 = new List<Student>() {
    new Student() { StudentID = 1, StudentName = "John", Age = 20 } ,
    new Student() { StudentID = 2, StudentName = "Steve",  Age = 19 } ,
    new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
    new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 },
    new Student() { StudentID = 6, StudentName = "Ram" , Age = 18 }
};
            //ThenBy Query
            Console.WriteLine("----------ThenBy Method-------------");
            var thenByResult=studentList2.OrderBy(s=>s.StudentName).ThenBy(s => s.Age);
            foreach(var t in thenByResult) { Console.WriteLine($"{t.StudentID} {t.StudentName} {t.Age}"); }
            Console.WriteLine("----------ThenBy Method DESC-------------");
            var thenByResultDesc = studentList2.OrderBy(s => s.StudentName).ThenByDescending(s => s.Age);
            foreach (var t in thenByResultDesc) { Console.WriteLine($"{t.StudentID} {t.StudentName} {t.Age}");  }

            //GroupBy Query
            Console.WriteLine("----------GroupBy Query-------------");
            var GroupByResultQ = from r in studentList2 group r by r.Age;
            foreach (var r1 in GroupByResultQ) {
                Console.WriteLine("Age is ::"+r1.Key);
                foreach (var r2 in r1) 
                    Console.WriteLine($"{r2.StudentID} {r2.StudentName} {r2.Age}"); 
            }
            //GroupBy Method
            Console.WriteLine("----------GroupBy Method-------------");
            var GroupByResultM = studentList2.GroupBy(g=>g.Age);
            foreach (var r1 in GroupByResultM) {
                Console.WriteLine("Age is ::" + r1.Key);
                foreach (var r2 in r1)
                Console.WriteLine($"{r2.StudentID} {r2.StudentName} {r2.Age}"); 
            }

            //ToLookUp Method
            Console.WriteLine("----------ToLookUp Method-------------");
            var lookUpResultM = studentList2.ToLookup(g => g.Age);
            foreach (var r1 in lookUpResultM)
            {
                Console.WriteLine("Age is ::" + r1.Key);
                foreach (var r2 in r1)
                    Console.WriteLine($"{r2.StudentID} {r2.StudentName} {r2.Age}");
            }

            //Select
            Console.WriteLine("----------Select-------------");
            var selectResult = from r in studentList2 select new {Name="Mr."+r.StudentName,r.Age };
            foreach(var r in selectResult)
            {
                Console.WriteLine($"Name: {r.Name} -/- Age: {r.Age}");
            }
            //Select Method
            Console.WriteLine("----------Select-------------");
            var selectResult2 = studentList2.Select(s=>new {Name="Mr."+s.StudentName,s.Age });
            foreach (var r in selectResult2)
            {
                Console.WriteLine($"Name: {r.Name} -/- Age: {r.Age}");
            }

            //All Method
            Console.WriteLine("----------All-------------");
            bool areAllStudentsTeenAger = studentList2.All(s =>s.Age>12&&s.Age<20);
            Console.WriteLine(areAllStudentsTeenAger);
            //Any Method
            Console.WriteLine("----------Any-------------");
            bool areAnyStudentsTeenAger = studentList2.Any(s => s.Age > 12 && s.Age < 20);
            Console.WriteLine(areAnyStudentsTeenAger);

            //Aggregate
            Console.WriteLine("----------Aggregate-------------");
            List<String> strList = new List<String>() { "One", "Two", "Three", "Four", "Five" };
            var commaSeperatedString = strList.Aggregate((s1, s2) => s1 + ", " + s2);
            Console.WriteLine(commaSeperatedString);

            //Average
            Console.WriteLine("----------Average-------------");
            var averageAges=studentList2.Average(s => s.Age);
            Console.WriteLine(averageAges);

            //Count
            Console.WriteLine("----------Count-------------");
            var countAges = studentList2.Count();
            Console.WriteLine("Total count: "+countAges);
            var countEvenAges = studentList2.Count(s => s.Age % 2 == 0);
            Console.WriteLine("Even count: " + countEvenAges);

            //Max
            Console.WriteLine("----------Max-------------");
            var maxAge = studentList2.Max(s=>s.Age);
            Console.WriteLine("Max Age: " + maxAge);

            //Sum
            Console.WriteLine("----------Sum-------------");
            var sumAge = studentList2.Sum(s => s.Age);
            Console.WriteLine("Sum Age: " + sumAge);

            //Concat
            Console.WriteLine("----------Concat-------------");
            List<string> collection1 = new List<string>() { "One","One", "Two", "Three","Three","Five" };
            List<string> collection2 = new List<string>() { "Five", "Six" };
            var collection3 = collection1.Concat(collection2);
            foreach (string str in collection3)
                Console.WriteLine(str);

            //Distinct
            Console.WriteLine("----------Distinct-------------");
            var distinctCollection = collection1.Distinct();
            foreach (var str in distinctCollection)
                Console.WriteLine(str);
            //Except
            Console.WriteLine("----------Except-------------");
            var exceptCollection = collection1.Except(collection2);
            foreach (var str in exceptCollection)
                Console.WriteLine(str);
            //Intersect
            Console.WriteLine("----------Intersect-------------");
            var IntersectCollection = collection1.Intersect(collection2);
            foreach (var str in IntersectCollection)
                Console.WriteLine(str);
            //Union
            Console.WriteLine("----------Union-------------");
            var unionCollection = collection1.Union(collection2);
            foreach (var str in unionCollection)
                Console.WriteLine(str);

            //Skip
            Console.WriteLine("----------Skip-------------");
            var skipCollection = collection1.Skip(2);
            foreach (var str in skipCollection)
                Console.WriteLine(str);

            //SkipWhile
            Console.WriteLine("----------SkipWhile-------------");
            var skipWhileCollection = collection1.SkipWhile(s=>s.Length<4);
            foreach (var str in skipWhileCollection)
                Console.WriteLine(str);

            //Take
            Console.WriteLine("----------Take-------------");
            var takeCollection = collection1.Take(2);
            foreach (var str in takeCollection)
                Console.WriteLine(str);

            //TakeWhile
            Console.WriteLine("----------TakeWhile-------------");
            var takeWhileCollection = collection1.TakeWhile(s => s.Length < 4);
            foreach (var str in takeWhileCollection)
                Console.WriteLine(str);


            //TakeWhile
            Console.WriteLine("----------Join-------------");
            List<StudentForJoin> studentListJoin = new List<StudentForJoin>() {
    new StudentForJoin() { StudentID = 1, StudentName = "John", StandardID =1 },
    new StudentForJoin() { StudentID = 2, StudentName = "Moin", StandardID =1 },
    new StudentForJoin() { StudentID = 3, StudentName = "Bill", StandardID =2 },
    new StudentForJoin() { StudentID = 4, StudentName = "Ram" , StandardID =2 },
    new StudentForJoin() { StudentID = 5, StudentName = "Ron"  }
};

            List<StandardForJoin> standardListJoin = new List<StandardForJoin>() {
    new StandardForJoin(){ StandardID = 1, StandardName="Standard 1"},
    new StandardForJoin(){ StandardID = 2, StandardName="Standard 2"},
    new StandardForJoin(){ StandardID = 3, StandardName="Standard 3"}
};

            var innerJoin = studentListJoin.Join(standardListJoin,
                student=>student.StandardID,
                statndard=>statndard.StandardID,
                (student, statndard) => new {student.StudentID,student.StudentName,student.StandardID,statndard.StandardName }
                );

            foreach (var data in innerJoin)
            {
                Console.WriteLine($"{data.StudentID} {data.StudentName} {data.StandardID} {data.StandardName}");
            }


            //
            Console.WriteLine("----------GrpJoin-------------");
            var groupJoin = standardListJoin.GroupJoin(studentListJoin,  //inner sequence
                                std => std.StandardID, //outerKeySelector 
                                s => s.StandardID,     //innerKeySelector
                                (std, studentsGroup) => new // resultSelector 
                                {
                                    Students = studentsGroup,
                                    StandarFulldName = std.StandardName
                                });

            foreach (var item in groupJoin)
            {
                Console.WriteLine(item.StandarFulldName);

                foreach (var stud in item.Students)
                    Console.WriteLine(stud.StudentName);
            }
        }
    }
}