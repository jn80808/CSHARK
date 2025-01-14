
namespace Part12_OOP_Abstract_Interface_Generic
{
    class OOP_Abstract_Interface_Generic
    {
        static void Main(string[] args)
        {

            /*
                -------------
                --- OOP ----
                -------------
                OOP : is a programming paradigm that relies on the concept of the classes and objects 
                Object : is yung Intance ng class ; eg. var a = new ClassName();
                Class : BluePrint 
                OOP : is yung paraan natin para gumawa ng system gamit yung real life models or entites (tables)
                    >> kung baga yung gagawin nating class is naka depend sa concept na gagawin natin objects hindi yung puro variable and function lang 
                
                 4 Pillars in OOP  : we have 4 Priciple Use in OOP Its calle 4 Pillars in OOP 
                        1. Abstraction  : modeling the relevant attributes and interactions of entities as classes to define an abastract representation of a system
                                        : Abstraction is a concept of an object 
                                            Example : Manager and Staff na models ibigsabihin yung concept ng models natin is about Employees 
                                                        and Employee Pwede naman maging Concept for the Person 
                                                        >> bali pag sa coding yung baseclass ng manager and staff is yung Employee 
                                                        >> and yung Employee yung baseclass naman nya is Person
                                        : Abstraction is pinaka outer layer ng class natin as example yung sa cellphone yung pinaka outer is yung screen , power switch and volume control
                                        : and yung sa code natin yun yung 
                                                                            ******** ATTRIBUTE ******** 
                                                                            Color: Black 
                                                                            Shape : Rectangle 
                                                                            ***************************
                                        : and yung action naman pag pinindot natin screen or power button yun naman yung behaivior 

                        2. Encapsulation : hiding the internal state and functionality of an object and only allowing access through a public set of fuction 
                                         : and ito naman yung members variable and function na accessible within the class and ito yung mga naka private sa class natin kaya di to pwede iaccess ng ibang class 
                                           Depende nalng kung gagawa tayo ng public properties or function para ireturn yung value ng private na data natin
                                         : kung yung Abstracion is our outer layer then yung Encapsulation is our Inner layer 
                                         : kung babalikan natin yung cellphone na example yung example ng encapsulation dun yung yung physical board nong cellphone naka enscapsulate yung wire yung IC Processor and process sa loob 
                                         : From Power Button may Process na mangyayare dun sa Board natin 
                                         : yung abstraction is yung nag iinteract sa labas ng class and pili lang yung properties and function yung ieexposed nya 
                                         : and yung encapsulation yun naman yung nag iinteract sa loob lang ng class nya 
                        
                        
                        3.Inheritance   : is the ability to recieve ("inherit) methods and properties from an existing class
                                        : madalas na iniinherit natin is yung mga class na ginawa natin sa abstraction 
                                        : As we Example yung Person Class natin is may Properties na FullName and Methods na Walk 

                                                    CLASS : Person  
                                                                    Properties:
                                                                                FullName 
                                                                    Method : 
                                                                                Walk
                                        : and then Gumawa tayo ng Class na Employee and Inherit lang natin yung Person then automatic si employee mainherit nya yung Properties and Methods ni Person 

                                                    EMPLOYEE  : Person  
                                                                        Properties:
                                                                                FullName 
                                                                        Method : 
                                                                                Walk

                                                    >> EMPLOYEE Inhiret Properties and Methods 

                                                    EMPLOYEE   
                                                            Properties:
                                                                    FullName 
                                                            Method : 
                                                                    Walk

                                                    >> and then pwede na tayo mag add ng specific properties and methods para sa EMPLOYEE its like Parent and Child lang

                                                     EMPLOYEE   
                                                            Properties:
                                                                    FullName 
                                                            Method : 
                                                                    Walk   
                                                                    Work  -- so here nag add tayo ng another Method 

                        4. Polymorphism : ability to implement inherited properties or methods in different ways accross multiple abstractions.
                                        : ito na may yung way natin para baguhin or i-extend yung properties or methods na nainherit natin sa baseclass 
                                        : Example if inherit natin yung Employee sa Manager and Staff na class tas sa manager pwede natin baguhin or i-extend yung implementation ng ibang function kasi mag kaiba naman talaga yung ginagawang manager sa staff 
                                        : Example yung na inherit natin na method kay employee is Do Work 

                                                                        EMPLOYEE   : Person 
                                                                                Properties:
                                                                                        FullName 
                                                                                Method : 
                                                                                        Walk   
                                                                                        Work  -- so here nag add tayo ng another Method 


                                        MANAGER : EMPLOYEE                                                                        STAFF   : EMPLOYEE
                                                Properties:                                                                                    Properties:
                                                        FullName                                                                                    FullName 
                                                Method :                                                                                        Method : 
                                                        Walk                                                                                        Walk   
                                                        Work                                                                                        Work   

                                        : and yung na Inheret  is may process na DoWork ();
                                                                                            Work(){
                                                                                                    DOWORK()
                                                                                                }    
                                        : nad at manager ni extend natin yun loob to check the subbordinates ()


                                                                        EMPLOYEE   : Person 
                                                                                Properties:
                                                                                        FullName 
                                                                                Method : 
                                                                                        Walk   
                                                                                        Work  -- so here nag add tayo ng another Method 


                                        MANAGER : EMPLOYEE                                                                        STAFF   : EMPLOYEE 
                                                Properties:                                                                                    Properties:
                                                        FullName                                                                                    FullName 
                                                Method :                                                                                        Method : 
                                                        Walk                                                                                        Walk   
                                                        Work (){                                                                                       Work 
                                                                 DOWORK()
                                                                 CheckSubbordinates() -- heres the extended 
                                                                 } 

                                        : pag tinawag natin yung Work() na method sa Abstract Class na Person para sa "Object" na STAFF Ang gagawin lang sya is DoWork since yung may extended lang naman kay Manaher 
                                        : while pag yung "Object" naman na  Manager naman yung gagawin nya is DOWORK () AND CheckSubbordinates() yung gagawin nya what does mean is yung work na method sa natin is naiiba-iba yung ginagawa nya depends kung ano ginagawa mo 
                                        : kasi yung Polymorphism means Many Forms
                                        : Polymorphism = Many Forms
                                        : Nagagawa natin bagohin yung Forms or Functionality na nainherit natin Propertues or Function gamit yung OverRidding and Overloading 
                                        : OverLoading na encounter na sa Part 10 yung Person 

                -------------------------------
                --- ABSTRACT VS INTERFACE ----
                --------------------------------
                
                    >> ABSTRACT VS INTERFACE : Pwede tayong gumamit ng Abstract and Interface para makagawa tayo ng Abstraction 
                    >> But the Questions is When to Use Abstraction and Interface 
                    >> ABSTRACT : class allow you to create functionality that subclasses can implement or override. 
                    >> ABTRACT : Gagamit lang tayo ng Abstact pag may Default Functionality or Block of Codes na gustong isama sa pag inhiret means may default function sya and kung may gusto baguhin or iadd dun sa default functionalitu gagamit lang tayong overrriding 
                    >> INTERFACE : An Interface only allows you to define functionality, not implement it 
                    >> INTERFACE : Gagamit naman tayo ng Inteface if gusto natin i-force yung mga subclass or yung mga nag iinheret na class na implement lang ng properties and methods na nakadefined sa interface 
                                 : and interface is a contract kungbaga yung class natin is may contrata sa interface na ininherit nya na need implement sa class natin mismo 
                                 : and sa interface wala syang pake pano po to implement sa class mo ang pinanghahawakan nya lang yung contract nyo na implement mo yung na inherit mo 
                    >> and this is one to consider choosing between sa Interface or Abstract kasi sa isang class isa lang yung pwedeng mainherit na abstract class and for interface pwede multiple yung iinheret natin 
                    >> Abstract Class : Isang besses lang sa isang class 
                    >> Inheret : Pwede multiple inheret sya sa isang class 
                    >> And whereas a class can extend only one abstract class , it can take advantage of multiple interfaces



                -------------------
                --- GENERIC  ----
                -------------------
                    >> C# allows you to define generic Clases, Interface, Abstract class, Fields, Methods, Static Methods, Properties, Events, Delegates, and Operators using the type parameter and without 
                        the specific data type. 
                    >> Generic is way natin para gumawa ng generic class means general form sya hindi sya specific sa isang form lang 
                    >> Example meron tayong delivery Truck for Fruits means para lang sya sa Fruits and yun lang yung idedeliver nya since specific 
                    >> pero pag gumamit tayo ng Generic na Truct means kaya ng mag process ng ibat ibang class or mag deliver ng kahit ano 
                    >> and since wala syang specific na data type and kahit anong data type is kaya nyang iprocess means yung truck mo pwede lagyan ulit ng truck sa loob or barko 
                    >> kaya its important din na mag lagay ng constring para malimit natin yung pwede nya lang mapasok sa loob ng truck, so constring is optional lang di sya required pag gumagawa ng Generic 
                    >> A type parameter is placeholder for particular type specified when creating an instance of the generic type 
                    >> and sa generic natin tayong type parameter and yun na yung placeholder natin 
                    >> bali dito na natin nilalagay yung data type na kaylangan natin i-process 
                    >> example yung placholder natin is lalagyan natin ng fruitas para sa generic natin na truck ibigsabihin yung result nya is truck na nag proprocess ng fruitas 
                    >> A generic type is declareed by spcifying a type parameter in an angle brackets after a type name, e.g. TypeName<T> where T is a type parameter 
                    >> yung placeholder natin ng data type is nilalagay natin sa loob ng angle brackets <T> after ng Generic Type natin pwede syang multiple seperated by comman and yung placeholder Nmae is kahit ano yan kasi custome name yan 
                    >> Placholder Name : Custome Name : TypeName 
                    >> Placeholder Data Type : <> : <T> 
                    >> and kung multiple yung Placeholder Data Type pwede syang T1 , T2, T3 ......Tn
                    >> TypeName <T1,T2,T3,......Tn>
                       

            */



  
        }
    }
}
