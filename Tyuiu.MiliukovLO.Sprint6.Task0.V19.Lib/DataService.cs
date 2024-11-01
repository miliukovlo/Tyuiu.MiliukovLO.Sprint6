using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MiliukovLO.Sprint6.Task0.V19.Lib
{
    public class DataService : ISprint6Task0V19
    {
        public double Calculate(int x)
        {
            return Math.Round((-(1 / 4) * ((Math.Pow(x, 3) - 3 * Math.Pow(x, 2) + 4))), 3);
        }
    }
}
