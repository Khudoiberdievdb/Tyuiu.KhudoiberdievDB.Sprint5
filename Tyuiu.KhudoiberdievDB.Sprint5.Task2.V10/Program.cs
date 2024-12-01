using System.IO;
using Tyuiu.KhudoiberdievDB.Sprint5.Task2.V10.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint5.Task2.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Title = "Спринт #5 | Худойбердиев Д. Б. | ИСПБ 24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Худойбердиев Далер Бахритдинович | ИСПБ 24-1                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Дана матрица, сохранить результат и вывести в текстовый файл            *");
            Console.WriteLine("* с клавиатуры. Заменить положительные элементы массива на 1,             *");
            Console.WriteLine("* отрицательные на 0. Результат сохранить в файл OutPutFileTask2.csv и    *");
            Console.WriteLine("* вывести на консоль.                                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            int[,] matrix = new int [3,3] { { 4, 3, -3},
                              {- 5, -6, -3},
                              {- 7, -9, -9}};
            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.GetUpperBound(1) + 1 ;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                
                Console.WriteLine();
            }
            DataService ds = new DataService();
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.SaveToFileTextData(matrix);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();






        }
    }
}
