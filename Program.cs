using System;
using System.Collections.Generic;

namespace RomanNumeralsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string returnToStart = "";
            string input = "";
            do
            {
                Console.Write("Please enter a Roman Numeral: ");
                input = Console.ReadLine();
                Console.WriteLine(RomanNumeralEncoder(input));

                Console.Write("Press r to continue or x to exit: ");
                returnToStart = Console.ReadLine();
                Console.Clear();

                if (returnToStart == "x")
                {
                    Environment.Exit(0);
                }

            } while (returnToStart.ToLower() == "r");
        }

        private static string RomanNumeralEncoder(string romanNumeral)
        {
            int numerals = int.Parse(romanNumeral);
            string result = "";
            Dictionary<int, string> roman = new Dictionary<int, string>
            {
                {1000, "M" },
                {900, "DM" },
                {500, "D" },
                {400, "CD" },
                {100, "C" },
                {90, "XC" },
                {50, "L" },
                {40, "XL" },
                {10, "X" },
                {9, "IX" },
                {5, "V" },
                {4, "IV" },
                {1, "I" }
            };

            foreach (KeyValuePair<int, string> entry in roman)
            {
                while (numerals - entry.Key >= 0)
                {
                    result += entry.Value;
                    numerals -= entry.Key;
                }
            }

            return result;
        } 
    }
}
