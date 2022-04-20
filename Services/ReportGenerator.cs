using main.Business;
using main.DataAccess;
using System.Collections.Generic;
using System.IO;

namespace Services
{
    public class ReportGenerator
    {
        public void GenerateReport()
        {
            SchoolRepo schoolRepo = new SchoolRepo();
            Calculator calculator = new Calculator();

            List<School> schoolsList = schoolRepo.RetrieveSchoolsList();
            
            File.Delete(@"..\..\..\..\DataFiles\generatedReport.html");

            string schoolTemplatePath = @"..\..\..\..\DataFiles\templates\schoolTemplate.html";
            string classNameTemplatePath = @"..\..\..\..\DataFiles\templates\classNameTemplate.html";
            string classesTemplatePath = @"..\..\..\..\DataFiles\templates\classesTemplate.html";

            string reportPath = @"..\..\..\..\DataFiles\generatedReport.html";

            string schoolText = File.ReadAllText(schoolTemplatePath);
            string classNametext = File.ReadAllText(classNameTemplatePath);
            string classesText = File.ReadAllText(classesTemplatePath);

            for (int i = 0; i < schoolsList.Count; i++)
            {
                schoolText = schoolText.Replace("{SchoolName}", schoolsList[i].Name);
                schoolText = schoolText.Replace("{SchoolAddress}", schoolsList[i].Address);
                schoolText = schoolText.Replace("{SchoolPhoneNumber}", schoolsList[i].PhoneNumber);
                schoolText = schoolText.Replace("{SchoolEmail}", schoolsList[i].Email);
                schoolText = schoolText.Replace("{ClassesTotal}", $"{schoolsList[i].Classes.Count}");
                int totalStudents = 0;
                for (int j = 0; j < schoolsList[i].Classes.Count; j++)
                {
                    totalStudents += schoolsList[i].Classes[j].Students.Count;
                }
                schoolText = schoolText.Replace("{studentsTotal}", $"{totalStudents}");
                File.AppendAllText(reportPath, schoolText);
                schoolText = File.ReadAllText(schoolTemplatePath);

                for (int j = 0; j < schoolsList[i].Classes.Count; j++)
                {
                    classNametext = classNametext.Replace("{Class}", $"{schoolsList[i].Classes[j].Name}{j+1}");
                    classNametext = classNametext.Replace("{total}", $"{schoolsList[i].Classes[j].Students.Count}");

                    File.AppendAllText(reportPath, classNametext);
                    classNametext = File.ReadAllText(classNameTemplatePath);

                    for (int k = 0; k < schoolsList[i].Classes[j].Students.Count; k++)
                    {
                        classesText = classesText.Replace("{StudentName}", schoolsList[i].Classes[j].Students[k].FirstName);
                        classesText = classesText.Replace("{StudentSurname}", schoolsList[i].Classes[j].Students[k].LastName);
                        classesText = classesText.Replace("{Gender}", schoolsList[i].Classes[j].Students[k].Gender);
                        int sem1 = calculator.CalculateSemesterAverage(i, j, k, 1);
                        int sem2 = calculator.CalculateSemesterAverage(i, j, k, 2);
                        int sem3 = calculator.CalculateSemesterAverage(i, j, k, 3);
                        classesText = classesText.Replace("{1semAv}", $"{sem1}");
                        classesText = classesText.Replace("{2semAv}", $"{sem2}");
                        classesText = classesText.Replace("{3semAv}", $"{sem3}");
                        classesText = classesText.Replace("{average}", $"{calculator.CalculateYearAverage(sem1, sem2, sem3)}");

                        File.AppendAllText(reportPath, classesText);
                        classesText = File.ReadAllText(classesTemplatePath);
                    }
                }
            }
        }
    }
}
