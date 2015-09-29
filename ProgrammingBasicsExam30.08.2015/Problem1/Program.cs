using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = int.Parse(Console.ReadLine());
            double h = int.Parse(Console.ReadLine());
            double a = int.Parse(Console.ReadLine());
            string g = Console.ReadLine();
            double e = int.Parse(Console.ReadLine());

            double man = 66.5 + (13.75 * (w / 2.2)) + (5.003 * (h * 2.54)) - (6.755 * a);
            double woman = 655 + (9.563 * (w / 2.2)) + (1.850 * (h * 2.54)) - (4.676 * a);

            double result = 0;
            if (g == "m")
            {
                if (e <= 0)
                {
                    result = man * 1.2;
                    result = Math.Floor(result);
                    Console.WriteLine(result);
                }
                else if (e >= 1 && e <= 3)
                {
                    result = man * 1.375;
                    result = Math.Floor(result);
                    Console.WriteLine(result);
                }
                else if (e >= 3 && e <= 6)
                {
                    result = man * 1.55;
                    result = Math.Floor(result);
                    Console.WriteLine(result);
                }
                else if (e >= 6 && e <= 9)
                {
                    result = man * 1.725;
                    result = Math.Floor(result);
                    Console.WriteLine(result);
                }
                else if (e >= 10)
                {
                    result = man * 1.9;
                    result = Math.Floor(result);
                    Console.WriteLine(result);
                }
            }
            else if (g == "f")
            {
                if (e <= 0)
                {
                    result = woman * 1.2;
                    result = Math.Floor(result);
                    Console.WriteLine(result);
                }
                else if (e >= 1 && e <= 3)
                {
                    result = woman * 1.375;
                    result = Math.Floor(result);
                    Console.WriteLine(result);
                }
                else if (e >= 3 && e <= 6)
                {
                    result = woman * 1.55;
                    result = Math.Floor(result);
                    Console.WriteLine(result);
                }
                else if (e >= 6 && e <= 9)
                {
                    result = woman * 1.725;
                    result = Math.Floor(result);
                    Console.WriteLine(result);
                }
                else if (e >= 10)
                {
                    result = woman * 1.9;
                    result = Math.Floor(result);
                    Console.WriteLine(result);
                }
            }
        }
    }
}
