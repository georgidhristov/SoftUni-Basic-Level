using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOf5Numbers
{
    class Problem7
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 5 number in a separate line: view(1 2 3 4 5): ");

            string[] numbers = Console.ReadLine().Split();
            double numOne = double.Parse(numbers[0]);
            double numTwo = double.Parse(numbers[1]);
            double numTree = double.Parse(numbers[2]);
            double numFour = double.Parse(numbers[3]);
            double numFive = double.Parse(numbers[4]);

            double result = numOne + numTwo + numTree + numFour + numFive;

            Console.WriteLine("Result: {0}", result);
        }
    }
}
