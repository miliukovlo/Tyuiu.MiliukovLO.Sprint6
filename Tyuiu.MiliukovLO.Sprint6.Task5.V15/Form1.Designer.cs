namespace Tyuiu.MiliukovLO.Sprint6.Task5.V15
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBoxCondition = new GroupBox();
            buttonOpenFile = new Button();
            buttonComplete = new Button();
            buttonQuestion = new Button();
            label1 = new Label();
            dataGridViewOutput = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            funcOfX = new DataGridViewTextBoxColumn();
            groupBoxCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition
            // 
            groupBoxCondition.Controls.Add(buttonOpenFile);
            groupBoxCondition.Controls.Add(buttonComplete);
            groupBoxCondition.Controls.Add(buttonQuestion);
            groupBoxCondition.Controls.Add(label1);
            groupBoxCondition.Location = new Point(12, 12);
            groupBoxCondition.Name = "groupBoxCondition";
            groupBoxCondition.Size = new Size(1049, 100);
            groupBoxCondition.TabIndex = 0;
            groupBoxCondition.TabStop = false;
            groupBoxCondition.Text = "Условие";
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Location = new Point(829, 36);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(140, 23);
            buttonOpenFile.TabIndex = 3;
            buttonOpenFile.Text = "Открыть файл";
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // buttonComplete
            // 
            buttonComplete.Location = new Point(678, 36);
            buttonComplete.Name = "buttonComplete";
            buttonComplete.Size = new Size(100, 23);
            buttonComplete.TabIndex = 2;
            buttonComplete.Text = "Выполнить";
            buttonComplete.UseVisualStyleBackColor = true;
            buttonComplete.Click += buttonComplete_Click;
            // 
            // buttonQuestion
            // 
            buttonQuestion.Location = new Point(517, 36);
            buttonQuestion.Name = "buttonQuestion";
            buttonQuestion.Size = new Size(75, 23);
            buttonQuestion.TabIndex = 1;
            buttonQuestion.Text = "?";
            buttonQuestion.UseVisualStyleBackColor = true;
            buttonQuestion.Click += buttonQuestion_Click;
            // 
            // label1
            // 
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(467, 78);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // dataGridViewOutput
            // 
            dataGridViewOutput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput.Columns.AddRange(new DataGridViewColumn[] { X, funcOfX });
            dataGridViewOutput.Location = new Point(12, 131);
            dataGridViewOutput.Name = "dataGridViewOutput";
            dataGridViewOutput.RowHeadersVisible = false;
            dataGridViewOutput.Size = new Size(203, 374);
            dataGridViewOutput.TabIndex = 1;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.ReadOnly = true;
            // 
            // funcOfX
            // 
            funcOfX.HeaderText = "F(X)";
            funcOfX.Name = "funcOfX";
            funcOfX.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 517);
            Controls.Add(dataGridViewOutput);
            Controls.Add(groupBoxCondition);
            Name = "Form1";
            Text = "Спринт 6 | Таск 5 | Вариант 15 | ИИПб-24-2 Милюков Л.О.";
            Load += Form1_Load;
            groupBoxCondition.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition;
        private Label label1;
        private Button buttonOpenFile;
        private Button buttonComplete;
        private Button buttonQuestion;
        private DataGridView dataGridViewOutput;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn funcOfX;
    }
}
