using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services;
using System.IO;

namespace unitTests
{
    [TestClass]
    public class GenerateReport
    {
        [TestMethod]
        public void GenerateReport_CreatesHtmlReportFile()
        {
            ReportGenerator reportGenerator = new ReportGenerator();
            reportGenerator.GenerateReport();

            var actual = File.Exists(@"..\..\..\..\DataFiles\generatedReport.html");
            var expected = true;

            Assert.AreEqual(expected, actual);
        }
    }
}