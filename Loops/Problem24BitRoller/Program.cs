using System;

namespace Problem24BitRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            const int size = 19;

            int n = int.Parse(Console.ReadLine());
            int f = int.Parse(Console.ReadLine());
            int r = int.Parse(Console.ReadLine());

            char[] bits = Convert.ToString(n, 2).PadLeft(size, '0').ToCharArray();

            f = size - 1 - f;

            for (int i = 0; i < r; i++)
            {
                RollBitsRight(bits, f);
            }

            int result = Convert.ToInt32(new string(bits), 2);
            Console.WriteLine(result);
        }

        private static void RollBitsRight(char[] bits, int possition)
        {
            char[] newBits = new char[bits.Length];
            for (int i = 0; i < bits.Length; i++)
            {
                if (i == possition)
                {
                    newBits[i] = bits[i];
                }
                else
                {
                    int newPossition = (i + 1) % bits.Length;
                    if (newPossition == possition)
                    {
                        newPossition = (newPossition + 1) % bits.Length;
                    }
                    newBits[newPossition] = bits[i];
                }
            }

            for (int i = 0; i < bits.Length; i++)
            {
                bits[i] = newBits[i];
            }
        }
    }
}
