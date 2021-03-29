using System;
using System.Linq;

namespace Calculator_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true) 
            {
                Console.WriteLine("Write your math expression like example(5+5) and press enter");
                Console.WriteLine(Calculator.Calculate(Console.ReadLine()));
            }
        }
    }
}
