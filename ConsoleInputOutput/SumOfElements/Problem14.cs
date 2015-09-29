using System;
using System.Linq;

namespace SumOfElements
{
    class Problem14
    {
        static void Main(string[] args)
        {
            long[] n = Console
                .ReadLine()
                .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(item => long.Parse(item))
                .ToArray();

            long maxValue = n.Max();
            long result = 0;
            long diff = 0;

            for (int i = 0; i < n.Length; i++)
            {
                result = result + n[i];
            }

            result = result - maxValue;
            diff = maxValue - result;

            if (result == maxValue)
            {
                Console.WriteLine("Yes, sum={0}",result);
            }
            else
            {  
                if (diff < 0)
                {
                    diff = diff * (-1);
                }

                Console.WriteLine("No, diff={0}", diff);
            }
        }
    }
}
