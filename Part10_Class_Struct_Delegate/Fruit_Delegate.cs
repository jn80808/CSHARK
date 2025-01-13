using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Part10_Class_Struct_Delegate
{
    public class Fruit_Delegate
    {


        /*
            <access specifier> : public 
            delegate: Default 
            <Return Type> : int data type 
            <Dlegate Name> :ProcessFruitDelegate
            (Parameters) :Fruit_Struct  fruit , Fruit_Struct : from struck
        
        */

        // Define a delegate to process the fruit
        public delegate int ProcessFruitDelegate (Fruit_Struct fruit);


        public List<Fruit_Struct> FavoriteFruits { get; set; } = new List<Fruit_Struct>();

        #region Methods

            // Method to add a favorite fruit
            /*
                >> 1st Parameter : Data Type : Fruit_Struct , Parameter Name : fruit 
                >> sa 2nd parameter : Data Type : ProcessFruitDelegate , Parameter Name : successCallback
                >> sa 2nd parameter means tatangap tayo ng method nanakabase sa  ProcessFruitDelegate as we can see sa line 22 
                >> and the signature of the method is nakabase sa signature nabinase natin sa ProcessFruitDelegate
                >> base sa "defination" natin sa DELEGATE IS  i-aaccept lang daw natin  na signature is may return type na int as shown 
                    sa line 25 yung return type dun sa int and may 1 parameter sya na fruit and yung data type nya is Fruit_Struct 
                >> as we can see dun sa loob ng block code natin is inovoke natin yung successCallback and  may parameter which is ito yung parameter natin sa  ProcessFruitDelegate (Fruit_Struct fruit); 


                >> Delegate is like event lang kasi yung EventHandler is mga delegate lang din yun and if ayaw natin gamitin yung EventHandler pag gumagawa tayo ng Event pwede natin gamitin yung Custom Delegate na ginamit natin  

                >> Event Use in the Scenario : 1. Something Happend 2. Something will Happen 3. Something is Happening 
                >> Delegate Use in the Scenario : 1. Full Back or Execute Something 


                >> 
            */
            public void AddFavoriteFruit(Fruit_Struct fruit, ProcessFruitDelegate successCallback) 
            {
                FavoriteFruits.Add(fruit); // 1st Parameter : 
                successCallback?.Invoke(fruit); // 2nd Parameter : pwede ganto pero pwede din successCallback(fruit) pero mas descriptive yung may Invoke
                                                //  and what its means here is yung mga function na galing sa labas is dito sa loob ineexecute yung mga yun and yung mga parameter value  nong mga nasa labas na function is dito natin sya nilalagay sa loob ng code of block natin denidetermined kung ano ipapasa natin 
            }

            // Method to delete a favorite fruit
            public void DeleteFavoriteFruit(Fruit_Struct fruit, ProcessFruitDelegate successCallback)
            {
                FavoriteFruits.Remove(fruit); // 1st Parameter : 
                successCallback?.Invoke(fruit); // 2nd Parameter :
            }

        #endregion

        
    }
}