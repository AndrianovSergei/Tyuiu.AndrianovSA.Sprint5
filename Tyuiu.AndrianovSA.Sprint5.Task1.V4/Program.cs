using System.IO;
using Tyuiu.AndrianovSA.Sprint5.Task1.V4.Lib;

namespace Tyuiu.AndrianovSA.Sprint5.Task1.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            int startValue = -5;
            int stopValue = 5;

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Андрианов С. А. | ИИПб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Андрианов Сергей Александрович | ИИПб-26-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция, произвести табулирование на заданном диапазоне [-5; 5]    *");
            Console.WriteLine("* с шагом 1. Результат сохранить в текстовый файл OutPutFileTask1.txt и   *");
            Console.WriteLine("* вывести на консоль в таблицу. Значения округлить до двух знаков.        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("Файл сохранен по пути: " + res);
            Console.WriteLine();

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |   f(x)   |");
            Console.WriteLine("+----------+----------+");

            string[] lines = File.ReadAllLines(res);

            int x = startValue;
            foreach (string line in lines)
            {
                Console.WriteLine($"|{x,5:d}     |  {line,6}  |");
                x++;
            }
            Console.WriteLine("+----------+----------+");

            Console.ReadKey();
        }
    }
}