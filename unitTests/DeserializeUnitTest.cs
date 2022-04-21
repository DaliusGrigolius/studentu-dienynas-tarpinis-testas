using Deserializer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace unitTests
{
    [TestClass]
    public class DeserializeUnitTest
    {
        [TestMethod]
        public void DeserializeDataFile_ReturnsListThatHasMoreThanOneSchool()
        {
            DeserializeData deserializeData = new DeserializeData();
            deserializeData.DeserializeDataFile();

            var actual = deserializeData.DeserializeDataFile().Count > 1;
            var expected = true;

            Assert.AreEqual(expected, actual);
        }
    }
}
