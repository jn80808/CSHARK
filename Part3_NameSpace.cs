// NameSpace is used to logically arrange classes , structs , interface 
// enums and delegates . The name space in C# can be nested.
// that means one namespace can contain other namespaces also.

//Using System : Its means that gusto mo gamiting yung mga classes under sa namespace 
//namepsace NameofNameSpace: ito naman yung pag lalagyan ng class 
// class Program : under sya ni name space 
// its like a main folder with subfolder then file 

//Example
using System.ComponentModel;

using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections;


namespace NamespaceName
{
    // Classes, interfaces, structs, enums, and delegates go here.
    public class ClassName
    {
        // Class members (fields, properties, methods, etc.)
        string vars = "Hi Joy";

        public void PrintMessageJoy()
        {
            Console.WriteLine("vars: {0}", vars);
        }
    }

    public interface InterfaceName
    {
        // Interface members
    }

    public struct StructName
    {
        // Struct members
    }

    public enum EnumName
    {
        // Enum values
        Value1,
        Value2,
        Value3
    }

    public delegate void DelegateName();
}

//No Output 
namespace App.Fruits
{
    class fuitsOfAppleandBananaa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Namespace for Fruits");

            // Creating a Queue object
            var queue = new Queue();

            Console.WriteLine("Queue Count: " + queue.Count);

            // Using the Banana class
            var banana = new Banana();
            banana.PrintBanana();

            // Using the Apple class
            var apple = new Apple();
            apple.PrintApple();
        }
    }
}





