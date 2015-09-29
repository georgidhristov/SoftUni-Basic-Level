using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem4DecryptTheMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            string start = Console.ReadLine();
            string end = "";
            int noMessage = 0;

            while (start != "start" && start != "START")
            {
                start = Console.ReadLine();
            }

            List<string> list = new List<string>();
            if (start == "START" || start == "start")
            {
                while (end != "end" && end != "END")
                {
                    end = Console.ReadLine();
                    if (end != "end" && end != "END" && end != "")
                    {
                        list.Add(end);
                        noMessage++;
                    }
                    else if (noMessage == 0 && end != "")
                    {
                        Console.WriteLine("No message received.");
                    }
                }
            }

            string result = "";
            for (int count = 0; count < list.Count; count++)
            {
                result = list[count];


                string final = "";
                for (int i = 0; i < result.Length; i++)
                {
                    if (result[i] == 'A')
                        final = final + "N";
                    else if (result[i] == 'B')
                        final = final + "O";
                    else if (result[i] == 'C')
                        final = final + "P";
                    else if (result[i] == 'D')
                        final = final + "Q";
                    else if (result[i] == 'E')
                        final = final + "R";
                    else if (result[i] == 'F')
                        final = final + "S";
                    else if (result[i] == 'G')
                        final = final + "T";
                    else if (result[i] == 'H')
                        final = final + "U";
                    else if (result[i] == 'I')
                        final = final + "V";
                    else if (result[i] == 'J')
                        final = final + "W";
                    else if (result[i] == 'K')
                        final = final + "X";
                    else if (result[i] == 'L')
                        final = final + "Y";
                    else if (result[i] == 'M')
                        final = final + "Z";

                    else if (result[i] == 'N')
                        final = final + "A";
                    else if (result[i] == 'O')
                        final = final + "B";
                    else if (result[i] == 'P')
                        final = final + "C";
                    else if (result[i] == 'Q')
                        final = final + "D";
                    else if (result[i] == 'R')
                        final = final + "E";
                    else if (result[i] == 'S')
                        final = final + "F";
                    else if (result[i] == 'T')
                        final = final + "G";
                    else if (result[i] == 'U')
                        final = final + "H";
                    else if (result[i] == 'V')
                        final = final + "I";
                    else if (result[i] == 'W')
                        final = final + "J";
                    else if (result[i] == 'X')
                        final = final + "K";
                    else if (result[i] == 'Y')
                        final = final + "L";
                    else if (result[i] == 'Z')
                        final = final + "M";

                    else if (result[i] == 'a')
                        final = final + "n";
                    else if (result[i] == 'b')
                        final = final + "o";
                    else if (result[i] == 'c')
                        final = final + "p";
                    else if (result[i] == 'd')
                        final = final + "q";
                    else if (result[i] == 'e')
                        final = final + "r";
                    else if (result[i] == 'f')
                        final = final + "s";
                    else if (result[i] == 'g')
                        final = final + "t";
                    else if (result[i] == 'h')
                        final = final + "u";
                    else if (result[i] == 'i')
                        final = final + "v";
                    else if (result[i] == 'j')
                        final = final + "w";
                    else if (result[i] == 'k')
                        final = final + "x";
                    else if (result[i] == 'l')
                        final = final + "y";
                    else if (result[i] == 'm')
                        final = final + "z";

                    else if (result[i] == 'n')
                        final = final + "a";
                    else if (result[i] == 'o')
                        final = final + "b";
                    else if (result[i] == 'p')
                        final = final + "c";
                    else if (result[i] == 'q')
                        final = final + "d";
                    else if (result[i] == 'r')
                        final = final + "e";
                    else if (result[i] == 's')
                        final = final + "f";
                    else if (result[i] == 't')
                        final = final + "g";
                    else if (result[i] == 'u')
                        final = final + "h";
                    else if (result[i] == 'v')
                        final = final + "i";
                    else if (result[i] == 'w')
                        final = final + "j";
                    else if (result[i] == 'x')
                        final = final + "k";
                    else if (result[i] == 'y')
                        final = final + "l";
                    else if (result[i] == 'z')
                        final = final + "m";

                    else if (result[i] == '+')
                        final = final + " ";
                    else if (result[i] == '%')
                        final = final + ",";
                    else if (result[i] == '&')
                        final = final + ".";
                    else if (result[i] == '#')
                        final = final + "?";
                    else if (result[i] == '$')
                        final = final + "!";

                    else if (result[i] == '0')
                        final = final + "0";
                    else if (result[i] == '1')
                        final = final + "1";
                    else if (result[i] == '2')
                        final = final + "2";
                    else if (result[i] == '3')
                        final = final + "3";
                    else if (result[i] == '4')
                        final = final + "4";
                    else if (result[i] == '5')
                        final = final + "5";
                    else if (result[i] == '6')
                        final = final + "6";
                    else if (result[i] == '7')
                        final = final + "7";
                    else if (result[i] == '8')
                        final = final + "8";
                    else if (result[i] == '9')
                        final = final + "9";
                }
                final = new string(final.ToCharArray().Reverse().ToArray());
                if (count == 0)
                {
                    Console.WriteLine("Total number of messages: {0}", noMessage);
                }
                Console.WriteLine(final);
            }
          
        }
    }
}
