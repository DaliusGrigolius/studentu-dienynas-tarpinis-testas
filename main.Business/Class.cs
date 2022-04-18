using System.Collections.Generic;

namespace main.Business
{
    public class Class
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; }

        public Class(string name, List<Student> students)
        {
            Name = name;
            Students = students;
        }
    }
}