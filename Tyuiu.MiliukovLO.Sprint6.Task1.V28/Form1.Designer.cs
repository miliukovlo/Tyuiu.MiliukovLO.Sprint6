namespace Tyuiu.MiliukovLO.Sprint6.Task1.V28
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
            groupBoxCondition = new GroupBox();
            pictureBoxCondition = new PictureBox();
            groupBoxOutput = new GroupBox();
            labelResult = new Label();
            BoxResult = new TextBox();
            groupBoxInput = new GroupBox();
            buttonComplete = new Button();
            buttonQuestion = new Button();
            labelEnd = new Label();
            labelStart = new Label();
            textBoxEndValue = new TextBox();
            textBoxStartValue = new TextBox();
            groupBoxCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCondition).BeginInit();
            groupBoxOutput.SuspendLayout();
            groupBoxInput.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition
            // 
            groupBoxCondition.Controls.Add(pictureBoxCondition);
            groupBoxCondition.Location = new Point(12, 12);
            groupBoxCondition.Name = "groupBoxCondition";
            groupBoxCondition.Size = new Size(656, 244);
            groupBoxCondition.TabIndex = 0;
            groupBoxCondition.TabStop = false;
            groupBoxCondition.Text = "Условие";
            groupBoxCondition.Enter += groupBox1_Enter;
            // 
            // pictureBoxCondition
            // 
            pictureBoxCondition.Image = Properties.Resources.загружено__1_;
            pictureBoxCondition.Location = new Point(6, 22);
            pictureBoxCondition.Name = "pictureBoxCondition";
            pictureBoxCondition.Size = new Size(643, 159);
            pictureBoxCondition.TabIndex = 0;
            pictureBoxCondition.TabStop = false;
            pictureBoxCondition.Click += pictureBox1_Click;
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(labelResult);
            groupBoxOutput.Controls.Add(BoxResult);
            groupBoxOutput.Location = new Point(674, 12);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(288, 420);
            groupBoxOutput.TabIndex = 1;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод данных";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(6, 19);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(63, 15);
            labelResult.TabIndex = 1;
            labelResult.Text = "Результат:";
            // 
            // BoxResult
            // 
            BoxResult.Location = new Point(6, 40);
            BoxResult.Multiline = true;
            BoxResult.Name = "BoxResult";
            BoxResult.ReadOnly = true;
            BoxResult.Size = new Size(276, 380);
            BoxResult.TabIndex = 0;
            BoxResult.TextChanged += BoxResult_TextChanged;
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(buttonComplete);
            groupBoxInput.Controls.Add(buttonQuestion);
            groupBoxInput.Controls.Add(labelEnd);
            groupBoxInput.Controls.Add(labelStart);
            groupBoxInput.Controls.Add(textBoxEndValue);
            groupBoxInput.Controls.Add(textBoxStartValue);
            groupBoxInput.Location = new Point(2, 262);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(672, 170);
            groupBoxInput.TabIndex = 2;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод данных:";
            // 
            // buttonComplete
            // 
            buttonComplete.BackColor = Color.Green;
            buttonComplete.Cursor = Cursors.Hand;
            buttonComplete.Location = new Point(513, 86);
            buttonComplete.Name = "buttonComplete";
            buttonComplete.Size = new Size(146, 64);
            buttonComplete.TabIndex = 5;
            buttonComplete.Text = "Выполнить";
            buttonComplete.UseVisualStyleBackColor = false;
            buttonComplete.Click += buttonComplete_Click;
            // 
            // buttonQuestion
            // 
            buttonQuestion.BackColor = SystemColors.ActiveCaption;
            buttonQuestion.Cursor = Cursors.Hand;
            buttonQuestion.Location = new Point(432, 85);
            buttonQuestion.Name = "buttonQuestion";
            buttonQuestion.Size = new Size(75, 64);
            buttonQuestion.TabIndex = 4;
            buttonQuestion.Text = "?";
            buttonQuestion.UseVisualStyleBackColor = false;
            buttonQuestion.Click += buttonQuestion_Click;
            // 
            // labelEnd
            // 
            labelEnd.AutoSize = true;
            labelEnd.Location = new Point(227, 109);
            labelEnd.Name = "labelEnd";
            labelEnd.Size = new Size(75, 15);
            labelEnd.TabIndex = 3;
            labelEnd.Text = "Конец шага:";
            // 
            // labelStart
            // 
            labelStart.AutoSize = true;
            labelStart.Location = new Point(16, 109);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(72, 15);
            labelStart.TabIndex = 2;
            labelStart.Text = "Старт шага:";
            // 
            // textBoxEndValue
            // 
            textBoxEndValue.Location = new Point(227, 127);
            textBoxEndValue.Name = "textBoxEndValue";
            textBoxEndValue.PlaceholderText = "Введите конец шага";
            textBoxEndValue.Size = new Size(186, 23);
            textBoxEndValue.TabIndex = 1;
            // 
            // textBoxStartValue
            // 
            textBoxStartValue.Location = new Point(16, 127);
            textBoxStartValue.Name = "textBoxStartValue";
            textBoxStartValue.PlaceholderText = "Введите старт шага";
            textBoxStartValue.Size = new Size(186, 23);
            textBoxStartValue.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 444);
            Controls.Add(groupBoxInput);
            Controls.Add(groupBoxOutput);
            Controls.Add(groupBoxCondition);
            Name = "Form1";
            Text = "Спринт 6 | Таск 1 | Вариант 28 | ИИПб-24-2 Милюков Л.О.";
            groupBoxCondition.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxCondition).EndInit();
            groupBoxOutput.ResumeLayout(false);
            groupBoxOutput.PerformLayout();
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition;
        private PictureBox pictureBoxCondition;
        private GroupBox groupBoxOutput;
        private Label labelResult;
        private TextBox BoxResult;
        private GroupBox groupBoxInput;
        private Label labelEnd;
        private Label labelStart;
        private TextBox textBoxEndValue;
        private TextBox textBoxStartValue;
        private Button buttonComplete;
        private Button buttonQuestion;
    }
}
