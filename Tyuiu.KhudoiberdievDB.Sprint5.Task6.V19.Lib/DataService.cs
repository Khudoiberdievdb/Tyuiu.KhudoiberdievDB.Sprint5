using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KhudoiberdievDB.Sprint5.Task6.V19.Lib
{
    public class DataService : ISprint5Task6V19
    {
        public int LoadFromDataFile(string path)
        {
            string data = File.ReadAllText(path);
            string[] strings = data.Split(' ');
            int count = 0;
            foreach (string s in strings)
            {

                int a;
                int.TryParse(s, out a);
                if (a > 9 && a <99)
                {
                    count++;
                }

            }
            return count;


        }

    }
}
