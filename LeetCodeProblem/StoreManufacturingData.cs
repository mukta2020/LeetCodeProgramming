using CsvHelper;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LeetCodeProblem
{
    public class StoreManufacturingData
    {
        static public async Task<string> StoreManufacturingCsv(string pathToStoreCSV)
        {
            pathToStoreCSV = @"D:\\";  //Projects\

            List<CellLocatorSheet> cellLocatorSheetList = new List<CellLocatorSheet>();
            if (true)
            {
                var cls = new CellLocatorSheet
                {
                    DrugName = "abc",
                    LabelName = "",
                    Baffle = 3,
                    Height = 1.5,
                    Width = "B.75",
                    Cell = "9V",
                    CellType = "",
                    MaxCapacity = 716,
                    SuperCellMaxCapacity = 1123,
                    NDC = "123456789",
                    Pressure = 30,
                    ThirtyDramCapacity = 159
                };
                cellLocatorSheetList.Add(cls);
            }

            try
            {
                XmlWriterSettings settings = new XmlWriterSettings { Async = true };
                settings.Encoding = Encoding.UTF8;
                settings.Indent = true;
                settings.NewLineChars = "\n";
                settings.OmitXmlDeclaration = true;

                using (FileStream fileStream = new FileStream(pathToStoreCSV, FileMode.Create, FileAccess.Write, FileShare.None, 4096, FileOptions.Asynchronous | FileOptions.WriteThrough))
                {
                    using (var bufferedStream = new BufferedStream(fileStream, 65536))
                    {
                        using (StreamWriter writer = new StreamWriter(bufferedStream))
                        {
                            using (CsvWriter csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                            {
                                await csv.WriteRecordsAsync(cellLocatorSheetList);
                                await csv.FlushAsync();
                            }
                            writer.Close();
                        }
                    }
                    fileStream.Close();
                }
            }
            catch (Exception ex)
            {

            }
            return "";

        }

    }

    public class CellLocatorSheet
    {
        public string DrugName { get; set; }
        public string LabelName { get; set; }
        public string NDC { get; set; }
        public double? Height { get; set; }
        public string Width { get; set; }
        public int? Baffle { get; set; }
        public int? Pressure { get; set; }
        public int? ThirtyDramCapacity { get; set; }
        public string Cell { get; set; }
        public string CellType { get; set; }
        public int? MaxCapacity { get; set; }
        public int? SuperCellMaxCapacity { get; set; }
        public bool S { get; set; } = false;
    }

}
