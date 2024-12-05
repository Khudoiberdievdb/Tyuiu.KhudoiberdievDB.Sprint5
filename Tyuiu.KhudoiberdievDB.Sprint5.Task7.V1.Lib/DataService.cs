using System.IO;

using System.Reflection.Metadata;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.KhudoiberdievDB.Sprint5.Task7.V1.Lib
{
    public class DataService : ISprint5Task7V1
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutFileTask7V1.txt");

            if (!File.Exists(path))
            {
                throw new FileNotFoundException("Файл не найден.", path);
            }

            string data = File.ReadAllText(path);

            data = Regex.Replace(data, @"\d", "");

            data = data.Replace(".", "");

             

            File.WriteAllText(pathSaveFile, data);

            return pathSaveFile;

        }
    }
}
