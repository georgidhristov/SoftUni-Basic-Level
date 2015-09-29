using System;
using System.Collections.Generic;

namespace Problem6RemoveNames
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Peter", "Peter", "Todor", "Todor", "Diana" };
            List<string> equalNames = new List<string>() { "Todor", "Steve", "Nakov" };

            for (int i = 0; i < equalNames.Count; i++)
            {
                for (int j = 0; j < names.Count; j++)
                {
                    if (equalNames[i] == names[j])
                    {
                        names.RemoveAt(j);
                        if (j == names.Count)
                        {
                            break;
                        }
                        if (equalNames[i] == names[j])
                        {
                            names.RemoveAt(j);
                            j--;
                            continue;
                        }
                    }
                }
            }

            foreach (var item in names)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
