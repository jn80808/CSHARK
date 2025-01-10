// See https://aka.ms/new-console-template for more information



using System.ComponentModel;

// Part2.cs
using System;


// Part 2 : local Variables , Var Scope , Keywords , Class vs Instance Variable , Parsing , Convert 



public class Part2
{
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
}

public class ScopeOfVariableInsideMethod //variable the accessible only inside of the method block 
{

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
}

public class ScopeOfVariableShared //variable the accessible to any method block inside of the class 
{

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
}

//keyword : static , readonly , constant 
public class ScopeOfVariableKeyWord //variable the accessible to any method block inside of the class 
{

    int sampleLocalIntGlobal ; // variable that share to all method since naka declare mismo sya sa class not inside of the method 
    static int samplevarSTATICInt ;
    public void SampleMethod1()
    {
    
        int sampleLocalIntGlobal = 1;
        var sampleLocalDouble = 1.5;
        samplevarSTATICInt = 11; // accessing static variable in public void only will not show error 
        
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
        sampleLocalIntGlobal = 13; // but here accessing not static variable getting error since the method declare public static void and means yung mga variable na hindi static is not accessble here 
        samplevarSTATICInt = 14;
    }

}











