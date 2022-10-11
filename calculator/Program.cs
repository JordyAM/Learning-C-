// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloWorld
{
    class Calc
    {
        static double Add (double x, double y)
        {
            return x + y;
        }
        static double Subtract(double x, double y)
        {
            return x - y;
        }
        static double Multiply(double x, double y)
        {
            return x * y;
        }
        static double Divide(double x, double y)
        {
            return x / y;
        }
        static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter another number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine(Divide(num1,num2));
    }
    }
}