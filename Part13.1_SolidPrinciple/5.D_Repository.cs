using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Part13._1_SolidPrinciple.D_Repository;

namespace Part13._1_SolidPrinciple
{
    public class D_Repository
    {
        
        /*
            >> ang purpose nito is para maiwasan yung tighly coupled na Implementation Approach means dapat yung application natin is dapat di sya naka depend sa low level code or details ng Implementation natin 
                dapat kaya nyang mabuhay kahot wala yung implementation na yun di sya tighly coupled kaya important yung abstraction na class para sa decoupling na process , sa programming always decoupling and laging implemented kesa sa coupled sa lovelife maganda 
            >> its like sa interface wala syang pakealam kung anong implementation meron ka basta ma implement mo yung nasa loob ng code block nya kaya here sa Dependency Inversion si Interface yung ginagamit 

        */

        // Class Repository with 2 methods od Add and Delete and this methods yung nakikipag interact sa methods natin 
        //   

            #region  -- Not - Dependency Inversion    -- 

                public class Repository
                {
                    public void Add()
                    {
                        // Simulating a DB operation with 1000+ lines of code
                        Console.WriteLine("Add using DB");
                    }

                    public void Delete()
                    {
                        // Simulating a DB operation with 1000+ lines of code
                        Console.WriteLine("Delete using DB");
                    }

                }
            #endregion


            #region  -- Using - Dependency Inversion    -- 
                        // Define an abstraction for database operations
                        public interface IRepository2
                        {
                            void Add();
                            void Delete();
                        }

                        // Implementation of IRepository for database operations
                        public class DatabaseRepository : IRepository2
                        {
                            public void Add() //Yung method natin na Add and Delete yun yung nakikipag interact sa database natin or transact
                            {
                                // Simulating a DB operation with 1000+ lines of code
                                Console.WriteLine("Add using DB");
                            }

                            public void Delete()
                            {
                                // Simulating a DB operation with 1000+ lines of code
                                Console.WriteLine("Delete using DB");
                            }
                        }

                        // Implementation of IRepository for file storage (example of an alternative)
                        public class FileRepository : IRepository2
                        {
                            public void Add()
                            {
                                Console.WriteLine("Add using File Storage");
                            }

                            public void Delete()
                            {
                                Console.WriteLine("Delete using File Storage");
                            }
                        }

                        // High-level class that depends on abstraction, not concrete implementation
                        public class RepositoryManager
                        {
                            private readonly IRepository2 _repository;

                            // Constructor injection to decouple dependencies
                            public RepositoryManager(IRepository2 repository)
                            {
                                _repository = repository;
                            }

                            public void PerformAddOperation()
                            {
                                _repository.Add();
                            }

                            public void PerformDeleteOperation()
                            {
                                _repository.Delete();
                            }
                        }
                
            #endregion


            #region  -- Change Implementation using API --

            // Implementation of IRepository for API integration
            public class APIIntegrationRepository : IRepository2
            {
                public void Add()
                {
                    Console.WriteLine("Add using WebAPI");
                }

                public void Delete()
                {
                    Console.WriteLine("Delete using WebAPI");
                }
            }
            #endregion





    }
}