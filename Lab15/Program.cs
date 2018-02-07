using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string FileName = "../../Countries.txt";
            CountriesApp MyCountriesApp = new CountriesApp();
            List<string> CountryList = new List<string>();

            CountriesTextFile.ReaderLineByLine(FileName, CountryList);

            Console.WriteLine("Welcome to the Countries of the World app!");
            while (MyCountriesApp.CompleteUserChoice(MyCountriesApp.GetUserChoice(),FileName, CountryList)!=0)
            {
                MyCountriesApp.CompleteUserChoice(MyCountriesApp.GetUserChoice(), FileName, CountryList);
                Console.WriteLine();
            }
            Console.WriteLine("Thanks for using the Countries of the World app! Goodbye! (Press enter to exit...)");
            Console.Read();
        }
    }
}
