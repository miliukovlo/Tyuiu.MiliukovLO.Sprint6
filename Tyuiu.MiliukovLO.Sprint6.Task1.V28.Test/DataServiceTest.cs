using Tyuiu.MiliukovLO.Sprint6.Task1.V28.Lib;

namespace Tyuiu.MiliukovLO.Sprint6.Task1.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            Assert.AreEqual(4.67, ds.GetMassFunction(-5, 5)[0]);
        }
    }
}