using Tyuiu.MiliukovLO.Sprint6.Task7.V2.Lib;

namespace Tyuiu.MiliukovLO.Sprint6.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            Assert.AreEqual(555, ds.GetMatrix("./InPutDataFileTask7V2.csv")[1,0]);
        }
    }
}