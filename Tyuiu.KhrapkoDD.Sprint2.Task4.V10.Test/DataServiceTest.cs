using Tyuiu.KhrapkoDD.Sprint2.Task4.V10.Lib;
namespace Tyuiu.KhrapkoDD.Sprint2.Task4.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 3;
            double res = ds.Calculate(x, y);
            double wait = 1.333;
            Assert.AreEqual(res, wait);
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 9;
            double res = ds.Calculate(x, y);
            double wait = 24;
            Assert.AreEqual(res, wait);
        }
    }
}