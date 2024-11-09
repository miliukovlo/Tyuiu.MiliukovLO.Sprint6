using Tyuiu.MiliukovLO.Sprint6.Task3.V21.Lib;

namespace Tyuiu.MiliukovLO.Sprint6.Task3.V21
{
    public partial class Form1 : Form
    {
        DataService ds = new();
        int[,] matrix = new int[5, 5]
        {
                {26, -15, 7, 1, -4 },
                {14, 26, 22 ,17 ,27},
                {-8, 31, 22, 34, 4 },
                {-18, 16, -2, 16, 27},
                {5 , 2, -4, 16, 15 }
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.Length / rows;
            dataGridViewMatrix.ColumnCount = cols;
            dataGridViewMatrix.RowCount = rows;

            for (int i = 0; i < cols; i++)
            {
                dataGridViewMatrix.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }

        private void buttonQuestion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил Милюков Леонид ИИПб-24-2", "Справка", MessageBoxButtons.OK);
        }

        private void buttonComplete_Click(object sender, EventArgs e)
        {
            int[,] result = ds.Calculate(matrix);
            int rows = result.GetUpperBound(0) + 1;
            int cols = result.Length / rows;
            dataGridViewResult.ColumnCount = cols;
            dataGridViewResult.RowCount = rows;

            for (int i = 0; i < cols; i++)
            {
                dataGridViewResult.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewResult.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }
    }
}
