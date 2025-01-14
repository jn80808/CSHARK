using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Part12_OOP_Abstract_Interface_Generic.poly_SampleOperation;

namespace Part12_OOP_Abstract_Interface_Generic
{
    public class SampleGenerics
    {

        /*
            so medyo familiar na tayo sa Generics kasi na encounter na natin sya before sa List kasi si List is generic type lang din sya 
                List <int> mgaIntegers;
                List <string> mgaStrings;
                 >> is pag nilagay natin sa <> loob is integer <int>  means list of intger then yung integer yung iproprocess nya 
                 >> is kung kung string naman ilalagay natin sa placeholder <string> means list of string naman yung iproprocess nya 

        */

        /*
            Generic Name : SampleGeneric
            Type Parameter : < T >  
            PlaceHolder Name : T 
            Constraint : where T  : and may constraint tayo na yung pwede lang daw ilagay sa Placeholder natin na T is Data  type na  poly_TagaCompute ,  
                                  : pwede yung TagaCompute na class or yung mga derive na class na nag inhirit sa tagacompute like tagaAdd , tagaMinus and so on 
                                  : pero di naman required yung constraint pwede hindi din to ilagay pag gusto mo kahit anong data type yung pwede ilagay sa placeholder mo na T 
            new () : ibigsabihin nya pwede tayo mag create ng instance sa kung anong mang data type na ilalagay natin sa place holder natin na T 
            Process : sa generic class natin gumawa tayo ng Method na Process and may 2 parameter and the data type is integer 
            1st Block of Code : is nag declare tayo ng T which is the data type kung ano mag ilalagay natin sa place holder <T>
                              : since yung sa place holder natin may constrain and yung TagaCompute yung data type nya means yung yung data type nong place holder natin is yung TagaCompute 
                              : so parang ganto yung itsuara nya is walang place holder 
                                            poly_TagaCompute t = new poly_TagaCompute ();
                              : and yung magiging value nya is new instance kung ano yung nakalagay sa place holder which is poly_TagaCompute
                              : so from the word place holder , placeholder nga lang si T 
            t.Compute : so tinawag na natin yung method na nasaloob ni poly_TagaCompute 
                      : and since naka pag instance pwede na natin maacess all the methods and properties inside of the poly_TagaCompute is pwede nanatin tawagin and gamitin 
            Console.WriteLine : print lang ng results 


        */


        // -- Example 1

        public class SampleGeneric<T> where T : poly_TagaCompute, new()
        {
            public void Process(int num1, int num2)
            {
                T t = new T();
                t.Compute(num1, num2);
                Console.WriteLine($"Compute: {t.Result}");
            }
        }



        // -- Example 2


        public class SampleMultipleType<Una, Pangalawa>
            where Una : poly_TagaCompute, new()  // Una must inherit from TagaCompute and have a parameterless constructor
            where Pangalawa : SampleGeneric<TagaMinus>, new()  // Pangalawa must inherit from SampleGeneric<TagaMinus> and have a parameterless constructor
        {
            // Method that performs computations and processes using both Una and Pangalawa
            public void ExecuteNa(int num1, int num2)
            {
                // Create instances of Una and Pangalawa using their parameterless constructors
                Una una = new Una();
                Pangalawa pangalawa = new Pangalawa();

                // Call Compute method on Una
                una.Compute(num1, num2);
                Console.WriteLine($"Una: {una.Result}");  // Display the result from Una

                // Call Process method on Pangalawa
                pangalawa.Process(num1, num2);  // Process num1 and num2 using Pangalawa
            }
        }





    }
}