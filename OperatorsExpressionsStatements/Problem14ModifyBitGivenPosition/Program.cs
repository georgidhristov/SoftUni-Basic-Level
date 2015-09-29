using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem14ModifyBitGivenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number:");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Enter bit position:");
            int position = int.Parse(Console.ReadLine());
            Console.Write("Enter bit value:");
            int value = int.Parse(Console.ReadLine());

            Console.WriteLine(Convert.ToString(num, 2).PadLeft(16, '0'));

            if (value == 1)
            {
                int one = 1 << position;
                int foundOne = num | one;
                Console.WriteLine(Convert.ToString(foundOne, 2).PadLeft(16, '0'));
                Console.WriteLine(foundOne);
            }
            else
            {
                int zero = ~(1 << position);
                int foundZero = num & zero;
                Console.WriteLine(Convert.ToString(foundZero, 2).PadLeft(16, '0'));
                Console.WriteLine(foundZero);
            }
        }
    }
}
