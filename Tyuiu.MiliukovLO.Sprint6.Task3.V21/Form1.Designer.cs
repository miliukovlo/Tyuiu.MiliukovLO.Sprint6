namespace Tyuiu.MiliukovLO.Sprint6.Task3.V21
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxConditions = new GroupBox();
            labelCondition = new Label();
            dataGridViewMatrix = new DataGridView();
            dataGridViewResult = new DataGridView();
            buttonComplete = new Button();
            buttonQuestion = new Button();
            groupBoxConditions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).BeginInit();
            SuspendLayout();
            // 
            // groupBoxConditions
            // 
            groupBoxConditions.Controls.Add(labelCondition);
            groupBoxConditions.Location = new Point(12, 12);
            groupBoxConditions.Name = "groupBoxConditions";
            groupBoxConditions.Size = new Size(227, 446);
            groupBoxConditions.TabIndex = 0;
            groupBoxConditions.TabStop = false;
            groupBoxConditions.Text = "Условие";
            // 
            // labelCondition
            // 
            labelCondition.Location = new Point(6, 19);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(215, 99);
            labelCondition.TabIndex = 0;
            labelCondition.Text = "Дан массив 5 на 5 элементов. Выполнить сортировку по возрастанию в первом столбце. Результат вывести в DataGridView. Графический интерфейс оформить по шаблону из лекции.";
            // 
            // dataGridViewMatrix
            // 
            dataGridViewMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix.ColumnHeadersVisible = false;
            dataGridViewMatrix.Location = new Point(245, 12);
            dataGridViewMatrix.Name = "dataGridViewMatrix";
            dataGridViewMatrix.RowHeadersVisible = false;
            dataGridViewMatrix.Size = new Size(268, 446);
            dataGridViewMatrix.TabIndex = 1;
            dataGridViewMatrix.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridViewResult
            // 
            dataGridViewResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult.ColumnHeadersVisible = false;
            dataGridViewResult.Location = new Point(519, 12);
            dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewResult.RowHeadersVisible = false;
            dataGridViewResult.Size = new Size(282, 372);
            dataGridViewResult.TabIndex = 2;
            // 
            // buttonComplete
            // 
            buttonComplete.Location = new Point(704, 409);
            buttonComplete.Name = "buttonComplete";
            buttonComplete.Size = new Size(97, 40);
            buttonComplete.TabIndex = 3;
            buttonComplete.Text = "Выполнить";
            buttonComplete.UseVisualStyleBackColor = true;
            buttonComplete.Click += buttonComplete_Click;
            // 
            // buttonQuestion
            // 
            buttonQuestion.Location = new Point(554, 418);
            buttonQuestion.Name = "buttonQuestion";
            buttonQuestion.Size = new Size(75, 23);
            buttonQuestion.TabIndex = 4;
            buttonQuestion.Text = "?";
            buttonQuestion.UseVisualStyleBackColor = true;
            buttonQuestion.Click += buttonQuestion_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 470);
            Controls.Add(buttonQuestion);
            Controls.Add(buttonComplete);
            Controls.Add(dataGridViewResult);
            Controls.Add(dataGridViewMatrix);
            Controls.Add(groupBoxConditions);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBoxConditions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxConditions;
        private Label labelCondition;
        private DataGridView dataGridViewMatrix;
        private DataGridView dataGridViewResult;
        private Button buttonComplete;
        private Button buttonQuestion;
    }
}
