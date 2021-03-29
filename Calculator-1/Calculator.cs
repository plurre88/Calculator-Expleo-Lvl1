using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator_1
{
    public static class Calculator
    {
        public static double Calculate(string problem)
        {
            if (problem.Contains("+"))
            {
                return Add(problem);
            }
            else if (problem.Contains("-"))
            {
                return Substract(problem);
            }
            else if (problem.Contains("/"))
            {
                return Divide(problem);
            }
            else if (problem.Contains("*"))
            {
                return Multiply(problem);
            }
            else
            {
                Console.WriteLine("Expression is wrong, try again");
                return 0;
            }
        }
        private static double Add(string problem)
        {
            double sum = 0;
            var numbers = Array.ConvertAll(problem.Split('+'), int.Parse).ToList();
            sum = numbers[0] + numbers[1];
            return sum;
        }
        private static double Substract(string problem)
        {
            double sum = 0;
            var numbers = Array.ConvertAll(problem.Split('-'), int.Parse).ToList();
            sum = numbers[0] - numbers[1];
            return sum;
        }
        private static double Divide(string problem)
        {
            double sum = 0;
            var numbers = Array.ConvertAll(problem.Split('/'), int.Parse).ToList();
            sum = numbers[0] / numbers[1];
            return sum;
        }
        private static double Multiply(string problem)
        {
            double sum = 0;
            var numbers = Array.ConvertAll(problem.Split('*'), int.Parse).ToList();
            sum = numbers[0] * numbers[1];
            return sum;
        }
    }
}
