﻿using System;

namespace BitsInverter
{
    class BitsInverter
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numStep = int.Parse(Console.ReadLine());
            int[] Byte = new int[n];
            int result = 0;
            int countByte = 8;
            int m = 0;

            for (int i = 0; i < n; i++)
            {
                Byte[i] = int.Parse(Console.ReadLine());
            }

            for (int step = 1, k = 0, j = 0; step <= n * 8; step = 1 + k * numStep)
            {
                m = j;
                int nRightP = Byte[j] >> Math.Abs(step - countByte);
                int bit = nRightP & 1;

                if (bit == 1)
                {
                    int mask = ~(1 << Math.Abs(step - countByte));
                    result = Byte[j] & mask;
                    Byte[j] = result;
                }
                else if (bit == 0)
                {
                    int mask = 1 << Math.Abs(step - countByte);
                    result = Byte[j] | mask;
                    Byte[j] = result;
                }

                if (numStep < countByte && (step + numStep) <= countByte)
                {
                    k++;
                    j = m;
                    continue;
                }
                else
                {
                    Console.WriteLine(result);
                    result = 0;
                    k++;
                    j++;
                }

                if ((step + numStep) >= countByte && (numStep) <= 16)
                {
                    countByte += 8;
                }
                else
                {
                    if (j < n)
                    {
                        Console.WriteLine(result);
                    }
                    countByte += 16;
                    j++;
                }
            }
        }
    }
}
