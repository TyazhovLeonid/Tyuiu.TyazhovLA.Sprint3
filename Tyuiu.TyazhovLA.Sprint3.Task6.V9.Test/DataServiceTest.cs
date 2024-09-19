using Tyuiu.TyazhovLA.Sprint3.Task6.V9.Lib;
namespace Tyuiu.TyazhovLA.Sprint3.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 10; int y = 19;
            var res = ds.GetSumTheDivisors(x, y);
            Assert.AreEqual(res, res);
        }
    }
}