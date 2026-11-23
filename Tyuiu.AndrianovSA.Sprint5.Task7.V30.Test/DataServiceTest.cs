using System.IO;
using Tyuiu.AndrianovSA.Sprint5.Task7.V30.Lib;

namespace Tyuiu.AndrianovSA.Sprint5.Task7.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = Path.Combine(@"C:\DataSprint5", "InPutDataFileTask7V30.txt");
            DataService ds = new DataService();

            string resPath = ds.LoadDataAndSave(path);
            FileInfo fileInfo = new FileInfo(resPath);
            bool fileExists = fileInfo.Exists;

            Assert.AreEqual(true, fileExists);
        }
    }
}