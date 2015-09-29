using System;

namespace _01CompoundInterest
{
    class Program
    {
        static void Main(string[] args)
        {

            double p = double.Parse(Console.ReadLine());              // Цена на телевизора.
            int n = int.Parse(Console.ReadLine());                      // Брой години имате докато трябва да платите банката обратно.
            double i = double.Parse(Console.ReadLine());              // % лиьва за банката.
            double f = double.Parse(Console.ReadLine());              // % лихва за кредит на приятеля.

            double bank = p * Math.Pow((1 + i), n);

            double friend = p * (1 + f);


            if (bank < friend)
            {
                Console.WriteLine("{0:0.00} Bank", bank);
            }
            else
            {
                Console.WriteLine("{0:0.00} Friend", friend);
            }
        }
    }
}
