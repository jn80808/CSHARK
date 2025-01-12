using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace App.Fruits
{

    public class LINQLAMBDA22
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            
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


            #endregion


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

            var numbersPartition = Enumerable.Range(1, 10); // equivalent to {1,2,3,4,5,6,7,8,9,10}
            Console.WriteLine(string.Join(",", numbersPartition)); // join the numbers with separator of ,

            var numberSkip5 = numbers.Skip(5);
            var numberSkipWhile = numbers.SkipWhile( n => n < 5);

            var numberTake5 = numbers.Take(5);
            var numberTakeWhile = numbers.TakeWhile(n => n < 5);

            Console.WriteLine($"Skip5: {string.Join(",", numberSkip5)}");
            Console.WriteLine($"SkipWhile : {string.Join(",", numberSkipWhile)}");
            Console.WriteLine($"Take5 : {string.Join(",", numberTake5)}");
            Console.WriteLine($"TakeWhile: {string.Join(",", numberTakeWhile)}");





            #endregion




           
        }
    }
}