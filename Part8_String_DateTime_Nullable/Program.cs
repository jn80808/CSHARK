/*
DateTime is struct 
Struct : Value Type
Class : Reference Type
*/


using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Part8
{
    class Part8_String_DateTime_Nullable
    
    {
        public enum Gender
        {
            Male = 1,
            Female = 2
        }

               // Enum for quarters in months
            public enum QuarterInMonths
            {
                First = 3,
                Second = 6,
                Third = 9,
                Fourth = 12
            }

            // Enum where values start at 5 and increment automatically
            public enum SampleThatStartAt5
            {
                Usa = 5,
                Duwa,   // This will automatically be 6
                I,      // This will automatically be 7
                Tulo    // This will automatically be 8
            }


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


            // ----------------------------------------------
            // --- Commonly used manipulations in string ---
            // ----------------------------------------------

            #region  -- Common Checker Content Function  --


            Console.WriteLine();
            Console.WriteLine("************************");
            Console.WriteLine("  -- Commonly used manipulations in string  -- ");
            Console.WriteLine();
            // Commonly used manipulations in string

            var myString = "Joy Ng";

            Console.WriteLine($"Original string: {myString}");

            // Reverse the string
            Console.WriteLine($"Reverse: {new string(myString.Reverse().ToArray())}");

            // Replace part of the string
            Console.WriteLine($"Replace: {myString.Replace("Ng", "Gonzaga")}");

            // Get a substring (starting from index 1, length 5)
            Console.WriteLine($"Substring: {myString.Substring(1, 5)}");

            // Convert to lowercase
            Console.WriteLine($"Lower case: {myString.ToLower()}");

            // Convert to uppercase
            Console.WriteLine($"Upper case: {myString.ToUpper()}");

            #endregion


            // ----------------------------------------------
            // --- TRIM ---
            // ----------------------------------------------

            #region  -- TRIM  --


            Console.WriteLine();
            Console.WriteLine("************************");
            Console.WriteLine("  -- TRIM  -- ");
            Console.WriteLine();



            var anotherString = " fra ce ";

            Console.WriteLine($"Original string: '{anotherString}'");

                // Trim leading spaces
                Console.WriteLine($"Trim start: '{anotherString.TrimStart()}'");

                // Trim trailing spaces
                Console.WriteLine($"Trim end: '{anotherString.TrimEnd()}'");

                // Trim both leading and trailing spaces
                Console.WriteLine($"Trim start and end: '{anotherString.Trim()}'"); //Trim : combination of TrimStart & TrimEnd

                // Trim all spaces and replace any remaining spaces within the string
                Console.WriteLine($"Trim start and end, and replace inner spaces: '{anotherString.Trim().Replace(" ", string.Empty)}'"); // use replace para yung mga spaces daw ireplace nya lang as empty string para mawala yung space dun sa gitna  


            #endregion



            // ----------------------
            // --- Split & Join ---
            // ----------------------

            #region  --- Split & Join ---


            Console.WriteLine();
            Console.WriteLine("************************");
            Console.WriteLine("  --- Split & Join --- ");
            Console.WriteLine();

            var lastString = "frace-marteja-programmer-TV:String";

            Console.WriteLine($"Original string: {lastString}");

            var words = lastString.Split('-');

            Console.WriteLine("=== Words ===");

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }

            // same but here inclue lang yung : 
            var wordsWithMultipleSeparator = lastString.Split(new char[] { '-', ':' });

            Console.WriteLine("=== Words with Multiple Separator and ':' ===");

            foreach (var word in wordsWithMultipleSeparator)
            {
                Console.WriteLine(word);
            }


            Console.WriteLine("=== Join the with the seperator of * ===");

            Console.WriteLine(string.Join("*", wordsWithMultipleSeparator));

            #endregion


            // ----------------------
            // --- DateTime ---
            // ----------------------

            #region  --- DateTime ---


            Console.WriteLine();
            Console.WriteLine("************************");
            Console.WriteLine("  --- DateTime --- ");
            Console.WriteLine();

            var now = DateTime.Now;
            var today = DateTime.Today;
            var timeNow = now.TimeOfDay;
            var dateNow = now.Date;

            Console.WriteLine($"Now: {now}");
            Console.WriteLine($"Today: {today}");
            Console.WriteLine($"Time now: {timeNow}");
            Console.WriteLine($"Date now: {dateNow}");
  


            // -----------------
            Console.WriteLine("");
            Console.WriteLine("  --- Example 2  --- ");
            Console.WriteLine("");
            // -----------------
            var myDate = new DateTime(2020, 12, 25);

            Console.WriteLine($"My Date: {myDate}");

            // Formatting
            Console.WriteLine($"Formatted: {myDate:MMM dd, yyyy}");

            // Computation
            var now1 = DateTime.Now; // Define now

            var yesterday = now1.AddDays(-1);
            var tomorrow = now1.AddDays(1);
            var days = now1.Subtract(myDate).Days;

            Console.WriteLine($"Yesterday: {yesterday:MM/dd/yyyy}");
            Console.WriteLine($"Tomorrow: {tomorrow:MM/dd/yyyy}");
            Console.WriteLine($"Now - My Date (number of days): {days}");


            #endregion


            // ----------------------
            // --- NULLABLE ---
            // ----------------------

            #region  --- NULLABLE ---


            Console.WriteLine();
            Console.WriteLine("************************");
            Console.WriteLine("  --- NULLABLE --- ");
            Console.WriteLine();

            // -- way to make nullable the variable -- 
            string myString1 = null; 
            Nullable<int> myNumber1 = null;
            int? secondnullableInt = null;

            // "Nullable" is equivalent to "Optional". Meaning, our int variables are now optional.

            // Version 1: Check if myNumber is not null
            if (myNumber1 != null)
            {
                Console.WriteLine("myNumber is not null");
            }
            else
            {
                Console.WriteLine("myNumber is NULL");
            }

            secondnullableInt = 3;

            // Version 2: Check if either myNumber or secondnullableInt has a value
            if (myNumber1.HasValue || secondnullableInt.HasValue)
            {
                Console.WriteLine(secondnullableInt.Value);
            };

            #endregion



            // ----------------------
            // --- Enumeration ---
            // ----------------------

            #region  --- Enumeration ---

            Console.WriteLine();
            Console.WriteLine("************************");
            Console.WriteLine("  --- Enumeration --- ");
            Console.WriteLine();

            var boyGender = Gender.Male;

            Console.WriteLine($"Gender: {boyGender}, Gender value: {(int)boyGender}");

            switch (boyGender)
            {
                case Gender.Male:
                    Console.WriteLine("Male");
                    break;

                case Gender.Female:
                    Console.WriteLine("Female");
                    break;

                default:
                    Console.WriteLine("Unknown");
                    break;
            }

            // Converting an int to the enum
            var value = 1;
            Gender genderFromValue = (Gender)value;

            // Converting a string to the enum
            var stringValue = "Male";
            Gender genderFromString = (Gender)Enum.Parse(typeof(Gender), stringValue);

            Console.WriteLine($"Gender from int: {genderFromValue}");
            Console.WriteLine($"Gender from String: {genderFromString}");



            // then pwede tayo mag lagay ng value sa mga enum natin as you can see sa line 23
            Console.WriteLine();
            Console.WriteLine("********************");
            Console.WriteLine("  --- Enumeration Setting Value Inside of Custom Class Line 23 --- ");
            Console.WriteLine();

                    // Display the enum values
                     Console.WriteLine("  --- enum values Months --- ");
 
                    Console.WriteLine($"First Quarter: {QuarterInMonths.First}");
                    Console.WriteLine($"Second Quarter: {QuarterInMonths.Second}");
                    Console.WriteLine($"Third Quarter: {QuarterInMonths.Third}");
                    Console.WriteLine($"Fourth Quarter: {QuarterInMonths.Fourth}");
                    
                    // Display values from the second enum
                    Console.WriteLine();
                    Console.WriteLine("  --- enum values random --- ");
                    Console.WriteLine($"Usa: {SampleThatStartAt5.Usa}");
                    Console.WriteLine($"Duwa: {SampleThatStartAt5.Duwa}");
                    Console.WriteLine($"I: {SampleThatStartAt5.I}");
                    Console.WriteLine($"Tulo: {SampleThatStartAt5.Tulo}");


            #endregion


        }
        

    }
}


