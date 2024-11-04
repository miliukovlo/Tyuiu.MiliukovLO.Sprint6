using Tyuiu.MiliukovLO.Sprint6.Task1.V28.Lib;

namespace Tyuiu.MiliukovLO.Sprint6.Task1.V28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonQuestion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¬ведите начало шага и конец шага, потом нажмите выполнить и вы увидите результат выполнени€ функции", "ќтвет на вопрос");
        }

        private void buttonComplete_Click(object sender, EventArgs e)
        {
            DataService ds = new();
            try
            {
                int startStep = Convert.ToInt32(textBoxStartValue.Text);
                int endStep = Convert.ToInt32(textBoxEndValue.Text);
                string strLine;
                int len = ds.GetMassFunction(-5, 5).Length;
                double[] result = ds.GetMassFunction(-5, 5);
                BoxResult.Text = "";
                BoxResult.AppendText("+-----------+-----------+" + Environment.NewLine);
                BoxResult.AppendText("+      x    +    F(x)   +" + Environment.NewLine);
                BoxResult.AppendText("+-----------+-----------+" + Environment.NewLine);
                for (int i = 0; i <= len-1; i++)
                {
                    strLine = String.Format("|{0,5:d}    | {1,5:f2}          |", startStep, result[i]);
                    BoxResult.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                BoxResult.AppendText("+-----------+-----------+" + Environment.NewLine);
            } catch
            {
                MessageBox.Show("¬ведены неправильные данныен", "ќшибка", MessageBoxButtons.OK);
            }

        }

        private void BoxResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
