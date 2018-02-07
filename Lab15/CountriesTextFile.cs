using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab15
{
    class CountriesTextFile
    {
        public static List<string> ReaderLineByLine(string FileName, List<string> CountriesList)
        {
            StreamReader Reader = new StreamReader(FileName);

            string CurrentLine = Reader.ReadLine();

            while (CurrentLine != null)
            {
                CountriesList.Add(CurrentLine);
                CurrentLine = Reader.ReadLine();
            }
            Reader.Close();
            return CountriesList;
        }

        public static void WriteListToFile(string FileName, List<string> CountryList)
        {
            StreamWriter Writer = new StreamWriter(FileName);
            foreach(string Country in CountryList)
            {
                Writer.WriteLine(Country);
            }
            Writer.Close();
        }
        public static void WriteAppendToFile(string FileName, string Country)
        {
            StreamWriter Writer = new StreamWriter(FileName,true);
            Writer.WriteLine(Country);
            Writer.Close();
        }


    }
}
