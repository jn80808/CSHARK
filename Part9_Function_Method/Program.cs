

using System.Reflection;

namespace Function_Method
{
    class Function_Method
    {
        static void Main(string[] args) // what this did this part is ito yung unang ieexecute pag nirurun yung C# project , means kahit saanng class yan nakalagay pag irun mo yung project mo hahanap hahanapin nya yung static void main and kung ano man laman nito yun yung ieexecute nya and pag wala to wala syang ieexecute 
            {                               // ayun nga pag wala to during execution palang mag kakaron ka na ng error na Program does not contain a Static "Main" (No Entry Point) kaya itong part na to is important 
    
                    /*
                    Syntax : <access specifier> <Return Type> <Method Name> (Parameters)
                    {
                        Method Body
                    }

                    <access specifier> : Visibilty ng function natin pwede maging public , private , protected 
                    <Return Type> : ito naman yung Data Type na nirereturn sa function natin , Pwede naman walang Data Type ayun yung gumagamit ng void
                    <Method Name> : Naming Method its depends on you what will be the name of the Method 
                    (Parameters) : is parang input sa function , bali dito natin nirerecieve yung mga data galing sa pag tawag ng function natin  
                    Method Body : ito naman yung series of Line of Code 

                    */

                //------------------------------------------------------------------------------------------- 
                //--------- AS PER DISCUSSION HERE SA  static void Main(string[] args) NAG OOUTPUT ----------
                //------------------------------------------------------------------------------------------- 

                //Example 1 : Initial Function
                #region -- Example 1 : Initial Function -- 

                    Console.WriteLine();
                    Console.WriteLine("********* --  Example 1 --  *********");
                    Console.WriteLine(" -- Initial Function  -- ");
                    Console.WriteLine();


                    // Creating an instance of Program
                    var program = new Function_Method(); //line 3 commonly class Program yan ni change ko lang 
                        // Calling methods
                        program.PrintName();
                        program.PrintNameWithParam("Joy Ng");
                        program.PrintNameWithAge("No Name", 25);

                    #endregion


                //Example 2 : Using params Keyword 
                #region  -- Using params Keyword -- 

                    Console.WriteLine();
                    Console.WriteLine("********* --  Example 2 --  *********");
                    Console.WriteLine(" --  Using params Keyword   -- ");
                    Console.WriteLine();

                    var Function_Method = new Function_Method ();

                    Function_Method.PrintNumber1 ("1", "4", "3");

                #endregion

                //Example 2.1 : Not Using params Keyword 
                #region  -- Using params Keyword -- 

                    Console.WriteLine();
                    Console.WriteLine("********* --  Example 2.1 --  *********");
                    Console.WriteLine(" -- Not Using params Keyword   -- ");
                    Console.WriteLine();

                    var Function_Method1 = new Function_Method ();

                    //Function_Method1.PrintNumber2 ("1", "4", "3");
                    Function_Method1.PrintNumber2 (new []{"1", "4", "3"}); // so pag di tayo gagamit ng params dapat ganto yung magiging format dito setting as an array 

                #endregion

                //Example 3 : Optional & Default 
                #region  -- Optional & Default -- 

                    Console.WriteLine();
                    Console.WriteLine("********* --  Example 3 --  *********");
                    Console.WriteLine(" -- Optional & Default  -- ");
                    Console.WriteLine();

                    var Function_Method3 = new Function_Method ();
                    // Uncomment the line below if you want to use PrintNumbers (not yet implemented in the code)
                    // program.PrintNumbers("1", "4", "3");

                    Console.WriteLine("-- Declare 1st Param ProcessNumbers-- ");
                    Function_Method3.ProcessNumbers(2);
                    Console.WriteLine();

                    
                    Console.WriteLine("-- Declare 1st & 2nd Param -- ");
                    Function_Method3.ProcessNumbers(5, secondNumber: 3); //declaring the parameter 
                    Function_Method3.ProcessNumbers(5, secondNumber: null); //declaring the parameter 
                    Console.WriteLine();

                    Console.WriteLine("-- Declare 1st & 3rd Param -- ");
                    Function_Method3.ProcessNumbers(10, name: "Frace"); //declaring the parameter 
                    Console.WriteLine();

                    
                    Console.WriteLine("-- Declare 1st Param ProcessNumbers1 -- "); // using ProcessNumbers1 function 
                    Function_Method3.ProcessNumbers1(2);
                    Console.WriteLine();


                #endregion

                //Example 4 : ShortCut to not use curly braket its looks like a lambda this is mostly i encounter during creation of my BeanTeaWeb Website 
                #region  -- ShortCut to not use curly braket --
                     Console.WriteLine();
                    Console.WriteLine("********* --  Example 4 --  *********");
                    Console.WriteLine(" -- ShortCut to not Use Curly braket  -- ");
                    Console.WriteLine();


                    var Function_Method4 = new Function_Method ();


                    Console.WriteLine("-- PrintMyName  -- ");
                    Function_Method4.PrintMyName("Joy Gonzaga Ng");
                    Console.WriteLine();

                    Console.WriteLine("-- MyStaticPrintMyName --");
                    // Calling the static method directly using the class name
                    Function_Method4.MyStaticPrintMyName("Joy Gonzaga Ng");
                    Console.WriteLine();


                #endregion 



                //Example 5 :  Function with return value 
                #region  -- Function with return value  --
                    Console.WriteLine();
                    Console.WriteLine("********* --  Example 5 --  *********");
                    Console.WriteLine(" -- Function with return value   -- ");
                    Console.WriteLine();


                    var Function_Method5 = new Function_Method ();

                    var sumofNum1AndNum2 = Function_Method5.AddTwoNumbers (1,2);
                    Console.WriteLine ($"Sum of Num 1 & Num 2: {sumofNum1AndNum2}"); 

                #endregion

                //Example 6 : Real Application of  Function 
                #region  --  Real Application of  Function --

                    Console.WriteLine();
                    Console.WriteLine("********* --  Example 6 --  *********");
                    Console.WriteLine(" --  Real Application of  Function   -- ");
                    Console.WriteLine();


                    Console.WriteLine(" --  Using <Return Type> : int    -- ");
                    Console.WriteLine();

                    var Function_Method6 = new Function_Method ();
                            Console.WriteLine("Addition 3 last Result: " + Function_Method6.AddNumbers(5, Operator.Add,2,3,4)); //5 + (2+3+4) = 2+(9) = 14 
                            Console.WriteLine("Addition 3 last Result: " + Function_Method6.AddNumbers(10, Operator.Add,2,3,4));
                            Console.WriteLine("Addition 2last Result: " + Function_Method6.AddNumbers(10, Operator.Add, 5, 5));
                            Console.WriteLine("Subtraction Result: " + Function_Method6.AddNumbers(10, Operator.Subtract, 2, 1));
                            Console.WriteLine("Multiplication Result: " + Function_Method6.AddNumbers(10, Operator.Multiply, 2, 3));
                            Console.WriteLine("Division Result: " + Function_Method6.AddNumbers(10, Operator.Divide, 2, 3)); // Note: This divides by the sum of [2, 3] (5).
                            Console.WriteLine();


                    Console.WriteLine(" --  Using <Return Type> : void     -- ");
                    Console.WriteLine();
                        // Test cases
                        Console.WriteLine("Case 1: Input = 0");
                        Function_Method6.ReturnRightAwaySample(0);

                        Console.WriteLine("\nCase 2: Input = 5");
                        Function_Method6.ReturnRightAwaySample(5);
                        Console.WriteLine();


                #endregion


                //Example 7 : Using REF  in Parameter 
                #region  -- Using REF in Parameter --

                    Console.WriteLine();
                    Console.WriteLine("********* --  Example 7 --  *********");

                  var Function_Method7 = new Function_Method ();


                    // Without Using REF 
                    Console.WriteLine(" --   Without Using REF    -- ");
                    Console.WriteLine();

                    var string1 = "Sample1";
                    var string2 = "Sample 2";

                    Function_Method7.WithNoREFModifyText(string2);
                    Console.WriteLine($"{string1} {string2}");
                    Console.WriteLine();

                    Console.WriteLine(" --   Using REF   -- ");
                    Console.WriteLine();

                    var stringA = "SampleA";
                    var stringB = "SampleB";

                    Function_Method7.WithREFModifyText(ref stringB);
                    Console.WriteLine($"{stringA} {stringB}");
  


                #endregion




                }


        //----------- AS we can see here is wala sya sa loob ni static void Main(string[] args) under sya ni class Function_Method ----------

        //--------------------------------------
        //  ------ FUNTION  LOCATION -----------
        //--------------------------------------


        //Example 1 : Initial Function
        #region -- Example 1 : Initial Function --
        // Void METHOD without parameters
        public void PrintName() // <access specifier> : public , <Return Type> : void means no data type , <Method Name> :PrintName , (Parameters) : No Parameter 
        {
            Console.WriteLine("Using PrintName()");

            var name = "any name";
            Console.WriteLine($"Name: {name}");
        }

        // Void METHOD with one parameter
        public void PrintNameWithParam(string name) // <access specifier> : public , <Return Type> : void means no data type , <Method Name> :PrintNameWithParam , (Parameters) : string name 
        {
            Console.WriteLine("Using PrintNameWithParam(string name)");
            Console.WriteLine($"Name: {name}");
        }

        // Void METHOD with two parameters
        public void PrintNameWithAge(string name, int age) // <access specifier> : public , <Return Type> : void means no data type , <Method Name> :PrintNameWithAge, (Parameters) : string name, int age
        {
            Console.WriteLine("Using PrintNameWithAge(string name, int age)");
            Console.WriteLine($"Name: {name}, Age: {age}");
        }

        #endregion


        //Example 2 : Using params Keyword 
        #region  -- Using params Keyword -- 
            private void PrintNumber1(params string [] numbers) // as we can see dun sa taas is tatlo yung parameter dun sa taas which is ito yung ginagawa ng params behind the scene yung tatlong to ("1", "4", "3") is kinoconvert nya into  into string of array tas tyaka na nya na nilalagay yung value na yan dun sa paramater natin dito na numbers   
            {
                Console.WriteLine(string.Join(",", numbers));
            }

            //params : Take note pag gagamit ng params lagi syang nilalagay sa dulo hindi sa unahan and isang beses lang sya nidedeclare 


        #endregion

        //Example 2.1 : Not Using params Keyword 
        #region  -- Using params Keyword -- 
            private void PrintNumber2( string [] numbers) // which is pag walang params isang parameter lang 
            {
                Console.WriteLine(string.Join(",", numbers));

            }

        #endregion


        //Example 3 : Optional & Default 
        #region  -- Optional & Default -- 
       
        /*
        Param1: long firstNumber
        Param2: int? secondNumber = null  -- Optional na intiger 
        Param3: string name = "Joy Ng"    -- Default na Joy Ng 
        
        >> yung optional and default is same lang ginagawa ang pinag kaiba lang yung optional is may default value na null 
        >> ang pinag kaiba lang nito sa normal function is yung parameters na may default value pag di ka nag provide ng value pag tinawag mo yung function mo automatic yung default value na nakaassigned sa kanya yun yung gagamitin nya 

        */

        public void ProcessNumbers(long firstNumber, int? secondNumber = null, string name = "Joy Ng") //secondNumber = null 
        {
            Console.WriteLine($"1st: {firstNumber}, 2nd: {(secondNumber.HasValue ? secondNumber.Value.ToString() : string.Empty)}");
            Console.WriteLine($"Name: {name}");
        }


        public void ProcessNumbers1(long firstNumber, int? secondNumber = 888, string name = "Joy Ng") //secondNumber = 888 have default value 
        {
            Console.WriteLine($"1st: {firstNumber}, 2nd: {(secondNumber.HasValue ? secondNumber.Value.ToString() : string.Empty)}");
            Console.WriteLine($"Name: {name}");
        }

        #endregion



        //Example 4 : ShortCut to not use curly braket its looks like a lambda this is mostly i encounter during creation of my BeanTeaWeb Website 
        #region  -- ShortCut to not use curly braket --

        public void PrintMyName (string myName) => Console.WriteLine (myName);

        //public static void MyStaticPrintMyName(string name) => Console.WriteLine($"using static: {name}");  // pag ito nag eeror kasi may static 
        
        public void MyStaticPrintMyName(string name) => Console.WriteLine($"using static: {name}");      
        

        #endregion 

        //Example 5 :  Function with return value , this is commonly use in the work project 
        #region  -- ShortCut to not use curly braket --

            public int AddTwoNumbers (int number1 , int number2) // <access specifier> : public , <Return Type> :int means the datatype of the results will be intger  , <FunctionName> : AddTwoNumbers , (Parameters) : int number1 , int number2
            {
                Console.WriteLine($"num1: {number1}, num2: {number2}"); //show what is the value of the paramerter inputted 
                return number1 + number2 ; // this is the returning the results 
            }
    
        #endregion


        //Example 6 : Real Application of  Function 
        #region  -- ShortCut to not use curly braket --

        public enum Operator //we gonna use Enumeration 
        {
            Add, 
            Subtract,
            Multiply,
            Divide
        }

        /*
        1st Param : int num1
        2nd Param : Operator op = Operator.Add -- this is the enumeration the datatype : Operator,  ParamName: op ,  Operator.Add : Default Value is Add
        3rd Param :  params int[] otherNumbers -- this part is array of intergers naman with params keywords 
        */

        //Using <Return Type> : int 
        public int AddNumbers(int num1, Operator op = Operator.Add, params int[] otherNumbers)  // <access specifier> : public , <Return Type> : int data type , <Function Name> : AddNumbers , (Parameters) : int num1, Operator op = Operator.Add, params int[] otherNumbers
        
        {
            var sumOfOtherNumbers = otherNumbers.Sum(); //variable to sum

            switch (op) //yung inievaluate here is yung op which is yung 2nd paramerter yung Operator 
            {
                case Operator.Add:
                    return num1 + sumOfOtherNumbers; //before gumagamit tayo ng break para di sya pumasok sa ibang case but here no need na kasi return na yung ginagamit natin here 

                case Operator.Subtract:
                    return num1 - sumOfOtherNumbers;

                case Operator.Multiply:
                    return num1 * sumOfOtherNumbers;

                case Operator.Divide:
                    // Ensure division by zero is avoided
                    return sumOfOtherNumbers != 0 ? num1 / sumOfOtherNumbers : 0;

                default:
                    return 0;
            }
        }

        //Using <Return Type> : void   
        public void ReturnRightAwaySample(int num)
        {
            Console.WriteLine("Start Process");

            if (num == 0)
            {
                Console.WriteLine("Terminate Process");
                return; // Exit the method early
            }

            Console.WriteLine($"End Process for num: {num}");
        }


        #endregion


        //Example 7 : Using REF  in Parameter 
        #region  -- Using REF in Parameter  --

        public void WithNoREFModifyText(string demo) // as you can see sa paramerter may no ref na sya so di walang effect yung nasa loob 
        {
            demo = "New";
        }

        public void WithREFModifyText(ref string demo)  // as you can see sa paramerter may ref na sya so mag apply na yung nasa loob , ang difference lang nito dun sa taas is yung string demo na parameter is nakareference na kung anong variable ang ilalagay natin sa function 
        {
            demo = "New";
        }

        #endregion


    }
}

