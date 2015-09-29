using System;

namespace Problem3KingOfThieves
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string str = Console.ReadLine();

            for (int i = 1; i <= (n + 1) / 2 ; i++)
            {
                for (int j = 1; j <= (n + 1) / 2 - i; j++)
                {
                    Console.Write("-");
                }
                for (int k = 1; k  <= i; k ++)
                {
                    Console.Write(str);
                }

                for (int k = 1; k < i; k++)
                {
                    Console.Write(str);
                }
                for (int j = 0; j < (n + 1) / 2 - i; j++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
            }

            //---------------------------------------------------

            for (int i = (n - 1) / 2; i >= 1; i--)
            {
                for (int j = 0; j < (n + 1) / 2 - i; j++)
                {
                    Console.Write("-");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(str);
                }
                for (int k = 1; k < i; k++)
                {
                    Console.Write(str);
                }
                for (int j = 0; j < (n + 1) / 2 - i; j++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
            }
        }
    }
}
