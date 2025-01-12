// See https://aka.ms/new-console-template for more information

/*
LINQ = Language Integrated Querry 
LINQ = is a Querry 
Lambda = is Method - base 

LINQ and Lambda is same lang ginagawa nila also interms of speed or performanace
>> Its a personal reference nalang kung ano yung gagamitin 
>> pero mensan ma force tayo lambda kung yung gagawin natin is nag rerequire ng function which is di available sa LINQ and sa Lambda lang sya pwede magawa 

>>Querry : is like SQLQuerry , is instruction what data to retrived on datasource and the datasource here tha Eunumerable 
            : as well if we need a transformation in our list if wala naman transformation na gagawin wag na tayo gumamit ng LINQ and Lamnda direct nalang tayo gumamit ng IEnumerable 

>> LINQ  is automatically Translated into lambda during the compilelation kaya lambda yung lastform nya 
>> pag walang LINQ yung lambda means mano mano filtering and mano mano iloop yung mga data sa list 
>> means yung LINQ is sya yung nag papadali nong mga ginagawa natin dati 
/
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace  App.Fruits
//format of NameSpace : MainFolder.Folder where the file of Banana.cs located 
{
    public class LINQLAMBDA
    {
        
        static void Main(string[] args )
        {
             Console.WriteLine ();

            //LOOP -> LINQ -> LAMNDA 
            #region -- LOOP -> LINQ -> LAMNDA  -- 


            //Print even numbers only 
            var numbers = new [] { 5, 6, 2, 9, 2,1 };


            //Using Loop and If-else 
            Console.WriteLine ("***************");
            Console.WriteLine("--- USING Loop and If-else ---");
            var evenNumbers = new List<int>(); 
            foreach (var number in numbers )
            {
                if (number % 2 == 0 ) //modulos : checking if the numbers have remainder if meron di sya mag proprocess pero pag wala mag proproceed sya sa loob na iadd nya yung number dun sa evenNumbers
                {
                    evenNumbers.Add(number);
                }
            }

            Console.WriteLine("--- Foreach and If results in modulus added value in evenNumbers variable  ---");
            foreach (var even in evenNumbers)
                Console.WriteLine(even);


            Console.WriteLine ("***************");
            Console.WriteLine("--- USING LINQ ---");
            //Using LINQ 
            var linqEvenNumbers = from number in numbers where number % 2 == 0 select number; //its same functionality dun sa loop pero mas maayus 
            foreach (var even in linqEvenNumbers)
                Console.WriteLine(even);



            Console.WriteLine ("***************");
            Console.WriteLine("--- USING LAMBDA ---");
            //Using LINQ 
            var lambdaEvenNumbers = numbers.Where(number => number % 2 == 0); //number => this part is called input parameter || => : is our operator to define our statement or expression sa loob ng lambda || Where : is nag rerequest sya ng boolean expression na dapat daw mag true ibigsabihin ito yung condition natin if nag true daw yung condition natin na   number % 2  == 0 include nya yung itereation na yun sa result 
            foreach (var even in lambdaEvenNumbers)
                Console.WriteLine(even);

            /*
            Expected output : 6, 2 

            Since 6/2 = 3 so no remainder so iadd nya si 6 

            Where is 5/2 = 2.5 may remainder so si 5 di sya mainclude kasi may remainder sya 

            Loop Approach : old school
            LINQ Approach : Modern 
            LAMBDA Approach : Legend to Modern 

            */
            Console.WriteLine ();
            #endregion 

            //PURELY LINQ & LAMBDA 

            #region  -- PURELY LINQ & LAMBDA -- 

            //LINQ 
            var mixedNumbers = new [] {3, 5, 6, 9 };
            var linqQuerry = from number in mixedNumbers 
                                where number < 9 //include number that less than 9 
                                orderby number descending //higher to lower 
                                select $"numero: {number}"; //convert the int to string and may level na numero kaya yung magiging data type natin dito is IEnumerable<string> nakadepende sa datatype ng select mo yung magiging datatype ng result mo example dito naka string kaya IEnumerable<string> 
            Console.WriteLine("*********************");
            Console.WriteLine (" -- LINQ2 -- ");
            foreach (var num in linqQuerry)
                        Console.WriteLine(num);


            //LAMBDA 
            Console.WriteLine("*********************");
            Console.WriteLine(" -- Lambda2 -- ");
            var lambdaQuerry = mixedNumbers
                                    .Where(number => number < 9 )
                                    .OrderByDescending(number => number)
                                    .Select(number => $"numero: {number}");
            foreach (var num in lambdaQuerry)
                Console.WriteLine(num);

            /*
            LINQ & LAMNDA : yung LINQ and Lambda di lang sya ginagamit sa Primitive Type / Build-in Type 
            Primitive Type / Build-in Type : yung yung mga build in data type like int , string , double , float , etc.
            yunng LINQ & LAMBDA Commonly ginagamit to sa mga custom type for the next example will create a custom class 
            */

            #endregion


        }

    }
}