using System.IO;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AndrianovSA.Sprint5.Task7.V30.Lib
{
    public class DataService : ISprint5Task7V30
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V30.txt");

            if (File.Exists(pathSaveFile))
            {
                File.Delete(pathSaveFile);
            }

            string content = File.ReadAllText(path);
            string result = Regex.Replace(content, @"(?<!\d)\d(?!\d)", "9");

            File.WriteAllText(pathSaveFile, result);

            return pathSaveFile;
        }
    }
}