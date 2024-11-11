using Tyuiu.MiliukovLO.Sprint6.Task6.V4.Lib;

namespace Tyuiu.MiliukovLO.Sprint6.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = "C:\\Users\\bibat\\source\\repos\\Tyuiu.MiliukovLO.Sprint6\\InPutDataTask6V4.txt";
            string wait = "SnBC nnndrM MNRjtbh RbvnKtNW UaZNpcgYjw";
            DataService ds = new();
            Assert.AreEqual(wait, ds.CollectTextFromFile("n", path));
        }
    }
}