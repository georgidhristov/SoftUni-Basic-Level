using System;
using System.Linq;

namespace Problem7JoinLists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstLine = Console
                .ReadLine().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(item => int.Parse(item))
                .ToArray();

            int[] secondLine = Console
                .ReadLine().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(item => int.Parse(item))
                .ToArray();

            int[] combined = firstLine.Concat(secondLine).Distinct().ToArray();
            Array.Sort(combined);

            for (int i = 0; i < combined.Length; i++)
            {
                Console.Write(combined[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
