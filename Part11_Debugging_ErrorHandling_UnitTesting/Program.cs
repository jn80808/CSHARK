
namespace Part11_Debugging_ErrorHandling_UnitTesting
{
    class Debugging_ErrorHandling_UnitTesting
    {
        static void Main(string[] args)
        {
            /*
                ----------------
                --  DEBUGGING --
                ----------------

                Debugging : is the  process of fixing a bug in the software, Usually, the software contains erros and bugs, which are routinely removed.

                Procees of Debugging:
                    1.Identify the Error : know the error before fixing the error 
                    2.Find the Error Location : hanapin natin sa source code natin san dun yung nag error 
                    3.Analyze the Error : is Nag Analyze natayo sa ng source code natin na nag error , pwede natin isimulate yung code and i-icheck yung code and yung mga data hanggang mahanap nanatin yung source ng error 
                    4.Prove the Analysis : need lang iproved yung mga finding mo and walang maapektuhan na mga system or modules pag inaply mo yung fixxed mo , or pwede mo ilist yung mmga impacted objects and what will be the effect if its big or not 
                    5.Cover Lateral Damage : here naman pag i-cocover mo yung fixxed mo make sure na macocover mo yung ibang system na di madadamay or wala magiging impact sa ibang code or functionality sa ibang code 
                    6.Fix & Validate : Apply na yung Fixxed and the validate na yung applied fixxed and Test sya sa lahat ng scenario included yung mga possible na madamay 
                
                >> This is not the required steps but this is a guide para maging effective yung debugging normally what i have experience this is really a steps to take like
                     standard flow 
                
                --------------------------------
                --  ERROR/EXCEPTION HANDLING  --
                --------------------------------

                Error/Exception Handling : are type of error that happend during the execution of the application. Errors are typically problems that are not expected 
            
                >> ito yung error na nang yayare during execution and para mahandale natin yung mga gantong error pwede tayo gumamit ng try , catch , finally and throw 

                Syntax: 
                    try {
                    }
                    catch (<Type of Exception>)
                    }
                    finally {
                    }

                ------------------------
                --  UNIT TESTING   --
                ------------------------

                Unit Testing - Check that your code is working as expected by creating and running unit tests.
                             - It's called unit testing beacuse you breakk down the functionality of your program into discreate testable behaiviors that you can test as individual units.
                >> gumagawa tayo ng test sa mga function natin to make sure na all the scenario is covered and aswell to make sure yung code natin is nag wowork base on sa scenario natin and base sa test data natin 
                >> as per experience nadin na required talaga na unit test and 100% yun magiging output nya percentage nya 

                Common Unite Test Projects in Visual Studio:
                        1. xUnit 
                        2.MSTest - this what we gonna use 
                        3.NUnit 
            */


                var binary1 = "00001111"; // 15
                var binary2 = "01000001"; // 65

                var firstBits = GetBitValues(binary1);
                var secondBits = GetBitValues(binary2);

                Console.WriteLine($"binary1: {binary1}, {string.Join(",", firstBits)}: {firstBits.Sum()}");
                Console.WriteLine($"binary2: {binary2}, {string.Join(",", secondBits)}: {secondBits.Sum()}");

        
            // Try Catch 
                    var number1 = 100;
                    var number2 = 50;
                    var number3 = 0;

                    try
                    {
                        Console.WriteLine($"Addition result: {number1 + number2}");
                        Console.WriteLine($"Division result: {number1 / number3}");
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine("Hindi pwede mag divide by zero.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        Console.WriteLine("finally! tapos na yung try and catch.");
                    }

        

                    // Custom Exception 

                    try
                        {
                            string firstName = null;
                            string lastName = "NG";

                            if (string.IsNullOrWhiteSpace(firstName))
                                throw new WalangFirtsNameException();

                            Console.WriteLine(firstName.ToLower());
                            Console.WriteLine(lastName.ToLower());
                        }
                        catch (WalangFirtsNameException ex)
                        {
                            Console.WriteLine("Walang first name");
                        }
                        catch (NullReferenceException)
                        {
                            Console.WriteLine("Hindi pwede mag gamit nang function pag null");
                        }
                        catch
                        {
                            Console.WriteLine("Ako bahala sa ibang exceptions");
                        }

                    //Event Except Subscribe 
                    // Attach the FirstChanceException handler
                        AppDomain.CurrentDomain.FirstChanceException += (sender, args) =>
                        {
                            if (args.Exception is WalangFirtsNameException)
                            {
                                Console.WriteLine("(From Event) nagaka-error na WalangFirstNameException");
                            }
                        };



        }


            // Created a function to Convert the Binary to Interger 
            public static IEnumerable<int> GetBitValues(string binaryValue)
            {
                return binaryValue
                    .Reverse()
                    .Select((value, index) => //lambda function instead gumamit pa ng mga loops 
                    {
                        return value == '1' ? (int)Math.Pow(2, index) : 0;
                    });
            }


            public static IEnumerable<int> GetBitValues1(string binaryValue)
            {
                return binaryValue
                    .Reverse()
                    .Select((value, index) => //lambda function instead gumamit pa ng mga loops 
                    {
                        return value == '1' ? (int)Math.Pow(2, index) : 0;
                    }).Reverse();
            }

            





    }
}
