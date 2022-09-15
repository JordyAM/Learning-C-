// See https://aka.ms/new-console-template for more information
using System;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
    {
        // string message = "Hello World!!";

        Console.WriteLine("Who are You?"); 
        var name = Console.ReadLine(); 
        var currentDate = DateTime.Now;
        Console.WriteLine($"\nHello, {name}, on {currentDate:d} at {currentDate:t}!");
        Console.Write($"\nPress any key to exit...");
        Console.ReadKey(true);
    }
    }
}