using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Part13._1_SolidPrinciple
{
    public class S_PDFDocument
    {

        /* - Single Responsibility : A class should have only one reaso to change 
           - here we have 2 method PDF and QuadraticEquation and there are not related to each other dapat kung ano lang ginagawa or purpose ng class yun lang yung gagawin nya 
           - kung yung class mo irelated lang sa PDF dapat yung function nya is related lang sa PDF 
        */
        public void PrintPDF()
        {


        }

        public void CalculateQuadraticEquation()
        {

        }

        // -- Single Responsibility Principle --
        #region -- Single Responsibility Principle -- 
        public class Word
        {
            public void S_Print()
            {

            }
        }

        public class QuadraticQuation
        {
            public void Calculate()
            {

            }
        }




        #endregion


    }
}