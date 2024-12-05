using Tyuiu.KhudoiberdievDB.Sprint5.Task6.V19.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint5.Task6.V19
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
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Худойбердиев Далер Бахритдинович | ИСПБ 24-1                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Подсчитать сколько двузначных чисел в файле                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = @"C:\DataSprint5\InPutDataFileTask6V19.txt";
            Console.WriteLine("Данные находятся в файле :" + path);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int count = ds.LoadFromDataFile(path);
            Console.WriteLine("Число двузначных чисел : " + count  );
            Console.ReadKey();
        }
    }
}
