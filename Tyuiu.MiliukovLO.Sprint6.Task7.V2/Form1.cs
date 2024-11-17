using Tyuiu.MiliukovLO.Sprint6.Task7.V2.Lib;

namespace Tyuiu.MiliukovLO.Sprint6.Task7.V2
{
    public partial class FormMain : Form
    {
        DataService ds = new();
        public FormMain()
        {
            InitializeComponent();
        }

        static int rows;
        static int columns;
        static string path;
        private void buttonQuestion_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private int[,] LoadFromFileDFate(string filename)
        {
            string text = File.ReadAllText(path);
            text = text.Replace('\n', '\r');
            string[] lines = text.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            columns = lines[0].Split(';').Length;
            int[,] array = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(line_r[j]);
                }
            }
            return array;
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

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogGet.ShowDialog();
            path = openFileDialogGet.FileName;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileDFate(path);

            dataGridViewInput.ColumnCount = columns;
            dataGridViewInput.RowCount = rows;
            dataGridViewOutput.ColumnCount = columns;
            dataGridViewOutput.RowCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInput.Columns[i].Width = 40;
                dataGridViewOutput.Columns[i].Width = 40;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewInput.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            buttonDone.Enabled = true;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] result = ds.GetMatrix(path);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOutput.Rows[i].Cells[j].Value = result[i, j];
                }
            }
            buttonSave.Enabled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "OutPutTask7.csv";
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog1.ShowDialog();

            string path = saveFileDialog1.FileName;

            FileInfo file = new FileInfo(path);
            bool fileExists = file.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutput.Rows.Count;
            int columns = dataGridViewOutput.Columns.Count;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutput.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutput.Rows[i].Cells[j].Value;
                    }
                }
            }
            File.AppendAllText(path, str + Environment.NewLine);
            str = "";
        }

        private void toolTip_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
