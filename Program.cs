// See https://aka.ms/new-console-template for more information
using MyApp;
using InheritanceUniverse;


ClassA a = new ClassA();
string aValue = a.value;
Console.WriteLine(aValue);
a.DisplayA();

ClassB b = new ClassB();
int bValue = b.age;
Console.WriteLine(bValue);
b.DisplayB();
//b.DisplayA();
//Console.WriteLine(b.value);
