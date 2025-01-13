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

                // -------- 1st Constructor --------
                public Person()
                {
                    //pag may gustong kang execute na code during initialization example  initial value yung variable or may tinatawag na function 

                }

                // -------- 2nd Constructor --------
                /*
                    >> Adding New Custom Construnctor 
                    >> Constructor that takes only the first name
                    >> yung result nito is an object na na may Peson na data type and the FirstName na property is may initial value kung ano man yung nilagay natin value sa firts na parameter 
                    >> have a 1 parameter firts and sa loob ng block of code,  kung anong value yung nakuha ni parameter istore lang sya dun sa loob ng variable na FirtsName 
                */
                public Person(string first) 
                {
                    FirstName = first;
                }

                // -------- 3rd Constructor --------
                /* 
                    >> Constructor that takes both first and last names, chaining to the first constructor
                    >> have 2 parameter first & last and ang pinag kaiba lang nito is bago natin iexecute yung block of code nya is tatawag mona tayo ng ibang constructor yan yung purpose bat may : colon and this(first) , and yung ibig sabihin ng "this" na keywords is "this intance of class"  , which in our sample is this instance of class which is Person so like this instance of person and nag provide tayo ng parameter value which is first which is yung 1st parameter natin na first nilagay lang natin dito din sa loob ng this 
                    >> ibig sabihin nito is pupunta mona sya  sa class nato (Line 32) and currently meron tayong 3 class constructor  from line 23 - 39 so yung constructor na may isang parameter lang ng firts ito yung execute nya lang yung block of code nung nasa loob  bago yung block of code natin dito sa line 39 since inside of block code natin dito is lastName lang so yung FirstName dun nya kukunin sa line 32 
                    >> sa 1st construnctor Line 32 nag karon tayo ng initial value sa sa firts 
                    >> and pwede naman di natin ilagay yung this(first)
                    >> pwede natin iassigned yung FirstName = first parang ganto yung magiging view (FirstName = first, string last) kaso uulitin lang natin kung ano yung block of code dun sa line 32 and what if yung dun sa line 32 yung block of code nya is may 10k line of codes ibigsabihin icocopy mo yun lahat then iadd dun sa next constructor   if ganto yung approach panget tingnan and mahirap imaintain 
                    >> what we call this is overloading 
                    >> means may 3 constructor tayo and iba iba yung set up parameter 
                    >> then proceed lang sa programs to test 
                
                */

                public Person(string first, string last) : this(first)
                {
                    LastName = last;
                }


            #endregion



            #region  -- Properties --

            // -------- 1st Propertoes Manual--------
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

            // -------- 2nd Propertoes : AutoImplementation --------
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

            // -------- 3rd Propertoes : private set --------
            //here naman autoImplementation and naka private yung set means pwede lang maka set value nito within the class
            public int Sample { get; private set; }

             // --------4th  Propertoes : Both  private  --------
            //public int Sample1 {private get; private set; } // di pwedeng gawin both private si get and set kasi mag eeror ka 

            //Example of Other properties na may ginagawa bago mag return ng value 
            

             // -------- 5h  Propertoes : Example Format  --------
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




            #region  -- Overloading  Method of Class  -- 

            // ----- same METHOD Name Different Parameter -------


            // -------- 1st Method  --------
            // Method to update only the Sample property
            public void Update(int sample)
            {
                Sample = sample;
            }

            // -------- 2nd Method  --------
            // Method to update both Sample and NickName properties
            public void Update(int sample, string nickName)
            {
                Update(sample); // Call the other Update method to set Sample
                NickName = nickName;
            }

            // -------- 3rd Method  --------
            public DateTime? BirthDate { get; set; }

            public int? GetAge()
            {
                if (BirthDate.HasValue)// checling if yung BirthDate is have a value 
                {
                    // Calculate the age in years
                    // yung result nito is double since TotalDays data type is double so sa unahan may casting tayo  (int?) since yung ineexpect ng class natin in integer public int? GetAge()
                    return (int?)((DateTime.Now - BirthDate.Value).TotalDays / 365.25); 
                }

                // Return null if BirthDate is not set
                return default; // so incase walang value return nya default which yung value nito is null 
            }


            #endregion


    }
}