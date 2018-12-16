using System;

namespace RainDrops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"12 => {RainDrops(12)}");
            Console.WriteLine($"30 => {RainDrops(30)}");
            Console.WriteLine($"34 => {RainDrops(34)}");
            Console.WriteLine($"105 => {RainDrops(105)}");
        }

        public static string RainDrops(int number)
        {
            string output = "";

            if (number % 3 == 0)
            {
                output += "Pling";
            }
            if (number % 5 == 0)
            {
                output += "Plang";
            }
            if (number % 7 == 0)
            {
                output += "Plong";
            }
            if (output == "")
            {
                output = number.ToString();
            }

            return output;
        }
    }
}
