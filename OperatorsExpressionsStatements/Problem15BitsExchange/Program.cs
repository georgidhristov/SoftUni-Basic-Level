using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem15BitsExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int p3 = 1 << 3;
            int result3 = n & p3;
            int p4 = 1 << 4;
            int result4 = n & p4;
            int p5 = 1 << 5;
            int result5 = n & p5;
      
            int p24 = 1 << 24;
            int result24 = n & p24;
            int p25 = 1 << 25;
            int result25 = n & p25;
            int p26 = 1 << 26;
            int result26 = n & p26;
            
            if (result3 == 0 )
            {
                n = n & (~(1 << 24));
            }
            else
            {
                n = n | (1 << 24);
            }
            if (result4 == 0)
            {
                n = n & (~(1 << 25));
            }
            else
            {
                n = n | (1 << 25);
            }
            if (result5 == 0)
            {
                n = n & (~(1 << 26));
            }
            else
            {
                n = n | (1 << 26);
            }
            if (result24 == 0)
            {
                n = n & (~(1 << 3));
            }
            else
            {
                n = n | (1 << 3);
            }
            if (result25 == 0)
            {
                n = n & (~(1 << 4));
            }
            else
            {
                n = n | (1 << 4);
            }
            if (result26 == 0)
            {
                n = n & (~(1 << 5));
            }
            else
            {
                n = n | (1 << 5);

            }

            Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
            Console.WriteLine(n);
            
        }
    }
}
