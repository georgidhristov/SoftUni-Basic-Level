﻿using System;

namespace EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first name of employee:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter last name of employee :");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter age of employee:");
            string age = Console.ReadLine();

            Console.WriteLine("Enter gender of employee");
            string gender = Console.ReadLine();

            Console.WriteLine("Enter personalIDNumber of employee:");
            long personalIDNumber = long.Parse(Console.ReadLine());
            int uniqueEmployeeNumber = 0;

            do
            {
                Console.WriteLine("Enter unique employee number within scope (27560000…27569999):");
                uniqueEmployeeNumber = int.Parse(Console.ReadLine());
            } while (uniqueEmployeeNumber < 27560000 || uniqueEmployeeNumber > 27569999);
            Console.WriteLine();
            Console.WriteLine("firstName:{0}", firstName);
            Console.WriteLine("lastName:{0}", lastName);
            Console.WriteLine("age:{0}", age);
            Console.WriteLine("gender:{0}", gender);
            Console.WriteLine("personalIDNumber:{0}", personalIDNumber);
            Console.WriteLine("uniqueEmployeeNumber:{0}", uniqueEmployeeNumber);
            Console.WriteLine();
        }
    }
}
