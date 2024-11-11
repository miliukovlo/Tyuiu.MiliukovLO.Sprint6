using Tyuiu.MiliukovLO.Sprint6.Task6.V4.Lib;

namespace Tyuiu.MiliukovLO.Sprint6.Task6.V4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string openFilePath;
        DataService ds = new();
        private void buttonLoad_Click(object sender, EventArgs e)
        { 
            openFileDialog.ShowDialog();
            openFilePath = openFileDialog.FileName;
            textBoxInput.Text = File.ReadAllText(openFilePath);
            labelPath.Text = "Путь: " + openFilePath;
            if (openFilePath != null)
            {
                buttonComplete.Enabled = true;
            }
        }
        private void buttonQuestion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил Милюков Леонид ИИПб-24-2", "Справа", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void buttonComplete_Click(object sender, EventArgs e)
        {
            textBoxOut.Text = ds.CollectTextFromFile("n", openFilePath);
        }
    }
}
