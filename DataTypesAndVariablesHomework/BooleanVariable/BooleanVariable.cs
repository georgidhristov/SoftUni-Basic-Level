using System;

namespace BooleanVariable
{
    class BooleanVariable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is your gender female? Enter yes or no!");

            string gender = Console.ReadLine();
            bool isFemale = gender == "yes";

            Console.WriteLine("{0}", isFemale); 
        }
    }
}
