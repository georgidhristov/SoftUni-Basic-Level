using System;

namespace PrintCompanyInformation
{
    class Problem2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter company name: ");
            string companyName = Console.ReadLine();
            Console.Write("Enter company address: ");
            string companyAddress = Console.ReadLine();
            Console.Write("Enter company number: ");
            string companyNumber = Console.ReadLine();
            Console.Write("Enter fax number: ");
            string faxNumber = Console.ReadLine();
            Console.Write("Enter web site: ");
            string webSite = Console.ReadLine();
            Console.Write("Enter manager first name: ");
            string managerFirstName = Console.ReadLine();
            Console.Write("Enter manager last name: ");
            string managerLastName = Console.ReadLine();
            Console.Write("Enter manager age: ");
            int managerAge = Int32.Parse(Console.ReadLine());
            Console.Write("Enter manager phone: ");
            string managerPhone = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Company Name: {0}", companyName);
            Console.WriteLine("Company Address: {0}", companyAddress);
            Console.WriteLine("Company Number: {0}", companyNumber);
            Console.WriteLine("Fax Number: {0}", faxNumber);
            Console.WriteLine("Web Site: {0}", webSite);
            Console.WriteLine("Manager First Name: {0}", managerFirstName);
            Console.WriteLine("Manager Last Name: {0}", managerLastName);
            Console.WriteLine("Manager age: {0}", managerAge);
            Console.WriteLine("Manager Phone: {0}", managerPhone);
        }
    }
}
