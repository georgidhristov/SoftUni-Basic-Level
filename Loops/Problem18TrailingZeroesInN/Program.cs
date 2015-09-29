using System;
using System.Linq;
using System.Numerics;


namespace Problem18TrailingZeroesInN
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = long.Parse(Console.ReadLine());
            BigInteger fac = 1;
            BigInteger zero = 0;

            for (int i = 1; i <= n; i++)
            {
                fac = fac * i;
            }
            

            BigInteger[] arr = Array.ConvertAll(fac.ToString().ToArray(), x => (BigInteger)x - 48);
            for (int i = arr.Length - 1; i >= 0 ; i--)
            { 
                if (arr[i] == 0)
                {
                    zero = zero + 1;
                }
                else
                {
                    break;
                }             
            }
            Console.WriteLine(zero);
        }
    }
}
