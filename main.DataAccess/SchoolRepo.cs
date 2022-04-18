using Deserializer;
using main.Business;
using System.Collections.Generic;

namespace main.DataAccess
{
    public class SchoolRepo
    {
        public List<School> Schools()
        {
            DeserializeData deserializeData = new DeserializeData();
            List<School> schoolsList = deserializeData.DeserializeDataFile();

            return schoolsList;
        }
    }
}
