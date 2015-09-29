using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = int.Parse(Console.ReadLine());
            int result = 0; 

            if (score >= 1 && score <= 3)
            {
                result = 10 * score;
                Console.WriteLine(result);
            }
            else if (score >= 4 && score <= 6)
            {
                result = 100 * score;
                Console.WriteLine(result);

            }
            else if (score >= 7 && score <= 9)
            {
                result = 1000 * score;
                Console.WriteLine(result);
            }
            else if (score <= 0 || score > 9)
            {

                Console.WriteLine("invalid score");    
            }
        }
    }
}
