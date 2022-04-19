using main.Business;
using main.DataAccess;
using System;
using System.Collections.Generic;

namespace Services
{
    public class Calculator
    {
        public SchoolRepo schoolRepo { get; }
        List<School> schoolsList { get; }

        public Calculator()
        {
            schoolRepo = new SchoolRepo();
            schoolsList = schoolRepo.RetrieveSchoolsList();
        }

        public int CalculateSemesterAverage(int schoolIndex, int classIndex, int studentIndex, int semesterNumber)
        {
            int finalResult = 0;

            Validator validator = new Validator();

            bool isSchoolIndexValid = validator.IsSchoolIndexValid(schoolIndex);
            if (!isSchoolIndexValid) return 0;
            bool isClassIndexValid = validator.IsClassIndexValid(schoolIndex, classIndex);
            if (!isClassIndexValid) return 0;
            bool isStudentIndexValid = validator.IsStudentIndexValid(schoolIndex, classIndex, studentIndex);
            if (!isStudentIndexValid) return 0;
            bool isSemesterNumberValid = validator.IsSemesterNumberValid(semesterNumber);
            if (!isSemesterNumberValid) return 0;

            if (semesterNumber == 1)
            {
                List<Grade> gradesList = schoolsList[schoolIndex].Classes[classIndex].Students[studentIndex].FirstSemesterGrades;
                int sum = 0;
                for (int i = 0; i < gradesList.Count; i++) sum += gradesList[i].GradeNum;
                double result = sum / gradesList.Count;
                finalResult += Convert.ToInt32(Math.Round(result));
            }
            else if (semesterNumber == 2)
            {
                List<Grade> gradesList = schoolsList[schoolIndex].Classes[classIndex].Students[studentIndex].SecondSemesterGrades;
                int sum = 0;
                for (int i = 0; i < gradesList.Count; i++) sum += gradesList[i].GradeNum;
                double result = sum / gradesList.Count;
                finalResult += Convert.ToInt32(Math.Round(result));
            }
            else
            {
                List<Grade> gradesList = schoolsList[schoolIndex].Classes[classIndex].Students[studentIndex].ThirdSemesterGrades;
                int sum = 0;
                for (int i = 0; i < gradesList.Count; i++) sum += gradesList[i].GradeNum;
                double result = sum / gradesList.Count;
                finalResult += Convert.ToInt32(Math.Round(result));
            }
            return finalResult;
        }

        public int CalculateYearAverage(int firstSemesterNumber, int secondSemesterNumber, int thirdSemesterNumber)
        {
            double result = (firstSemesterNumber + secondSemesterNumber + thirdSemesterNumber) / 3;
            return Convert.ToInt32(Math.Round(result));
        }
    }
}
