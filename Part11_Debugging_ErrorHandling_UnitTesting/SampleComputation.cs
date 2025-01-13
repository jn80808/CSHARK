using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Part11_Debugging_ErrorHandling_UnitTesting
{
    public class SampleComputation
    {
            public int Compute(int num1, int num2, SampleOperator op)
            {
                switch (op)
                {
                    case SampleOperator.Add:
                        return num1 + num2;

                    case SampleOperator.Subtract:
                        return num1 - num2;

                    case SampleOperator.Multiply:
                        return num1 * num2;

                    case SampleOperator.Divide:
                        // Handle division by zero
                        if (num2 == 0)
                        {
                            throw new InvalidOperationException("Cannot divide by zero.");
                        }
                        return num1 / num2;

                    default:
                        throw new ArgumentOutOfRangeException(nameof(op), op, "Unknown operator");
                }
            }
        }

        public enum SampleOperator
        {
            Add,
            Subtract,
            Divide,
            Multiply
        }



    }
