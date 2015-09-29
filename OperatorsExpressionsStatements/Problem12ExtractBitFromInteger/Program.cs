using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem12ExtractBitFromInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            int mask = 1 << p;
            int result = n & mask;

            if (result == 0)
            {
                Console.WriteLine(false);
                Console.WriteLine(Convert.ToString(n,2).PadLeft(16, '0'));
            }
            else
            {
                Console.WriteLine(true);
                Console.WriteLine(Convert.ToString(n, 2).PadLeft(16, '0'));
            }
        }
    }
}
