using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MiliukovLO.Sprint6.Task3.V21.Lib
{
    public class DataService : ISprint6Task3V21
    {
        public int[,] Calculate(int[,] matrix)
        {
            int[,] result = matrix;
            int rows = result.GetUpperBound(0) + 1;
            int cols = result.Length / rows;
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < rows - i - 1; j++)
                {
                    if (result[j, 0] > result[j + 1, 0])
                    {
                            int temp = result[j, 0];
                            result[j, 0] = result[j + 1, 0];
                            result[j + 1, 0] = temp;
                    }
                }
            }
            return result;
        }
    }
}
