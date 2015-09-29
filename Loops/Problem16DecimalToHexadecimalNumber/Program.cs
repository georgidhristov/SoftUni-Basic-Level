using System;

namespace Problem16DecimalToHexadecimalNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            long dec = long.Parse(Console.ReadLine());
            string hex = Convert.ToString(dec, 16);

            Console.WriteLine(hex);
        }
    }
}
