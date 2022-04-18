using System.Collections.Generic;

namespace main.Business
{
    public class School
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public List<Class> Classes { get; set; }

        public School(string name, string address, string phoneNumber, string email, List<Class> classes)
        {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
            Classes = classes;
        }
    }
}
