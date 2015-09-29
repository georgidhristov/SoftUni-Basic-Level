using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7CalculateNKNK
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            double factN = 1;
            double factK = 1;
            double factorial = 1;
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
                for (int i = 1; i <= n - k; i++)
                {
                    factorial = factorial * i;
                }

                result = factN / (factK * factorial);
                Console.WriteLine("{0}", result);
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
