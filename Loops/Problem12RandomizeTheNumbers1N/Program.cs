using System;

namespace Problem12RandomizeTheNumbers1N
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Random rand = new Random();
            
            for (int i = 1; i <= n; i++)
            {
                Console.Write(rand.Next(1, (n + 1)) + " ");
            }
            Console.WriteLine();
        }
    }
}
