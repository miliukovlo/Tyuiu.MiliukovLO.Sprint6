namespace Tyuiu.MiliukovLO.Sprint6.Task4.V19
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBoxConditions = new GroupBox();
            pictureBoxCondition = new PictureBox();
            groupBoxButtons = new GroupBox();
            buttonSave = new Button();
            buttonComplete = new Button();
            buttonQuestion = new Button();
            labelVarY = new Label();
            labelVarX = new Label();
            textBoxVarY = new TextBox();
            textBoxVarX = new TextBox();
            dataGridViewOutput = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            FOfX = new DataGridViewTextBoxColumn();
            groupBoxConditions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCondition).BeginInit();
            groupBoxButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput).BeginInit();
            SuspendLayout();
            // 
            // groupBoxConditions
            // 
            groupBoxConditions.Controls.Add(pictureBoxCondition);
            groupBoxConditions.Location = new Point(12, 12);
            groupBoxConditions.Name = "groupBoxConditions";
            groupBoxConditions.Size = new Size(662, 280);
            groupBoxConditions.TabIndex = 0;
            groupBoxConditions.TabStop = false;
            groupBoxConditions.Text = "Условие";
            // 
            // pictureBoxCondition
            // 
            pictureBoxCondition.Image = Properties.Resources.загружено__1_;
            pictureBoxCondition.Location = new Point(6, 22);
            pictureBoxCondition.Name = "pictureBoxCondition";
            pictureBoxCondition.Size = new Size(638, 239);
            pictureBoxCondition.TabIndex = 0;
            pictureBoxCondition.TabStop = false;
            // 
            // groupBoxButtons
            // 
            groupBoxButtons.Controls.Add(buttonSave);
            groupBoxButtons.Controls.Add(buttonComplete);
            groupBoxButtons.Controls.Add(buttonQuestion);
            groupBoxButtons.Controls.Add(labelVarY);
            groupBoxButtons.Controls.Add(labelVarX);
            groupBoxButtons.Controls.Add(textBoxVarY);
            groupBoxButtons.Controls.Add(textBoxVarX);
            groupBoxButtons.Location = new Point(12, 298);
            groupBoxButtons.Name = "groupBoxButtons";
            groupBoxButtons.Size = new Size(662, 247);
            groupBoxButtons.TabIndex = 1;
            groupBoxButtons.TabStop = false;
            groupBoxButtons.Text = "Ввод данных";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(505, 203);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonComplete
            // 
            buttonComplete.Location = new Point(409, 203);
            buttonComplete.Name = "buttonComplete";
            buttonComplete.Size = new Size(90, 23);
            buttonComplete.TabIndex = 5;
            buttonComplete.Text = "Выполнить";
            buttonComplete.UseVisualStyleBackColor = true;
            buttonComplete.Click += buttonComplete_Click;
            // 
            // buttonQuestion
            // 
            buttonQuestion.Location = new Point(318, 203);
            buttonQuestion.Name = "buttonQuestion";
            buttonQuestion.Size = new Size(75, 23);
            buttonQuestion.TabIndex = 4;
            buttonQuestion.Text = "?";
            buttonQuestion.UseVisualStyleBackColor = true;
            buttonQuestion.Click += buttonQuestion_Click;
            buttonQuestion.MouseLeave += buttonQuestion_MouseLeave;
            buttonQuestion.MouseHover += buttonQuestion_MouseHover;
            // 
            // labelVarY
            // 
            labelVarY.AutoSize = true;
            labelVarY.Location = new Point(181, 185);
            labelVarY.Name = "labelVarY";
            labelVarY.Size = new Size(117, 15);
            labelVarY.TabIndex = 3;
            labelVarY.Text = "Введите значение Y:";
            // 
            // labelVarX
            // 
            labelVarX.AutoSize = true;
            labelVarX.Location = new Point(6, 185);
            labelVarX.Name = "labelVarX";
            labelVarX.Size = new Size(117, 15);
            labelVarX.TabIndex = 2;
            labelVarX.Text = "Введите значение X:";
            // 
            // textBoxVarY
            // 
            textBoxVarY.Location = new Point(181, 203);
            textBoxVarY.Name = "textBoxVarY";
            textBoxVarY.Size = new Size(100, 23);
            textBoxVarY.TabIndex = 1;
            // 
            // textBoxVarX
            // 
            textBoxVarX.Location = new Point(6, 203);
            textBoxVarX.Name = "textBoxVarX";
            textBoxVarX.Size = new Size(100, 23);
            textBoxVarX.TabIndex = 0;
            // 
            // dataGridViewOutput
            // 
            dataGridViewOutput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput.Columns.AddRange(new DataGridViewColumn[] { X, FOfX });
            dataGridViewOutput.Location = new Point(711, 25);
            dataGridViewOutput.Name = "dataGridViewOutput";
            dataGridViewOutput.RowHeadersVisible = false;
            dataGridViewOutput.Size = new Size(203, 499);
            dataGridViewOutput.TabIndex = 2;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.ReadOnly = true;
            // 
            // FOfX
            // 
            FOfX.HeaderText = "F(X)";
            FOfX.Name = "FOfX";
            FOfX.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1286, 557);
            Controls.Add(dataGridViewOutput);
            Controls.Add(groupBoxButtons);
            Controls.Add(groupBoxConditions);
            Name = "Form1";
            Text = "Спринт 6 | Таск 4 | Вариант 19 | ИИПб-24-2 Милюков Л.О.";
            Load += Form1_Load;
            groupBoxConditions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxCondition).EndInit();
            groupBoxButtons.ResumeLayout(false);
            groupBoxButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBoxConditions;
        private PictureBox pictureBoxCondition;
        private GroupBox groupBoxButtons;
        private TextBox textBoxVarX;
        private Label labelVarX;
        private TextBox textBoxVarY;
        private Button buttonSave;
        private Button buttonComplete;
        private Button buttonQuestion;
        private Label labelVarY;
        private DataGridView dataGridViewOutput;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn FOfX;
    }
}
