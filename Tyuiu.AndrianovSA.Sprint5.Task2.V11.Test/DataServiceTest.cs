using System.IO;
using Tyuiu.AndrianovSA.Sprint5.Task2.V11.Lib;

namespace Tyuiu.AndrianovSA.Sprint5.Task2.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");

            int[,] matrix = new int[3, 3] { { 4, 9, 3 }, { 5, 8, 8 }, { 5, 7, 5 } };

            ds.SaveToFileTextData(matrix);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            Assert.AreEqual(true, fileExists);
        }
    }
}