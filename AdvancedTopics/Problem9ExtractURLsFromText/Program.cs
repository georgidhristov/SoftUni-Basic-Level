using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem9ExtractURLsFromText
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();

            foreach (var item in input)
            {
                if (item.Contains("http://") || item.Contains("www."))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
