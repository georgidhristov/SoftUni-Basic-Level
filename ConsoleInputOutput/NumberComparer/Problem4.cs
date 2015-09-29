using System;

namespace NumberComparer
{
    class Problem4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double firstNum = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double secondNum = double.Parse(Console.ReadLine());

            double greater = (firstNum > secondNum) ? firstNum : secondNum;

            Console.WriteLine("Greater = {0}",greater);
        }
    }
}
