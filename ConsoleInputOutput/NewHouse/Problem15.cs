using System;

namespace NewHouse
{
    class Problem15
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string floor = "|";
            string roof = "*";
            string space = "-";

            for (int i = 1; i <= n; i++)
            {
                if ((i % 2) == 0)
                {
                    continue;
                }
                for (int j = 1; j < n - i; j++)
                {
                    Console.Write(space);
                    j++;
                }

                for (int k = 1; k <= i; k++)
                {                  
                    Console.Write("{0}", roof);
                }
                for (int j = 1; j < n - i; j++)
                {
                    Console.Write(space);
                    j++;
                }
                Console.WriteLine();
            }

            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0}", floor);
                for (int j = 1; j <= n - 2; j++)
                {
                    Console.Write("{0}", roof);
                }
                Console.WriteLine("{0}", floor);
            }
        }
    }
}
