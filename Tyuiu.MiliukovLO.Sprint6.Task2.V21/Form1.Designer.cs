namespace Tyuiu.MiliukovLO.Sprint6.Task2.V21
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
            pictureBoxCondition = new PictureBox();
            groupBoxInput = new GroupBox();
            buttonComplete = new Button();
            buttonQuestion = new Button();
            groupBoxOutput = new GroupBox();
            dataGridViewOutput = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            FunctionOfX = new DataGridViewTextBoxColumn();
            groupBoxConditions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCondition).BeginInit();
            groupBoxInput.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput).BeginInit();
            SuspendLayout();
            // 
            // groupBoxConditions
            // 
            groupBoxConditions.Controls.Add(pictureBoxCondition);
            groupBoxConditions.Location = new Point(12, 12);
            groupBoxConditions.Name = "groupBoxConditions";
            groupBoxConditions.Size = new Size(755, 275);
            groupBoxConditions.TabIndex = 0;
            groupBoxConditions.TabStop = false;
            groupBoxConditions.Text = "Условие";
            // 
            // pictureBoxCondition
            // 
            pictureBoxCondition.Image = Properties.Resources.загружено;
            pictureBoxCondition.Location = new Point(6, 22);
            pictureBoxCondition.Name = "pictureBoxCondition";
            pictureBoxCondition.Size = new Size(729, 233);
            pictureBoxCondition.TabIndex = 0;
            pictureBoxCondition.TabStop = false;
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(buttonComplete);
            groupBoxInput.Controls.Add(buttonQuestion);
            groupBoxInput.Location = new Point(12, 293);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(755, 228);
            groupBoxInput.TabIndex = 1;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод данных";
            // 
            // buttonComplete
            // 
            buttonComplete.BackColor = Color.SeaGreen;
            buttonComplete.Location = new Point(537, 153);
            buttonComplete.Name = "buttonComplete";
            buttonComplete.Size = new Size(160, 60);
            buttonComplete.TabIndex = 3;
            buttonComplete.Text = "Выполнить";
            buttonComplete.UseVisualStyleBackColor = false;
            buttonComplete.Click += button1_Click;
            // 
            // buttonQuestion
            // 
            buttonQuestion.BackColor = SystemColors.ActiveCaption;
            buttonQuestion.Location = new Point(420, 153);
            buttonQuestion.Name = "buttonQuestion";
            buttonQuestion.Size = new Size(75, 59);
            buttonQuestion.TabIndex = 2;
            buttonQuestion.Text = "?";
            buttonQuestion.UseVisualStyleBackColor = false;
            buttonQuestion.Click += buttonQuestion_Click;
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(dataGridViewOutput);
            groupBoxOutput.Location = new Point(773, 34);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(215, 487);
            groupBoxOutput.TabIndex = 2;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод данных";
            // 
            // dataGridViewOutput
            // 
            dataGridViewOutput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput.Columns.AddRange(new DataGridViewColumn[] { X, FunctionOfX });
            dataGridViewOutput.Location = new Point(6, 22);
            dataGridViewOutput.Name = "dataGridViewOutput";
            dataGridViewOutput.RowHeadersVisible = false;
            dataGridViewOutput.Size = new Size(202, 449);
            dataGridViewOutput.TabIndex = 0;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.ReadOnly = true;
            // 
            // FunctionOfX
            // 
            FunctionOfX.HeaderText = "F(X)";
            FunctionOfX.Name = "FunctionOfX";
            FunctionOfX.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 564);
            Controls.Add(groupBoxOutput);
            Controls.Add(groupBoxInput);
            Controls.Add(groupBoxConditions);
            Name = "Form1";
            Text = "Спринт 6 | Таск 2 | Вариант 21 | ИИПб-24-2 Милюков Л.О.";
            Load += Form1_Load;
            groupBoxConditions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxCondition).EndInit();
            groupBoxInput.ResumeLayout(false);
            groupBoxOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxConditions;
        private PictureBox pictureBoxCondition;
        private GroupBox groupBoxInput;
        private Button buttonQuestion;
        private Button buttonComplete;
        private GroupBox groupBoxOutput;
        private DataGridView dataGridViewOutput;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn FunctionOfX;
    }
}
