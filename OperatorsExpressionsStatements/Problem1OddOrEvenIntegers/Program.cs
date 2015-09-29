using System;

namespace Problem1OddOrEvenIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool odd = (n % 2) == 0;
            Console.WriteLine(!odd);
        }
    }
}
