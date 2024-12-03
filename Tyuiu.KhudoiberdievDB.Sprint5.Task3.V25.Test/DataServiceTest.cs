using Tyuiu.KhudoiberdievDB.Sprint5.Task3.V25.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint5.Task3.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\user\AppData\Local\Temp\OutPutFileTask3.bin";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}