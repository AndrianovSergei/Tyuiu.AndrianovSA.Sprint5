using System.IO;
using Tyuiu.AndrianovSA.Sprint5.Task6.V4.Lib;

namespace Tyuiu.AndrianovSA.Sprint5.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = Path.Combine(@"C:\DataSprint5", "InPutDataFileTask6V4.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            Assert.AreEqual(true, fileExists);
        }
    }
}