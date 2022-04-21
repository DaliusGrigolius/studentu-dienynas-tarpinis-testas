using main.Business;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class Calculator
    {
        public string CalculateSemesterAverage(List<School> schoolsList, int schoolIndex, int classIndex, int studentIndex, int semesterNumber)
        {
            string finalResult = "";

            Validator validator = new Validator();

            bool isSchoolIndexValid = validator.IsSchoolIndexValid(schoolIndex);
            if (!isSchoolIndexValid) return "";
            bool isClassIndexValid = validator.IsClassIndexValid(schoolIndex, classIndex);
            if (!isClassIndexValid) return "";
            bool isStudentIndexValid = validator.IsStudentIndexValid(schoolIndex, classIndex, studentIndex);
            if (!isStudentIndexValid) return "";
            bool isSemesterNumberValid = validator.IsSemesterNumberValid(semesterNumber);
            if (!isSemesterNumberValid) return "";

            if (semesterNumber == 1)
            {
                int arrSize = schoolsList[schoolIndex].Classes[classIndex].Students[studentIndex].FirstSemesterGrades.Count;
                int[] arr = new int[arrSize];
                for (int i = 0; i < arrSize; i++)
                {
                    arr[i] = schoolsList[schoolIndex].Classes[classIndex].Students[studentIndex].FirstSemesterGrades[i].GradeNum;
                }
                double avg = Queryable.Average(arr.AsQueryable());
                finalResult += String.Format("{0:0.0}", avg);
            }
            else if (semesterNumber == 2)
            {
                int arrSize = schoolsList[schoolIndex].Classes[classIndex].Students[studentIndex].SecondSemesterGrades.Count;
                int[] arr = new int[arrSize];
                for (int i = 0; i < arrSize; i++)
                {
                    arr[i] = schoolsList[schoolIndex].Classes[classIndex].Students[studentIndex].SecondSemesterGrades[i].GradeNum;
                }
                double avg = Queryable.Average(arr.AsQueryable());
                finalResult += String.Format("{0:0.0}", avg);
            }
            else
            {
                int arrSize = schoolsList[schoolIndex].Classes[classIndex].Students[studentIndex].ThirdSemesterGrades.Count;
                int[] arr = new int[arrSize];
                for (int i = 0; i < arrSize; i++)
                {
                    arr[i] = schoolsList[schoolIndex].Classes[classIndex].Students[studentIndex].ThirdSemesterGrades[i].GradeNum;
                }
                double avg = Queryable.Average(arr.AsQueryable());
                finalResult += String.Format("{0:0.0}", avg);
            }
            return finalResult;
        }

        public string CalculateYearAverage(string firstSemesterNumber, string secondSemesterNumber, string thirdSemesterNumber)
        {
            double[] arr = { Convert.ToDouble(firstSemesterNumber), Convert.ToDouble(secondSemesterNumber), Convert.ToDouble(thirdSemesterNumber) };
            double avg = Queryable.Average(arr.AsQueryable());
            return String.Format("{0:0.0}", avg);            
        }
    }
}
