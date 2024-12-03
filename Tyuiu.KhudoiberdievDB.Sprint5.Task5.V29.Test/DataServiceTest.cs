using System.IO;

using Tyuiu.KhudoiberdievDB.Sprint5.Task5.V29.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint5.Task5.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V29.txt";
            FileInfo fl = new FileInfo(path);
            bool fe = fl.Exists;
            bool wait = true;
            Assert.AreEqual(fe, wait);
        }
    }
}