using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Part12_OOP_Abstract_Interface_Generic
{
    public abstract class poly_TagaCompute
    {
                
            private string _securedData; // Private field for internal use
            protected int _result;       // Protected means parang private sya na di sya available sa labas ng class ang pinag kaiba lang is avialble sya sa mga subclass withing sa subclass only , Protected can be use to methods , property and so on 

            // Public property to access _result
            public int Result // just getter so nirereturn lang kung ano yung value na nasa result 
            {
                get
                {
                    return _result;
                }
            }

            // Virtual method to allow overriding in derived classes
            public virtual void Compute(int num1, int num2) // 2 parameters , virtual keyword pag nilagay na natin to sa property or  method is pwede na natin to i-override sa lobb ng subclas 
            {
                _result = num1 + num2;
            }


    }
}