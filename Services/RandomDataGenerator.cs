using main.Business;
using System;
using System.Collections.Generic;

namespace Services
{
    public class RandomDataGenerator
    {
        public string GenerateRandomFirstName(int length)
        {
            Random rnd = new Random();
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "r", "s", "t", "v" };
            string[] vowels = { "a", "e", "i", "o", "u", "y" };
            string Name = "";
            Name += consonants[rnd.Next(consonants.Length)].ToUpper();
            Name += vowels[rnd.Next(vowels.Length)];
            int b = 2;
            while (b < length)
            {
                Name += consonants[rnd.Next(consonants.Length)];
                b++;
                Name += vowels[rnd.Next(vowels.Length)];
                b++;
            }
            return Name;
        }

        public string GenerateRandomLastName(int length)
        {
            Random rnd = new Random();
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "r", "s", "t", "v" };
            string[] vowels = { "a", "e", "i", "o", "u", "y" };
            string Name = "";
            Name += consonants[rnd.Next(consonants.Length)].ToUpper();
            Name += vowels[rnd.Next(vowels.Length)];
            int b = 2;
            while (b < length)
            {
                Name += consonants[rnd.Next(consonants.Length)];
                b++;
                Name += vowels[rnd.Next(vowels.Length)];
                b++;
            }
            return Name;
        }

        public string GenerateRandomAddress(int length)
        {
            Random rnd = new Random();
            int house = rnd.Next(1, 150);
            int apartment = rnd.Next(1, 150);

            Random address = new Random();
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "r", "s", "t", "v" };
            string[] vowels = { "a", "e", "i", "o", "u", "y", "os", "as" };
            string Adress = "";
            Adress += consonants[address.Next(consonants.Length)].ToUpper();
            Adress += vowels[address.Next(vowels.Length)];
            int b = 2;
            while (b < length)
            {
                Adress += consonants[address.Next(consonants.Length)];
                b++;
                Adress += vowels[address.Next(vowels.Length)];
                b++;
            }
            return $"{Adress} str. House No.{house} Apartment No.{apartment}";
        }

        public string GenerateRandomEmail(int length)
        {
            Random rnd = new Random();
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "r", "s", "t", "v", "a", "e", "i", "o", "u", "y", "os", "as" };
            string[] nums = { "1", "2", "3", "4", "5", "6", "7", "8" };
            string email = "";
            email += consonants[rnd.Next(consonants.Length)];
            email += nums[rnd.Next(nums.Length)];
            int b = 2;
            while (b < length)
            {
                email += consonants[rnd.Next(consonants.Length)];
                b++;
                email += nums[rnd.Next(nums.Length)];
                b++;
            }
            return $"{email}@gmail.com";
        }

        public string GenerateRandomPhoneNumber()
        {
            Random rnd = new Random();
            string[] nums = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string number = "";
            number += nums[rnd.Next(nums.Length)];
            int b = 0;
            while (b < 6)
            {
                number += nums[rnd.Next(nums.Length)];
                b++;
            }
            return $"+3706{number}";
        }

        public string GenerateRandomBirthDate()
        {
            Random rnd = new Random();
            return $"199{rnd.Next(1, 10)}-{rnd.Next(1, 13)}-{rnd.Next(1, 32)}";
        }

        public string GenerateRandomGender()
        {
            Random rnd = new Random();
            string[] genders = { "Male", "Female" };

            return $"{genders[rnd.Next(0, 2)]}";
        }

        public List<Student> GenerateStudentsList()
        {
            List<Student> students = new List<Student>();
            Random random = new Random();
            int rndNum = random.Next(5, 31);
            for (int i = 0; i < rndNum; i++)
            {
                students.Add(new Student(GenerateRandomFirstName(5), GenerateRandomLastName(6), GenerateRandomBirthDate(), GenerateRandomGender(), GenerateGradesList(), GenerateGradesList(), GenerateGradesList()));
            }
            return students;
        }

        public List<Grade> GenerateGradesList()
        {
            List<Grade> grades = new List<Grade>();
            for (int i = 0; i < 5; i++)
            {
                Random rnd = new Random();
                grades.Add(new Grade(rnd.Next(4, 11)));
            }
            return grades;
        }

        public List<Class> GenerateClasses()
        {
            List<Class> classes = new List<Class>();
            Random random = new Random();
            int rndNum = random.Next(2, 16);
            for (int i = 0; i < rndNum; i++)
            {
                classes.Add(new Class(GenerateRandomFirstName(6), GenerateStudentsList()));
            }
            return classes;
        }

        public List<School> GenerateSchools()
        {
            List<School> schools = new List<School>();
            Random random = new Random();
            int rndNum = random.Next(2, 10);
            for (int i = 0; i < rndNum; i++)
            {
                schools.Add(new School(GenerateRandomFirstName(8), GenerateRandomAddress(7), GenerateRandomPhoneNumber(), GenerateRandomEmail(5), GenerateClasses()));
            }
            return schools;
        }

    }
}
