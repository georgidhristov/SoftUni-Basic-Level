using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem11BitwiseExtractBit3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number:");
            int num = int.Parse(Console.ReadLine());

            int fakeBit = 1 << 3;
            int bit = num & fakeBit;

            if (bit == 0)
            {
                Console.WriteLine("Third bit: '0' " + Convert.ToString(num, 2).PadLeft(16, '0'));
            }
            else
            {
                Console.WriteLine("Third bit: '1' " + Convert.ToString(num, 2).PadLeft(16, '0'));
            }
        }
    }
}
