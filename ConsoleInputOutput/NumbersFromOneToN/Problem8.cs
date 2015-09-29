using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersFromOneToN
{
    class Problem8
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("  Sum: ");
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("   {0}", i);
            }
        }
    }
}
