using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9Trapezoids
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a =");
            double a = double.Parse(Console.ReadLine());
            Console.Write("enter b =");
            double b = double.Parse(Console.ReadLine());
            Console.Write("enter h =");
            double h = double.Parse(Console.ReadLine());
 
            double area = ((a + b) / 2) * h;
 
            Console.WriteLine("Area is: " + area);
        }
    }
}
