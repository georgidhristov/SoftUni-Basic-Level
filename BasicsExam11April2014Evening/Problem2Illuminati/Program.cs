using System;
using System.Linq;

namespace Problem2Illuminati
{
    class Program
    {
        static void Main(string[] args)
        {
           string input = Console.ReadLine();

            int a = 65, 
                e = 69,
                i = 73,
                o = 79,
                u = 85;

            int latters = 0;
            int result = 0;
            for (int spiner = 0; spiner < input.Length; spiner++)
			{
                if (input[spiner] == 'a' || input[spiner] == 'A')
                { 
                    result = result + a; 
                    latters = latters + 1;
                }
                if (input[spiner] == 'e' || input[spiner] == 'E')
                { 
                    result = result + e;
                    latters = latters + 1;
                }
                if (input[spiner] == 'i' || input[spiner] == 'I') 
                { 
                    result = result + i;
                    latters = latters + 1;
                }
                if (input[spiner] == 'o' || input[spiner] == 'O') 
                {
                    result = result + o;
                    latters = latters + 1;
                }
                if (input[spiner] == 'u' || input[spiner] == 'U') 
                {
                    result = result + u;
                    latters = latters + 1;
                }
			}
            Console.WriteLine(latters);
            Console.WriteLine(result);
        }
    }
}
