using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8PrimeNumberCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter numbers: ");
            int num = int.Parse(Console.ReadLine());

            if (num == 1)
            {
                Console.WriteLine("This number is prime = (0)", false);
            }
            else
            {
                int count = 0;

                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        count++;
                    }
                }
                bool prime = true;
                if (count > 2)
                {
                    prime = false;
                }
                Console.WriteLine("{0}", prime);
            }
        }
    }
}
