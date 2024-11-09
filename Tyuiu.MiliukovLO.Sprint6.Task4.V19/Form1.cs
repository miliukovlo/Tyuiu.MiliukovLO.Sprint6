using System.Text;
using Tyuiu.MiliukovLO.Sprint6.Task4.V19.Lib;

namespace Tyuiu.MiliukovLO.Sprint6.Task4.V19
{
    public partial class Form1 : Form
    {
        DataService ds = new();
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

        private void buttonQuestion_MouseHover(object sender, EventArgs e)
        {
            buttonQuestion.BackColor = Color.LightBlue;
            buttonQuestion.ForeColor = Color.White;
        }

        private void buttonQuestion_MouseLeave(object sender, EventArgs e)
        {
            buttonQuestion.BackColor = Color.White;
            buttonQuestion.ForeColor = Color.Black;
        }

        private void buttonComplete_Click(object sender, EventArgs e)
        {
            int startValue = Convert.ToInt32(textBoxVarX.Text);
            int endValue = Convert.ToInt32(textBoxVarY.Text);
            int index = 0;
            double[] result = ds.GetMassFunction(startValue, endValue);
            for (int i = startValue; i <= endValue; i++)
            {
                this.dataGridViewOutput.Rows.Add(i, result[index]);
                index++;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string path = Path.GetTempPath();
            string name = "OutPutFileTask4V19.txt";
            string finalPath = Path.Combine(path, name);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("x      |   F(X)");
            sb.AppendLine("—————————");

            foreach (DataGridViewRow row in dataGridViewOutput.Rows)
            {
                if (!row.IsNewRow)
                {
                    var xValue = row.Cells[0].Value?.ToString() ?? "";
                    var fValue = row.Cells[1].Value?.ToString() ?? "";
                    sb.AppendLine($"{xValue,-8} | {fValue}");
                }
            }
            MessageBox.Show(finalPath, "Путь", MessageBoxButtons.OK);
            File.WriteAllText(finalPath, sb.ToString());
        }

    }
}
