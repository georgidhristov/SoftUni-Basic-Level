using System;


namespace FormattingNumbers
{
    class Problem5
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int firstNum = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            float secondNum = float.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            float thirdNum = float.Parse(Console.ReadLine());

            string convert = Convert.ToString((int)firstNum, 2);

            if (firstNum >= 0 && firstNum <= 500)
            {
                Console.WriteLine("|{0,-10:X}|{1,0}|{2,10:0.00}|{3,-10:0.000}", firstNum, convert.PadLeft(10, '0'), secondNum, thirdNum);    
            }
            else
            {
                Console.WriteLine("first number >= 0 and first number <= 500");
            }
        }
    }
}
