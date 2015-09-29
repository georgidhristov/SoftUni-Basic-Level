using System;

namespace Problem3ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //----------------------TOP---------------------\\

            for (int i = 1; i <= n; i++)
            {

                if (i % 2 == 0)
                {
                    continue;
                }

                for (int j = 0; j <= n * 2 - i ; j++)
                {
                    Console.Write("'");
                    j++;
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("^");
                }

                for (int j = 0; j <= n * 2 - i; j++)
                {
                    Console.Write("'");
                    j++;
                }
                Console.WriteLine();
            }

            //-------------------MIDDLE---------------\\

            for (int i = 2; i <= n + 2; i++)
            {

                if (i % 2 == 0)
                {
                    continue;
                }

                for (int j = 0; j <= n * 2 - i; j++)
                {
                    Console.Write("'");
                    j++;
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("^");
                }

                for (int j = 0; j <= n * 2 - i; j++)
                {
                    Console.Write("'");
                    j++;
                }
                Console.WriteLine();
            }

            //---------------BOTTOM--------------\\

            for (int i = 1; i <= n / 2 + 1; i++)
            {
                for (int j = 1; j <= n - 1; j++)
                {
                    Console.Write("'");
                }

                Console.Write("| |");

                for (int j = 1; j <= n - 1; j++)
                {
                    Console.Write("'");
                }
                Console.WriteLine();
            }

            for (int i = 1; i <= n * 2 + 1; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();

        }
    }
}
