using System.IO; // Обязательно для работы с файлами и путями
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AndrianovSA.Sprint5.Task0.V6.Lib
{
    public class DataService : ISprint5Task0V6
    {
        public string SaveToFileTextData(int x)
        {
            // 1. Создаем путь к файлу во временной папке системы (Temp)
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");

            // 2. Вычисляем значение по формуле
            double y = (double)x / Math.Sqrt(Math.Pow(x, 2) + x);

            // 3. Округляем до 3 знаков после запятой
            y = Math.Round(y, 3);

            // 4. Создаем файл и записываем в него результат (преобразованный в строку)
            File.WriteAllText(path, y.ToString());

            // Возвращаем путь к созданному файлу
            return path;
        }
    }
}