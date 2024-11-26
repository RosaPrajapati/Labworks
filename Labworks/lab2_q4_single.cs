using System;

class A
{
    public int a = 10, b = 5;
}

class B : A
{
    public void test()
    {
        Console.WriteLine("value of a is: " + a);
        Console.WriteLine("value of b is: " + b);
    }
}
class Inherit
{ 
   /* static void Main(string[] args)
    {
       B obj=new B();
        obj.test();
        Console.ReadKey();
    }*/
}
