

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MiliukovLO.Sprint6.Task4.V19.Lib
{
    public class DataService : ISprint6Task4V19
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] result = new double[11];
            int index = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                double funcOfX = ((5 * i + 2.5)/(Math.Sin(i) - 2)) + 2;
                if (Math.Sin(i) - 2 == 0)
                {
                    result[index] = 0;
                } else
                {
                    result[index] = Math.Round(funcOfX,2);
                }
                index++;
            }
            return result;
        }
    }
}
