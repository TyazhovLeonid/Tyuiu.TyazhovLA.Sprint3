using Tyuiu.TyazhovLA.Sprint3.Task2.V9.Lib;
namespace Tyuiu.TyazhovLA.Sprint3.Task2.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var ds = new DataService();
            int value = 5;
            int startValue = 1, stopValue = 10;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            Assert.AreEqual(res, res);
        }
    }
}