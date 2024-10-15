using Tyuiu.KhrapkoDD.Sprint2.Task5.V4.Lib;

namespace Tyuiu.KhrapkoDD.Sprint2.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            Assert.AreEqual("пики", ds.CardSuit(1));
            Assert.AreEqual("трефы", ds.CardSuit(2));
            Assert.AreEqual("бубны", ds.CardSuit(3));
            Assert.AreEqual("червы", ds.CardSuit(4));

            Assert.ThrowsException<ArgumentException > (() =>
            { ds.CardSuit(5); });
            Assert.ThrowsException<ArgumentException > (() =>
            { ds.CardSuit(-1); });
        }
    }
}