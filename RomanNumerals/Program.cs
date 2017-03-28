using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RomanNumerals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter in a number between 0-3999: ");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);

            var numeral = ConvertToRomanNumeral(number);
            Console.WriteLine(numeral);
            Console.ReadKey();

        }
        public static List<Tuple<int, string>> RomanTable = new List<Tuple<int, string>>
            {
                new Tuple<int, string>(1, "I"),
                new Tuple<int, string>(4, "IV"),
                new Tuple<int, string>(5, "V"),
                new Tuple<int, string>(9, "IX"),
                new Tuple<int, string>(10, "X"),
                new Tuple<int, string>(40, "XL"),
                new Tuple<int, string>(50, "L"),
                new Tuple<int, string>(90, "XC"),
                new Tuple<int, string>(100, "C"),
                new Tuple<int, string>(400, "CD"),
                new Tuple<int, string>(500, "D"),
                new Tuple<int, string>(900, "CM"),
                new Tuple<int, string>(1000, "M")
            };
        public static int RomanTableLength = RomanTable.Count;
        private static string ConvertToRomanNumeral(int number)
        {
            var romanNumeral = "";

            while (number > 0)
            {
                for (var count = 0; count <= RomanTableLength-1; count++)
                {
                    if (count == RomanTableLength-1)
                    {
                        number -= RomanTable[count].Item1;
                        romanNumeral += RomanTable[count].Item2;
                        break;
                    }
                    if (number < RomanTable[count+1].Item1)
                    {
                        number -= RomanTable[count].Item1;
                        romanNumeral += RomanTable[count].Item2;
                        break;
                    }
                }
            }

            return romanNumeral;
        }
    }
}
