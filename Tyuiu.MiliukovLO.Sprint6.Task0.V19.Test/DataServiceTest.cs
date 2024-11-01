using Tyuiu.MiliukovLO.Sprint6.Task0.V19.Lib;

namespace Tyuiu.MiliukovLO.Sprint6.Task0.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            int x = 3;
            Assert.AreEqual(1, ds.Calculate(x));
        }
    }
}