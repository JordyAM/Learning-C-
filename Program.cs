// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
    {
        // string message = "Hello World!!";
        // float temp = 89.7; 
        // double gpa = 3.3;
        // decimal usd = 3.50 ; // from least accurate to most accurate for decimal ints
        string phrase = "Giraffe Academy";
        Console.WriteLine(phrase.Substring(8, 3));
        // Console.WriteLine("Who are You?"); 
        // var name = Console.ReadLine(); 
        // var currentDate = DateTime.Now;
        // Console.WriteLine($"\nHello, {name}, on {currentDate:d} at {currentDate:t}!");
        // Console.Write($"\nPress any key to exit...");
        // Console.ReadKey(true);
    }
    }
}