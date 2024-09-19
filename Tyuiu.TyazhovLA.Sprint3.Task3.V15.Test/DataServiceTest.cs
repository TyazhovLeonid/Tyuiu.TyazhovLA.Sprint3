using Tyuiu.TyazhovLA.Sprint3.Task3.V15.Lib;
namespace Tyuiu.TyazhovLA.Sprint3.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var ds = new DataService();
            char item = 'm';
            string x = "lrmmse mg sermmmrt";
            int res = ds.GetMinCharCount(x, item);
            Assert.AreEqual(3, res);
        }
    }
}