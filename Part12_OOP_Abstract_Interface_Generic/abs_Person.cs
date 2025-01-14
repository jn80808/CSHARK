using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;




namespace Part12_OOP_Abstract_Interface_Generic
{
    public abstract class abs_Part12_Person
    /*
    >> here nag add na sya ng abstract na class 
    >> means this is now a abstract class and di na pwede mag iinstantiate sa Person na class 
    >> kasi parang template lang to para sa mga concreate na class natin like Leni na class natin 
    
    */
    {

        //Common members Existing in SARA & LENI 
        public string FullName { get; set; }

        public void DoSomething() {}
    }
        
    
}