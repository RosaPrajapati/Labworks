using System;

class ClassA
{
    public int a = 10, b = 5; // base class
}

class ClassB : ClassA // ClassB inherits from ClassA
{
    public void test()
    {
        Console.WriteLine("Value of a is: " + a);
        Console.WriteLine("Value of b is: " + b);
    }
}

class ClassC : ClassA // ClassC also inherits from ClassA
{
    public void add()
    {
        Console.WriteLine("Sum of a and b: " + (a + b));
    }
}

class InheritHierarchical
{
    /*static void Main(string[] args)
    {
        ClassB objB = new ClassB();
        objB.test(); // ClassB uses method test()

        ClassC objC = new ClassC();
        objC.add();  // ClassC uses method add()

        Console.ReadKey();
    }*/
}
