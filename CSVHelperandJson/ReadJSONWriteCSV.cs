﻿using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace CSVHelperandJson
{
    public class ReadJSONWriteCSV
    {
        public static void ImplementJSONToCSV()
        {
            string importFilePath = @"C:\Users\HP\csharp\CSVHelperandJson\CSVHelperandJson\Utility\export.json";
            string exportFilePath = @"C:\Users\HP\csharp\CSVHelperandJson\CSVHelperandJson\Utility\export.csv";
            IList<AddressData> addressData = JsonConvert.DeserializeObject<IList<AddressData>>(File.ReadAllText(importFilePath));

            Console.WriteLine("**********************Reading from Json file and Write to csv file **************************");
            using (var writer = new StreamWriter(exportFilePath))
            using (var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csvExport.WriteRecords(addressData);
            }

        }
    }
}
