using System;

namespace Problem19The_Explorer
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            n = n / 2 + 1 ;

            for (int i = 1; i < n ; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write("-");
                }
                for (int j = 1; j <= i; j++)
                {
                    if (j == 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                for (int k = 1; k <  i; k++)
                {
                    if (k == i - 1)
                    {
                        Console.Write("*");

                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
            }

            //---------------------------------------------------------

            for (int i = n ; i >= 1; i--)
            {
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write("-");
                }
                for (int j = 1; j <= i; j++)
                {
                    if (j == 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                for (int k = 1; k < i; k++)
                {
                    if (k == i - 1)
                    {
                        Console.Write("*");

                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
            }
        }
    }
}
