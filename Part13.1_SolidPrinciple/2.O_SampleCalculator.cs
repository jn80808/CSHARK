using System;

namespace Part13._1_SolidPrinciple
{
    #region  -- Without Principle of O -- 
    //Not Using O - Open for Extension, Closed for Modification: Software entities should be open for extension, but closed for modification
    public class O_SampleCalculator
    {  
        //Calculate Function: If we add a new operation like divide, we need to modify the calculate function and add an else-if block, which violates the O principle (no modification, but open for extension)
        public void SimpleCalculatorV1(O_Operation[] operations)
        {
            foreach (var operation in operations)
            {
                if (operation is Add addOperation)
                {
                    Console.WriteLine($"For Add class: {addOperation.A + addOperation.B}");
                }
                else if (operation is Subtract subtractOperation)
                {
                    Console.WriteLine($"For Subtract class: {subtractOperation.A - subtractOperation.B}");
                }
            }
        }

        // Abstract class
        public abstract class O_Operation
        {
            public int A { get; set; }
            public int B { get; set; }
        }

        // 2 Derived Classes
        public class Add : O_Operation { }
        public class Subtract : O_Operation { }
    }
    #endregion

    #region  -- With Principle of O -- 
    // Define the IOperation interface
    public interface IOperation
    {
        int A { get; set; }
        int B { get; set; }
        void Compute();
    }

    // Abstract class implementing IOperation
    public abstract class OperationV2 : IOperation
    {
        public int A { get; set; }
        public int B { get; set; }
        public abstract void Compute(); // inabstract natin yung Compute na method dito para sa evertime may magiinheret din nong OperationV2 is ifoforce din nya iimplement to para unique yung implementation nya  
                                                    //The override keyword in C# is used to provide a new implementation of a method in a derived class that is already defined in its base class. This happens when the base class declares the method as virtual, abstract, or part of an interface.
    }

    // AddV2 class extending OperationV2
    public class AddV2 : OperationV2 //inherit OperationV2 so dun sa taas yung Compute method is naka absrtract so we need to implement here sa loob as explanation dun sa taas 
    {
        public override void Compute()
        {
            Console.WriteLine($"For Add class: {A + B}");
        }
    }

    // SubtractV2 class extending OperationV2
    public class SubtractV2 : OperationV2
    {
        public override void Compute()
        {
            Console.WriteLine($"For Subtract class: {A - B}");
        }
    }

    // SimpleCalculatorV2 class to process calculations
    public class SimpleCalculatorV2 //hindi na natin kaylangan icheck yung data type for every item kasi  ginagamitan na natin to ng absrtact na IOperation bali yung parent natin na IOPeration yung nag add up sa and nag susubract 
    {
        public void Calculate(IOperation[] operations)
        {
            foreach (var operation in operations)
            {
                operation.Compute();
            }
        }
    }
    #endregion

}
