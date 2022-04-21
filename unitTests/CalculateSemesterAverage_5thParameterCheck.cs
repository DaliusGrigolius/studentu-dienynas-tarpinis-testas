using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services;

namespace unitTests
{
    [TestClass]
    public class CalculateSemesterAverage_5ndParameterCheck
    {
        [TestMethod]
        public void CalculateSemesterAverage_HasData_ReturnsCorrectlyIf5rdParameterWrong()
        {
            Calculator calculator = new Calculator();
            CalculateSemesterAverage_2ndParameterCheck smt = new CalculateSemesterAverage_2ndParameterCheck();
            var schoolsList = smt.schoolsList;
            var actual = calculator.CalculateSemesterAverage(schoolsList, 0, 0, 0, -1);
            var expected = "";

            Assert.AreEqual(expected, actual);
        }
    }
}