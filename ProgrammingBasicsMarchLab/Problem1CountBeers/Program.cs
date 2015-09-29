using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1CountBeers
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            while (true) // Loop indefinitely
            {
                string line = Console.ReadLine(); // Get string from user
                if (line == "exit") // Check string
                {
                    break;
                }
                Console.Write("You typed "); // Report output
                Console.Write(line.Length);
                Console.WriteLine(" character(s)");
            }
        }
    }
}
