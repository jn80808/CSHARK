using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Part12_OOP_Abstract_Interface_Generic
{
    public class Abstract_vs_Interface
    {

 
        //-----------------------------------------------------------------
        // ----------------------- ABSTRACT  ------------------------------
        //-----------------------------------------------------------------
        
        /*
            >>  In Real world Project its combination of Abstract and Interface 
            >>  yung Parent ng Abstract is yung Interface and yung Interface na yung ginagamit sa ibat ibang code na nasa project para di tighly coupled yung application sa mga implementation 
            >>  and mas testable espcially is ginagamit sa mocking 
        */


            // Abstract base class
                public abstract class Document
                {
                    public string Name { get; set; }

                    public void Process()
                    {
                        Console.WriteLine($"{Name} is being processed.");
                    }

                    public abstract void Print(); // Added abstract na method as per poly_TagaCompute  gumamit tayo ng virtual na keyword para pwede natin i-override yung method pero optional lang yun pwede natin i-override pwede hindi 
                                                    // and for the abstract na keyword is required na  i-override yung method na to kaya walang body yung abstract natin kaya sa next class natin na PDF Is Ininherit nya yung class Document natin automatic yung members ni Document is nainheret na ni PDF 
                                                    // take note pwede ka lang gumamit ng absrtract sa mga properties and methods if naka abstract din yung class mo 
                }

                // Derived classes
                public class PDF : Document
                {
                    public override void Print()  // And in this part is ni force tayo na i-override yung method natin na Print , ginagamit lang natin yung abstract pag reqired na unique yung functionality ng bawat class na mag iinherit sa abstract class natin kasi kung may default implementation yung abstract natin means pwede to gamitin ng mga mag i-inherit class natin and di na sya magiging unique kung gagamitin nila yung default 
                    {
                        Console.WriteLine($"{Name} is a PDF document and is printing.");
                    }
                }

                public class Word : Document
                {
                    public override void Print()
                    {
                        Console.WriteLine($"{Name} is a Word document and is printing.");
                    }
                }

                //-----------------------------------------------------------------
                // ----------------------- Interface ------------------------------
                //-----------------------------------------------------------------


                /*
                    >>  Just use Interface na keyword and I in Firts
                    >>  and sa Interfacae is di pwede mag karon ng field or vairable sa loob yung var variableName di to pwede sa loob 
                    >>  and yung members nya is walang access modifier or acess specifier yung public , private and so on kasi by default mga naka public na sya as we can see the IDokumento is data type lang nideclare 
                    >>  and yung property and method is nasa abstract lahat kaya required na implement to pag i-inhiret natin yung interface na to  bali ito na yung na seserve ng kontrata natin na need natin i-implement sa class natin na nag iinhirit sa interface na to 


                */




                public interface IDokumento   
                {
                    string Name { get; set; }
                    void Process();
                    void Print();
                }

                // -----------------Implementation of the interface-------------

                /* 
                    >> so here nag create tayo ng class and ininherit natin yung Inteface natin and as we can see dun sa loob is finorce na tayo na iimplement yung lahat ng property and methods unlike sa abstract class is may default implementation 
                    >> sa inhiritance naman ang disadvantage sa class is isa lang pwede inhirit na class pero pwede naman multiple interface yung iinhirit nya as shown sa example sa baba na NewDocument 
                    >> Interface is different from Inhiritance 


                */
                public class Excel : IDokumento 
                {
                    public string Name { get; set; }

                    public void Process() { }

                    public void Print(){ }

                }

                // Empty interfaces
                public interface IDoc1 { }
                public interface IDoc2 { }

                // so here as example sa NewDocument na class is ininherit nya yung Word na class pero di na nya pwede mag inhirit ng ibang class kasi sa per inhiritance pwede ka lang isang beses mag inhirit ng class 
                //pero pwede ka mag inherit ng multiple Interface sa isang class as shown below 
                //kung pano inimplement yung sa abstract is same lang sa inteface ang pinag kaiba is walang default implementation si interface pag assigned naman ng instance is same lang naman sila ni abstract din 
                
                public class NewDocument : Word , IDoc1, IDoc2 {}
                


    }
}