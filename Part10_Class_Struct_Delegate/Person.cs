using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Part10_Class_Struct_Delegate
{
    // <access specifier> :  public , Notes at MAIN CLASS: pag gumagawa ng class di pwedeng naka private or protected , pero sa loob ng class pwede gumawa ng sub class and pwede na yun naka Private and Protected  
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
                    //pag may gustong kang execute na code during initialization example  initial value yung variable or may tinatawag na function 

                }

                //Adding New Custom Construnctor 
                // Constructor that takes only the first name
                // yung result nito is an object na na may Peson na data type and the FirstName na property is may initial value kung ano man yung nilagay natin value sa firts na parameter 
                public Person(string first) // have a 1 parameter firts and sa loob ng block of code,  kung anong value yung nakuha ni parameter istore lang sya dun sa loob ng variable na FirtsName 
                {
                    FirstName = first;
                }

                // Constructor that takes both first and last names, chaining to the first constructor
                //have 2 parameter first & last and ang pinag kaiba lang nito is bago natin iexecute yung block of code nya is tatawag mona tayo ng ibang constructor yan yung purpose bat may : colon and this(first) , and yung ibig sabihin ng "this" na keywords is "this intance of class"   
                public Person(string first, string last) : this(first)
                {
                    LastName = last;
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

            public string FullName {
                
                get // get lang means pwede maka get yung ibang class sa FullName pero di sila pwedeng maka set since walang set sa loob
                {
                    return $"{FirstName} {LastName}";
                }
            }

            //here naman autoImplementation and naka private yung set means pwede lang maka set value nito within the class
            public int Sample { get; private set; }

            //public int Sample1 {private get; private set; } // di pwedeng gawin both private si get and set kasi mag eeror ka 

            //Example of Other properties na may ginagawa bago mag return ng value 
            
            private string _nickName;

            public string NickName
            {
                get
                {
                    if (string.IsNullOrEmpty(_nickName))
                        return "N/A";
                    return _nickName;
                }
                set
                {
                    if (value == null)
                        _nickName = string.Empty;
                    else
                        _nickName = value;
                }
            }



            #endregion


    }
}