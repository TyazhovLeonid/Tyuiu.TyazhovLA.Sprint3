using Tyuiu.TyazhovLA.Sprint3.Task5.V10.Lib;
namespace Tyuiu.TyazhovLA.Sprint3.Task5.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 1; int y = 3; int z = 1; int d = 10; int e=5;
            var res = ds.GetSumSumSeries(e,x,y,z,d);
            Assert.AreEqual(1, res);
        }
    }
}