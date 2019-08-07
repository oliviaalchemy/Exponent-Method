using System;

namespace Exponent_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetPow(3, 2));
            Console.ReadLine();
        }
        static int GetPow(int baseNum, int powNum) //GetPow only works for positive number powers
        {
            int result = 1;

            for (int i = 0; i < powNum; i++)
            {
                result = result * baseNum; 
            }

            return result; //will read 9
        }
    }
}
