using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Problem1CountBeers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            string measure = "";
            string count = "";

            int calcBeers = 0;
            int sumOfBeers = 0;

            int calcStacks = 0;
            int sumOfStacks = 0;

            List<string> list = new List<string>();

            while (input != "End")
            {
                input = Console.ReadLine();
                if (input != "End")
                {
                    list.Add(input);
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                measure = Regex.Replace(list[i], @"[\d- ]", string.Empty);

                if (measure == "beers")
                {
                    count = Regex.Replace(list[i], @"\D", "");
                    calcBeers = Convert.ToInt32(count);
                    sumOfBeers = sumOfBeers + calcBeers;
                }
                if (measure == "stacks")
                {
                    count = Regex.Replace(list[i], @"\D", "");
                    calcStacks = Convert.ToInt32(count);
                    sumOfStacks = sumOfStacks + calcStacks;
                }
                
            }

            if (sumOfBeers > 19)
            {
                int i = sumOfBeers / 20;
                sumOfStacks = sumOfStacks + i;
            }
            sumOfBeers = sumOfBeers % 20;


            Console.WriteLine("{0} stacks + {1} beers",sumOfStacks, sumOfBeers);
        }
    }
}
