using System;
using System.Globalization;
using System.Threading;

namespace Problem1Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-GB");

            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double premiere = 12.00;
            double normal = 7.50;
            double discount = 5.00;

            if (type == "Premiere")
            {
                double premiereResult = (rows * columns) * premiere;
                Console.WriteLine("{0:0.00} leva", premiereResult);
            }
            else if (type == "Normal")
            {
                double normalResult = (rows * columns) * normal;
                Console.WriteLine("{0:0.00} leva", normalResult);
            }
            else if (type == "Discount")
            {
                double discountResult = (rows * columns) * discount;
                Console.WriteLine("{0:0.00} leva", discountResult);
            }
        }
    }
}
