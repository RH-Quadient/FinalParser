using System;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace FinalParser
{
    public class CsvParseClassMap : ClassMap<CsvParse>
    {
        public CsvParseClassMap()
        {
            Map( m => m.TID).Name("TID");
            Map( m => m.Name).Name("Name");
            Map( m => m.Add1).Name("Add1");
            Map( m => m.Add2).Name("Add2");
            Map( m => m.Add3).Name("Add3");
            Map( m => m.Addr4).Name("Addr4");
            Map( m => m.City).Name("City");
            Map( m => m.St).Name("St");
            Map( m => m.Zip).Name("Zip");
            Map( m => m.Situs).Name("Situs");

        }
    }
    public class CsvParse
    {
        public int TID {get; set; }
        public string Name {get; set; }
        public string Add1 {get; set; }
        public string Add2 {get; set; }
        public string Add3 {get; set; }
        public string Addr4 {get; set; }
        public string City {get; set; }
        public string St {get; set; }
        public string Zip {get; set; }
        public string Situs {get; set; }
    }
}