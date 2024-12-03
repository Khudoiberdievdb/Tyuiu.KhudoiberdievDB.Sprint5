using System.IO;

using Tyuiu.KhudoiberdievDB.Sprint5.Task4.V8.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint5.Task4.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V8.txt";
            FileInfo fl = new FileInfo(path);
            bool fe = fl.Exists;
            bool wait = true;
            Assert.AreEqual(fe, wait);

        }
    }
}