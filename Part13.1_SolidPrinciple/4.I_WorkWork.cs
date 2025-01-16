using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Part13._1_SolidPrinciple
{
    public class I_WorkWork
    {

            /*
                >> I - Interface Segragation : A class should have only one reason to change  
                >> 
            */
            
        #region  -- NON - Interface Segragation --

                     /*
                        >> The Issue here is parang naging all in 1 na yung Iterface natin pag nimplement to and with This parang naViviolate na yung Single Responsibility pang ganto  
                        >> and pag ganto mahirap na to imaintain dapat ihiwalay natin ng maayus or segragate yung mga interface
                        >> The Solution here is gumawa tayo ng ITrabahador2 
                    */

            public interface ITrabahador

                {
                    string Name { get; set; }

                    void GetSalary();

                    void MaghugasPlato();

                    void MaglinisNangBahay();

                    void Maglaba();

                    void MagPlantsa();

                }

                public class Tagalaba : ITrabahador
                {
                    public string Name { get; set; }

                    public void GetSalary()
                    {
                        Console.WriteLine($"{Name} is getting their salary.");
                    }

                    public void MaghugasPlato()
                    {
                        Console.WriteLine($"{Name} is washing dishes.");
                    }

                    public void Maglaba()
                    {
                        Console.WriteLine($"{Name} is doing the laundry.");
                    }

                    public void MaglinisNangBahay()
                    {
                        Console.WriteLine($"{Name} is cleaning the house.");
                    }

                    public void MagPlantsa()
                    {
                        Console.WriteLine($"{Name} is ironing clothes.");
                    }
                }

        #endregion


        #region  --Using - Interface Segragation --

                // Base interface for common properties or methods
                public interface ITrabahador2
                {
                    string Name { get; set; }
                    void GetSalary();
                }

                // Specialized interfaces
                public interface ITagaHugas : ITrabahador2
                {
                    void MaghugasPlato();
                }

                public interface ITagalinis : ITrabahador2
                {
                    void MaglinisNangBahay();
                }

                public interface ITagaLaba : ITrabahador2
                {
                    void Maglaba();
                }

                public interface ITagaPlantsa : ITrabahador2
                {
                    void MagPlantsa();
                }

                // Combined interface pag need nag iba pang trabago example need ng taga laba and taga plantsa inherit lang yun 
                public interface TagalabaNaPlantsadoraPa : ITagaLaba, ITagaPlantsa
                {
                }


                // Implementing a class that uses TagalabaNaPlantsadoraPa
                public class Trabahador : TagalabaNaPlantsadoraPa
                {
                    public string Name { get; set; }

                    public void GetSalary()
                    {
                        Console.WriteLine($"{Name} is getting their salary.");
                    }

                    public void Maglaba()
                    {
                        Console.WriteLine($"{Name} is doing the laundry.");
                    }

                    public void MagPlantsa()
                    {
                        Console.WriteLine($"{Name} is ironing clothes.");
                    }
                }


        #endregion



        #region  -- Use D - Dependency Inversion-- 

    


        #endregion

    }
}
