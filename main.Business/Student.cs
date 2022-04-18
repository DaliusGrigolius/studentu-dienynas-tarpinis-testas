using System.Collections.Generic;

namespace main.Business
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public string Gender { get; set; }
        public List<Grade> FirstSemesterGrades { get; set; }
        public List<Grade> SecondSemesterGrades { get; set; }
        public List<Grade> ThirdSemesterGrades { get; set; }

        public Student(string firstName, string lastName, string birthDate, string gender, List<Grade> firstSemesterGrades, List<Grade> secondSemesterGrades, List<Grade> thirdSemesterGrades)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Gender = gender;
            FirstSemesterGrades = firstSemesterGrades;
            SecondSemesterGrades = secondSemesterGrades;
            ThirdSemesterGrades = thirdSemesterGrades;
        }
    }
}
