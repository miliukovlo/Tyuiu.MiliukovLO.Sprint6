using Tyuiu.MiliukovLO.Sprint6.Task2.V21.Lib;

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
            DataService ds = new();
            int startValue = -5;
            int endValue = 5;
            int index = 0;
            double[] result = ds.GetMassFunction(startValue, endValue);
            for (int i = startValue; i <= endValue; i++)
            {
                this.dataGridViewOutput.Rows.Add(i, Math.Round(result[index], 2));
                index++;
            }
        }

        private void buttonQuestion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("��������� ������� ������� �� -5 �� 5 �� �������� �������. ������� ������ �������� ����-24-2", "C������", MessageBoxButtons.OK);
        }
    }
}
