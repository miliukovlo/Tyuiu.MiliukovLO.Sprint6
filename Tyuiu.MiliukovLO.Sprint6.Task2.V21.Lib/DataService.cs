using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MiliukovLO.Sprint6.Task2.V21.Lib
{
    public class DataService : ISprint6Task2V21
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] result = new double[11];
            int index = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                double complete = Math.Cos(i) + (Math.Cos(i) / (i + 2)) - 3 * i;
                if (i == 0)
                {
                    complete = 0;
                }
                result[index] = Math.Round(complete,2);
                index++;
            }
            return result;
        }
    }
}
