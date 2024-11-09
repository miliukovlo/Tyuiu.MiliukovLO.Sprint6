using Tyuiu.MiliukovLO.Sprint6.Task3.V21.Lib;

namespace Tyuiu.MiliukovLO.Sprint6.Task3.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            int[,] matrix = new int[5, 5]
{
                {26, -15, 7, 1, -4 },
                {14, 26, 22 ,17 ,27},
                {-8, 31, 22, 34, 4 },
                {-18, 16, -2, 16, 27},
                {5 , 2, -4, 16, 15 }
            };
            Assert.AreEqual(-18, ds.Calculate(matrix)[0,0]);
        }
    }
}