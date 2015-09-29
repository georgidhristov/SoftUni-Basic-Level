using System;

namespace Problem4PrintADeckOf52Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            string j = "J", q = "Q", k = "K", a = "A";

            for (int i = 2; i <= 14; i++)
            {
                
                for (int loop = 1; loop <= 4; loop++)
                {
                    switch (i)
                    {
                        case 2: Console.Write(" {0}", i); break;
                        case 3: Console.Write(" {0}", i); break;
                        case 4: Console.Write(" {0}", i); break;
                        case 5: Console.Write(" {0}", i); break;
                        case 6: Console.Write(" {0}", i); break;
                        case 7: Console.Write(" {0}", i); break;
                        case 8: Console.Write(" {0}", i); break;
                        case 9: Console.Write(" {0}", i); break;
                        case 10: Console.Write("{0}", i); break;
                        case 11: Console.Write(" {0}", j); break;
                        case 12: Console.Write(" {0}", q); break;
                        case 13: Console.Write(" {0}", k); break;
                        case 14: Console.Write(" {0}", a); break;
                        default:
                            break;
                    }

                    if (loop == 1)
                    {
                        Console.Write("♣ ");
                    }
                    else if (loop == 2)
                    {
                        Console.Write("♦ ");
                    }
                    else if (loop == 3)
                    {
                        Console.Write("♥ ");
                    }
                    else if (loop == 4)
                    {
                        Console.Write("♠ ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
