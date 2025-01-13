using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Part10_Class_Struct_Delegate
{
    public class Person
    {
            #region  -- Fields --

            private string _firtsName;  // accessible only within the class and cannot be access by other class and module and if gusto nyo magamit sa iba then public yung ilagay natin and yun na yung tinatawag na instance variable 
                                        // but the other way for this accesible to other class is gumamit tayo ng property in the following we will discuss bat mas maganda gumamit ng properties kesa sa instances 
           public string _FName ; // pag public yun na yung accessable sa ibang class and module , and also known as intance variable 


            #endregion


            #region  -- Constructor --

                public Person()
                {




                }

            #endregion



            #region  -- Properties --

            //1st Properties : FirstName  which is manually pa sya format 

            public string FirstName 
            {
                get //getter: is returning the value 
                {
                        return _firtsName; // yung nirereturn natin yung _firstName nanaka private dun sa line 12 , ngayon pwede na sya makuha sa labas ng class or ng ibang module gamit yung Properties na public string FirstName
                }

                set 
                {
                    _firtsName = value; //with this pwede natin masetan ng value yung firtsname galing sa ibang class and module , dito sya sa set mag process or gagamitin nya yung set 
                }

                // in this properties ang ginagawa lang sya is mag get and set ng value wala syang extrang process and validation bago iset and ireturn yung value pag ganto lang ginagawa sa property natin na nag get and set lang pwede natin gamitin yung auto implementation na property 
                
            }

            //2nd properties  LastName : Automation Properties 

            // AutoImplementation of Properties 
            // short key for this is type lang yung prop
            public string  LastName { get; set; }
            

            
            #endregion


    }
}