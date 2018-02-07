using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab15
{
    class CountriesApp
    {

        public int GetUserChoice()
        {
            string Option1, Option2, Option3, Option4;
            int UserChoice;


            Option1 = "1) Display the list of countries";
            Option2 = "2) Add a new country to the list";
            Option3 = "3) Remove a country from the list";
            Option4 = "4) Exit Program";

            Console.WriteLine("Please select one of the following options.");
            Console.WriteLine($"\n{Option1}\n{Option2}\n{Option3}\n{Option4}\n");
            Console.Write("Option: ");
            UserChoice = Validation.ValidateInteger(Console.ReadLine());
            return UserChoice;
        }
        public void DisplayCountryList(List<string> CountryList)
        {
            Console.Clear();
            Console.WriteLine(new string('*', 20) + "\n");
            foreach (string Country in CountryList)
            {
                Console.WriteLine(Country);
            }
            Console.WriteLine(Environment.NewLine + new string('*', 20));
            Console.WriteLine("\n");
        }
        public void AddCountryToList(List<string> CountryList, string FileName)
        {
            string CountryName = "", EnterAgain = "Y";
            Console.WriteLine("\nPlease enter a country.");
            CountryName = Validation.ValidateInput1(Console.ReadLine());
            while (CountryList.Contains(CountryName))
            {
                Console.WriteLine("You entered the name of a country that's already on the Country List.");
                Console.WriteLine("Would you like to try again? (Y or N)");
                EnterAgain = Console.ReadLine();
                if (Validation.ValidateYesNo(EnterAgain).ToLower() == "y")
                {
                    CountryName = Validation.ValidateInput1(Console.ReadLine());
                }
                else
                {
                    break;
                }
            }
                CountryList.Add(CountryName);
            CountriesTextFile.WriteAppendToFile(FileName, CountryName);
        }
        public void RemoveCountryFromList(List<string> CountryList, string FileName)
        {
            string EnterAgain = "Y", CountryToDelete = "";
            Console.WriteLine("\nPlease enter the name of the country you wish to delete from the list.\n");
            CountryToDelete = Validation.ValidateInput1(Console.ReadLine());
            while (!CountryList.Contains(CountryToDelete))
            {
                Console.WriteLine("You did not enter the name of a country on the Country List.");
                Console.WriteLine("Would you like to try again? (Y or N)");
                EnterAgain = Console.ReadLine();
                if (Validation.ValidateYesNo(EnterAgain).ToLower() == "y")
                {
                    CountryToDelete = Validation.ValidateInput1(Console.ReadLine());
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine($"{CountryToDelete} has been removed from the list.\n");
            CountryList.Remove(CountryToDelete);
            CountriesTextFile.WriteListToFile(FileName, CountryList);
        }
        public int CompleteUserChoice(int UserChoice, string FileName, List<string> CountryList)
        {
            switch (UserChoice)
            {
                case 1:

                    DisplayCountryList(CountryList);
                    return 1;

                case 2:

                    AddCountryToList(CountryList, FileName);
                    return 1;

                case 3:

                    RemoveCountryFromList(CountryList, FileName);
                    return 1;

                case 4:
                    return 0;
                
                default:
                    return 1;
            }
        }
    }
}
