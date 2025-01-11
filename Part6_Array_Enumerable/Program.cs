// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;
using Microsoft.Win32;


/*
Topics:
1.Array
2.Enumerable
3.Collection 
4.List
*/

namespace  Array_IEnumerable
//format of NameSpace : MainFolder.Folder where the file of Banana.cs located 
{
    class Array
    {
        static void Main(string[] args )
        {

            Console.WriteLine("");
            Console.WriteLine("***************");
            Console.WriteLine("-- Array --");

            // explicit data type 
            #region --Explicit Array --
            // sa example dito is puro integer but we can use other data type and becaused this more int we called this as integer of array 
            // and this is explicit array since tayo nag dedeclare ng data type 
            

            int [] numbers = new int [10]; // during declaration required malaman agad ilan yung capacity nong array  so dito palang sa declaration natin sa variable natin na naumbers ni specify na natin yung arrray natin is may available 10 slots para sa numbers na variable natin and di na sya pwede dagdagan or bawasan final na to 
            int [] numbersWithInit = new int[] {1, 2, 3}; // here di tayo nag lagay ng capacity pero nag lagay tayo ng initial value or content ng array natin , so kung ilan yung nilagay mo so it means yun na din yung magiging capacity nya so here meron tayong 3 so its means yung availabe slots or capacity nya is 3 lang din , so yung array value na 1,2,3 pwede mo pa sya ma modify pero yung capacity is hindi na 
            int [][] multiNumbers = new int [3][] { // heres sa multdimentional for the firt bracket :  [3] so required na specify mo yung capacity nya and sa 2nd bracket [] is nag initialize tayo ng value ng array , sa 2nd bracket [] is di na nag specify ng capacity it means pwede yung value ng array is iba iba na yung length , since dito yung lenghth natin is same sama this called a multidemintions pero pag nag iba iba na yung length dun na yung jagged 
                new int [] {1, 2, 3}, 
                new int [] {4, 5, 6}, 
                new int [] {7, 8, 9}
            };

            int[,] otherNumbers = new int [2,2]; // another way to declare array  the left 2 is means 2 yung capacity nong array natin and yung right 2 naman means yung content nya is may 2 din na capacity it means 2x2 dimentional array 

            #endregion

            //Implicit Array : where system assigned the data type 
            #region --Implicit Array --
            var numbersimplicit = new int [10];
            var numberWithInitImplicit = new int[] {1, 2, 3};
            var multiNumbersImplicit = new int [3][] {
                new int [] {1, 2, 3}, 
                new int [] {4, 5, 6}, 
                new int [] {7, 8, 9}
            };

            int[,] otherNumbersImplicit = new int [2,2]; // another way to declare array  the left 2 is means 2 yung capacity nong array natin and yung right 2 naman means yung content nya is may 2 din na capacity it means 2x2 dimentional array 
            #endregion


            // how to access array base on the position and Modified the value 
            #region -- Array Access -- 

            var names = new [] {"farce", "ace" , "truncks"};
            Console.WriteLine ("---- Before Update ----");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            names[1] = "hardware"; //modified the value of the position 1 from farce to hardware 
            Console.WriteLine("---- After Update ----");
            foreach(var name in names) //reflect the new value 
            {
                Console.WriteLine(name);
            }

            //accessing the specific position 
            Console.WriteLine();
            Console.WriteLine("accessing specific location");
            Console.WriteLine($"name at index 2: {names[2]}");
                
            #endregion

            //MultiDimentional Array Output 
            #region -- Multidementional array --
            
            var rowsAndCells = new int [3][]{
                new [] { 1, 2, 3 },
                new [] { 1, 2, 3 },
                new [] { 1, 2, 3 }
            };
            /*
            Since nispecify natin yung capacity nong variable natin which new int [3] so yung length nya is 3 kasi rowsAndCells.Length 
                And yung magiging condition dito is 
                row < 3
                var row = 0 , row < 3 ; row ++ 
                So parang ganyan yung itsura nya 
            */

            for ( var row = 0; row < rowsAndCells.Length; row++) //var row = 0 , row < 3 ; row ++
            {   
                Console.WriteLine();
                Console.WriteLine($"row: {row}");
                foreach ( var cell in rowsAndCells[row])
                {
                    Console.WriteLine($"Value: {cell}");
                }
            }
            //more notes here slides 57 : https://docs.google.com/presentation/d/1qhyAuIu5h35etERvR_uCLokCAgPLxCmM0klR1vYPq9w/edit#slide=id.g324c19a5240_0_324

            #endregion

            //EInumerable : is read only 
            #region -- IEnumerable -- 
             Console.WriteLine( "--- IEnumerable ---");
             Console.WriteLine();


            var countries = new [] { "Philippines" , "Switzerland", "New Zealand", "Austrilia", "Germany", "Netherlands", "Japan", "USA", "Canada"};
            IEnumerable <string> enumCountries = countries; //<string> means generic its means IEnumerable Abs string 
            //enumCountries[1] ="PHI"; // this part naka comment lang sya since nag eeror sya nitry ko lang kasi as per discussion IEnumerable is a read only so nitry natin sya iaccess and as we can see nag eeror 
            
            /*
            >> as we can see yung countries array natin is directly natin sya pinasa sa enumCountries kasi yung array is IEnumerable din, yung parent ng array natin is IEnumerable  kaya pwede natin syang ipasa IEnumerable
            Data Type : IEnumerable <string> 
            variable : enumCountries
            value : countries
            */

            // to access the IEnumerable need lang natin sya gawing Iterate same sa array we use looping or Foreach , then iterate nya lang yung mga value dun sa countries 
            foreach (var country in enumCountries)
            {
                Console.WriteLine($"IEnumerable Countries: {country}");
            }

            //so yung naging output parang array lang din 

            Console.WriteLine();
            #endregion


            //ICollection
            #region  -- ICollection -- 
             Console.WriteLine( "--- ICollection ---");
             Console.WriteLine();

            // ICollection is my function sya to Add and remove that we can use here 
            var countriesCollection = new [] { "Philippines" , "Switzerland", "New Zealand", "Austrilia", "Germany", "Netherlands", "Japan", "USA", "Canada"};
            ICollection<string> colCountries = new List<string>(countriesCollection);
            colCountries.Add("Sweden");
            colCountries.Remove("USA");
            //colCountries[0] = "Sample"; // so here we try to access again but getting error again same as IEnumerable 
            //same sa IEnumerable to see the output we need to add foreach 
            
            
            foreach (var country in colCountries)
            {
                Console.WriteLine(country);
            }

            Console.WriteLine();
            #endregion

            //List 
            #region -- IList -- 
            Console.WriteLine( "--- IList ---");
            Console.WriteLine();
            var countriesIList = new [] { "Monaco" , "Switzerland", "New Zealand", "Australia", "Germany", "Netherlands", "Japan", "USA", "Canada"};
            var ListCountries = new List<string>(countries); //with initial value from array 
            var ListInitCountries = new List<string>() //initial new list of abstring and manually put initial value
            {
                "Philippines",
                "Europe"
            };

            var listCountriesNew = new List<string> (); //created variable and no value as empty lang () and for the next line manually tayo nag addd ng mga value 
            listCountriesNew.Add("South Korea");
            listCountriesNew.Add("Thailand");
            listCountriesNew.AddRange(new [] {"Canada","Australia"}); //if maramihan naman if meron kang IEnumerable or ICollection pwede naman marami and gagagmit lang ng AddRange 
            listCountriesNew.Remove("Philippines");
            listCountriesNew[0] = "Spain"; //accessing the value by indexing sa list pwede natin maaccess yung specific position pero sa IEnumerable and ICollection is hindi , so what happend here is yung ListInitCountries na "Europe" is machange to Spain yung "Europe" na yung firt item kasi may remove tayo bago to  listCountriesNew.Remove("Philippines");
            
            Console.WriteLine("List of Countries");
            for (var index = 0 ; index <listCountriesNew.Count; index++ )
            {
                Console.WriteLine ($"{index}:{listCountriesNew[index]}");
            }

            #endregion

        }
    }
}





