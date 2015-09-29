using System;

namespace Problem14DecimalToBinaryNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            long dec = long.Parse(Console.ReadLine());
            string bin = Convert.ToString(dec, 2);

            Console.WriteLine(bin);
        }
    }
}
