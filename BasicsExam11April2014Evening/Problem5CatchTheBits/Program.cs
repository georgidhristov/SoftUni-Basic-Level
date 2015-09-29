using System;

namespace Problem5CatchTheBits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
            int nNumbers = 0;

            int mask = 0;
            int result = 0;
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                nNumbers = int.Parse(Console.ReadLine());

                for (int j = 7; j >= 0; j--)
                {
                    if (mask % step == 1 || (step == 1 && mask > 0))
                    {
                        int bitValue = (nNumbers >> j) & 1;

                        result = result << 1;
                        result = result | bitValue;
                        count++;
                        if (count == 8)
                        {
                            Console.WriteLine(result);
                            result = 0;
                            count = 0;
                        }
                    }
                    mask++;
                }
            }
            if (count > 0)
            {
                result = result << (8 - count);
                Console.WriteLine(result);
            }
        }
    }
}
