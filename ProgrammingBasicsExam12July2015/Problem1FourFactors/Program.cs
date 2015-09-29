using System;

namespace Problem1FourFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            double FG = double.Parse(Console.ReadLine());
            double FGA = double.Parse(Console.ReadLine());
            double threeP = double.Parse(Console.ReadLine());
            double TOV = double.Parse(Console.ReadLine());
            double ORB = double.Parse(Console.ReadLine());
            double OppDRB = double.Parse(Console.ReadLine());
            double FT = double.Parse(Console.ReadLine());
            double FTA = double.Parse(Console.ReadLine());

            double resulteFG = (FG + 0.5 * threeP) / FGA;
            Console.WriteLine("eFG% {0:0.000}",resulteFG);
            double resultTOV = TOV / (FGA + 0.44 * FTA + TOV);
            Console.WriteLine("TOV% {0:0.000}", resultTOV);
            double resultORB = ORB / (ORB + OppDRB);
            Console.WriteLine("ORB% {0:0.000}", resultORB);
            double resultFT = FT / FGA;
            Console.WriteLine("FT% {0:0.000}", resultFT);
        }
    }
}


        }
    }
}
