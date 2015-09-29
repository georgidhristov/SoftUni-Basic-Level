using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem20BitsUp
{
    class Program
    {
        static void Main(string[] args)
        {                                            
            int n = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
            StringBuilder builder = StringBuilder;

            for (int i = 1; i <= n; i++)
            {
                int nNum = int.Parse(Console.ReadLine());
                Console.WriteLine(Convert.ToString(nNum, 2).PadLeft(8, '0'));

                for (int j = 7; j <= 0; j--)
                {
                    int mask = nNum << j;

                    if (mask == 1)
                    {
                        nNum = nNum | 1;
                    }
                    if (mask == 1 + step)
                    {
                        nNum = nNum | 1;
                    }
                    if (mask == 1 + 2 * step)
                    {
                        nNum = nNum | 1;
                    }
                }
                Console.WriteLine(Convert.ToString(nNum, 2).PadLeft(8, '0'));
            }
        }
    }
}
