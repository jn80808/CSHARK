using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;
using Part10_Class_Struct_Delegate;



namespace Part12_OOP_Abstract_Interface_Generic
{
    // public class Sara : Part12_Person
    // {

    // }
    public class abs_Sara :  Zunitsu 
    {

    }

    // and then we add new method Zunitsu and naka inherent din sya kay Person natin means automatic may FullName and DoSomething din syang members 
    public class Zunitsu : abs_Part12_Person {
        public bool KidlatSmaurai { get; set; }
    }
        
    /*
    ----- CREATE AN ABSTRACT ------------------
    

        >> 1st  step is Identify common members in both class ni SARA and Leni 
        >> 2nd step is gagawa tayo ng class na Person para sa abstraction 
        >> 3rd step is malaman kung ano yung mga common members sa mga class natin 
            And remove na natin yung members natin sa SARA 
            And add na nag abstract keyword dun sa Person para maging Abstract class na sya 
            >> here nag add na sya ng abstract na class 
            >> means this is now a abstract class and di na pwede mag iinstantiate sa Person na class 
            >> kasi parang template lang to para sa mga concreate na class natin like Leni na class natin 
        >> 4th is inupdate natin yung class ni sara and kay zunitsu nanatin sya i-inherit so yung members ni 
            zunitsu nag KidlatSamurai is maiinherit ni zara and kay leni inaplly na natin yung person na class dun 
            so si leni is mainherit naman nya yung work and dosomething ni Person 
    
    */
}