using Tyuiu.KhudoiberdievDB.Sprint5.Task6.V19.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint5.Task6.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V19.txt";
            int wait = 3;
            int res = ds.LoadFromDataFile(path);
            Assert.AreEqual(wait, res);

        }




        [TestMethod]
        public void ValidFileExist()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V19.txt";
            FileInfo fl = new FileInfo(path);
            bool fe = fl.Exists;
            bool wait = true;
            Assert.AreEqual(fe, wait);
        }

    }
}
