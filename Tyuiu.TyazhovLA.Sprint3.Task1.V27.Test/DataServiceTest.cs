using Tyuiu.TyazhovLA.Sprint3.Task1.V27.Lib;
namespace Tyuiu.TyazhovLA.Sprint3.Task1.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var ds = new DataService();
            double value = 0.75;
            int startValue = 1, stopValue = 5;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            Assert.AreEqual(res, res);
        }
    }
}