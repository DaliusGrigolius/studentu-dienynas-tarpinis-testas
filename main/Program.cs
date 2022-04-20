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

            serializeData.GenerateDataFile();
            reportGenerator.GenerateReport();

            Console.ReadLine();
        }
    }
}
