namespace Tyuiu.MiliukovLO.Sprint6.Task6.V4
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBoxCondition = new GroupBox();
            labelCondition = new Label();
            groupBoxButtons = new GroupBox();
            buttonQuestion = new Button();
            buttonComplete = new Button();
            buttonLoad = new Button();
            openFileDialog = new OpenFileDialog();
            toolTipLoad = new ToolTip(components);
            groupBoxInput = new GroupBox();
            textBoxInput = new TextBox();
            labelPath = new Label();
            textBoxOut = new TextBox();
            groupBoxOutput = new GroupBox();
            groupBoxCondition.SuspendLayout();
            groupBoxButtons.SuspendLayout();
            groupBoxInput.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition
            // 
            groupBoxCondition.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxCondition.AutoSize = true;
            groupBoxCondition.Controls.Add(labelCondition);
            groupBoxCondition.Location = new Point(12, 118);
            groupBoxCondition.Name = "groupBoxCondition";
            groupBoxCondition.Size = new Size(1395, 114);
            groupBoxCondition.TabIndex = 0;
            groupBoxCondition.TabStop = false;
            groupBoxCondition.Text = "Условие";
            // 
            // labelCondition
            // 
            labelCondition.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelCondition.AutoSize = true;
            labelCondition.Location = new Point(3, 19);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(1247, 15);
            labelCondition.TabIndex = 0;
            labelCondition.Text = resources.GetString("labelCondition.Text");
            // 
            // groupBoxButtons
            // 
            groupBoxButtons.Controls.Add(buttonQuestion);
            groupBoxButtons.Controls.Add(buttonComplete);
            groupBoxButtons.Controls.Add(buttonLoad);
            groupBoxButtons.Location = new Point(12, 12);
            groupBoxButtons.Name = "groupBoxButtons";
            groupBoxButtons.Size = new Size(1395, 100);
            groupBoxButtons.TabIndex = 1;
            groupBoxButtons.TabStop = false;
            groupBoxButtons.Text = "Управление";
            // 
            // buttonQuestion
            // 
            buttonQuestion.Location = new Point(188, 44);
            buttonQuestion.Name = "buttonQuestion";
            buttonQuestion.Size = new Size(75, 23);
            buttonQuestion.TabIndex = 2;
            buttonQuestion.Text = "Справка";
            toolTipLoad.SetToolTip(buttonQuestion, "Получить справку по заданию.\r\n");
            buttonQuestion.UseVisualStyleBackColor = true;
            buttonQuestion.Click += buttonQuestion_Click;
            // 
            // buttonComplete
            // 
            buttonComplete.Enabled = false;
            buttonComplete.Location = new Point(87, 44);
            buttonComplete.Name = "buttonComplete";
            buttonComplete.Size = new Size(95, 23);
            buttonComplete.TabIndex = 1;
            buttonComplete.Text = "Выполнить";
            toolTipLoad.SetToolTip(buttonComplete, "Нажмите для выполнения программы.\r\n");
            buttonComplete.UseVisualStyleBackColor = true;
            buttonComplete.Click += buttonComplete_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(6, 44);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(75, 23);
            buttonLoad.TabIndex = 0;
            buttonLoad.Text = "Загрузить";
            toolTipLoad.SetToolTip(buttonLoad, "Нажмите чтобы произвести загрузку файла.\r\n");
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(textBoxInput);
            groupBoxInput.Controls.Add(labelPath);
            groupBoxInput.Location = new Point(12, 238);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(481, 249);
            groupBoxInput.TabIndex = 2;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод данных";
            // 
            // textBoxInput
            // 
            textBoxInput.BackColor = SystemColors.ControlLightLight;
            textBoxInput.Enabled = false;
            textBoxInput.Location = new Point(6, 46);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.ReadOnly = true;
            textBoxInput.Size = new Size(469, 197);
            textBoxInput.TabIndex = 1;
            // 
            // labelPath
            // 
            labelPath.AutoSize = true;
            labelPath.Location = new Point(6, 28);
            labelPath.Name = "labelPath";
            labelPath.Size = new Size(150, 15);
            labelPath.TabIndex = 0;
            labelPath.Text = "Путь: Вы не выбрали путь";
            // 
            // textBoxOut
            // 
            textBoxOut.BackColor = SystemColors.ControlLightLight;
            textBoxOut.Enabled = false;
            textBoxOut.Location = new Point(6, 46);
            textBoxOut.Multiline = true;
            textBoxOut.Name = "textBoxOut";
            textBoxOut.ReadOnly = true;
            textBoxOut.Size = new Size(469, 197);
            textBoxOut.TabIndex = 1;
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(textBoxOut);
            groupBoxOutput.Location = new Point(926, 238);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(481, 249);
            groupBoxOutput.TabIndex = 3;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод данных";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1419, 499);
            Controls.Add(groupBoxOutput);
            Controls.Add(groupBoxInput);
            Controls.Add(groupBoxButtons);
            Controls.Add(groupBoxCondition);
            Name = "Form1";
            Text = "Спринт 6 | Таск 6 | Вариант 4 | ИИПб-24-2 Милюков Л.О.";
            groupBoxCondition.ResumeLayout(false);
            groupBoxCondition.PerformLayout();
            groupBoxButtons.ResumeLayout(false);
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            groupBoxOutput.ResumeLayout(false);
            groupBoxOutput.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxCondition;
        private Label labelCondition;
        private GroupBox groupBoxButtons;
        private Button buttonQuestion;
        private Button buttonComplete;
        private Button buttonLoad;
        private OpenFileDialog openFileDialog;
        private ToolTip toolTipLoad;
        private GroupBox groupBoxInput;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBoxInput;
        private TextBox textBoxOut;
        private GroupBox groupBoxOutput;
        private Label labelPath;
    }
}
