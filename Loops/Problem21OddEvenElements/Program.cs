using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem21OddEvenElements
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] arr = Console.ReadLine().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(item => decimal.Parse(item)).ToArray();

            List<decimal> oddElements = new List<decimal>();

            List<decimal> evenElements = new List<decimal>();

            for (int i = 0; i < arr.Length; i++)
            {

                if (i % 2 == 0)
                {
                    oddElements.Add(arr[i]);
                }
                else if (i % 2 != 0)
                {
                    evenElements.Add(arr[i]);
                }
            }

            decimal oddSum = 0;
            decimal oddMin = 0;
            decimal oddMax = 0;
            for (int i = 0; i < oddElements.Count; i++)
            {
                oddSum = oddSum + oddElements[i];
                oddMin = oddElements.Min();
                oddMax = oddElements.Max();
            }

            decimal evenSum = 0;
            decimal evenMin = 0;
            decimal evenMax = 0;
            for (int i = 0; i < evenElements.Count; i++)
            {
                evenSum = evenSum + evenElements[i];
                evenMin = evenElements.Min();
                evenMax = evenElements.Max();
            }

            if (arr.Length == 0)
            {
                Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
            }
            else if (arr.Length == 1)
            {
                Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum=No, EvenMin=No, EvenMax=No",
                (double)oddSum, (double)oddMin, (double)oddMax, (double)evenSum, (double)evenMin, (double)evenMax);
            }
            else
            {
                Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}",
                (double)oddSum, (double)oddMin, (double)oddMax, (double)evenSum, (double)evenMin, (double)evenMax);
            }
        }
    }
}
