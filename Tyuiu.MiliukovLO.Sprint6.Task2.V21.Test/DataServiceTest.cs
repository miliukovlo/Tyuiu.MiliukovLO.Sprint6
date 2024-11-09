using Tyuiu.MiliukovLO.Sprint6.Task2.V21.Lib;

namespace Tyuiu.MiliukovLO.Sprint6.Task2.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            Assert.AreEqual(15.19, ds.GetMassFunction(-5, 5)[0]);
        }
    }
}