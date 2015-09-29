using System;

namespace Problem13BinaryToDecimalNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string bin = Console.ReadLine();
            char[] array = bin.ToCharArray();
            long dec = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[array.Length - i - 1] == '0')
                {
                    continue;
                } 

                dec = dec + (int)Math.Pow(2, i);
            }
            Console.WriteLine("{0}", dec);
        }
    }
}
