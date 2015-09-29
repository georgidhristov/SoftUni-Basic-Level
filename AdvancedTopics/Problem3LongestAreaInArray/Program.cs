using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3LongestAreaInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] userInput = new string[n];

            for (int i = 0; i < userInput.Length; i++)
            {
                userInput[i] = Console.ReadLine();
            }

            
            int count = 0;
            int count2 = 0;
            string result = "";

            for (int i = 1; i < n; i++)
            {
                if (userInput[i] == userInput[i - 1])
                {
                    count++;
                    if (count > count2)
                    {
                        count2 = count;
                        result = userInput[i];
                    }
                }
                else
                {
                    count = 1;
                }
            }
            Console.WriteLine(count2);

            for (int i = 0; i < count2; i++)
            {
                Console.WriteLine(result);   
            }
        }
    }
}
