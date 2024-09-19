using Tyuiu.TyazhovLA.Sprint3.Task4.V16.Lib;
namespace Tyuiu.TyazhovLA.Sprint3.Task4.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5; int stopValue=5; 
            double res = ds.Calculate(startValue, stopValue);
            Assert.AreEqual(2.757,res);
        }
    }
}