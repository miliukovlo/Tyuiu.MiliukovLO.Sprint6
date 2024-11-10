using Tyuiu.MiliukovLO.Sprint6.Task5.V15.Lib;

namespace Tyuiu.MiliukovLO.Sprint6.Task5.V15
{
    public partial class Form1 : Form
    {
        DataService ds = new();
        string path = "../../../../InPutDataTask5V15.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonQuestion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил Милюков Леонид ИИПб-24-2", "Справка", MessageBoxButtons.OK);
        }

        private void buttonComplete_Click(object sender, EventArgs e)
        {
            double[] result = ds.LoadFromDataFile(path);
            dataGridViewOutput.Rows.Clear(); // Очистка предыдущих данных

            for (int i = 0; i < result.Length; i++) // Изменено на i < result.Length
            {
                dataGridViewOutput.Rows.Add(Convert.ToString(i), Convert.ToString(result[i]));
            }
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe"; 
                txt.StartInfo.Arguments = path; 
                txt.Start();
            }
            else
            {
                MessageBox.Show("Файл не найден: " + path);
            }
        }

    }
}
