using System;
using System.Linq;

namespace Problem8LongestWordInAText
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            string[] words = inputText.Split(' ');

            var sorted = words.OrderBy(n => n.Length);
            var longestWord = sorted.LastOrDefault();

            Console.WriteLine(longestWord);
        }
    }
}
