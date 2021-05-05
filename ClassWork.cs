//Create a class with a method that prints "This is parent class"
// and its subclass with another method that prints "This is child class". Now, create an object for each of the class and call
//1 - method of parent class by object of parent class
// - method of child class by object of child class
//3 - method of parent class by object of child class

using System;
public class ParentClass
{

public void printMessage()
{
Console.WriteLine("This is a parent class");
}

}
public class ChildClass:ParentClass
{
public new void printMessage1()
{
Console.WriteLine("This is a child class");
}
}
