using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MiliukovLO.Sprint6.Task5.V15.Lib
{
    public class DataService : ISprint6Task5V15
    {
        public double[] LoadFromDataFile(string path)
        {
            int len = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (Convert.ToDouble(line) >= 2 && Convert.ToDouble(line) <= 7)
                    {
                        len++;
                    }
                }
            }
            double[] result = new double[len];
            int index = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (Convert.ToDouble(line) >= 2 && Convert.ToDouble(line) <= 7)
                    {
                        result[index] = Convert.ToDouble(line);
                        index++;
                    }
                }
            }
            return result;

        }
    }
}
