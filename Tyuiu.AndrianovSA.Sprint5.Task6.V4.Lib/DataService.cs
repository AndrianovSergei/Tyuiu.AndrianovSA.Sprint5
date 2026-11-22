using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AndrianovSA.Sprint5.Task6.V4.Lib
{
    public class DataService : ISprint5Task6V4
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            string content = File.ReadAllText(path);

            foreach (char c in content)
            {
                if ((c >= 'А' && c <= 'Я') || c == 'Ё')
                {
                    count++;
                }
            }

            return count;
        }
    }
}