using main.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services;
using System.Collections.Generic;

namespace unitTests
{
    [TestClass]
    public class UnitTest
    {
        private Calculator calculator { get; }
        private List<School> schoolsList { get; }

        public UnitTest()
        {
            calculator = new Calculator();
            schoolsList = new List<School>();

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
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateSemesterAverage_HasData_ReturnsCorrectlyIf3rdParameterWrong()
        {
            var actual = calculator.CalculateSemesterAverage(schoolsList, 0, -1, 0, 1);
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateSemesterAverage_HasData_ReturnsCorrectlyIf4thParameterWrong()
        {
            var actual = calculator.CalculateSemesterAverage(schoolsList, 0, 0, -1, 1);
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateSemesterAverage_HasData_ReturnsCorrectlyIf5thParameterWrong()
        {
            var actual = calculator.CalculateSemesterAverage(schoolsList, 0, 0, 0, -1);
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateSemesterAverage_HasData_ReturnsCorrectlyIfAllParametersValid()
        {
            var actual = calculator.CalculateSemesterAverage(schoolsList, 0, 0, 0, 1);
            var expected = 6;

            Assert.AreEqual(expected, actual);
        }
    }
}
