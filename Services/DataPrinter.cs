using main.Business;
using main.DataAccess;
using System;
using System.Collections.Generic;

namespace Services
{
    public class DataPrinter
    {
        public void PrintDataFile()
        {
            SchoolRepo schoolRepo = new SchoolRepo();
            Calculator calculator = new Calculator();

            List<School> schoolsList = schoolRepo.RetrieveSchoolsList();

            for (int i = 0; i < schoolsList.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("------------------------------------------------------");
                Console.ResetColor();
                Console.WriteLine($" SchoolName: {schoolsList[i].Name}");
                Console.WriteLine($" Address: {schoolsList[i].Address}");
                Console.WriteLine($" PhoneNumber: {schoolsList[i].PhoneNumber}");
                Console.WriteLine($" Email: {schoolsList[i].Email}");
                Console.WriteLine($" Classes Total: {schoolsList[i].Classes.Count}");
                int totalStudents = 0;
                for (int j = 0; j < schoolsList[i].Classes.Count; j++)
                {
                    totalStudents += schoolsList[i].Classes[j].Students.Count;
                }
                Console.WriteLine($" Students Total: {totalStudents}");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("------------------------------------------------------");
                Console.ResetColor();

                for (int j = 0; j < schoolsList[i].Classes.Count; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("---------------------------------");
                    Console.ResetColor();
                    Console.WriteLine($"  Class: {schoolsList[i].Classes[j].Name}{j + 1}");
                    Console.WriteLine($"  Students in Class: {schoolsList[i].Classes[j].Students.Count}");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("---------------------------------");
                    Console.ResetColor();

                    for (int k = 0; k < schoolsList[i].Classes[j].Students.Count; k++)
                    {
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine($"     Student Name: {schoolsList[i].Classes[j].Students[k].FirstName}");
                        Console.WriteLine($"     StudentSurname: {schoolsList[i].Classes[j].Students[k].LastName}");
                        Console.WriteLine($"     Gender: {schoolsList[i].Classes[j].Students[k].Gender}");
                        int sem1 = calculator.CalculateSemesterAverage(schoolsList, i, j, k, 1);
                        int sem2 = calculator.CalculateSemesterAverage(schoolsList, i, j, k, 2);
                        int sem3 = calculator.CalculateSemesterAverage(schoolsList, i, j, k, 3);
                        Console.WriteLine($"        1st semester average: {sem1}");
                        Console.WriteLine($"        2nd semester average: {sem2}");
                        Console.WriteLine($"        3rd semester average: {sem3}");
                        Console.WriteLine($"        Year average: {calculator.CalculateYearAverage(sem1, sem2, sem3)}");
                        Console.WriteLine("---------------------------------");

                    }
                }
            }
        }
    }
}
