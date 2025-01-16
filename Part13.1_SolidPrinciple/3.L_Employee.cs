using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Part13._1_SolidPrinciple
{
    public class L_Employee
    {
        /*
            L - Liskov's Substitution : A class should have only one reason to change
            in Liskov's is where di naman lahat ng scenario na need natin ipasa yung child instrance natin 
            ParentClass obj = new Child Class ();
            >> So pag mag iinherit tayo ng inerface sa class natin we should make sure na dapat na mag wowork padin yung class natin pag mag act sya sa sarili nya hindi as Parent or abstract  Class 

            [Normal Creation of class instance]

            class obj = new Class()
                    or 
            ChildClass cls = new ChildClass(); 

         */

        #region -- Problem In Interface Implementation -- 
        public interface IEmployee //Interface with 2 methods
        {
            void DoWork();
            void CheckSubordinates();
        }

        //Manageer Claas 
        public class Manager : IEmployee //inherit the Interface and need to implement the 2 method from interface
        {
            public void DoWork()
            {
                Console.WriteLine("Work work work");
            }

            public void CheckSubordinates()
            {
                Console.WriteLine("Supervise");
            }
        }

        //Staff Claas 
        public class Staff : IEmployee // Inherit the Interface again and here si staff need nya lang yung isang method here where what is the rules is if you inherit in interface need define  yung mga method and members ni interface 
        {                              // and si Staff is 1sang method lang need nya yung DoWork() lang what we do here is define lang natin yung DoWork na may Implementation and for CheckSubordinates denifine lang natin dito sa loob without Implementation kaya pag tinawag to sa ibang programs (yung nag ooutput) babato lang sya ng Error NotImplementedException 
                                       // and if implement naman natin yung CheckSubordinates mali naman yung logic since wala naman subordinates si employee
                public void DoWork()        
            {
                Console.WriteLine("Work work work");
            }

            public void CheckSubordinates()
            {
                // Not implemented for Staff class
                throw new NotImplementedException();
            }
        }


        #endregion




        #region -- Solution -- 

        //To solve this we need Seperate the 2 Method on Separate Interface 
        public interface IStaff
        {
            void DoWork();
        }

        public interface IManager : IStaff // here ninherit lang natin si IStaff so maiinhirit nya yung yung DoWork() na method 
        {
            void CheckSubordinates();
            
        }

        //Staff2
        public class Staff2 : IStaff //So here we see na DoWork() na method nalang yung Implemented sa loob
        {

            public void DoWork()        
            {
                Console.WriteLine("Work work work");
            }
        }


        //Manageer2 Claas 
        public class Manager2 : Staff2,  IManager // so here naka Inherit tayo sa Staff2 so kung anong implementation sa class nato is yun din makukuha natin para sa Manager2 natin is DoWork nya is ComputeBillofMonthofJune then yun din yung DoWork ni Manager 
        {

            public void CheckSubordinates()
            {
                Console.WriteLine("Supervise");
            }
        }

        #endregion
    }
}