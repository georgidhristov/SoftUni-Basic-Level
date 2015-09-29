using System;

namespace Problem2OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int even = 0;
            int odd = 0;
            int diff = 0;

            for (int i = 1; i <= n * 2; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    even = even + num;
                }
                else
                {
                    odd = odd + num;                   
                }
            }
            if (even == odd)
            {
                Console.WriteLine("Yes, sum={0}", even);
            }
            else if (even < odd)
            {
                diff = odd - even;
                Console.WriteLine("No, diff={0}", diff);
            }
            else if (odd < even)
            {
                diff = even - odd;
                Console.WriteLine("No, diff={0}", diff);
            }
        }
    }
}
