using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2DetectiveBoev
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = Console.ReadLine();         //   secret word     // C#                    //   secret word     // abc                                        
            string encryptedMessage = Console.ReadLine();   // encrypted message //  |wfvohyfqX#hodzwclV  // encrypted message //  ;7*8&yioyg<&mtossglmulV

            //------------SECRET-WORD-DECRYPTED-------------\\
            byte[] asciiSW = Encoding.ASCII.GetBytes(secretWord);
            int sumSW = 0;
            for (int i = 0; i < asciiSW.Length; i++)
            {
                sumSW = sumSW + asciiSW[i];
            }
            
            //-------Create-MASK-------\\
            while (sumSW > 9)
            {
                int mask = 0;
                while (sumSW != 0)
                {
                    int r = sumSW % 10;
                    sumSW = sumSW / 10;
                    mask = mask + r;
                }
                sumSW = mask;
            }
            

            //---------ENCRYPTED-MESSAGE-DECRYPTED-----------\\
            byte[] asciiEM = Encoding.ASCII.GetBytes(encryptedMessage);
            int[] asciiToInt = Array.ConvertAll(asciiEM, c => (int)c);
            
            for (int i = 0; i < asciiToInt.Length; i++)
            {
                if (asciiToInt[i] % sumSW == 0)
                {
                    asciiToInt[i] = asciiToInt[i] + sumSW;
                }
                else
                {
                    asciiToInt[i] = asciiToInt[i] - sumSW;
                }
            }

            //---------CONVERT-ASCII-TO-WORDS---------\\
            string text = "";
            for (int i = 0; i < asciiToInt.Length; i++)
            {
                char character = (char)asciiToInt[i]; 
                text = text + character.ToString();
            }

            //---------REVERSE-THE-MESSAGE-----------\\ 
            char[] result = new char[text.Length];
            for (int i = 0, j = text.Length - 1; i < text.Length; i++, j--)
            {
                result[i] = text[j];
            }
            Console.WriteLine(result);
        }
    }
}
