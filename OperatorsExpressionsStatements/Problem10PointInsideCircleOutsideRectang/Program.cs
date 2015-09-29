using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10PointInsideCircleOutsideRectang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter x =");
            double x = double.Parse(Console.ReadLine());
            Console.Write("enter y =");
            double y = double.Parse(Console.ReadLine());

            bool circle = (x - 1) * (x - 1) + (y - 1) * (y - 1) <= (1.5 * 1.5);
            bool rectangle = x > 1 || x < 6 && y > -1 || y < 2;

            if (x == 0 || y == 0)
            {
                Console.WriteLine("no");
            }
            else if (circle == true && rectangle == true)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
