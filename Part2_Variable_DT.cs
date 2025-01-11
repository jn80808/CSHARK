// See https://aka.ms/new-console-template for more information



using System.ComponentModel;

// Part2.cs
using System;
using System.Security.Cryptography.X509Certificates;


// Part 2 : local Variables , Var Scope , Keywords , Class vs Instance Variable , Parsing , Convert 


// ----------- local Variables , Var Scope , Keywords ----------- //

public class Part2
{

    #region -- PART 2 --
    public void Execute()
    {
            //WET and DRY Principle
            Console.WriteLine(); // Adds a blank line
            Console.WriteLine("PARRRRRRRRTTTTTTTTTTT22222222");

            //Declaration of Variable : explicit , implicit & dynamic 
            Console.WriteLine("Declaration of Variable"); 
            //local variables 
            //explicit : malalaman mo agad yung data type since dinideclare agad yung data type 
            int sampleNumberExplicit = 3;
            //implicit : tyaka mo lang malalaman yung data type upon declaring the value 
            //variable is name in a given to hold temporary value or information so this is the like a storage
            var sampleNumberImplicit = 3;
            //dynamic is parang var lang : during run time tyaka dinidetermine yung data type na meron ka 
            dynamic sampleNumberDynamic = 5;

            //Scope of variable 
            Console.WriteLine(); // Adds a blank line
            Console.WriteLine("Scope of variable"); // Adds a blank line

    }

    #endregion
}

//Variable inside of the method  
public class ScopeOfVariableInsideMethod //variable the accessible only inside of the method block 
{
    #region  -- Variable inside of the method --
    public void SampleMethod1()
    {
    
        int sampleLocalInt = 1;
        var sampleLocalDouble = 1.5;
        
        Console.WriteLine("SM1: {0}",  sampleLocalInt); // Corrected Console.WriteLine
    }

    public void SampleMethod2()
    {
        int sample2Int =1;
    }

    #endregion
}

//Shared Variable 
public class ScopeOfVariableShared //variable the accessible to any method block inside of the class 
{
    #region  -- Shared Variable --

    int sampleLocalIntGlobal ; // variable that share to all method since naka declare mismo sya sa class not inside of the method 
    public void SampleMethod1()
    {
    
        int sampleLocalIntGlobal = 1;
        var sampleLocalDouble = 1.5;
        
        Console.WriteLine("SM1: {0}",  sampleLocalIntGlobal);
    }

    public void SampleMethod2()
    {
        int sampleLocalIntGlobal =12;
         Console.WriteLine("SM2: {0}",  sampleLocalIntGlobal);
    }

    #endregion
}



//keyword : static , readonly , constant 
//@STATIC Variable 
public class ScopeOfVariableSTATIC 
{
    #region  -- STATIC VAR -- 
    int sampleLocalIntGlobal ; // variable that share to all method since naka declare mismo sya sa class not inside of the method 
    static int samplevarSTATICInt ;
    public void SampleMethod1()
    {
    
        int sampleLocalIntGlobal = 1;
        var sampleLocalDouble = 1.5;
        samplevarSTATICInt = 11; // accessing static variable 
        
        Console.WriteLine("SM1: {0}",  sampleLocalIntGlobal);
    }

    public void SampleMethod2()
    {
        int sampleLocalIntGlobal =12;
         Console.WriteLine("SM2: {0}",  sampleLocalIntGlobal);
         samplevarSTATICInt = 12;
    }

    public static void SampleSTATICMethod1 ()
    {
        //sampleLocalIntGlobal = 13; // but here accessing not static variable getting error since the method declare public static void and means yung mga variable na hindi static is not accessble here 
        samplevarSTATICInt = 14;
    }

    #endregion

}

//@STATIC Class

public static class  ScopeOfClassSTATIC 
{
    #region  -- STATIC CLASS -- 

    static int samplevarSTATICInt ;
    public static void SampleSTATICMethod1()
    {
        samplevarSTATICInt = 14;
        Console.WriteLine("Static variable value: " + samplevarSTATICInt);
    }
    #endregion

}

//@READ ONLY Variables
//read only variable is can be use only one time 
// can be use in constructor or during for initialization
public class ScopeOfVariableReadOnly 
{
    #region  -- read only --
    int sampleLocalIntGlobal ; // variable that share to all method since naka declare mismo sya sa class not inside of the method 
    readonly long samplevarreadonly1 = 10; //sample of read only use during initialize value 
    readonly int samplevarreadonly2 ; 

    // Constructor to initialize readonly fields
    public ScopeOfVariableReadOnly()
    {
        samplevarreadonly1 = 30; // and then we can still modify the initial value assigned inside of the contructor 
        samplevarreadonly2 = 20; // Assigned a value in the constructor
    }

       public void SampleMethodReadOnly1() // here sa method we cannot assigned value of readonly variable since we can only assigned value of readonly variable during initialization and in the constructor but we can still access it inside of the method just read 
    {
        // Read and use the readonly variable
        Console.WriteLine("samplevarreadonly1: {0}", samplevarreadonly1);
        Console.WriteLine("samplevarreadonly2: {0}", samplevarreadonly2);

        // samplevarreadonly1 = 50; // Error: Cannot assign to readonly field
    }

    #endregion

}


//Constant variable 
public class ScopeOfVariableConst 
{
    #region  -- Constant Var -- 
    int sampleLocalIntGlobal  ; // variable that share to all method since naka declare mismo sya sa class not inside of the method 
    int sampleLocalIntGlobal1 = 20;
    const long samplevarConst1 = 10; 
    const float mathPI = 3.14F ;  // if using constant variable we cannot change the declare value 
 
    // Constructor to initialize readonly fields
    public ScopeOfVariableConst()
    {
        //mathPI = 3.144F; // as you can sa constructor is pag nag reassigned tayo ng value is nag eeror padin since sa const variable you can just initialize value during declaring the variable you cannot change it even its in contructor and method 
        sampleLocalIntGlobal = 19;
        sampleLocalIntGlobal1 = 22; // as you can i modify the value of globalvar/shared value  here and can modify the value 
    }

    public void VarConstMethod ()
    {
        Console.WriteLine ("Constant Value of Var1 {0}", samplevarConst1); 
        Console.WriteLine ("Constant Value of Var {0} and {1}", samplevarConst1, mathPI); 
        Console.WriteLine ("Gloabal Var  {0}", sampleLocalIntGlobal); 
        Console.WriteLine ("Gloabal Var1  {0}", sampleLocalIntGlobal1); 
    }

    #endregion

}


//Code Region to Organized the Code 
//by declaring default = #region  -- declare the name of the region --
// sample : #region -- STATIC VARIABLE -- 
// And then add lang ng #endregion
//Example : so the purpose on this is pwede natin sya i-colapse 
public class ScopeOfREGION 
{
    #region  -- region sample  -- 
    int sampleLocalIntGlobal  ; // variable that share to all method since naka declare mismo sya sa class not inside of the method 
    int sampleLocalIntGlobal1 = 20;
    const long samplevarConst1 = 10; 
    const float mathPI = 3.14F ;  // if using constant variable we cannot change the declare value 
 
    // Constructor to initialize readonly fields
    public ScopeOfREGION()
    {
        //mathPI = 3.144F; // as you can sa constructor is pag nag reassigned tayo ng value is nag eeror padin since sa const variable you can just initialize value during declaring the variable you cannot change it even its in contructor and method 
        sampleLocalIntGlobal = 19;
        sampleLocalIntGlobal1 = 22; // as you can i modify the value of globalvar/shared value  here and can modify the value 
    }

    public void VarConstMethod ()
    {
        Console.WriteLine ("Constant Value of Var1 {0}", samplevarConst1); 
        Console.WriteLine ("Constant Value of Var {0} and {1}", samplevarConst1, mathPI); 
        Console.WriteLine ("Gloabal Var  {0}", sampleLocalIntGlobal); 
        Console.WriteLine ("Gloabal Var1  {0}", sampleLocalIntGlobal1); 
    }
#endregion
}




/// ------- Class Variables & Instance Variables  ------- /// <summary>


// Class Variable vs Instane Variable
// Class Variable : yung class variable is naka attached mismo sa type, pag sinabing type yan yung custome data type which is yung Class1 natin : public class Class1 
// Instance Variable : 
public class Class1 
{
    #region  -- Class Variable -- 
    public static int sampleStaticOrClassVariableInt = 3; //static variable is a class variable 
    public int samplePublicInt = 500; // public variable is instance variable : kaya sya tinawag na instance variable kasi need mona mag create ng instance ng class bago maaccess yung public variable natin  
    private int samplePrivateInt = 100; // private var : can only access inside of the class cannot be access outside of the class 

    #endregion
}







