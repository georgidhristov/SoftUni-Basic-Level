using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem2Chessboard_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            n = n * n;
            string input = Console.ReadLine();
            string str = "";

            if (input.Length > n)
                str = input.Substring(0, n);
            else
                str = input;

            var white = str.Where((item, index) => index % 2 != 0);
            string whiteTeam = "";
            foreach (var item in white)
            {
                whiteTeam = whiteTeam + item;
            }

            var black = str.Where((item, index) => index % 2 == 0);
            string blackTeam = "";
            foreach (var item in black)
            {
                blackTeam = blackTeam + item;
            }      

            whiteTeam = Regex.Replace(whiteTeam, "[^a-zA-Z0-9]","");
            string whiteUpper = "";
            for (int i = 0; i < whiteTeam.Length; i++)
            {
                if (char.IsUpper(whiteTeam[i]))
                {
                    whiteUpper = whiteUpper + whiteTeam[i];
                }
            }

            blackTeam = Regex.Replace(blackTeam, "[^a-zA-Z0-9]","");
            string blackUpper = "";
            for (int i = 0; i < blackTeam.Length; i++)
            {
                if (char.IsUpper(blackTeam[i]))
                {
                    blackUpper = blackUpper + blackTeam[i];
                }
            }

            int whiteScore = 0;
            byte[] whiteAscii = Encoding.ASCII.GetBytes(whiteTeam);
            for (int i = 0; i < whiteAscii.Length; i++)
            {
                whiteScore = whiteScore + whiteAscii[i];
            }

            byte[] whiteUpperAscii = Encoding.ASCII.GetBytes(whiteUpper);
            int askiiW = 0;
            for (int i = 0; i < whiteUpperAscii.Length; i++)
            {
                askiiW = askiiW + whiteUpperAscii[i];
            }

            int blackScore = 0;
            byte[] blackAscii = Encoding.ASCII.GetBytes(blackTeam);
            for (int i = 0; i < blackAscii.Length; i++)
            {
                blackScore = blackScore + blackAscii[i];
            }

            byte[] blackUpperAscii = Encoding.ASCII.GetBytes(blackUpper);
            int askiiB = 0;
            for (int i = 0; i < blackUpperAscii.Length; i++)
            {
                askiiB = askiiB + blackUpperAscii[i];
            }
            
            whiteScore = (whiteScore - askiiW) + askiiB;
            blackScore = (blackScore - askiiB) + askiiW;

            if (whiteScore == blackScore)
            {
                Console.WriteLine("Equal result: {0}",whiteScore);
            }
            else if (whiteScore > blackScore)
            {
                whiteScore = whiteScore - blackScore;
                Console.WriteLine("The winner is: white team");
                Console.WriteLine(whiteScore);
            }
            else if (blackScore > whiteScore )
            {
                blackScore = blackScore - whiteScore;
                Console.WriteLine("The winner is: black team");
                Console.WriteLine(blackScore);
            }
        }
    }
}
