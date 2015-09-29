using System;

namespace DifferenceBetweenDates
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstInput = Console.ReadLine();
            DateTime firstDate = Convert.ToDateTime(firstInput);

            string secondInput = Console.ReadLine();
            DateTime secondDate = Convert.ToDateTime(secondInput);

            TimeSpan t = secondDate - firstDate;
            double days = t.TotalDays;

            Console.WriteLine(days);
        }
    }
}
