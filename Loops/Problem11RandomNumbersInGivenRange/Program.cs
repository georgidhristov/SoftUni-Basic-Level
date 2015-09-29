using System;

namespace Problem11RandomNumbersInGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());

            Random rand = new Random();

            for (int i = 1; i <= n; i++)
            {
                Console.Write(rand.Next(min, (max + 1)) + " ");     
            }

            Console.WriteLine();
        }
    }
}
