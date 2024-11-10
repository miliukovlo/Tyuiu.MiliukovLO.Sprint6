using Tyuiu.MiliukovLO.Sprint6.Task4.V19.Lib;

namespace Tyuiu.MiliukovLO.Sprint6.Task4.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            Assert.AreEqual(23.61, ds.GetMassFunction(-5, 5)[0]);
        }
    }
}