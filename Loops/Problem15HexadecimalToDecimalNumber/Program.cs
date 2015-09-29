using System;

namespace Problem15HexadecimalToDecimalNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine();
            long dec = Convert.ToInt32(hex, 16);

            Console.WriteLine(dec);
        }
    }
}
