using System;

namespace SumOf3Numbers
{
    class Problem1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three real numbers:");

            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double thirdNum = double.Parse(Console.ReadLine());

            Console.WriteLine("Sum = {0}", firstNum + secondNum + thirdNum);
        }
    }
}
