using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5ThirdDigitIs7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int newN = (n / 100) % 10;

            bool result = (newN == 7);
            Console.WriteLine(result);

        }
    }
}
