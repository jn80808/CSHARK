using System.ComponentModel;

// Part2.cs
using System;


// Part 2 : local Variables , Var Scope , Keywords , Class vs Instance Variable , Parsing , Convert 


public class Part1
{
    public void Execute()
    {
        
            //WET and DRY Principle
            
            Console.WriteLine("PARRRRRRRRTTTTTTTTTTT1");
            Console.WriteLine(); // Adds a blank line
                        
            Console.WriteLine("Hello, World!");

            // LESSON PART 1 : VARIABLES AND DATA TYPES

            // Reference Tutorial: https://www.youtube.com/watch?v=aypXF837HfM&list=PLERakPgTjTl_MpF-PWX1FdtYa0hKrZVWS&index=4
            // NO KISS
            Console.WriteLine("NO KISS");
            Console.WriteLine(); // Adds a blank line


            int sampleNumber = 100;
            string numberstring = ConvertToString(sampleNumber);

            string ConvertToString(int number)
            {
            return number.ToString();
            }

            Console.WriteLine(sampleNumber);
            Console.WriteLine(); // Adds a blank line
            // With KISS: Keep It Simple Stupid
            Console.WriteLine("With Kiss");
            Console.WriteLine(); // Adds a blank line

            int sampleNumberWithKiss = 100;
            Console.Write(sampleNumberWithKiss);
            Console.WriteLine(); // Adds a blank line

            // Sample of not DAMP: Descriptive And Meaningful Phrases
            Console.WriteLine("DAMP");
            // Violated yung DAMP principle kasi di natin malalaman kung ano ibig sabihin ng variable na 'a'
            var a = 10;
            Console.WriteLine($"This not Good Practice of DAMP: {a}");
            // Now, mas descriptive na yung variable name natin tapos alam na natin kung ano purpose nang variable 
            var numberOfApples = 10;
            Console.WriteLine($"Number of Apple: {numberOfApples}");

            Console.WriteLine(); // Adds a blank line
            // WET and DRY Principle
            Console.WriteLine("WET");
            int aa = 1;
            int b = 2;
            int c = 3;
            int d = 4;
            int e = 5;
            int f = 6;

            //#region  -- WET PRINCIPLE --

            Console.WriteLine($"a + b = {aa + b}");
            Console.WriteLine($"c + b = {c + b}");
            // Violated na dito na part yung WET principle dahil more than 2 times ka nag repeat nang same process
            // WET: Write Everything Twice : so don't write code twice if you do means you violated the WET Principle
            Console.WriteLine("Violated WET");
            Console.WriteLine($"d + e: {c + d}");

            // DRY: DO NOT REPEAT YOURSELF
            // So sa taas is ulit ulit yung process nya and to solve this is
            // gagamit tayo ng function
            Console.WriteLine("DRY");
            // Gumagamit nang DRY Principle para di natin ma violate ung WET Principle
            AddAndPrint("a + b", aa, b);
            AddAndPrint("b + c", b, c);
            AddAndPrint("d + e", d, e);
            AddAndPrint("d + f", d, f);

            void AddAndPrint(string text, int firstNum, int secondNum)
            {
            Console.WriteLine($"{text} = {firstNum + secondNum}");
            }

            // Data Type Categories
            // Value Type: stores its contents in memory allocated on the stack {Value Types}
            // Reference Type: is basically stored on the heap and passed by creating a reference {reference type}
            // for more discussion notes: https://docs.google.com/presentation/d/1qhyAuIu5h35etERvR_uCLokCAgPLxCmM0klR1vYPq9w/edit#slide=id.g323ce48552b_0_2043

            // to continue: https://www.youtube.com/watch?v=aypXF837HfM&list=PLERakPgTjTl_MpF-PWX1FdtYa0hKrZVWS&index=4

            // Part 2: local Variables, Var Scope, Keywords, Class vs Instance Variable, Parsing, Convert


    }
}