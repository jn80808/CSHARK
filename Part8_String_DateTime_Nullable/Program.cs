/*
DateTime is struct 
Struct : Value Type
Class : Reference Type
*/


using System.Text;

namespace Part8
{
    class Part8_String_DateTime_Nullable
    {
        static void Main(string[] args)
        {

            // ----------------------
            // --- STRING ---
            // ----------------------

            #region  -- STRING --


            Console.WriteLine();
            Console.WriteLine("************************");
            Console.WriteLine(" -- Custom Formatting  -- ");
            Console.WriteLine();
            string sampleString;
            string sampleStringWithNullValue = null;
            string stringUsingClass = "Test";

            var myName = "Joy"; //regular string literal
            myName  += " Ng"; // equivalent to: MyName = MyName +" Ng";
            Console.WriteLine ("Print by characters using Loop");
            foreach (var c in myName)
            {
                Console.Write(c);
            }
            char [] nameCharacters = myName.ToCharArray();
            var stringFromArray = new string (nameCharacters);

            //verbatim string literal 
            var stringWithSpecialCharacter = @"""test\only""";
            var stringMulitipleLines = @"J
                                         o
                                         y
                                         N
                                         g";


            Console.WriteLine(stringWithSpecialCharacter);
            Console.WriteLine(stringMulitipleLines);

            //String Escape sequence 
            var stringWithTabAndNewLine = "my\tname\tis:\nJoy"; //\t : tab ||  \n: new line
            Console.WriteLine(stringWithTabAndNewLine);

            //Immutable Issue 
            Console.WriteLine();
            Console.WriteLine(" -- USING NORMAL CONCATENATION -- ");
            var testString = "number";
            for (var number = 1 ; number <= 5 ; number++)
            {
                testString += number ;
            }
            Console.WriteLine(testString);


            Console.WriteLine();
            Console.WriteLine(" -- USING STRINGBUILDER -- ");
            var sb = new StringBuilder ();
            sb.Append("number");
            for (var number = 1 ; number <= 5 ; number++)
            {
                sb.Append(number.ToString());
            }
            Console.WriteLine("using String Builder");
            Console.WriteLine(sb.ToString());

            #endregion

            // ----------------------
            // --- NUMERIC ---
            // ----------------------

            #region  -- NUMERIC --

            /*
                NUMERIC STANDARD FORMATTING 
                C = CURRENCY 
                N = NUMBER 
                P = PERCENT 
                D = DECIMAL
            */
            Console.WriteLine();
            Console.WriteLine("************************");
            Console.WriteLine(" -- NUMERIC -- ");
            Console.WriteLine();


            var myNumeric = 12345.678D;
            Console.WriteLine("CURRENCY: {0}",myNumeric.ToString("C"));
            Console.WriteLine("NUMBER: {0}",myNumeric.ToString("N"));
            Console.WriteLine("PERCENTAGE: {0}",myNumeric.ToString("P"));

            var myNumber = 123 ;
            Console.WriteLine("DECIMAL: {0}",myNumber.ToString("D10"));//D10 : means 10 digits , 10 is means decimal places 
            Console.WriteLine(myNumber.ToString("Number with 2 decimal places only"));
            Console.WriteLine("TOSTRING : {0}",myNumber.ToString("N2"));



            Console.WriteLine();
            Console.WriteLine("************************");
            Console.WriteLine(" -- Custom Formatting  -- ");
            Console.WriteLine();

            Console.WriteLine("Custom");
            Console.WriteLine(myNumeric.ToString("PHP#,##0.00"));









            #endregion


            // --------------------------------------
            // --- Composite & Interpolation  ---
            // --------------------------------------

            #region  -- string format & Interpolation --

            Console.WriteLine();
            Console.WriteLine("************************");
            Console.WriteLine("  -- string format & Interpolation -- ");
            Console.WriteLine();


            var name = "Joy";
            var age = 32;
            var sampleMoney = 523940947D;

            //using string format 
            Console.WriteLine("Using String.Format");
            var stringOutput = string.Format("my name{0}, age:{1}, sample computation: {2}", name , age, 1 + 1);
            Console.WriteLine(stringOutput);
            Console.WriteLine(string.Format("{0:C}", sampleMoney));
            Console.WriteLine();

            //interpolation 
            Console.WriteLine(" -- Using Interpolation -- ");
            var stringOutputV2 = $"my name: {name}, age: {age}, sample computation:{1 + 1}"; //Interporlation is use $
            Console.WriteLine(stringOutputV2);
            Console.WriteLine($"{sampleMoney: C}");
            Console.WriteLine();

            #endregion


            // -----------------------------
            // --- String Checker   ---
            // -----------------------------

            #region  -- String Checker  --

            Console.WriteLine();
            Console.WriteLine("************************");
            Console.WriteLine("  -- String Checker  -- ");
            Console.WriteLine();


            //Checker 
            string firtsString = null ;
            var secondString = string.Empty;
            var thirdString = " ";
            if (firtsString == null)
                Console.WriteLine("firstString is Null");
            
            //version 1 
            if (secondString != null && secondString != string.Empty)
                Console.WriteLine("secondString is not Null");
            else 
                Console.WriteLine ("secondString is empty");

            
            //version 2 : is commonly use since its combined IsNull and Empty 
            if (!string.IsNullOrEmpty(secondString))
                Console.WriteLine("V2: secondString is not Null");
            else 
                Console.WriteLine("V2: secondString is empty");
            

            //check string is null, empty or bank ( white spaces only )
            if (string.IsNullOrWhiteSpace(thirdString))
                Console.WriteLine("thirdString is: NULL , EMPTY or BLANK");


            #endregion


            // ----------------------------------------------
            // --- Common Checker Content Function ---
            // ----------------------------------------------

            #region  -- Common Checker Content Function  --


            Console.WriteLine();
            Console.WriteLine("************************");
            Console.WriteLine("  -- Common checker functions  -- ");
            Console.WriteLine();
            // Common checker functions

            var myNameForChecker = "frace";

            if (myNameForChecker.StartsWith("fr"))
                Console.WriteLine("frace starts with 'fr'");

            if (myNameForChecker.EndsWith("e"))
                Console.WriteLine("frace ends with 'e'");

            if (myNameForChecker.Contains("ac"))
                Console.WriteLine("frace contains 'ac'");

            if (myNameForChecker == "Frace")
                Console.WriteLine("frace is equal to 'Frace'");
            else
                Console.WriteLine("frace is \"NOT\" equal to 'Frace'");

            // Ignore case
            Console.WriteLine("\n-- Ignore Case --\n");

            if (myNameForChecker.Equals("Frace", StringComparison.InvariantCultureIgnoreCase))
                Console.WriteLine("(Ignored Case) frace is equal to 'Frace'");
            else
                Console.WriteLine("(Ignored Case) frace is \"NOT\" equal to 'Frace'");


            #endregion




        }
        
    }
}


