// See https://aka.ms/new-console-template for more information

using System.Runtime.Intrinsics.Arm;
using LearnCSharp;

Console.WriteLine("Hello, World!");


Class1 c1 = new Class1();

Class2 c2 = new Class2();

Class1 c12 = c2;

Interface1 i = c2;

Console.WriteLine(c12.ValamiNew());
Console.WriteLine(c12.ValamiOverride());

Console.WriteLine(i.ValamiNew());
Console.WriteLine(i.ValamiOverride());

Console.ReadLine();
