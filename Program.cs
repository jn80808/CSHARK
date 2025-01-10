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

