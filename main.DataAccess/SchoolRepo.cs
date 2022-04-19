using Deserializer;
using main.Business;
using System.Collections.Generic;

namespace main.DataAccess
{
    public class SchoolRepo
    {
        private List<School> schoolsList { get; }

        public SchoolRepo()
        {
            DeserializeData deserializeData = new DeserializeData();
            schoolsList = deserializeData.DeserializeDataFile();
        }

        public List<School> RetrieveSchoolsList()
        {
            return schoolsList;
        }

        public School RetrieveSchool(int schoolIndex)
        {
            return schoolsList[schoolIndex];
        }
    }
}
