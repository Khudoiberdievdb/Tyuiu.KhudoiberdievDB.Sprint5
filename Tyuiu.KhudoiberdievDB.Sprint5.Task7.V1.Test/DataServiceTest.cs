using System.IO;

using Tyuiu.KhudoiberdievDB.Sprint5.Task7.V1.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint5.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckValidExists()
        {
            string path =  @"C:\Users\user\AppData\Local\Temp\OutPutFileTask7V1.txt";

            FileInfo fl = new FileInfo(path);
            bool fe = fl.Exists;
            bool wait = true;
            Assert.AreEqual(fe, wait);
        }
    }
}