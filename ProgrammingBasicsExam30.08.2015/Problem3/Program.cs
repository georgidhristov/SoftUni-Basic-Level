using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int h = (n / 2) + 1;

            for (int i = 0; i < n + h; i++)
            {
                if (i == 0)
                {
                    Console.Write("#");
                }
               
            }
            Console.WriteLine(h);
        }
    }
}
