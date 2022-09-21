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
        static int Add (int x, int y)
        {
            return x + y;
        }
        static int Subtract(int x, int y)
        {
            return x - y;
        }
        static int Multiply(int x, int y)
        {
            return x * y;
        }
        static int Divide(int x, int y)
        {
            return x / y;
        }
        static void Main(string[] args)
    {
       Console.WriteLine(Divide(15,3));
    }
    }
}