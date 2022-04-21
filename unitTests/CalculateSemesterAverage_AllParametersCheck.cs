using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services;

namespace unitTests
{
    [TestClass]
    public class CalculateSemesterAverage_AllParametersCheck
    {
        [TestMethod]
        public void CalculateSemesterAverage_HasData_ReturnsCorrectlyIfAllParametersValid()
        {
            Calculator calculator = new Calculator();
            CalculateSemesterAverage_2ndParameterCheck smt = new CalculateSemesterAverage_2ndParameterCheck();
            var schoolsList = smt.schoolsList;
            var actual = calculator.CalculateSemesterAverage(schoolsList, 0, 0, 0, 1);
            var expected = "6.0";

            Assert.AreEqual(expected, actual);
        }
    }
}