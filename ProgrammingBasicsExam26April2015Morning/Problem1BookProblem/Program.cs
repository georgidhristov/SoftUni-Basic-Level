using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1BookProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int bookPages = int.Parse(Console.ReadLine());
            int campingDays = int.Parse(Console.ReadLine());
            int pagesPerDay = int.Parse(Console.ReadLine());

            if ((campingDays == 30) || (pagesPerDay == 0))
            {
                Console.WriteLine("never");
            }
            else
            {
                int pages = 30 - campingDays;

                int months = pagesPerDay * pages;

                int monthsNeeded = (int)Math.Ceiling((double)bookPages / months);

                int remainingYears = monthsNeeded / 12;
                int remainingMonths = monthsNeeded % 12;

                Console.WriteLine("{0} years {1} months", remainingYears, remainingMonths);

            }
        }
    }
}
