using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AndrianovSA.Sprint5.Task5.V1.Lib
{
    public class DataService : ISprint5Task5V1
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            string content = File.ReadAllText(path);
            string[] parts = content.Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string part in parts)
            {
                if (double.TryParse(part.Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out double number))
                {
                    if (number % 2 == 0)
                    {
                        res += number;
                    }
                }
            }

            return Math.Round(res, 3);
        }
    }
}