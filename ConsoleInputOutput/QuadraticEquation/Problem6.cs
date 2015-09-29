using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class Problem6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a, b and c : ");

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d, x1, x2, x1x2 = 0;      // d = discriminant

            d = (b * b) - (4 * a * c);  //discriminant formula

            if (d > 0)
            {
                x2 = ((-b) + Math.Sqrt(d)) / (2 * a);
                x1 = ((-b) - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("x1= {0} ; x2 = {1}", x1, x2);
            }
            else if (d == 0)
            {
                x1x2 = ((-b) + Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("x1 = x2 = {0}", x1x2);
            }
            else if (d < 0)
            {
                Console.WriteLine("No real roots");
            }

        }
    }
}
