using Serializer;
using Services;
using System;

namespace main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SerializeData serializeData = new SerializeData();
            ReportGenerator reportGenerator = new ReportGenerator();
            DataPrinter dataPrinter = new DataPrinter();

            serializeData.GenerateDataFile();
            reportGenerator.GenerateReport();
            dataPrinter.PrintDataFile();

            Console.ReadLine();
        }
    }
}
