// See https://aka.ms/new-console-template for more information

using System;
using System.ComponentModel;

// var part1 = new Part1();
// part1.Execute();

// ----------- local Variables , Var Scope , Keywords ----------- //

#region  -- Part 1 --
var part2 = new Part2();
part2.Execute();

Console.WriteLine("");
Console.WriteLine("***************");
Console.WriteLine("-- ScopeOfVariableInsideMethod --");
var scopevar = new ScopeOfVariableInsideMethod();
scopevar.SampleMethod1();
Console.WriteLine("");


Console.WriteLine("***************");
Console.WriteLine("-- Shared Variable --");
var scopevarshared = new ScopeOfVariableShared();
scopevarshared.SampleMethod1();
scopevarshared.SampleMethod2();

Console.WriteLine("");

Console.WriteLine("***************");
var varstatic = new ScopeOfVariableSTATIC();
//varstatic.SampleSTATICMethod1(); // nag eerror kasi not accessable sya since yung class is non-static it can only access the non static method 
//static class with static method 
// So Directly calling na yung static method pag static no need to declare variable to store the class
Console.WriteLine("-- STATIC VAR --");
ScopeOfClassSTATIC.SampleSTATICMethod1(); 



Console.WriteLine("");
Console.WriteLine("***************");
Console.WriteLine("-- Read Only Variable --");
var varreadonly = new ScopeOfVariableReadOnly();
varreadonly.SampleMethodReadOnly1();
Console.WriteLine("");


Console.WriteLine("***************");
Console.WriteLine("-- Constant Variable --");
var varconst = new ScopeOfVariableConst  ();
varconst.VarConstMethod();

#endregion
Console.WriteLine("");

/// ------- Class Variables & Instance Variables  ------- ///

Console.WriteLine("***************");
Console.WriteLine("-- PUBLIC --");
var class1 = new  Class1 ();
Console.WriteLine (class1.samplePublicInt);
class1.samplePublicInt = 250 ;
Console.WriteLine (class1.samplePublicInt);
Console.WriteLine("");


Console.WriteLine("***************");
Console.WriteLine("-- STATIC --");
Console.WriteLine(Class1.sampleStaticOrClassVariableInt);
Class1.sampleStaticOrClassVariableInt =200;
Console.WriteLine(Class1.sampleStaticOrClassVariableInt);

Console.WriteLine("");
Console.WriteLine("***************");
Console.WriteLine("-- DATA TYPE PARSE --");


//Parse & Convert 
//Parse
string textOne = "3";
var intOne = int.Parse(textOne);
var result = intOne * 5;
Console.WriteLine("result of pasred variable: {0}",result);
//Convert : may tab for ToInt16:short , ToInt32 , ToInt64:long
string varToConvert = "13";
var vartoint = Convert.ToInt32(varToConvert);
var resultcon = vartoint * 5;
Console.WriteLine("result of convert variable: {0}",resultcon);

//try Parsing 
string textstring = "Sample";
int intVar;
int.TryParse(textstring ,out intVar);
Console.WriteLine ("Result of Try Parse: {0}", intVar);
Console.WriteLine ($"Result of Try Parse: {intVar}");

//try if else Parse 
string textThree ="Hello3";
int intThree; //inline declaration , walang pinag gamitan pero never ginamit sa ibang part nang code not until nag try tayo mag TryParse
int intTwo =3;
if (int.TryParse(textThree,out intThree))
{
    Console.WriteLine($"Result Three using TrtParse: {intTwo}");
}
else 
{
    Console.WriteLine($"Not a Number: {textThree} AHA");
}

//Inline Variable Declaration
string text4 ="Hello3"; 
string textFour ="**TEST**";

if (int.TryParse(text4 ,out int inttextFour  )) // here the inline declaration which is dito na mismo na lagay ng datatype and variable 
{
    
    Console.WriteLine($"Result TextFour using TrtParse: {inttextFour}");
}
else 
{
    Console.WriteLine($"Not a Number: {textFour} AHA");
}







