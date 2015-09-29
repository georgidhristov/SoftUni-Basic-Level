using System;

namespace DeclareVariables
{
    class DeclareVariables
    {
        static void Main(string[] args)
        {
            byte varByte = 97;
            sbyte varSByte = -115;
            ushort varUShort = 52130;
            int varInt = -10000;
            uint varUInt = 4825932;

            Console.WriteLine("byte={0}", varByte);
            Console.WriteLine("sbyte={0}", varSByte);
            Console.WriteLine("ushort={0}", varUShort);
            Console.WriteLine("int={0}", varInt);
            Console.WriteLine("uint={0}", varUInt);

        }
    }
}
