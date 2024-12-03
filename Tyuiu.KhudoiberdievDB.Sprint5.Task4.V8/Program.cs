using System.IO;
using Tyuiu.KhudoiberdievDB.Sprint5.Task4.V8.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint5.Task4.V8
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
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Худойбердиев Далер Бахритдинович | ИСПБ 24-1                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить значение по формуле  и вернуть полученный результат на консоль*");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = @"C:\DataSprint5\InPutDataFileTask4V8.txt";

            Console.WriteLine("Данный находятся в файле :" + path );
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double result = ds.LoadFromDataFile(path);
            Console.WriteLine(result);
            Console.ReadKey();


        }
    }
}
