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
                textBoxResult.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxInputx.Text)));
            }
            catch (Exception)
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBoxInputx_TextChange(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
