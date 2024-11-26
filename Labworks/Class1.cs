using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Get the folder where the program is currently running
        string folderPath = Directory.GetCurrentDirectory();

        Console.WriteLine("Current folder path: " + folderPath);

        // Keep the console open
        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }
}
