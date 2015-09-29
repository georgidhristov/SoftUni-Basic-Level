using System;

namespace Problem14BitFlipper
{
    class Program
    {
        static void Main(string[] args)
        {
            //8773276988229695713 = 
            //0111100111000000111100001111000000011111100010100011100011100001 >>                                                  
            //0000100000111111000111100001111111000000011110111100011100011101 =
            //594226797558351645     

            ulong dec = ulong.Parse(Console.ReadLine());

            int loseBit = 62;

            while (loseBit > 0)
            {
                loseBit--;

                ulong threeBits = (dec >> loseBit) & 7;
                if (threeBits == 0 || threeBits == 7)
                {
                    dec = dec ^ ((ulong)7 << loseBit);
                    loseBit -= 2;
                }
            }

            Console.WriteLine(dec);
        }
    }
}
