using System;

class Aa
{
    public int a = 10, b = 5;
}

class Bb: Aa
{
    public void test()
    {
        Console.WriteLine("Value of a is: " + a);
        Console.WriteLine("Value of b is: " + b);
    }
}

class Cc: Bb
{
    public void multiply()
    {
        Console.WriteLine("Multiplication of a and b: " + (a * b));
    }
}

class InheritMultilevel
{
   /* static void Main(string[] args)
    {
        Cc obj = new Cc();
        obj.test();
        obj.multiply();
        Console.ReadKey();
    }*/
}
