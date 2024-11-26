using System;

namespace GenericDemo
{
    // Generic class with a type parameter T
    class GenericClass<T>
    {
        private T data;

        // Constructor to initialize the data
        public GenericClass(T value)
        {
            data = value;
        }

        // Generic method to display the value of data
        public void DisplayData()
        {
            Console.WriteLine("Data: " + data);
        }

        // Generic method to compare two values of the same type
        public bool Compare(T otherValue)
        {
            return data.Equals(otherValue);
        }
    }

    class Program
    {
        /*static void Main(string[] args)
        {
            // Creating a generic class instance with int
            GenericClass<int> intObj = new GenericClass<int>(5);
            intObj.DisplayData();  // Output: Data: 5
            Console.WriteLine("Compare with 5: " + intObj.Compare(5)); // Output: True

            // Creating a generic class instance with string
            GenericClass<string> stringObj = new GenericClass<string>("Hello");
            stringObj.DisplayData();  // Output: Data: Hello
            Console.WriteLine("Compare with 'Hello': " + stringObj.Compare("Hello")); // Output: True
            Console.WriteLine("Compare with 'World': " + stringObj.Compare("World")); // Output: False

            Console.ReadLine();
        }*/
    }
}
