using System;

namespace Problem1BaiIvanAdventures
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            decimal money = decimal.Parse(Console.ReadLine());
            decimal liters = decimal.Parse(Console.ReadLine());

            decimal alcohol = 1;
            switch (n)
            {
                case 0: alcohol = money / 25M; break;
                case 1: alcohol = money / 21M; break;
                case 2: alcohol = money / 14M; break;
                case 3: alcohol = money / 17M; break;
                case 4: alcohol = money / 45M; break;
                case 5: alcohol = money / 59M; break;
                case 6: alcohol = money / 42M; break;
            }
    
            string status = "";

            if (alcohol > 1.5m)
            {
                status = "very drunk";
            }
            else if (alcohol >= 1.0m)
            {
                status = "drunk";
            }
            else
            {
                status = "sober";
            }

            if (liters < alcohol)
            {
                Console.WriteLine("Bai Ivan is {0} and very happy and he shared {1:F2} l. of alcohol with his friends",
                    status,
                    alcohol - liters);
            }
            else if (liters == alcohol)
            {
                Console.WriteLine("Bai Ivan is {0} and happy. He is as drunk as he wanted",
                    status);
            }
            else
            {
                Console.WriteLine("Bai Ivan is {0} and quite sad. He wanted to drink another {1:F2} l. of alcohol",
                    status,
                    liters - alcohol);
            }
        }
    }
}
