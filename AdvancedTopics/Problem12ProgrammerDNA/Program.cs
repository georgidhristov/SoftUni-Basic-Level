using System;

namespace Problem12ProgrammerDNA
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char startingLetter = char.Parse(Console.ReadLine());


                for (int i = 1; i <= 7; i++)
                {
                    for (int j = 1; j <= 4 - i; j++)
                    {
                        Console.Write(".");
                    }

                    if (i <= 3)
                    {
                        for (int j = 0; j >= 2 - i - i; j--)
                        {
                            Console.Write(startingLetter);

                            if (startingLetter == 'G')
                            {
                                startingLetter = 'A';
                            }
                            else
                            {
                                startingLetter++;
                            }
                        }
                    }

                    for (int j = 1; j <= 4 - i; j++)
                    {
                        Console.Write(".");
                    }

                    if (i == 4)
                    {
                        for (int j = 1; i <= 10; i++)
                        {
                            Console.Write(startingLetter);
                            startingLetter++;
                        }
                    }

                    Console.WriteLine();
                }

                for (int i = 1; i <= 3; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(".");
                    }

                    for (int j = 1; j <= 7 - i - i; j++)
                    {
                        Console.Write(startingLetter);
                        startingLetter++;
                    }

                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(".");
                    }
                    Console.WriteLine();
                }
        }
    }
}
