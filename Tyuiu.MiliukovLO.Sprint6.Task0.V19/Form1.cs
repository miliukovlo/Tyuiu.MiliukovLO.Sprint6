using Tyuiu.MiliukovLO.Sprint6.Task0.V19.Lib;

namespace Tyuiu.MiliukovLO.Sprint6.Task0.V19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelConditions_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalculation_Click(object sender, EventArgs e)
        {
            DataService ds = new();
            try
            {
                MessageBox.Show(textBoxInputx.Text, "Check", MessageBoxButtons.OK);
                MessageBox.Show(Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxInputx.Text))), "Check", MessageBoxButtons.OK);
                textBoxResult.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxInputx.Text)));
            }
            catch (Exception)
            {
                MessageBox.Show("¬ведены неверные данные", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxInputx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;
        }
    }
}
