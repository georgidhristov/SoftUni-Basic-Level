using System;

namespace Problem3Eclipse
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //-----------TOP----------\\
            Console.Write(" ");
            for (int i = 1; i <= (n * 2) - 2; i++)
            {
                Console.Write("*");
            }
            for (int i = 1; i <= n + 1; i++)
            {
                Console.Write(" ");
            }
            for (int i = 1; i <= (n * 2) - 2; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine(" ");

            //-----------MIDDLE-----------\\
            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write("*");
                for (int j = 1; j <= (n * 2) - 2; j++)
                {
                    Console.Write("/");
                }
                Console.Write("*");
                for (int j = 1; j <= n - 1; j++)
                {
                    if (i == n / 2)
                    {
                        Console.Write("-");
                    }
                    else
                    {
                        Console.Write(" ");      
                    } 
                }
                Console.Write("*");
                for (int j = 1; j <= (n * 2) - 2; j++)
                {
                    Console.Write("/");
                }
                Console.Write("*");

                Console.WriteLine();
            }


            //-----------BOTTOM-----------\\
            Console.Write(" ");
            for (int i = 1; i <= (n * 2) - 2; i++)
            {
                Console.Write("*");
            }
            for (int i = 1; i <= n + 1; i++)
            {
                Console.Write(" ");
            }
            for (int i = 1; i <= (n * 2) - 2; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine(" ");
        }
    }
}
