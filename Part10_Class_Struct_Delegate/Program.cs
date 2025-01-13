

using System.Runtime.CompilerServices;
using static Part10_Class_Struct_Delegate.Person;

namespace Part10_Class_Struct_Delegate
{
    class Class_Struct_Delegate
    {
        static void Main(string[] args)
        {
  
            
            /*
                -------------
                -- @CLASS --
                -------------

                Class is reference type 
                >> as per last topic we see the difference of value type and reference type and kung pano to sinisave sa ram natin or memory natin 
                >> Class is like a blueprint of specific object , is like a layout ng data natin pano nya i-sasave sa memory natin 
                >> Example we have FRUITS and apple sya and may attribute sya na Shape and Color bali sa blue print nya indidcate natin sa storage nya may dalawa syang allocation sa para sa  pag lalagyan ng variables natin  which is the Color and Shape 
                >> ginagamit natin yung Class to create a custom types  gamit yung mga built in data types and other custom types 
                >> and ginogroup natin yung variable ng isang objects , example yung apples nasa isang group lang yung Color and Shape 

                Syntax :
                    <access modifier> class <identifier/name>{
                        -- Fields --
                        -- constructors --
                        -- properties --
                        -- methods/function -- 
                        -- events -- 
                    }

                    <access modifier> : Public , Private , Internal 
                    Class : Default 
                    <identifier/name> : Class Name or Custom Name 

                ---------------
                -- @STRUCT  --
                ---------------

                Class vs Struct 
                class : Reference Type 
                Struct : Valuer Type 

                >> Struct is Value Type 
                >> Struct is like a BluePrint of Specific Object.
                >> same sa class gingroup nya din yung class nya 
                >> Struct enables you to create your custom Types by grouping variables of other types, method , and events 
                
                Syntax: 
                    <acess modifier> struct <identifier/name>{
                        -- Fields --
                        -- constructors --
                        -- properties --
                        -- methods/function -- 
                        -- events -- 
                    }

                    <access modifier> : Public , Private , Internal , abstract , sealed 
                    struct : Default 
                    <identifier/name> : Class Name or Custom Name 

                    Abstract and Sealed : will be discuss OOP 



                -----------------
                -- @DELEGATE  --
                -----------------
                
                >> Delegate is a reference type 
                >> Delegate is a data type that represents references to methods with a particular parameter list return type 
                >> Delegate is data type and yung Value nya is Mehod or Fucntion means yung iassigned nyang values is may return type din  and may block of codes and pwede din mag karon ng parameters list 
                >> Delegate is katumbas ng Pointers to Function sa C and C++
                >> Mas madali syang intindihin pag may background sa C and C++
                >> Delegate is pwede natin gamitin sa argument or parameter sa methods 
                >> Delegate are used to pass methods as arguments to other methods 
                >> and since Delegate ibigsabihin yung methods na tinatawag natin is papasahan din natin ng method na parameter value 
                
                Syntax :
                <access modifier> delegate <return type> <identifier/name>(<parameters>)


                    <access modifier> : Public , Private , Internal , abstract , sealed 
                    delegate : Default 
                    <return type> : data type
                    <identifier/name> : Class Name or Custom Name 
                    (<parameters>) : as needed 

                >> as we can wala syang block of code compare sa class and function 

            */


                    Console.WriteLine();
                    Console.WriteLine("********* --  Part 10 --  *********");
                    Console.WriteLine(" -- main  -- ");
                    Console.WriteLine();


            //Application of what we did 

            #region - Not using a class
            //we use this since small data lang sya  pero what is madaming data sya like 1000 people so isa isa yan gagawan ng variable so mahirapan to solve this problem what we do is gumanit ng class as shown sa baba 

                //Juan 
                string firstNameJuan;
                string lastNameJuan;

                //pedro 
                string firstNamePedro;
                string lastNamePedro;

            #endregion


            #region - Using a class --

                // Juan : is like our grouping here and yung FirstName & LastName is variable natin  
                var juan = new Person(); //to Intantiate the class para magamit nalng yung loob ng class gagamit lang tayo na word na new , as () default constructor na empty yung ginamit natin as we can see din yung sa class Person walang lamab yung constructor 
                juan.FirstName = "Juan";
                juan.LastName = "Bautista";

                var pedro = new Person()
                {
                    FirstName = "Pedro",
                    LastName = "Ewan"
                };

            /*
            -- so how Initialization Happened -- 

            >> 1st row nag initialize sya ng Juan 
            >> 2nd row nag initialize sya ng Juan for the FirstName Variable 
            >> 3rd row nag initialize sya ng Bautista for the LastName Variable 

            >> same kay pedro same lang pero mas magandang approach yung kay pedro kesa kay juan kay old approach pa yun 


            */


            #endregion


            /*
            Create Class Person 
                -  Add fields , constructor and properties
                -  Use Peson in Program.cs line 102 -140 

            >> back again sa Person na Class : so far complete na yung fields , constructor and properties here  


            */

            #region -- Using Constructor --

            var doray = new Person ("Maria");


            #endregion
            

            #region  --  Method of Class -- 

            
            Console.WriteLine();
            Console.WriteLine("********* --   Method of Class --  *********");
            Console.WriteLine(" -- Update WithOut EventInvoke  -- ");
            Console.WriteLine();


            // Create a new person instance
            var person = new Person("Joy", "NG")
            {
                NickName = "Pretty Joy",
                BirthDate = new DateTime(1998, 6, 16) // YYYY/MM/DD
            };

            // Update Sample and NickName
            person.UpdatewithOutEventInvoke(10, "Ace");// UpdatewithOutEventInvoke(int sample, string nickName) so na momodify dito yung NickName 


            // Output the details
            Console.WriteLine($@"
                                Name: {person.FullName}
                                Age: {person.GetAge()}
                                Nickname: {person.NickName}
                                SampleInt: {person.Sample}"
                            );

            #endregion


            #region  -- Events --

            /*
            So yung naging flow dito is 
            1st : is mag susubscribe mo na sya 
            2nd : is yung function na update natin mag rurun yung block of code natin sa loob and ipapasa sa loob yung mga nakuha value which is sample = 10 and NickName = Ace 
            3rd : is yung pinaka last na block of code sa update is yung NickNameHandler which is lahat nong mga naka subscribe is makakarecived ng values nato yung nasa parameter (this, new NickName ) , this: Person Object , NickName is Ace yung code na to papasok na sa NickNameChanging Function kasi ito yung method na tinatawag natin pag nakakarecieved tayo ng subscription and kung ano yung mga nakalagay na statement or line of code or block of code execute nya lang 

            */

            Console.WriteLine();
            Console.WriteLine("********* --   Events --  *********");
            Console.WriteLine(" -- Update With EventInvoke  -- ");
            Console.WriteLine();

            // Create a new person instance
            var person1 = new Person("Joy", "NG")
            {
                NickName = "Pretty Joy",
                BirthDate = new DateTime(1998, 6, 16) // YYYY/MM/DD
            };
            // -------- 1st Step : Line 201   --------
            person1.NickNameHandler += NickNameChanging; // += for subscribe event, -= for unsubcribe event, then method name 

            // -------- 2nd Step : Line 202   --------
            // Update Sample and NickName
            person1.UpdateWithEventInvoke(10, "Ace"); // UpdatewithOutEventInvoke(int sample, string nickName) so na momodify dito yung NickName 
            
            //nag lagay lang ako dito to compare the output : the difference is pag after to nilagat sa update is walang output na compare pag before update sa taas may NickName is changing to: Ace
            //person1.NickNameHandler += NickNameChanging; // += for subscribe event, -= for unsubcribe event, then method name 

            
            // Output the details
                Console.WriteLine($@"
                    Name: {person1.FullName}
                    Age: {person1.GetAge()}
                    Nickname: {person1.NickName}
                    SampleInt: {person1.Sample}");
            #endregion




        }
            // -------- 3nd Step : Line 203   --------
        // Add new Function for : Event handler for NickNameChanging
        /*
        <access specifier> : private static void 
        <Function Name> : NickNameChanging
        2Parameter :
                    1st Param : 
                     Parameter Name : sender 
                     Data Type : Object 
                     2nd  Param : 
                     Parameter Name : args
                     Data Type : NickNameArgs means dito papasok yung notification natin 
        */
        private static void NickNameChanging(object? sender, NickNameArgs args)
        {
             Console.WriteLine($"NickName is changing to: {args.NickName}"); //piniprint lang yung value nong NickNameArgs property sa na parameter 
        }
    }
}
