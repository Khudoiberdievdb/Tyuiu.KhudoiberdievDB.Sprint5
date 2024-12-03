using System.IO;
using Tyuiu.KhudoiberdievDB.Sprint5.Task5.V29.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint5.Task5.V29
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
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Худойбердиев Далер Бахритдинович | ИСПБ 24-1                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Создать папку в ручную С:\\DataSprint5\\ и скопировать в неё файл) в    *");
            Console.WriteLine("* котором есть набор значений. Найти минимальное целое число в файле,     *");
            Console.WriteLine("* которое является двузначным числом. Полученный результат вывести на     *");
            Console.WriteLine("* консоль. У вещественных значений округлить до трёх знаков после запятой.*");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = @"C:\DataSprint5\InPutDataFileTask5V29.txt";
            Console.WriteLine("Данные находятся в файле :" + path);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double result = ds.LoadFromDataFile(path);
            Console.WriteLine("Минимально число : " + result);
            Console.ReadKey();


        }
    }
}
