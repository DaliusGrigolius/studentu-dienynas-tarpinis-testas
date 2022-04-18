using main.Business;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Serializer
{
    public class SerializeData
    {
        public void GenerateDataFile()
        {

            Random random = new Random();

            List<Student> students = new List<Student>();

            for (int i = 0; i < 5; i++)
            {

                List<Grade> firstSemesterGrades0 = new List<Grade>();
                for (int j = 0; j < 5; j++) firstSemesterGrades0.Add(new Grade(random.Next(4, 10)));
                List<Grade> secondSemesterGrades0 = new List<Grade>();
                for (int k = 0; k < 5; k++) secondSemesterGrades0.Add(new Grade(random.Next(4, 10)));
                List<Grade> thirdSemesterGrades0 = new List<Grade>();
                for (int l = 0; l < 5; l++) thirdSemesterGrades0.Add(new Grade(random.Next(4, 10)));
                List<Grade> firstSemesterGrades1 = new List<Grade>();
                for (int j = 0; j < 5; j++) firstSemesterGrades1.Add(new Grade(random.Next(4, 10)));
                List<Grade> secondSemesterGrades1 = new List<Grade>();
                for (int k = 0; k < 5; k++) secondSemesterGrades1.Add(new Grade(random.Next(4, 10)));
                List<Grade> thirdSemesterGrades1 = new List<Grade>();
                for (int l = 0; l < 5; l++) thirdSemesterGrades1.Add(new Grade(random.Next(4, 10)));

                students.Add(new Student($"Vardas{i + 1}", $"Vardaitis{i + 1}", $"200{random.Next(0, 9)}-{random.Next(1, 12)}-{random.Next(1, 31)}", "Vyras", firstSemesterGrades0, secondSemesterGrades0, thirdSemesterGrades0));
                students.Add(new Student($"Varde{i + 1}", $"Vardaite{i + 1}", $"199{random.Next(1, 9)}-{random.Next(1, 12)}-{random.Next(1, 31)}", "Moteris", firstSemesterGrades1, secondSemesterGrades1, thirdSemesterGrades1));

            }
            List<Student> students1 = new List<Student>();

            for (int i = 0; i < 5; i++)
            {

                List<Grade> firstSemesterGrades0 = new List<Grade>();
                for (int j = 0; j < 5; j++) firstSemesterGrades0.Add(new Grade(random.Next(4, 10)));
                List<Grade> secondSemesterGrades0 = new List<Grade>();
                for (int k = 0; k < 5; k++) secondSemesterGrades0.Add(new Grade(random.Next(4, 10)));
                List<Grade> thirdSemesterGrades0 = new List<Grade>();
                for (int l = 0; l < 5; l++) thirdSemesterGrades0.Add(new Grade(random.Next(4, 10)));
                List<Grade> firstSemesterGrades1 = new List<Grade>();
                for (int j = 0; j < 5; j++) firstSemesterGrades1.Add(new Grade(random.Next(4, 10)));
                List<Grade> secondSemesterGrades1 = new List<Grade>();
                for (int k = 0; k < 5; k++) secondSemesterGrades1.Add(new Grade(random.Next(4, 10)));
                List<Grade> thirdSemesterGrades1 = new List<Grade>();
                for (int l = 0; l < 5; l++) thirdSemesterGrades1.Add(new Grade(random.Next(4, 10)));

                students1.Add(new Student($"Vardas{i + 1}", $"Vardaitis{i + 1}", $"200{random.Next(0, 9)}-{random.Next(1, 12)}-{random.Next(1, 31)}", "Vyras", firstSemesterGrades0, secondSemesterGrades0, thirdSemesterGrades0));
                students1.Add(new Student($"Varde{i + 1}", $"Vardaite{i + 1}", $"199{random.Next(1, 9)}-{random.Next(1, 12)}-{random.Next(1, 31)}", "Moteris", firstSemesterGrades1, secondSemesterGrades1, thirdSemesterGrades1));

            }
            List<Student> students2 = new List<Student>();

            for (int i = 0; i < 5; i++)
            {

                List<Grade> firstSemesterGrades0 = new List<Grade>();
                for (int j = 0; j < 5; j++) firstSemesterGrades0.Add(new Grade(random.Next(4, 10)));
                List<Grade> secondSemesterGrades0 = new List<Grade>();
                for (int k = 0; k < 5; k++) secondSemesterGrades0.Add(new Grade(random.Next(4, 10)));
                List<Grade> thirdSemesterGrades0 = new List<Grade>();
                for (int l = 0; l < 5; l++) thirdSemesterGrades0.Add(new Grade(random.Next(4, 10)));
                List<Grade> firstSemesterGrades1 = new List<Grade>();
                for (int j = 0; j < 5; j++) firstSemesterGrades1.Add(new Grade(random.Next(4, 10)));
                List<Grade> secondSemesterGrades1 = new List<Grade>();
                for (int k = 0; k < 5; k++) secondSemesterGrades1.Add(new Grade(random.Next(4, 10)));
                List<Grade> thirdSemesterGrades1 = new List<Grade>();
                for (int l = 0; l < 5; l++) thirdSemesterGrades1.Add(new Grade(random.Next(4, 10)));

                students2.Add(new Student($"Vardas{i + 1}", $"Vardaitis{i + 1}", $"200{random.Next(0, 9)}-{random.Next(1, 12)}-{random.Next(1, 31)}", "Vyras", firstSemesterGrades0, secondSemesterGrades0, thirdSemesterGrades0));
                students2.Add(new Student($"Varde{i + 1}", $"Vardaite{i + 1}", $"199{random.Next(1, 9)}-{random.Next(1, 12)}-{random.Next(1, 31)}", "Moteris", firstSemesterGrades1, secondSemesterGrades1, thirdSemesterGrades1));

            }
            List<Student> students3 = new List<Student>();

            for (int i = 0; i < 5; i++)
            {

                List<Grade> firstSemesterGrades0 = new List<Grade>();
                for (int j = 0; j < 5; j++) firstSemesterGrades0.Add(new Grade(random.Next(4, 10)));
                List<Grade> secondSemesterGrades0 = new List<Grade>();
                for (int k = 0; k < 5; k++) secondSemesterGrades0.Add(new Grade(random.Next(4, 10)));
                List<Grade> thirdSemesterGrades0 = new List<Grade>();
                for (int l = 0; l < 5; l++) thirdSemesterGrades0.Add(new Grade(random.Next(4, 10)));
                List<Grade> firstSemesterGrades1 = new List<Grade>();
                for (int j = 0; j < 5; j++) firstSemesterGrades1.Add(new Grade(random.Next(4, 10)));
                List<Grade> secondSemesterGrades1 = new List<Grade>();
                for (int k = 0; k < 5; k++) secondSemesterGrades1.Add(new Grade(random.Next(4, 10)));
                List<Grade> thirdSemesterGrades1 = new List<Grade>();
                for (int l = 0; l < 5; l++) thirdSemesterGrades1.Add(new Grade(random.Next(4, 10)));

                students3.Add(new Student($"Vardas{i + 1}", $"Vardaitis{i + 1}", $"200{random.Next(0, 9)}-{random.Next(1, 12)}-{random.Next(1, 31)}", "Vyras", firstSemesterGrades0, secondSemesterGrades0, thirdSemesterGrades0));
                students3.Add(new Student($"Varde{i + 1}", $"Vardaite{i + 1}", $"199{random.Next(1, 9)}-{random.Next(1, 12)}-{random.Next(1, 31)}", "Moteris", firstSemesterGrades1, secondSemesterGrades1, thirdSemesterGrades1));

            }
            List<Student> students4 = new List<Student>();

            for (int i = 0; i < 5; i++)
            {

                List<Grade> firstSemesterGrades0 = new List<Grade>();
                for (int j = 0; j < 5; j++) firstSemesterGrades0.Add(new Grade(random.Next(4, 10)));
                List<Grade> secondSemesterGrades0 = new List<Grade>();
                for (int k = 0; k < 5; k++) secondSemesterGrades0.Add(new Grade(random.Next(4, 10)));
                List<Grade> thirdSemesterGrades0 = new List<Grade>();
                for (int l = 0; l < 5; l++) thirdSemesterGrades0.Add(new Grade(random.Next(4, 10)));
                List<Grade> firstSemesterGrades1 = new List<Grade>();
                for (int j = 0; j < 5; j++) firstSemesterGrades1.Add(new Grade(random.Next(4, 10)));
                List<Grade> secondSemesterGrades1 = new List<Grade>();
                for (int k = 0; k < 5; k++) secondSemesterGrades1.Add(new Grade(random.Next(4, 10)));
                List<Grade> thirdSemesterGrades1 = new List<Grade>();
                for (int l = 0; l < 5; l++) thirdSemesterGrades1.Add(new Grade(random.Next(4, 10)));

                students4.Add(new Student($"Vardas{i + 1}", $"Vardaitis{i + 1}", $"200{random.Next(0, 9)}-{random.Next(1, 12)}-{random.Next(1, 31)}", "Vyras", firstSemesterGrades0, secondSemesterGrades0, thirdSemesterGrades0));
                students4.Add(new Student($"Varde{i + 1}", $"Vardaite{i + 1}", $"199{random.Next(1, 9)}-{random.Next(1, 12)}-{random.Next(1, 31)}", "Moteris", firstSemesterGrades1, secondSemesterGrades1, thirdSemesterGrades1));

            }
            List<Student> students5 = new List<Student>();

            for (int i = 0; i < 5; i++)
            {

                List<Grade> firstSemesterGrades0 = new List<Grade>();
                for (int j = 0; j < 5; j++) firstSemesterGrades0.Add(new Grade(random.Next(4, 10)));
                List<Grade> secondSemesterGrades0 = new List<Grade>();
                for (int k = 0; k < 5; k++) secondSemesterGrades0.Add(new Grade(random.Next(4, 10)));
                List<Grade> thirdSemesterGrades0 = new List<Grade>();
                for (int l = 0; l < 5; l++) thirdSemesterGrades0.Add(new Grade(random.Next(4, 10)));
                List<Grade> firstSemesterGrades1 = new List<Grade>();
                for (int j = 0; j < 5; j++) firstSemesterGrades1.Add(new Grade(random.Next(4, 10)));
                List<Grade> secondSemesterGrades1 = new List<Grade>();
                for (int k = 0; k < 5; k++) secondSemesterGrades1.Add(new Grade(random.Next(4, 10)));
                List<Grade> thirdSemesterGrades1 = new List<Grade>();
                for (int l = 0; l < 5; l++) thirdSemesterGrades1.Add(new Grade(random.Next(4, 10)));

                students5.Add(new Student($"Vardas{i + 1}", $"Vardaitis{i + 1}", $"200{random.Next(0, 9)}-{random.Next(1, 12)}-{random.Next(1, 31)}", "Vyras", firstSemesterGrades0, secondSemesterGrades0, thirdSemesterGrades0));
                students5.Add(new Student($"Varde{i + 1}", $"Vardaite{i + 1}", $"199{random.Next(1, 9)}-{random.Next(1, 12)}-{random.Next(1, 31)}", "Moteris", firstSemesterGrades1, secondSemesterGrades1, thirdSemesterGrades1));

            }

            List<Class> classesList = new List<Class>();
            classesList.Add(new Class("Klase1", students));
            classesList.Add(new Class("Klase2", students1));
            classesList.Add(new Class("Klase3", students2));
            classesList.Add(new Class("Klase4", students3));
            classesList.Add(new Class("Klase5", students4));
            classesList.Add(new Class("Klase6", students5));

            School school = new School("Mokykla1", "Adresas1", "+370-654-32-101", "mokykla1@mokykla1.lt", classesList);
            School school1 = new School("Mokykla2", "Adresas2", "+370-654-45-678", "mokykla2@mokykla2.lt", classesList);
            School school2 = new School("Mokykla3", "Adresas3", "+370-654-44-555", "mokykla3@mokykla3.lt", classesList);

            List<School> schoolsList = new List<School>();
            schoolsList.Add(school);
            schoolsList.Add(school1);
            schoolsList.Add(school2);

            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(schoolsList, options);

            File.WriteAllText(@"..\..\..\..\DataFiles\SchoolsData.json", jsonString);
        }
    }
}
