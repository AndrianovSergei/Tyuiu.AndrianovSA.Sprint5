using System.IO;
using Tyuiu.AndrianovSA.Sprint5.Task2.V11.Lib;

namespace Tyuiu.AndrianovSA.Sprint5.Task2.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Андрианов С. А. | ИИПб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Андрианов Сергей Александрович | ИИПб-26-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3, заполненный с клавиатуры.    *");
            Console.WriteLine("* Заменить нечетные элементы массива на 0. Результат сохранить в файл     *");
            Console.WriteLine("* OutPutFileTask2.csv и вывести на консоль.                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] matrix = new int[3, 3];

            Console.WriteLine("Введите элементы массива (3x3):");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Введите элемент [{i},{j}]: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nМассив:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(matrix);

            Console.WriteLine("Файл сохранен по пути: " + res);
            Console.WriteLine();
            Console.WriteLine("Созданный массив (с нулями вместо нечетных чисел):");

            string[] lines = File.ReadAllLines(res);
            foreach (string line in lines)
            {
                string[] elements = line.Split(';');
                foreach (string el in elements)
                {
                    Console.Write($"{el} \t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}