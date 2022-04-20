using Services;
using System;
using System.IO;
using System.Text.Json;

namespace Serializer
{
    public class SerializeData
    {
        public void GenerateDataFile()
        {
            RandomDataGenerator rndDataGen = new RandomDataGenerator();

            Random random = new Random();

            string rndNum = random.Next(1, 1000).ToString();
            string rndNum1 = random.Next(1, 1000).ToString();
            int i = random.Next(1, 3) == 1 ? random.Next(65, 91) : random.Next(97, 123);
            char anyLetter = Convert.ToChar(i);

            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(rndDataGen.GenerateSchools(), options);

            File.WriteAllText(@"..\..\..\..\DataFiles\SchoolsData.json", jsonString);
            File.WriteAllText(@$"..\..\..\..\DataFiles\SavedDataTxt\SchoolsData{rndNum}{anyLetter}{rndNum1}.txt", jsonString);
        }
    }
}
