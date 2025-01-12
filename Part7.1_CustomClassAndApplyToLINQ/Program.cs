using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace App.Fruits
{
    // Custom Classes
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }
    }

    public class Section
    {
        public string SectionName { get; set; }
        public int Grade { get; set; }
    }


        // Assuming GradeCount is defined as:
        public class GradeCount
        {
            public int GradeC { get; set; }  // Grade as the key for grouping
            public int Count { get; set; }    // Count of students in that grade
            public int StudentCount { get; set; }
        };
        

    public class LINQLAMBDA2
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            // -----------  Custom Class Example -----------  
            #region -- Custom Class Example --

            var students = new List<Student>()
            {
                new Student() { Name = "frace", Age = 32, Grade = 1 },    
                new Student() { Name = "Ace", Age = 25, Grade = 3 },
                new Student() { Name = "truncks", Age = 30, Grade = 1 }
            };

            // Create a sections list
                var sections = new List<Section>()
                {
                    new Section() { SectionName = "A", Grade = 1 },
                    new Section() { SectionName = "B", Grade = 1 },
                    new Section() { SectionName = "C", Grade = 4 }
                };
        
    
            // -------------------------------
            // -----------   LINQ ----------- 
            // ------------------------------- 
            #region  -- LINQ Age > 20 --
            // LINQ Example: Select students with Age > 20
            Console.WriteLine("*********************");
            Console.WriteLine (" -- LINQ2 Age > 20 -- ");
            Console.WriteLine ();

            Console.WriteLine("Students with Age > 20 (LINQ):");
            Console.WriteLine ();
            var query = from sectionLINQ in sections
                        join studentLINQ in students on sectionLINQ.Grade equals studentLINQ.Grade
                        where studentLINQ.Age > 20
                        orderby studentLINQ.Age, studentLINQ.Grade //since naka order by to Asceding for from lower age to high so expected output is si trunks mona bago si frace
                        select new //return value
                        {
                            SectionName = sectionLINQ.SectionName, //since walang mga declare data type dito yung magiging results data type natin is IEnumerable<anonymous> 
                            StudentName = studentLINQ.Name,  //IEnumerable<anonymous>  magandang lang syang gamit pag sa local lang pero pag sa web page need natin to use is strongly type 
                            //StudentAge = student.Age
                        };

            foreach (var sectionAndStudent in query)
            {
                Console.WriteLine($"Section {sectionAndStudent.SectionName}, Student Name: {sectionAndStudent.StudentName}");
            }
            Console.WriteLine ();
            #endregion -- LINQ Age > 20 END--

            // -------------------------------
            //-----------   LAMBDA -----------  
            // -------------------------------
            #region -- LAMBDA Age > 20 --
            Console.WriteLine("*********************");
            Console.WriteLine (" -- LAMBDA Age > 20 -- ");
            Console.WriteLine ();

            Console.WriteLine("Students with Age > 20 (LAMBDA):");
            Console.WriteLine ();
            var lambdaQuery = sections //Table of section join to students table 
                .Join(
                    students.Where(student => student.Age > 20),  // Filter students with Age > 20
                    section => section.Grade,                    // Key selector for sections -- parang yung on pag nag jojoin 
                    student => student.Grade,                    // Key selector for students -- so its like section.Grade on student.Grade or its looks like this section.Grade ==  student.Grade, like comparing lang and returning data that have same value 
                    (section, student) => new                   // Result selector ,we have 2 parameter (section, student) : declaring this para maaccess natin yung data sa section and student 
                    {
                        section.SectionName,                    // adding variable anonymous type so its a IEnumerable <anonymous>
                        StudentName = student.Name,             // Fix property naming
                        student.Age,
                        student.Grade
                    }
                )
                .OrderBy(student => student.Age)                // Fix OrderBy syntax  Age // so what happends is orderby nya mona yung age then next na sya si grade 
                .ThenBy(student => student.Grade);              // Fix ThenBy syntax Grade //alternatively if you want in decending order you can use OrderByDecending() and ThenByDescending()
                                                                // or pwede naman combination of OrderBy() and ThenByDescending()
            //output result
            foreach (var sectionAndStudent in lambdaQuery)
            {
                Console.WriteLine($"Section: {sectionAndStudent.SectionName}, Student Name: {sectionAndStudent.StudentName}");
            }

            Console.WriteLine();
            #endregion -- END LAMBDA Age > 20--


            // --------------------------------------------------------
            //-----------   Grouping with LINQ and LAMBDA -----------   
            // --------------------------------------------------------
            #region -- Grouping for LINQ and LAMBDA --

            // -- LINQ -- 
            //no Strongly Type
            Console.WriteLine("*********************");
            Console.WriteLine (" -- no Strongly Type LINQ -- ");
            Console.WriteLine ();

            var querygroupLINQ = from student in students
                                group student by student.Grade into gradeGroup //into gradeGroup: is a variable is the results of our grouping 
                               // select new { gradeGroup.Key , Count = gradeGroup.Count()}; //select results BEFORE Without strongly data type
                                select new { gradeGroup.Key , Count = gradeGroup.Count()}; // sa new wala pang nakalagay sa baba meron na more info : https://docs.google.com/presentation/d/1qhyAuIu5h35etERvR_uCLokCAgPLxCmM0klR1vYPq9w/edit#slide=id.g324e21e8009_0_20 slide 89
            foreach (var group in querygroupLINQ)
                {
                    Console.WriteLine($"Grade: {group.Key}, Count: {group.Count}");
                }
            
            //with  Strongly Type
            Console.WriteLine("*********************");
            Console.WriteLine (" -- with  Strongly Type LINQ -- ");
            Console.WriteLine ();
            var querygroupLINQ1 = from student in students
                      group student by student.Grade into gradeGroup1
                      select new GradeCount //so firts nag create tayo ng class sa taas and name it as GradeCount and properties dun yung GradeC and Count which is like variable dito sa baba and dahil dito yung data type natin is IEnumerable <GradeCount>
                      {
                          GradeC = gradeGroup1.Key, // Map Key to the Grade property
                          Count = gradeGroup1.Count() // Use Count for the Count property
                      };
            foreach (var group in querygroupLINQ1)
                {
                    Console.WriteLine($"Grade: {group.GradeC}, Count: {group.Count}");
                }

            //LAMBDA 
            //with  Strongly Type
            Console.WriteLine("*********************");
            Console.WriteLine (" -- with  Strongly Type LAMBDA -- ");
            Console.WriteLine ();

            var querygrouplambda = students.GroupBy(student => student.Grade , student => student)
                .Select(groupCount =>
                        new GradeCount 
                        {
                            GradeC = groupCount.Key,
                            StudentCount = groupCount.Count()
                        }
                );
            foreach (var groupCount in querygrouplambda)
                {
                    Console.WriteLine($"Grade: {groupCount.GradeC}, Count: {groupCount.StudentCount}");
                }
            Console.WriteLine ();
            #endregion -- END Grouping for LINQ and LAMBDA --



            // --------------------------------------------------------------------
            // ------- AGREGATION LAMBDA ONLY Means not Available in LINQ --------
            // --------------------------------------------------------------------
            #region  -- AGREGATION LAMBDA ONLY Means not Available in LINQ  --
            Console.WriteLine("*********************");
            Console.WriteLine (" -- AGREGATION THAT AVAILABLE IN LAMNDA   -- ");
            Console.WriteLine ();

            var numbers = Enumerable.Range(1, 10); //equivalent to {1,2,3,4,5,6,7,8,9,10} //shortcut to make 1 - 10 
            Console.WriteLine(string.Join(",", numbers )); //join the numbers with seperator of , 

            //Average 
            Console.WriteLine ();
            Console.WriteLine (" -- average  num1To5Average  -- ");
            var average = numbers.Average();
            var num1To5Average = numbers.Where (n => n <= 5 ).Average();
            Console.WriteLine($"Average: {average}, Average 1 to 5: {num1To5Average}");

            //Count or long Count, use Long Count when expected count is more that int capacity 
            var count = numbers.Count();

            //Max and Mix 
            var maxNumber = numbers.Max();
            var minNumber = numbers.Min();

            //Sum 
            var summation = numbers.Sum();

            Console.WriteLine ();
            Console.WriteLine (" -- Count  Max  MIN  SUM  -- ");
            Console.WriteLine($"Count:{count}, Max: {maxNumber}, Min: {minNumber}, Sum: {summation}");


            #endregion --LAMNDA ONLY


            // --------------------------------------------------------------------
            // ------- CONVERTION LAMBDA ONLY Means not Available in LINQ --------
            // --------------------------------------------------------------------
            #region  -- CONVERTION LAMBDA ONLY Means not Available in LINQ  --
            Console.WriteLine("*********************");
            Console.WriteLine (" -- CONVERTION THAT AVAILABLE IN LAMNDA   -- ");
            Console.WriteLine ();

            var numberstoConvert = Enumerable.Range(1, 10); //equivalent to {1,2,3,4,5,6,7,8,9,10} //shortcut to make 1 - 10 
            Console.WriteLine(string.Join(",", numberstoConvert )); //join the numbers with seperator of ,

            var list = new List<int> (numberstoConvert); // dito naka list ab int tayo tas yung sa line 232 is naka IEnumerable <int> so to fixxed the error need natin iconvert to list 
            var enumValue = list.AsEnumerable(); //converted to enumerable 
            var backToList = enumValue.ToList(); //converted back to list 

            //list = (from number in numberstoConvert where number >= 5 select number); //as per discussion yung LINQ and LAMBDA is always IEnumerable line IEnumerable<int> , IEnumerable <string> , IEnumerable <strongly type > and so on 

            //Convert IEnumerable <int> to List 
            list = (from number in numberstoConvert where number >= 5 select number).ToList();

            Console.WriteLine ();
            #endregion 


            // ------------------------------------------------------------------------------------
            // ------- BASIC ELEMENT ACCESS FUNCTION OF  LAMBDA ONLY Means not Available in LINQ --------
            // ------------------------------------------------------------------------------------
            #region  --BASIC ELEMENT ACCESS FUNCTION OF  LAMBDA ONLY Means not Available in LINQ  --
            Console.WriteLine("*********************");
            Console.WriteLine (" -- BASIC ELEMENT ACCESS FUNCTION THAT AVAILABLE IN LAMNDA   -- ");
            Console.WriteLine ();

            var numbersElemet = Enumerable.Range(1, 10); // equivalent to {1,2,3,4,5,6,7,8,9,10}
            Console.WriteLine(string.Join(",", numbersElemet)); // join the numbers with separator of ,

            var firstNumber = numbersElemet.FirstOrDefault();
            Console.WriteLine("First Number (with default): " + firstNumber);

            var lastNumber = numbersElemet.LastOrDefault();
            Console.WriteLine("Last Number (with default): " + lastNumber);

            var firstEvenNumber = numbersElemet.FirstOrDefault(n => n % 2 == 0);
            Console.WriteLine("First Even Number: " + firstEvenNumber);

            var firstWithoutDefault = numbersElemet.First();
            Console.WriteLine("First Number (without default): " + firstWithoutDefault);

            var lastWithoutDefault = numbersElemet.Last();
            Console.WriteLine("Last Number (without default): " + lastWithoutDefault);

            Console.WriteLine ();
            #endregion


            // ------------------------------------------------------------------------------------
            // ------- PARTITIONING OF LAMBDA ONLY Means not Available in LINQ --------
            // ------------------------------------------------------------------------------------
            #region  -- PARTITIONING OF LAMBDA ONLY Means not Available in LINQ  --
            Console.WriteLine("*********************");
            Console.WriteLine (" -- PARTITIONING OF   -- ");
            Console.WriteLine ();

            #endregion

            // -------------------------------
            // ------- Other Samples --------
            // -------------------------------
            #region -- Other Examples --
            // Lambda Example: Select students with Age > 20
            
            Console.WriteLine("*********************");
            Console.WriteLine (" -- other sample  -- ");
            Console.WriteLine ();
            Console.WriteLine("\nStudents with Age < 30 (Lambda):");
            var youngStudents = students.Where(student => student.Age < 30);
            foreach (var student in youngStudents)
            {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Grade: {student.Grade}");
            }
            
            // LINQ Example: Select students with Grade > 2
            Console.WriteLine("Students with Grade > 2 (LINQ):");
            var highGradeStudents = from student in students
                                    where student.Grade > 2
                                    select student;

            foreach (var student in highGradeStudents)
            {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Grade: {student.Grade}");
            }
            #endregion --other sample end --





            #endregion
        }
    }
}