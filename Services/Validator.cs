using main.DataAccess;
using System;

namespace Services
{
    public class Validator
    {
        SchoolRepo schoolRepo = new SchoolRepo();

        public bool IsSchoolIndexValid(int schoolIndex)
        {
            if (schoolIndex >= schoolRepo.RetrieveSchoolsList().Count || schoolIndex < 0)
            {
                Console.WriteLine($"klaidingai ivestas mokyklos indeksas. iveskite skaiciu nuo 0 iki {schoolRepo.RetrieveSchoolsList().Count - 1}");
                return false;
            }
            return true;
        }

        public bool IsClassIndexValid(int schoolIndex, int classIndex)
        {
            if (classIndex >= schoolRepo.RetrieveSchoolsList()[schoolIndex].Classes.Count || classIndex < 0)
            {
                Console.WriteLine($"klaidingai ivestas klases indeksas. iveskite skaiciu nuo 0 iki {schoolRepo.RetrieveSchoolsList()[schoolIndex].Classes.Count - 1}");
                return false;
            }
            return true;
        }

        public bool IsStudentIndexValid(int schoolIndex, int classIndex, int studentIndex)
        {
            if (studentIndex >= schoolRepo.RetrieveSchoolsList()[schoolIndex].Classes[classIndex].Students.Count || studentIndex < 0)
            {
                Console.WriteLine($"klaidingai ivestas studento indeksas. iveskite skaiciu nuo 0 iki {schoolRepo.RetrieveSchoolsList()[schoolIndex].Classes[classIndex].Students.Count - 1}");
                return false;
            }
            return true;
        }

        public bool IsSemesterNumberValid(int semesterNumber)
        {
            if (semesterNumber < 1 || semesterNumber > 3)
            {
                Console.WriteLine("semestro skaicius turi buti nuo 1 iki 3");
                return false;
            }
            return true;
        }
    }
}
