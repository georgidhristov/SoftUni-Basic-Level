using System;

namespace PrintLongSequence
{
    class PrintLongSequence
    {
        static void Main(string[] args)
        {
            int number ;

            for (int i = 2; i <= 1001; i++)
            {
                if (i % 2 == 0)
                {
                    number = i;
                }
                else
                {
                    number = i * (-1);
                }
                Console.Write(number + ",");
            }
        }
    }
}
