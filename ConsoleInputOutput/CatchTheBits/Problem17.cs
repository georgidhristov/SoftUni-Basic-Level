using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchTheBits
{
    class Problem17
    {  
        static void Main(string[] args)
        {
            Console.Write("Enter (n): ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter (step): ");
            int step = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            string binary;
            string allBinary;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter number: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int index = 0; index < array.Length; index++)
            {
                binary = Convert.ToString(array[index], 2);
                allBinary = binary.PadLeft(8, '0');

                for (int i = 1; i <= allBinary.Length; i = i + step)
                {
                    allBinary = Convert.ToString(allBinary[i]);
                    Console.Write(allBinary.PadRight(8, '0'));

                }
            }
            Console.WriteLine();
        }
    }
}
