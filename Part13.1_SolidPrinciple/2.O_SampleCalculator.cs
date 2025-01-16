using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Part13._1_SolidPrinciple
{
        public class O_SampleCalculator
        {
            
        public void Calculate(Operation[] operations)
        {
            foreach (var operation in operations)
            {
                if (operation is Add)
                {
                    Console.WriteLine($"For Add class: {operation.A + operation.B}");
                }
                else if (operation is Subtract)
                {
                    Console.WriteLine($"For Subtract class: {operation.A - operation.B}");
                }
            }
        }
    }

    public abstract class Operation
    {
        public int A { get; set; }
        public int B { get; set; }
    }

    public class Add : Operation
    {
    }

    public class Subtract : Operation
    {
    }

    // Example Usage
    class Program
    {
        static void Main()
        {
            var operations = new Operation[]
            {
                new Add { A = 10, B = 5 },
                new Subtract { A = 10, B = 5 }
            };

            var calculator = new O_SampleCalculator();
            calculator.Calculate(operations);
        }
    }
        
}