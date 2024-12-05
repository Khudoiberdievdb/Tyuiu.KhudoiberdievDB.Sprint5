using System.IO;
using Tyuiu.KhudoiberdievDB.Sprint5.Task7.V1.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint5.Task7.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Худойбердиев Д. Б. | ИСПБ 24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Худойбердиев Далер Бахритдинович | ИСПБ 24-1                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Удалить все цифры из файла. Полученный результат сохранить в файл       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = @"C:\DataSprint5\InPutDataFileTask7V1.txt";
            string pathSaveFile = @"C:\DataSprint5\OutPutDataFileTask7V1.txt";
            Console.WriteLine("Данные находятся в файле :" + path);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine(" Находится в файле: " + pathSaveFile);
            Console.ReadKey();


        }
    }
}
