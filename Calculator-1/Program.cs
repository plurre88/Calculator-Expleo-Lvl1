using System;
using System.Linq;

namespace Calculator_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var Problem1 = "5+4";
            var Problem2 = "25-5";
            var Problem3 = "99/3";
            var Problem4 = "10*10";

            Console.WriteLine(FindOperator(Problem1));
            Console.WriteLine(FindOperator(Problem2));
            Console.WriteLine(FindOperator(Problem3));
            Console.WriteLine(FindOperator(Problem4));

            Console.ReadKey();
        }
        public static double FindOperator(string problem)
        {
            if(problem.Contains("+"))
            {
                return Add(problem);
            }
            else if(problem.Contains("-"))
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
            return 0;
        }
        public static double Add(string problem)
        {
            double sum = 0;
            var numbers = Array.ConvertAll(problem.Split('+'), int.Parse).ToList();
            sum = numbers[0] + numbers[1];
            return sum;
        }
        public static double Substract(string problem)
        {
            double sum = 0;
            var numbers = Array.ConvertAll(problem.Split('-'), int.Parse).ToList();
            sum = numbers[0] - numbers[1];
            return sum;
        }
        public static double Divide(string problem)
        {
            double sum = 0;
            var numbers = Array.ConvertAll(problem.Split('/'), int.Parse).ToList();
            sum = numbers[0] / numbers[1];
            return sum;
        }
        public static double Multiply(string problem)
        {
            double sum = 0;
            var numbers = Array.ConvertAll(problem.Split('*'), int.Parse).ToList();
            sum = numbers[0] * numbers[1];
            return sum;
        }
    }
}
