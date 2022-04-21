using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services;

namespace unitTests
{
    [TestClass]
    public class CalculateYearAverage
    {
        [TestMethod]
        public void CalculateYearAverage_ReturnsCorrectly()
        {
            Calculator calculator = new Calculator();
            CalculateSemesterAverage_2ndParameterCheck smt = new CalculateSemesterAverage_2ndParameterCheck();
            var schoolsList = smt.schoolsList;

            var a = calculator.CalculateSemesterAverage(schoolsList, 0, 0, 0, 1);
            var b = calculator.CalculateSemesterAverage(schoolsList, 0, 0, 0, 2);
            var c = calculator.CalculateSemesterAverage(schoolsList, 0, 0, 0, 3);

            var actual = calculator.CalculateYearAverage(a, b, c);
            var expected = "8.0";

            Assert.AreEqual(expected, actual);
        }
    }
}