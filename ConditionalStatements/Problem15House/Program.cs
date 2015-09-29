using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem15House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < (n + 1) / 2; i++)
            {
                for (int j = 1; j <= (n + 1) / 2 - i; j++)
                {
                    Console.Write(".");
                }



                Console.Write("*");



                for (int j = 1; j <= i - 1; j++)
                {
                    Console.Write(".");
                }
                for (int j = 3; j <= i; j++)
                {
                    if (i >= 2)
                    {
                        Console.Write(".");
                    }
                }
                


                if (i >= 2)
                {
                    Console.Write("*");
                }



                for (int j = 1; j <= (n + 1) / 2 - i; j++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= n; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();

            //----------------------------------------------------

            if (n == 5)
            {
                for (int i = 1; i <= (n - 2) / 2; i++)
                {
                    for (int j = 1; j <= n / 4; j++)
                    {
                        Console.Write(".");
                    }
                    Console.Write("*");

                    for (int j = 1; j <= n / 4; j++)
                    {
                        Console.Write(".");
                    }
                    Console.Write("*");

                    for (int j = 1; j <= n / 4; j++)
                    {
                        Console.Write(".");
                    }
                    Console.WriteLine();
                }

                for (int i = 1; i <= n / 4; i++)
                {
                    Console.Write(".");
                }
                for (int i = 1; i <= (n + 7) / 4; i++)
			    {
			        Console.Write("*");
			    }
                for (int i = 1; i <= n / 4; i++)
                {
                    Console.Write(".");
                }

            }
            else if (n == 7 || n == 9)
            {
                for (int i = 1; i <= (n - 2) / 2; i++)
                {
                    for (int j = 1; j <= n / 4; j++)
                    {
                        Console.Write(".");
                    }
                    Console.Write("*");

                    for (int j = 1; j <= (n  + 5) / 4; j++)
                    {
                        Console.Write(".");
                    }
                    Console.Write("*");

                    for (int j = 1; j <= n / 4; j++)
                    {
                        Console.Write(".");
                    }
                    Console.WriteLine();
                }

                for (int i = 1; i <= n / 4; i++)
                {
                    Console.Write(".");
                }
                for (int i = 1; i <= (n + 13) / 4; i++)
			    {
			        Console.Write("*");
			    }
                for (int i = 1; i <= n / 4; i++)
                {
                    Console.Write(".");
                }
            }
            else if (n > 9)
            {
                for (int i = 1; i <= (n - 2) / 2; i++)
                {
                    for (int j = 1; j <= n / 4; j++)
                    {
                        Console.Write(".");
                    }
                    Console.Write("*");

                    int n2 = n + 1;
                    for (int j = 1; j <= (n + n2) / 4; j++)
                    {
                        Console.Write(".");
                    }
                    Console.Write("*");

                    for (int j = 1; j <= n / 4; j++)
                    {
                        Console.Write(".");
                    }
                    Console.WriteLine();
                }

                for (int i = 1; i <= n / 4; i++)
                {
                    Console.Write(".");
                }
                int n3 = n + 7;
                for (int i = 1; i <= (n + n3) / 4; i++)
                {
                    Console.Write("*");
                }
                for (int i = 1; i <= n / 4; i++)
                {
                    Console.Write(".");
                }
            }
        }
    }
}
