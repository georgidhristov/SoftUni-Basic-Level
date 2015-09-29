using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6FourDigitNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int a = n % 10;
            int b = (n / 10) % 10;
            int c = ((n / 10) / 10) % 10;
            int d = (((n / 10)/ 10) / 10) % 10;

            int sumOfDigits = a + b + c + d;
            string reversed = "" + a + b + c + d;
            string lastDigitInFront = "" + a + d + c + b;
            string secondAndThirdDigitsExchanged = "" + d + b + c + a;

            Console.WriteLine(sumOfDigits);
            Console.WriteLine(reversed);
            Console.WriteLine(lastDigitInFront);
            Console.WriteLine(secondAndThirdDigitsExchanged);
        }
    }
}
\