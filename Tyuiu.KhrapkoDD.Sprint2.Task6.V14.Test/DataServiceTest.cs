using Tyuiu.KhrapkoDD.Sprint2.Task6.V14.Lib;
namespace Tyuiu.KhrapkoDD.Sprint2.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual("�����������", ds.FindDateOfNextDay(1, 1));
            Assert.AreEqual("�������", ds.FindDateOfNextDay(2, 1));
            Assert.AreEqual("�������", ds.FindDateOfNextDay(6, 1));
            Assert.AreEqual("�������", ds.FindDateOfNextDay(6, 7));
            Assert.AreEqual("�������", ds.FindDateOfNextDay(360, 7));
        }
    }
}