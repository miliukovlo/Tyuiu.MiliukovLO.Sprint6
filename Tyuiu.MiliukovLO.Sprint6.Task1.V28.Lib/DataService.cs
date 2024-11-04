using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MiliukovLO.Sprint6.Task1.V28.Lib
{
    public class DataService : ISprint6Task1V28
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] myDoubles = new double[11];

            for (int i = 0; i < 11; i++)
            {
                myDoubles[i] = Math.Round(Math.Cos(startValue + i) + ((4 * (startValue + i)) / 2) - Math.Sin(startValue + i) * (3 * (startValue + i)),2);
                if (startValue + i == 0)
                {
                    myDoubles[i] = 0;
                    continue;
                }
            }
            return myDoubles;
        }
    }
}