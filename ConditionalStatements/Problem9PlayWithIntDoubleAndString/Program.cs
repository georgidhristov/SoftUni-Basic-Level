using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9PlayWithIntDoubleAndString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> sring");
            Console.Write("Pleace choose a type: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": 
                    Console.Write("Please enter a int: "); 
                    int myInt = int.Parse(Console.ReadLine());
                    Console.WriteLine(myInt);
                    break;
                case "2": 
                    Console.Write("Please enter a double: ");
                    double myDouble = double.Parse(Console.ReadLine());
                    Console.WriteLine(myDouble);
                    break;
                case "3":
                    Console.Write("Please enter a string: ");
                    string myString = Console.ReadLine();
                    Console.WriteLine(myString);
                    break;
                default:
                    Console.WriteLine("Enter again!!!");
                    break;
            }
        }
    }
}
