using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem12ZeroSubset
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());

            if (a + b + c + d + e  == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", a,b,c,d,e);
            }
            if (a + b + c + d == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, d);
            }
            if (a + b + c + d == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, d );
            }
            if (b + c + d + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", b, c, d, e);
            }
            if (c + d + e + a == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", c, d, e, a);
            }
            if (d + e + a + b == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", d, e, a, b);
            }
            if (e + d + a + b == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", e, a ,b ,c);
            }
            if (a + b + c == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", a, b, c);
            }
            if (b + c + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2}  = 0", b, c, e);              
            }
            if (b + d + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2}  = 0", b, d, e);
            }
            if (a + c + d == 0)
            {
                Console.WriteLine("{0} + {1} + {2}  = 0", a, c, d);
            }
            if (a + c + e == 0 )
            {
                Console.WriteLine("{0} + {1} + {2}  = 0", a, c, e);
            }
            if (a + b + d == 0)
            {
                Console.WriteLine("{0} + {1} + {2}  = 0", a, b, d);
            }
            if (b + c + d == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", b, c, d);
            }
            if (c + d + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", c, d, e);
            }
            if (d + e + a == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", c, e, a);
            }
            if (e + a + b == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", e, a, b);
            }
            if (a + b == 0)
            {
                Console.WriteLine("{0} + {1} = 0", a, b);
            }
            if (a + c == 0)
            {
                Console.WriteLine("{0} + {1} = 0", a, c);
            }
            if (a + d == 0)
            {
                Console.WriteLine("{0} + {1} = 0", a, d);
            }
            if (a + e == 0)
            {
                Console.WriteLine("{0} + {1} = 0", a, e);
            }
            if (b + c == 0)
            { 
                Console.WriteLine("{0} + {1} = 0", b, c);
            }
            if (b + d == 0)
            {
                Console.WriteLine("{0} + {1} = 0", b, d);
            }
            if (b + e == 0)
            {
                Console.WriteLine("{0} + {1} = 0", b, e);   
            }
            if (c + d == 0)
            {
                Console.WriteLine("{0} + {1} = 0", c, d);
            }
            if (c + e == 0)
            {
                Console.WriteLine("{0} + {1} = 0", c, e);
            }
            if (d + e == 0)
            {
                Console.WriteLine("{0} + {1} = 0", d, e);
            }
            else
            {
                Console.WriteLine("no zero subset");
            }
        }
    }
}
