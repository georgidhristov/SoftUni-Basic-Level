using System;

namespace CirclePerimeterAndArea
{
    class Problem3
    {
        static void Main(string[] args)
        {
            Console.Write("Enter radius: ");
            double radius = double.Parse(Console.ReadLine());
            double pI = Math.PI;

            double area = pI * radius * radius;
            double perimeter = 2 * pI * radius;

            Console.WriteLine("Perimeter = {0:0.00}", perimeter);
            Console.WriteLine("Area = {0:0.00}", area);
        }
    }
}
