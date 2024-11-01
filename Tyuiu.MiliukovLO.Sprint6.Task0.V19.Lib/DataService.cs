using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MiliukovLO.Sprint6.Task0.V19.Lib
{
    public class DataService : ISprint6Task0V19
    {
        public double Calculate(int x)
        {
            double oneOfFour = -(1.0 / 4);
            double Coube = Math.Pow(x, 3);
            double threeOnSquare = 3 * Math.Pow(x, 2);
            double result = Math.Round(oneOfFour * (Coube - threeOnSquare + 4), 3);
            return result;
        }
    }
}
