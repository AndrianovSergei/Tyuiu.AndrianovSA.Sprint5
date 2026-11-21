using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AndrianovSA.Sprint5.Task4.V13.Lib
{
    public class DataService : ISprint5Task4V13
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path).Trim();
            double x = double.Parse(strX.Replace(",", "."), CultureInfo.InvariantCulture);

            double res = Math.Cos(x) + (Math.Pow(x, 2) / 2);
            return Math.Round(res, 3);
        }
    }
}