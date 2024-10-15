using Tyuiu.KhrapkoDD.Sprint2.Task0.V1.Lib;

namespace Tyuiu.KhrapkoDD.Sprint2.Task0.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetComparisonResults()
        {
            DataService ds = new DataService();
            int x = 233;
            int y = 122;
            bool[] res = new bool[6];
            res = ds.GetComparisonResults(x, y);
            bool[] wait = new bool[6] { false, true, false, true, false, true };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}