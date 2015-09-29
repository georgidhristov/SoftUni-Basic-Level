using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2AniIsDrunk
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCabins = int.Parse(Console.ReadLine());
            string endOfInput = Console.ReadLine();
            int stepsCount = 0;

            List<int> myList = new List<int>();
            while (endOfInput != "Found a free one!")
            {
                stepsCount = int.Parse(endOfInput);

                myList.Add(stepsCount);

                endOfInput = Console.ReadLine();
            }

            int result = 0;
            int sumOfAll = 0;
            for (int i = 0; i < myList.Count; i++)
            {
                result = myList[i];

                if (result < numberOfCabins)
                {
                    for (int j = result; j < numberOfCabins; j++)
                    {      
                        result = result + 1;
                        
                    }
                    result = result - myList[i];

                    Console.WriteLine("Go {0} steps to the left, Ani.", result);
                }
                else if (result > numberOfCabins)
                {
                    for (int j = result; j > numberOfCabins; j--)
                    {
                        result = result - 1;
                        
                    }
                    result = result - myList[i];

                    if (result < 0)
                    {
                        result = result * (-1);
                    }

                    Console.WriteLine("Go {0} steps to the right, Ani.", result);
                }

                sumOfAll = sumOfAll + result;
            }
            Console.WriteLine("Moved a total of {0} steps.",sumOfAll);
        }
    }
}
