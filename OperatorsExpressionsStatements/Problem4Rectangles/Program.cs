using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4Rectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter width: ");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("enter height: ");
            double height = double.Parse(Console.ReadLine());

            double area = width * height;
            double perimeter = 2 * (width + height);

            Console.WriteLine("perimeter: {0}; area: {1}", perimeter, area);
        }
    }
}
