using Deserializer;
using main.Business;
using System;
using System.Collections.Generic;

namespace Services
{
    public class Calculator
    {

        public int CalculateSemesterAverage(int schoolIndex, int classIndex, int studentIndex, int semesterNumber)
        {
            DeserializeData deserializeData = new DeserializeData();
            List<School> schoolsList = deserializeData.DeserializeDataFile();

            if (semesterNumber == 1)
            {
                List<Grade> gradesList = schoolsList[schoolIndex].Classes[classIndex].Students[studentIndex].FirstSemesterGrades;

                int sum = 0;
                for (int i = 0; i < gradesList.Count; i++)
                {
                    sum += gradesList[i].GradeNum;
                }
                decimal result = sum / gradesList.Count;

                return Convert.ToInt32(Math.Round(result)); 
            }
            else if (semesterNumber == 2)
            {
                List<Grade> gradesList = schoolsList[schoolIndex].Classes[classIndex].Students[studentIndex].SecondSemesterGrades;

                int sum = 0;
                for (int i = 0; i < gradesList.Count; i++)
                {
                    sum += gradesList[i].GradeNum;
                }
                decimal result = sum / gradesList.Count;

                return Convert.ToInt32(Math.Round(result));
            }
            else if (semesterNumber == 3)
            {
                List<Grade> gradesList = schoolsList[schoolIndex].Classes[classIndex].Students[studentIndex].ThirdSemesterGrades;

                int sum = 0;
                for (int i = 0; i < gradesList.Count; i++)
                {
                    sum += gradesList[i].GradeNum;
                }
                decimal result = sum / gradesList.Count;

                return Convert.ToInt32(Math.Round(result));
            }
            else
            {
                return 0;
            }
        }
    }
}
