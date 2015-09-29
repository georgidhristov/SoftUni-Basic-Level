using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10BeerTime
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Please enter time: ");
                string userTime = Console.ReadLine();
                DateTime time = Convert.ToDateTime(userTime);

                DateTime beerTime = DateTime.Parse("1:00 PM");
                DateTime nonBeerTime = DateTime.Parse("3:00 AM");


                if (time >= beerTime || time < nonBeerTime)
                {
                    Console.WriteLine("beer time");
                }
                else
                {
                    Console.WriteLine("non-beer time");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
