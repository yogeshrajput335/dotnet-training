﻿// See https://aka.ms/new-console-template for more information
using MyApp;
using InheritanceUniverse;


Console.WriteLine("Enter your age:");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your age is: " + age);
// Type your username and press enter
//Console.WriteLine("Enter username:");

// // Create a string variable and get user input from the keyboard and store it in the variable
// string userName = Console.ReadLine();

// // Print the value of the variable (userName), which will display the input value
// Console.WriteLine("Username is: " + userName);

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
