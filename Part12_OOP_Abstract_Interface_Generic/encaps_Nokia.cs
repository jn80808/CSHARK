using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Part12_OOP_Abstract_Interface_Generic
{
    public class Nokia : MobilePhone
    {
        public override void MakeCall(string phoneNumber)
        {
            throw new NotImplementedException();
        }
    }

    public class IPHONE : MobilePhone
    {
        public override void MakeCall(string phoneNumber)
        {
            throw new NotImplementedException();
        }
    }
}

