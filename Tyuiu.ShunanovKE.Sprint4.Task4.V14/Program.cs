using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShunanovKE.Sprint4.Task4.V14.Lib;

namespace Tyuiu.ShunanovKE.Sprint4.Task4.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт#4 | Выполнил: Шунанов К. Е. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Шунанов Кирилл Ерболатович | ПКТб-23-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* заполненный значениями с клавиатуры в диапазоне от 1 до 8.              *");
            Console.WriteLine("* Заменить нечетные элементы массива на 0.                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите кол-во строк: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол-во столбцов: ");
            int cols = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[rows, cols]; 
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("Введите " + i + ", " + j + " элемент: ");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Массив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int[,] res = ds.Calculate(array);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(res[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
