using System;
using CsvHelper;
using System.IO;
using System.Globalization;
using System.Linq;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace FinalParser
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var streamReader = new StreamReader(@"C:\Users\khoushid\Desktop\reporting AIMS Zacs file\@AdvancedReporting\TestFiles\smallsampleAddresslist.csv"))
            {
                using (var csvReader = new CsvReader( streamReader, CultureInfo.InvariantCulture))
                {
                    csvReader.Context.RegisterClassMap<CsvParseClassMap>();
                    var records = csvReader.GetRecords<CsvParse>().ToList();
                }
            }

        }
    }
}