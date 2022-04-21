using Deserializer;
using main.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Serializer;
using Services;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace unitTests
{
    [TestClass]
    public class UnitTest
    {
        private Calculator calculator { get; }
        private List<School> schoolsList { get; }
        private ReportGenerator reportGenerator { get; }
        private SerializeData serializeData { get; }
        private DeserializeData deserializeData { get; }

        public UnitTest()
        {
            reportGenerator = new ReportGenerator();
            calculator = new Calculator();
            schoolsList = new List<School>();
            serializeData = new SerializeData();
            deserializeData = new DeserializeData();

            List<Grade> firstSemesterGrades = new List<Grade>();
            firstSemesterGrades.Add(new Grade(6));
            List<Grade> secondSemesterGrades = new List<Grade>();
            secondSemesterGrades.Add(new Grade(8));
            List<Grade> thirdSemesterGrades = new List<Grade>();
            thirdSemesterGrades.Add(new Grade(10));
            List<Student> students = new List<Student>();
            students.Add(new Student("a", "b", "c", "d", firstSemesterGrades, secondSemesterGrades, thirdSemesterGrades));
            List<Class> classes = new List<Class>();
            classes.Add(new Class("a", students));
            schoolsList.Add(new School("a", "b", "c", "d", classes));
        }

        [TestMethod]
        public void CalculateSemesterAverage_HasData_ReturnsCorrectlyIf2ndParameterWrong()
        {
            var actual = calculator.CalculateSemesterAverage(schoolsList, - 1, 0, 0, 1);
            var expected = "";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateSemesterAverage_HasData_ReturnsCorrectlyIf3rdParameterWrong()
        {
            var actual = calculator.CalculateSemesterAverage(schoolsList, 0, -1, 0, 1);
            var expected = "";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateSemesterAverage_HasData_ReturnsCorrectlyIf4thParameterWrong()
        {
            var actual = calculator.CalculateSemesterAverage(schoolsList, 0, 0, -1, 1);
            var expected = "";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateSemesterAverage_HasData_ReturnsCorrectlyIf5thParameterWrong()
        {
            var actual = calculator.CalculateSemesterAverage(schoolsList, 0, 0, 0, -1);
            var expected = "";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateSemesterAverage_HasData_ReturnsCorrectlyIfAllParametersValid()
        {
            var actual = calculator.CalculateSemesterAverage(schoolsList, 0, 0, 0, 1);
            var expected = "6.0";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateYearAverage_ReturnsCorrectly()
        {
            var a = calculator.CalculateSemesterAverage(schoolsList, 0, 0, 0, 1);
            var b = calculator.CalculateSemesterAverage(schoolsList, 0, 0, 0, 2);
            var c = calculator.CalculateSemesterAverage(schoolsList, 0, 0, 0, 3);

            var actual = calculator.CalculateYearAverage(a, b, c);
            var expected = "8.0";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GenerateReport_CreatesHtmlReportFile()
        {
            reportGenerator.GenerateReport();

            var actual = File.Exists(@"..\..\..\..\DataFiles\generatedReport.html");
            var expected = true;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GenerateDataFile_CreatesDataTxtFile()
        {
            serializeData.GenerateDataFile();

            var actual = Directory.EnumerateFileSystemEntries(@$"..\..\..\..\DataFiles\SavedDataTxt\").Any();
            var expected = true;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeserializeDataFile_ReturnsListThatHasMoreThanOneSchool()
        {
            deserializeData.DeserializeDataFile();

            var actual = deserializeData.DeserializeDataFile().Count > 1;
            var expected = true;

            Assert.AreEqual(expected, actual);
        }
    }
}
