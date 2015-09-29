using System;

namespace Problem1Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string leap = Console.ReadLine();

            int p = int.Parse(Console.ReadLine()); //-NUMBERS-OF-HOLYDAYS-\\
            int h = int.Parse(Console.ReadLine()); //-WEEKENDS-IN-HOME-\\

            int yearW = 48;             //-WEEKENDS-IN-YEAR-\\
            int normalW = yearW - h;    //-NORMAL-WEEKENDS--\\

            double games = normalW *
                3.0 / 4.0 + h * 1.0 + p * 2.0 / 3.0;

            if (leap == "leap")
            {
                games = games * 1.15;
            }

            games = (int)games;
            Console.WriteLine(games);
        }
    }
}
