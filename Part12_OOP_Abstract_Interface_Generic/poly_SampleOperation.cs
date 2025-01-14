using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Part12_OOP_Abstract_Interface_Generic
{
    public class poly_SampleOperation
    {

        public void Process()
            {
            
                TagaAdd addition = new TagaAdd();
                addition.Compute(5, 10);
                Console.WriteLine("Addition Result: " + addition.Result);

                TagaMinus subtraction = new TagaMinus();
                subtraction.Compute(10, 5);
                Console.WriteLine("Subtraction Result: " + subtraction.Result);

                TagaMultiply multiplication = new TagaMultiply();
                multiplication.Compute(5, 10);
                Console.WriteLine("Multiplication Result: " + multiplication.Result);

                TagaDivide division = new TagaDivide();
                try
                {
                    division.Compute(10, 2);
                    Console.WriteLine("Division Result: " + division.Result);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                TagaAddWith10 addWith10 = new TagaAddWith10();
                addWith10.Compute(5, 10);
                Console.WriteLine("Addition with 10 Result: " + addWith10.Result);


                poly_TagaCompute add = new TagaAdd ();
                add.Compute(1,2);
                //add._result = 0;
                Console.WriteLine($"Add: {add.Result}");

                var addWith10q = new TagaAddWith10();
                TagaAddWith10 poly_TagaCompute = addWith10q;
                poly_TagaCompute.Compute(1,2);
                Console.WriteLine($"Add {poly_TagaCompute.Result}");

            }
        
                
        // Class for addition
        public class TagaAdd : poly_TagaCompute
        {
        }

        // Class for subtraction
        public class TagaMinus : poly_TagaCompute
        {
            public override void Compute(int num1, int num2)
            {
                _result = num1 - num2;
            }
        }

        // Class for multiplication
        public class TagaMultiply : poly_TagaCompute
        {
            public override void Compute(int num1, int num2)
            {
                _result = num1 * num2;
            }
        }

        // Class for division
        public class TagaDivide : poly_TagaCompute
        {
            public override void Compute(int num1, int num2)
            {
                if (num2 == 0) // Handle division by zero
                {
                    throw new DivideByZeroException("Division by zero is not allowed.");
                }
                _result = num1 / num2;
            }
        }

        // Class for adding 10 to both numbers before addition
        public class TagaAddWith10 : poly_TagaCompute
        {
            public override void Compute(int num1, int num2)
            {
                num1 += 10;
                num2 += 10;
               base.Compute(num1 , num2);
            }
        }

    }
}