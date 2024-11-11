using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MiliukovLO.Sprint6.Task6.V4.Lib
{
    public class DataService : ISprint6Task6V4
    {
        public string CollectTextFromFile(string str, string path)
        {
            string[] lines = File.ReadAllLines(path);
            string text = string.Join(" ", lines);
            string[] words = text.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            var result = words.Where(word => word.Contains(str, StringComparison.OrdinalIgnoreCase));
            return string.Join(" ", result);
        }

        public string CollectTextFromFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            string text = string.Join(" ", lines);
            string[] words = text.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            var result = words.Where(word => word.Contains("n", StringComparison.OrdinalIgnoreCase));
            return string.Join(" ", result);
        }
    }
}
