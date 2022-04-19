using System;

namespace Serializer
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
            while (b < 7)
            {
                number += nums[rnd.Next(nums.Length)];
                b++;
            }
            return $"+3706{number}";
        }

        public string GenerateRandomBirthDate()
        {
            Random rnd = new Random();
            return $"199{rnd.Next(1, 9)}-{rnd.Next(1, 12)}-{rnd.Next(1, 31)}";
        }

        public string GenerateRandomGender()
        {
            Random rnd = new Random();
            string[] genders = { "Male", "Female" };

            return $"{genders[rnd.Next(0, 2)]}";
        }

        public int GenerateRandomGrade()
        {
            Random rnd = new Random();
            return rnd.Next(2, 11);
        }
    }
}
