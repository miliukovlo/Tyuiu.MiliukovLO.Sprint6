namespace Tyuiu.MiliukovLO.Sprint6.Task2.V21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = -5; i <= 5; i++)
            {
                double result = Math.Cos(i) + (Math.Cos(i) / (i + 2)) - 3 * i;
                if (i == 0)
                {
                    result = 0;
                }
                this.dataGridViewOutput.Rows.Add(i, Math.Round(result, 2));
            }
        }

        private void buttonQuestion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа выводит решение от -5 до 5 по заданной формуле. Милюков Леонид Олегович ИИПб-24-2", "Cправка", MessageBoxButtons.OK);
        }
    }
}
