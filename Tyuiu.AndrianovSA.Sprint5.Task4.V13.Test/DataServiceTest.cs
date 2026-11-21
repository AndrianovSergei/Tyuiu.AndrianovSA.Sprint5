using System.IO;
using Tyuiu.AndrianovSA.Sprint5.Task4.V13.Lib;

namespace Tyuiu.AndrianovSA.Sprint5.Task4.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = Path.Combine(@"C:\DataSprint5", "InPutDataFileTask4V13.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            Assert.AreEqual(true, fileExists);
        }
    }
}