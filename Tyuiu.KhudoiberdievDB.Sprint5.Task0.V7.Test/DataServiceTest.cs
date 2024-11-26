using System.IO;
using Tyuiu.KhudoiberdievDB.Sprint5.Task0.V7.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint5.Task0.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\user\source\repos\Tyuiu.KhudoiberdievDB.Sprint5\Tyuiu.KhudoiberdievDB.Sprint5.Task0.V7\bin\Debug\net8.0\OutPutFileTask0.txt";
            
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}