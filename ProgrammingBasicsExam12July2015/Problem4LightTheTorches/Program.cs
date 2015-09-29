using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4LightTheTorches
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5; //int.Parse(Console.ReadLine()); //total number of rooms in the basement.
            string series = Console.ReadLine();

            char[] arr = series.ToCharArray();
  
            
            while (series != "END")
            {
                series = Console.ReadLine();
            }
            Console.WriteLine(series);

            

            int priest = (n + 1) / 2;


            
        }
    }
}
