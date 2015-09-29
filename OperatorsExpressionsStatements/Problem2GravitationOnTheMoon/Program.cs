using System;

namespace Problem2GravitationOnTheMoon
{
    class Program
    {
        static void Main(string[] args)
        {
            double weightOnEarth = double.Parse(Console.ReadLine());

            double weightOnMoon = weightOnEarth * 0.17;

            Console.WriteLine(weightOnMoon);
        }
    }
}
