using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Problem5Calculate11X2X2NXN
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());

            double result = 1.00;
            double sum = 1.00;
            double devided = 1.00;

            for (int i = 1; i <= n; i++)
            {

                result = result + (sum  * i) / (devided * n);
            }

            Console.WriteLine("{0}",result);
 
        }
    }
}
