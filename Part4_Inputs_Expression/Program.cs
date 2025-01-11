// See https://aka.ms/new-console-template for more information
using System;
using System.Reflection;
using System.Security.Cryptography;

namespace Inputs
{
    class InputProgram
    {
        static void Main(string[] args)
        {
            // Write vs WriteLine
            #region -- Write vs WriteLine --
            //comment out lang mona
            // Console.WriteLine("");
            // Console.WriteLine("***************");
            // Console.WriteLine("--  Write vs WriteLine --");

            // Console.Write("a");
            // Console.Write("b");

            // Console.WriteLine("c");
            // Console.WriteLine("d");

            // Console.Write($"e {Environment.NewLine}"); //Environment.NewLine create a new line instead using of \n 
            // Console.WriteLine("k\n"); // using backlash n
             #endregion

            //Read vs ReadLine 
            // Read : is kinukuha nya lang yung 1st character sa Inputed mo exam Test yung T lang yung kinukuha nya and  yung ibabalik nya yung keycode value of integer nong character na yun  
            #region  -- Read & ReadLine -- 
            // Console.WriteLine("");
            // Console.WriteLine("***************");
            // Console.WriteLine("-- Read vs ReadLine --");
            // var readTest = Console.Read();     // try to input A and the output is 65 so its means the value of lower case of a is 97 its binary value 
            // Console.WriteLine ($"readTest : {readTest}"); 
            #endregion

            // ReadLine and WriteLine
            #region -- ReadLine and WriteLine --
            // Console.WriteLine("");
            // Console.WriteLine("***************");
            // Console.WriteLine("-- ReadLine and WriteLine --");

            // var stringValue = Console.ReadLine();
            // Console.WriteLine($"Inputted Value:{stringValue}");// sa output in nirereflect nya mona kung ano yung input natin bago nya ireflect tong writeline natin ang nanangyayare is nag wiwrite mona sya bago iexecute yung writeline 
            
            #endregion
        
            // Input
            #region  -- Input --
                
            // Console.WriteLine("");
            // Console.WriteLine("***************");
            // Console.WriteLine("-- Input --");

            // Console.WriteLine("Input your age: "); // we put this so that user know what input you asking
            // var ageString = Console.ReadLine(); //we use ReadLine para mag antay ng input ni User 
            // var age = int.Parse(ageString);
            // if (age < 18 )
            //     Console.WriteLine("minor");
            // else    
            //     Console.WriteLine("adult");

            #endregion

            // Expression & Operator
            /*expression is yung mga value natin or mga evaluated value natin 
                For Example :
                1.Constant expression : 10 -- this is single experssion
                2.Literal expression with "*" (Multiplication) operator: 5 * 2
                3.Compound expression : 2 + (4*2) -- compound expreession kasi may group sya so unang nyang eevaluate yung nasa right side na (4*2) syaka nya i-evaluate kasama na yung 2 
                4.Void Expression : Console.WriteLine () --No return Value 
                5.Assignment Expression : a = 10 , Compound Assignment : a = 5 
                6.Primary Expression : Math.Pow(10,1) -- this is Pow : Power so 10 to the Power of 1 , 10^1 
                7.Bolean Expression : True or False 

            // Operator : is the symbol we use to manipulate variables and values 
                1.Assignment Operator : =
                2.Arithmetic Operator : * / + - %
                3.Boolean/Logical Operator : and or 
                4.Equality Operator : == /=
                5.Comparison Operator : <> , => <= 
                6.Null - Coalescing Operator : ??
                7.Unary Operator :  ++ -- ! -- to inverse the value
                8.Ternary Operator : ? :
                9.Bitwise and Shift Operators : 
            */
            
            // Null - Coaleasing 
            #region -- Null - Coaleasing  -- 
            var sampleString = "may laman";
            string? nullString = null ; 
            var sampleResult1 = sampleString ?? "sampleString nilagyan nang laman"; //if null yung value na nasa left side matic iaaply nya yung value na nasa rightside 
            var sampleResult2 = nullString ?? "nullString nilagyan nang laman"; // as example dito yung nullstring na variable is null so as expected yung mag ooutput is yung nasa rightside which is "nullString nilagyan nang laman"

            Console.WriteLine (sampleResult1);
            Console.WriteLine (sampleResult2);

            #endregion

            //Unary 
            #region -- Unary --
                
            // Console.WriteLine("");
            // Console.WriteLine("***************");
            // Console.WriteLine("-- Unary using ! --");
            // //using !
            // var trueValue = true;
            // trueValue = !trueValue; //! is Not or "Inverted BOOLEAN VALUE" since ! so from true it will inverse so false na yung value nya 
            // Console.WriteLine(trueValue );

            // //increment and decrement 
            // Console.WriteLine("");
            // Console.WriteLine("***************");
            // Console.WriteLine("-- Unary using increment and decrement --");
            // /*
            // Post increment: <operand> ++ 
            // Pre increment : ++<operand> 

            //     Post vs. Pre 
            //     Post : is evaluate nya mona bago nya isuply yung incrementation 
            //     Pre : is apply nya mona yung incrementation bago nya mag evaluate 
            // */
            // var numberIncrementDecrement = 10;
            // Console.WriteLine("Post Increment");//<operand> ++
            // //Equivalent to : numberIncrementDecrement = numberIncrementDecrement + 1;
            // Console.WriteLine(numberIncrementDecrement++);
            // //Equivalent to : numberIncrementDecrement = numberIncrementDecrement - 1 ;
            // Console.WriteLine(numberIncrementDecrement--);

            // numberIncrementDecrement = 10;
            // Console.WriteLine("Pre Increment"); //++<operand>
            // //Post incr and decr 
            // Console.WriteLine(++numberIncrementDecrement);
            // Console.WriteLine(--numberIncrementDecrement);

            // var numberIncrementDecrementcomparisonpost = 20;
            // var numberIncrementDecrementcomparisonpre = 20;
            // Console.WriteLine("comparison"); //++<operand>
            // //Post incr and decr 
            // Console.WriteLine("++ {0}",numberIncrementDecrementcomparisonpost ++);
            // Console.WriteLine("++ {0}",++numberIncrementDecrementcomparisonpost);
            // Console.WriteLine("-- {0}",--numberIncrementDecrementcomparisonpre);
            // Console.WriteLine("-- {0}",numberIncrementDecrementcomparisonpre--);

            #endregion

            // Ternary 
            #region  -- ternary -- 
            // //ternary is like if else 
            // Console.WriteLine("");
            // Console.WriteLine("***************");
            // Console.WriteLine("-- Ternary --");

            // var sampleStringTernary = "frace";
            // var result = sampleStringTernary == "frace" ? "programmertv" : "??unknown??";
            // Console.WriteLine(result);
            // // resutlt = checking if yung variable na sampleStringTernary is frace ? when true then yung output is programmertv : when false then unknown 
            // // result = sampleStringTernary = "frace" ? True : Flase 
            // // result =   condition ? True : Flase 

            // //other example
            // Console.WriteLine("Input your age: "); // we put this so that user know what input you asking
            // var ageString = Console.ReadLine(); //we use ReadLine para mag antay ng input ni User 
            // var age = int.Parse(ageString);
            // Console.WriteLine (age   < 18 ? "minor" : "adult");

            #endregion


            //combination : Input + Expression + Operator 
            #region -- Combination -- 
                
            // //sample of pythogorean theorem 
            // //Formula to get C : c = square root of ( a square + b square )

            // //Input is a and b 
            // //Output is c 

            // Console.WriteLine("Input a value: ");
            // var FormulaA = double.Parse(Console.ReadLine());
            // Console.WriteLine("Input b value: ");
            // var FormulaB = double.Parse(Console.ReadLine());

            // var formulaResult = Math.Sqrt(Math.Pow(FormulaA,2) + Math.Pow(FormulaB,2));
            // Console.WriteLine($"Sample C result: {formulaResult}");

            #endregion

        }
    }
}

