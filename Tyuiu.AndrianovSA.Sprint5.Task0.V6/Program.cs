using System.IO;
using Tyuiu.AndrianovSA.Sprint5.Task0.V6.Lib;

namespace Tyuiu.AndrianovSA.Sprint5.Task0.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 3; // Значение из условия

            Console.Title = "Спринт #5 | Выполнил: Андрианов С. А. | ИИПб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Андрианов Сергей Александрович | ИИПб-26-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение, вычислить его значение при x = 3, результат сохранить   *");
            Console.WriteLine("* в текстовый файл OutPutFileTask0.txt и вывести на консоль.              *");
            Console.WriteLine("* Округлить до трёх знаков после запятой.                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("x = " + x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            // Вызов метода, который посчитает и создаст файл
            string res = ds.SaveToFileTextData(x);

            Console.WriteLine("Файл сохранен по пути: ");
            Console.WriteLine(res);

            // Чтобы выполнить условие "вывести на консоль", можно просто прочитать записанное из файла
            string fileContent = File.ReadAllText(res);
            Console.WriteLine("Значение y = " + fileContent);

            Console.ReadKey();
        }
    }
}