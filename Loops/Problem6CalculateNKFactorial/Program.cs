using System;

namespace Problem6CalculateNKFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            double factN = 1;
            double factK = 1;
            double result = 0;

            if (n < 100 && k > 1 && n > k)
            {
                for (int i = 1; i <= n; i++)
                {
                    factN = factN * i;

                    if (i <= k)
                    {
                        factK = factK * i;
                    }
                }

                result = factN / factK;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
