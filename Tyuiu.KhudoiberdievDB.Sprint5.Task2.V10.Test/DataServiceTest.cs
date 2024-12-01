using System.IO;

using Tyuiu.KhudoiberdievDB.Sprint5.Task2.V10.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint5.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\user\AppData\Local\Temp\OutPutFileTask2.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}