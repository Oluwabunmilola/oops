using System;

namespace OOPWeek4
{
    class Program
    {
        static void Main(string[] args)
        {

    //  PartTimeEmployee pte=new PartTimeEmployee();

     ParentClass parentClass=new ParentClass();
     parentClass.printMessage();
     ChildClass childClass=new ChildClass();
     childClass.printMessage1();
     childClass.printMessage();

      //Inheritance allows us to use the base class variable to point to the clild class
      //Employee employee = new PartTimeEmployee();
     //Multiple classes cannot be inherited in .net
     //Its possible through using interfaces 


     // Polymorphism(many forms)in c# is a concept by which we can perform a single action in different ways.
     //We can perform polymorphism in c# by method overloading and method overriding. 
     //If you overload a method in c#, it is the example of compile time(static) polymorphism
     //If you override a method in c#, it is the example of run time(dynamic) polymorphism

     //Polymorphison allows to call derived class methods using parent class refence
     
//      pte.firstName="Presh";
//      pte.lastName="ajayi";
//      pte.PrintFullNmae(); 
//      //employee.PrintFullName();

//  ContractEmployee ce=new ContractEmployee();//mthod hiding
//      ce.firstName="muiz";
//      ce.lastName="ade";
//      ce.PrintFullNmae(); 
        }

    }
}
