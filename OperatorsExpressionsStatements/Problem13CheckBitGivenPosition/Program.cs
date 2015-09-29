using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem13CheckBitGivenPosition
{
    class Program
    {
        static void Main(string[] args)
        {

        Console.Write("Enter number:");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Enter position:");
        int position = int.Parse(Console.ReadLine());
 
        int move = num >> position;
        int bit = move & 1;
 
        bool result = bit == 1;
 
        Console.WriteLine(Convert.ToString(num, 2).PadLeft(16, '0'));
        Console.WriteLine("Bit position {0} = {1}", position, result);
        }
    }
}
