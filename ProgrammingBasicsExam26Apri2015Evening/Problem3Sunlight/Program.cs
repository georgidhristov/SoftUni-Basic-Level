using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3Sunlight
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());  
            int z = (n + n) / 4;

            for (int i = 1; i <= n + z; i++)
            {
                Console.Write(".");
            }

            Console.Write("*");

            for (int i = 1; i <= n + z; i++)
            {
                Console.Write(".");
            }

            Console.WriteLine();

            //-----------------------------------------------------
            if (n > 3)
            {
                for (int i = 1; i < n; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(".");
                    }

                    Console.Write("*");

                    for (int j = 1; j <= (n - i) + z - 1; j++)
                    {
                        Console.Write(".");
                    }

                    Console.Write("*");

                    for (int j = 1; j <= (n - i) + z - 1; j++)
                    {
                        Console.Write(".");
                    }

                    Console.Write("*");

                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(".");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(".");
                    }

                    Console.Write("*");

                    for (int j = 1; j <= (n - i) + z - 1; j++)
                    {
                        Console.Write(".");
                    }

                    Console.Write("*");

                    for (int j = 1; j <= (n - i) + z - 1; j++)
                    {
                        Console.Write(".");
                    }

                    Console.Write("*");

                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(".");
                    }
                    Console.WriteLine();
                }
            }
            //--------------------------------------------------
            
            if (n > 3)
            {
                for (int i = 1; i <= z; i++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        Console.Write(".");
                    }
                    for (int j = 1; j <= n; j++)
                    {
                        Console.Write("*");
                    }
                    for (int j = 1; j <= n; j++)
                    {
                        Console.Write(".");
                    }
                    Console.WriteLine();
                }
            }

            //----------------------------------------------------------------
            
            for (int i = 1; i <= n * 3; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            //----------------------------------------------------------------

            if (n > 3)
            {
                for (int i = 1; i <= z; i++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        Console.Write(".");
                    }
                    for (int j = 1; j <= n; j++)
                    {
                        Console.Write("*");
                    }
                    for (int j = 1; j <= n; j++)
                    {
                        Console.Write(".");
                    }
                    Console.WriteLine();
                }
            }

            //-----------------------------------------------------

            if (n > 3)
            {
                for (int i = 2; i <= n; i++)
                {
                    for (int j = 0; j <= n - i; j++)
                    {
                        Console.Write(".");
                    }

                    Console.Write("*");

                    for (int j = 1; j < z + i - 1; j++)
                    {
                        Console.Write(".");
                    }

                    Console.Write("*");

                    for (int j = 1; j < z + i - 1; j++)
                    {
                        Console.Write(".");
                    }

                    Console.Write("*");

                    for (int j = 0; j <= n - i; j++)
                    {
                        Console.Write(".");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 0; j <= n - i; j++)
                    {
                        Console.Write(".");
                    }

                    Console.Write("*");

                    for (int j = 1; j <= i - 1; j++)
                    {
                        Console.Write(".");
                    }

                    Console.Write("*");

                    for (int j = 1; j <= i - 1; j++)
                    {
                        Console.Write(".");
                    }

                    Console.Write("*");

                    for (int j = 0; j <= n - i; j++)
                    {
                        Console.Write(".");
                    }
                    Console.WriteLine();
                }
            }
                //----------------------------------------------------------

                for (int i = 1; i <= n + z; i++)
                {
                    Console.Write(".");
                }

                Console.Write("*");

                for (int i = 1; i <= n + z; i++)
                {
                    Console.Write(".");
                }

                Console.WriteLine();
        }
    }
}
