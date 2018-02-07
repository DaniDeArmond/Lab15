using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab15
{
    class Validation
    {
        public static string ValidateYesNo(string Word)
        {
            while (!Regex.IsMatch(Word, @"[YyNn]"))
            {
                Console.WriteLine("You did not enter 'Y' or 'N'. Please try again.");
                Word = Console.ReadLine();
            }
            return Word;
        }

        public static string ValidateInput1(string Word)
        {

            while (Regex.IsMatch(Word, @"^[A-z\ ]+$") != true)
            {
                Console.WriteLine("You did not enter a valid word. Please make sure your selection matches a category name.");
                Word = Console.ReadLine();
            }
            return Word;
        }

        public static bool ValidateInput2(string Word)
        {
            bool AllLetters = true;

            if (Regex.IsMatch(Word, @"^[A-z\']+$") != true)
            {
                AllLetters = false;
            }
            return AllLetters;
        }

        public static int ValidateInteger(string Input)
        {
            int Answer = 0;
            bool Repeat = true;

            while (Repeat == true)
            {
                while (int.TryParse(Input, out int Result) != true)
                {
                    Console.WriteLine("You did not enter a valid number. Please try again.");
                    Input = Console.ReadLine();
                }

                Answer = int.Parse(Input);
                if (Answer > -1 && Answer < 5)
                {
                    Repeat = false;
                }
                else
                {
                    Console.WriteLine("You did not enter a valid menu option. Please try again.");
                }
            }
            return Answer;
        }
    }
}
