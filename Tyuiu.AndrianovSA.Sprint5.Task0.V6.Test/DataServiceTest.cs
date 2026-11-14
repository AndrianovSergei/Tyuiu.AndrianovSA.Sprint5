using System.IO;
using Tyuiu.AndrianovSA.Sprint5.Task0.V6.Lib;

namespace Tyuiu.AndrianovSA.Sprint5.Task0.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");

            // Вызываем метод, чтобы он создал файл (по условию x = 3)
            ds.SaveToFileTextData(3);

            // Проверяем, существует ли файл
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            Assert.AreEqual(true, fileExists);
        }
    }
}