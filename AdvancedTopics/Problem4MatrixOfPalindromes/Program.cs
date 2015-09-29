using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem4MatrixOfPalindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console
                    .ReadLine()
                    .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(item => int.Parse(item))
                    .ToArray();


        }
    }
}
