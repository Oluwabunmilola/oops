using System;

public class Employee
{
    public string firstName;
     public string lastName;

    public void PrintFullNmae() //or  public virtual PrintFullNmae()
{
    Console.WriteLine(firstName + " "+ lastName);

}
}
public class PartTimeEmployee:Employee 
{
        public new void PrintFullNmae() //or  public override void PrintFullNmae()
{
    Console.WriteLine(firstName + " "+ lastName+"----Part time employee");

}

}
public class ContractEmployee:Employee 
{
      public new void PrintFullNmae() //or  public  void PrintFullNmae()
{
    Console.WriteLine(firstName + " "+ lastName+"---Contract employee");

}

}

