namespace Tyuiu.MiliukovLO.Sprint6.Task7.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonQuestion_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void groupBoxCondition_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxOutput_Enter(object sender, EventArgs e)
        {

        }

        private void buttonQuestion_MouseEnter(object sender, EventArgs e)
        {
            toolTip.ToolTipTitle = "Справка";
        }
    }
}
