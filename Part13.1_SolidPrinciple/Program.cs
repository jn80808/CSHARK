﻿

/*
S - Single Responsibility : A class should have only one reaso to change 
O - Open for Extension, Closed for Modification: Software entities should be open for extension , but closed for medification
L - Liskov's Substitution : A class should have only one reason to change
I - Interface Segragation : A class should have only one reason to change 
D - Dependency Inversion : High-level module/class should not depend on low-level modules/class Both should depend upon abstraction 


*/


using System;
using static Part13._1_SolidPrinciple.D_Repository;
using static Part13._1_SolidPrinciple.I_WorkWork;
using static Part13._1_SolidPrinciple.L_Employee;
using static Part13._1_SolidPrinciple.O_SampleCalculator;
using static Part13._1_SolidPrinciple.S_PDFDocument;

namespace Part13._1_SolidPrinciple
{
    class Print_O_O
    {
        static void Main(string[] args)
        {

            #region  -- S - Single Responsibility  -- 

                Console.WriteLine();
                Console.WriteLine("********* Single Responsibility  *********");
                Console.WriteLine();

                // Demonstrating PDF functionality
                S_PDFDocument pdfDocument = new S_PDFDocument();
                pdfDocument.PrintPDF();

                // Demonstrating Quadratic Equation functionality
                QuadraticQuation quadraticEquation = new QuadraticQuation();
                quadraticEquation.Calculate(1, -3, 2); // Solving equation: x^2 - 3x + 2 = 0

            #endregion

            #region  -- O - Open for Extension  -- 
            

                #region -- Example 1 : [NON - OPERATIONAL ] --
                
                Console.WriteLine();
                Console.WriteLine("********* -- [NON - OPERATIONAL ]   *********");
                Console.WriteLine();

                // Create instances of operations
                var operations = new O_Operation[] {
                    new Add { A = 5, B = 5 },
                    new Subtract { A = 5, B = 5 }
                    // If you want to add multiply, you would need to create a Multiply class
                };

                // Call the Calculate method
                var sampleCalculator = new O_SampleCalculator();
                sampleCalculator.SimpleCalculatorV1(operations);

                #endregion

                #region -- Example 2 : [USING - OPERATIONAL ] --
                Console.WriteLine();
                Console.WriteLine("********* -- [USING - OPERATIONAL ] *********");
                Console.WriteLine();

                // Define operations for using principle of O (Open for Extension, Closed for Modification)
                IOperation[] operations1 = new IOperation[] {
                    new AddV2 { A = 5, B = 5 },
                    new SubtractV2 { A = 5, B = 5 }
                };

                // Instantiate the calculator and perform calculations
                var calculatorV2 = new SimpleCalculatorV2();
                calculatorV2.Calculate(operations1);
                #endregion

            #endregion


            #region  -- L - Liskov's Substitution  -- 

                Console.WriteLine();
                Console.WriteLine("*********  -- Liskov's Substitution  --  *********");
                Console.WriteLine();

                IEmployee manager = new Manager();
                manager.DoWork();
                manager.CheckSubordinates();

                IEmployee staff = new Staff();
                staff.DoWork();
                try
                {
                    staff.CheckSubordinates(); // This will throw NotImplementedException
                }
                catch (NotImplementedException)
                {
                    Console.WriteLine("Staff cannot check subordinates.");
                }

            #endregion

            #region  -- I - Interface Segragation   -- 

                Console.WriteLine();
                Console.WriteLine("*********  -- Interface Segragation --  *********");
                Console.WriteLine();

                #region  -- NON - Interface Segragation --

                    Console.WriteLine();
                    Console.WriteLine("*********  -- NON - Interface Segragation --  *********");
                    Console.WriteLine();
                    // Create an instance of Tagalaba
                    Tagalaba trabahador = new Tagalaba { Name = "Juan" };

                    // Call the methods
                    trabahador.GetSalary();
                    trabahador.MaghugasPlato();
                    trabahador.Maglaba();
                    trabahador.MaglinisNangBahay();
                    trabahador.MagPlantsa();

                #endregion

                #region  -- USING - Interface Segragation --

                    
                    Console.WriteLine();
                    Console.WriteLine("*********  -- USING - Interface Segragation --  *********");
                    Console.WriteLine();

                    // Example: A worker who can do laundry and ironing
                    Trabahador worker = new Trabahador { Name = "Maria" };

                    // Calling methods
                    worker.GetSalary();
                    worker.Maglaba();
                    worker.MagPlantsa();

                #endregion




            #endregion

            #region  -- D - Dependency Inversion    -- 

                #region  -- Not - Dependency Inversion    -- 

                    Console.WriteLine();
                    Console.WriteLine("*********  -- Not - Dependency Inversion --  *********");
                    Console.WriteLine();

                        
                    /*
                        >> pag ginamit na to sa program magiging dependent yung program natin or  tighly couple na sya sa repository na connected sa database natin kasi yung Repository natin is our Implementation natin 
                        >> di naman mali yung ganto pero di na sya Testable and at the same time pag may binago ka sa data source mo is babaguhin mo din yung application instead na data source lang kaya mahihirapan ka na imaintain pag malaki na yung application 
                        >> kung baga may pakealam ka na sa implementation mo unlike sa interface is wla kang pake kung ano man basta implement ng mga mag iinherit sayou yung mga member or method or ano man code yung nasa loob ng code of block mo 

                    */
                    var repo = new Repository ();
                    repo.Add ();
                    repo.Delete();


                #endregion

                    
                #region  -- USING - Dependency Inversion    -- 

                    Console.WriteLine();
                    Console.WriteLine("*********  -- USING  - Dependency Inversion --  *********");
                    Console.WriteLine();

                    // Dependency injection: inject the specific implementation
                    IRepository2 dbRepository = new DatabaseRepository();
                    RepositoryManager dbManager = new RepositoryManager(dbRepository);

                    Console.WriteLine("Using Database Repository:");
                    dbManager.PerformAddOperation();
                    dbManager.PerformDeleteOperation();

                    Console.WriteLine("\nUsing File Repository:");
                    IRepository2 fileRepository = new FileRepository();
                    RepositoryManager fileManager = new RepositoryManager(fileRepository);

                    fileManager.PerformAddOperation();
                    fileManager.PerformDeleteOperation();


                #endregion

                
            #region  -- Change Implementation using API --

                IRepository2 dbRepository1 = new DatabaseRepository();
                dbRepository1.Add();




            #endregion



                


            #endregion



        }
    }
}
