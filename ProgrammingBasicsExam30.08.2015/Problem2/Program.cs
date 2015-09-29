using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            string input = "";

            List<string> list = new List<string>();
            int plus1 = 0;
            while (input != "End of the league.")
            {
                plus1++;
                input = Console.ReadLine();
                if (input != "End of the league.")
                {
                     list.Add(input);
                }
            }          
            double money = (n * (plus1-1)) * 1.94;
            Console.WriteLine("{0:0.00}lv.",money);

            List<string> winners = new List<string>();
            string myStr = "";
            for (int i = 0; i < list.Count; i++)
            {
                myStr = Regex.Match(list[i], @"\d+").Value;
                if (myStr == "")
                {
                    myStr = "3";
                }

                int myInt = 0;
                myInt = Convert.ToInt32(myStr);
                
                if (myInt == 1)
                {
                    string firstWord = list[i].Split(' ').FirstOrDefault();
                    winners.Add(firstWord + " - 3 points.");
                    string lastWord = list[i].Split(' ').LastOrDefault();
                    winners.Add(lastWord + " - 0 points.");
                }
                else if (myInt == 2)
                {
                    string lastWord = list[i].Split(' ').LastOrDefault();
                    winners.Add(lastWord + " - 3 points.");
                    string firstWord = list[i].Split(' ').FirstOrDefault();
                    winners.Add(firstWord + " - 0 points.");
                }
                else if (myInt == 3)
                {
                    string firstWord = list[i].Split(' ').FirstOrDefault();
                    winners.Add(firstWord + " - 1 points.");
                    string lastWord = list[i].Split(' ').LastOrDefault();
                    winners.Add(lastWord + " - 1 points.");
                }
            }


            winners.Sort();
            for (int i = 0; i < winners.Count; i++)
            {
                winners[i] = winners[i];

                string newValue = Regex.Replace(winners[i], "([a-z])([A-Z])", "$1 $2");
                Console.WriteLine(newValue);
            }

        }
    }
}
