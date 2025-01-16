

/*
S - Single Responsibility : A class should have only one reaso to change 
O - Open for Extension, Closed for Modification: Software entities should be open for extension , but closed for medification
L - Liskov's Substitution : A class should have only one reason to change
I - Interface Segragation : A class should have only one reason to change 
D - Dependency Inversion : High-level module/class should not depend on low-level modules/class Both should depend upon abstraction 
S

*/


using System;
using static Part13._1_SolidPrinciple.O_SampleCalculator;

namespace Part13._1_SolidPrinciple
{
    class Print_O_O
    {
        static void Main(string[] args)
        {
            #region -- Example 1 : [NON - OPERATIONAL ] --
            Console.WriteLine();
            Console.WriteLine("********* --  Example 1 --  *********");
            Console.WriteLine(" -- [NON - OPERATIONAL ]  -- ");
            Console.WriteLine();

            // Create instances of operations
            var operations = new O_Operation[] {
                new Add { A = 5, B = 5 },
                new Subtract { A = 5, B = 5 }
                // If you want to add multiply, you would need to create a Multiply class
            };

            // Call the Calculate method
            var sampleCalculator = new O_SampleCalculator();
            sampleCalculator.SimpleCalculatorV1(operations);

            #endregion

            #region -- Example 2 : [USING - OPERATIONAL ] --
            Console.WriteLine();
            Console.WriteLine("********* --  Example 2 --  *********");
            Console.WriteLine(" -- [USING - OPERATIONAL ]  -- ");
            Console.WriteLine();

            // Define operations for using principle of O (Open for Extension, Closed for Modification)
            IOperation[] operations1 = new IOperation[] {
                new AddV2 { A = 5, B = 5 },
                new SubtractV2 { A = 5, B = 5 }
            };

            // Instantiate the calculator and perform calculations
            var calculatorV2 = new SimpleCalculatorV2();
            calculatorV2.Calculate(operations1);
            #endregion
        }
    }
}
