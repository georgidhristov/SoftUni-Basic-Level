using System;

namespace WorkHours
{
    class Problem13
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());

            decimal workDays = days * 0.90m;
            int workHoursPerDay = 12;
            decimal workHours = Math.Floor(workDays * workHoursPerDay * percent / 100.0m);

            if (hours <= workHours)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            Console.WriteLine(workHours - hours);
        }
    }
}
