using main.Business;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Deserializer
{
    public class DeserializeData
    {
        public List<School> DeserializeDataFile()
        {
            var path = @"..\..\..\..\DataFiles\SchoolsData.json";
            var text = File.ReadAllText(path);
            List<School> schoolData = JsonSerializer.Deserialize<List<School>>(text);

            return schoolData;
        }
    }
}
