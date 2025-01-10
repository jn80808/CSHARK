// See https://aka.ms/new-console-template for more information

using System;
using System.ComponentModel;

// var part1 = new Part1();
// part1.Execute();


var part2 = new Part2();
part2.Execute();


var scopevar = new ScopeOfVariableInsideMethod();
scopevar.SampleMethod1();

var scopevarshared = new ScopeOfVariableShared();
scopevarshared.SampleMethod1();
scopevarshared.SampleMethod2();


var varstatic = new ScopeOfVariableSTATIC();
//varstatic.SampleSTATICMethod1(); // nag eerror kasi not accessable sya since yung class is non-static it can only access the non static method 

//static class with static method 
// So Directly calling na yung static method pag static no need to declare variable to store the class
ScopeOfClassSTATIC.SampleSTATICMethod1(); 

Console.WriteLine(); 
var varreadonly = new ScopeOfVariableReadOnly();
varreadonly.SampleMethodReadOnly1();

Console.WriteLine(); 
var varconst = new ScopeOfVariableConst  ();
varconst.VarConstMethod();