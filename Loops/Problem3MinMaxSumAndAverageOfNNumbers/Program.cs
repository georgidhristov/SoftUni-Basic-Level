using System;
using System.Linq;

namespace Problem3MinMaxSumAndAverageOfNNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int min = array.Min();
            int max = array.Max();
            int sum = array.Sum();
            double avg = array.Average();

            Console.WriteLine("min = {0}", min);
            Console.WriteLine("max = {0}", max);
            Console.WriteLine("sum = {0}", sum);
            Console.WriteLine("avg = {0:0.00}", avg);
        }
    }
}
