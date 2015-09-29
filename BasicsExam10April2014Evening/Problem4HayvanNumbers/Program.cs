using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4HayvanNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            int diff = int.Parse(Console.ReadLine());

            int abc = 0,
                def = 0,
                ghi = 999 ;

            def = ghi - diff;
            abc = def - diff;
            Console.Write(abc);
            Console.Write(def);
            Console.WriteLine(ghi);
        }
    }
}
