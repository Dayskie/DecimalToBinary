using System;

namespace DecimalToBinary
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int input);
            string binary = "";
            
            while (input != 0)
            {
                binary += (input % 2).ToString();
                input /= 2;
            }
            Console.Write(Flipped(binary));
        }

        public static string Flipped(string s)
        {
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}