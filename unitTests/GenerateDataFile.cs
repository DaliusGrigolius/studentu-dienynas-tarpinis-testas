using Microsoft.VisualStudio.TestTools.UnitTesting;
using Serializer;
using System.IO;
using System.Linq;

namespace unitTests
{
    [TestClass]
    public class GenerateDataFile
    {
        [TestMethod]
        public void GenerateDataFile_CreatesDataTxtFile()
        {
            SerializeData serializeData = new SerializeData();
            serializeData.GenerateDataFile();

            var actual = Directory.EnumerateFileSystemEntries(@$"..\..\..\..\DataFiles\SavedDataTxt\").Any();
            var expected = true;

            Assert.AreEqual(expected, actual);
        }
    }
}