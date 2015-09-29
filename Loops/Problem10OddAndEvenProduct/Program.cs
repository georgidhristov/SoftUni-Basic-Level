using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10OddAndEvenProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(item => int.Parse(item))
                .ToArray();

            int even = 1,
                odd  = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 != 0)
                {
                    even = even * numbers[i];
                }
                else if (i % 2 == 0)
                {
                    odd = odd * numbers[i];                   
                }
            }
            if (even == odd)
            {
                Console.WriteLine("yes");
                Console.WriteLine("product = {0}", even);
            }
            else
            {
                Console.WriteLine("no");
                Console.WriteLine("odd_product = {0}", odd);
                Console.WriteLine("even_product = {0}", even);
            }
        }
    }
}
