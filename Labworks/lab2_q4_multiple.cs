using System;

// First interface
interface ITestA
{
    void displayA();
}

// Second interface
interface ITestB
{
    void displayB();
}

// Class implementing both interfaces (simulating multiple inheritance)
class ClassD : ITestA, ITestB
{
    public void displayA()
    {
        Console.WriteLine("Display from interface A");
    }

    public void displayB()
    {
        Console.WriteLine("Display from interface B");
    }
}

class MultipleInheritance
{
   /* static void Main(string[] args)
    {
        ClassD obj = new ClassD();
        obj.displayA();  // Calls displayA() from ITestA
        obj.displayB();  // Calls displayB() from ITestB

        Console.ReadKey();
    }*/
}
