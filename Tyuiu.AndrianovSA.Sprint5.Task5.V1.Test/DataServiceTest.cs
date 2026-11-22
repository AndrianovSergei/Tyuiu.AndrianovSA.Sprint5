using System.IO;
using Tyuiu.AndrianovSA.Sprint5.Task5.V1.Lib;

namespace Tyuiu.AndrianovSA.Sprint5.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = Path.Combine(@"C:\DataSprint5", "InPutDataFileTask5V1.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            Assert.AreEqual(true, fileExists);
        }
    }
}