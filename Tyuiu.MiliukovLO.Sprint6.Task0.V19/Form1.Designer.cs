namespace Tyuiu.MiliukovLO.Sprint6.Task0.V19
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
            pictureFormula = new PictureBox();
            labelConditions = new Label();
            groupBoxInput = new GroupBox();
            labelInputX = new Label();
            textBoxInputx = new TextBox();
            groupBoxOutput = new GroupBox();
            labelResult = new Label();
            textBoxResult = new TextBox();
            buttonCalculation = new Button();
            groupBoxConditions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureFormula).BeginInit();
            groupBoxInput.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxConditions
            // 
            groupBoxConditions.Controls.Add(pictureFormula);
            groupBoxConditions.Controls.Add(labelConditions);
            groupBoxConditions.Location = new Point(12, 12);
            groupBoxConditions.Name = "groupBoxConditions";
            groupBoxConditions.Size = new Size(1169, 296);
            groupBoxConditions.TabIndex = 0;
            groupBoxConditions.TabStop = false;
            groupBoxConditions.Text = "Условие";
            // 
            // pictureFormula
            // 
            pictureFormula.Image = Properties.Resources.formulaTask0;
            pictureFormula.Location = new Point(883, 23);
            pictureFormula.Name = "pictureFormula";
            pictureFormula.Size = new Size(280, 88);
            pictureFormula.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureFormula.TabIndex = 1;
            pictureFormula.TabStop = false;
            // 
            // labelConditions
            // 
            labelConditions.AllowDrop = true;
            labelConditions.Location = new Point(6, 23);
            labelConditions.Name = "labelConditions";
            labelConditions.Size = new Size(614, 117);
            labelConditions.TabIndex = 0;
            labelConditions.Text = "Дано выражение вычислить его значение при x = 3, результат вывести в TextBox. Округлить до трёх знаков после запятой. Графический интерфейс оформить по шаблону из лекции.";
            labelConditions.Click += labelConditions_Click;
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(labelInputX);
            groupBoxInput.Controls.Add(textBoxInputx);
            groupBoxInput.Location = new Point(18, 330);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(511, 150);
            groupBoxInput.TabIndex = 1;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Поле ввода";
            // 
            // labelInputX
            // 
            labelInputX.AutoSize = true;
            labelInputX.Location = new Point(16, 33);
            labelInputX.Name = "labelInputX";
            labelInputX.Size = new Size(149, 20);
            labelInputX.TabIndex = 4;
            labelInputX.Text = "Введите значение x:";
            // 
            // textBoxInputx
            // 
            textBoxInputx.Location = new Point(16, 65);
            textBoxInputx.Name = "textBoxInputx";
            textBoxInputx.Size = new Size(213, 27);
            textBoxInputx.TabIndex = 3;
            textBoxInputx.TextChanged += textBoxInputx_TextChanged;
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(labelResult);
            groupBoxOutput.Controls.Add(textBoxResult);
            groupBoxOutput.Location = new Point(694, 330);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(487, 150);
            groupBoxOutput.TabIndex = 2;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Поле вывода";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(18, 33);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(78, 20);
            labelResult.TabIndex = 1;
            labelResult.Text = "Результат:";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(18, 65);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(231, 27);
            textBoxResult.TabIndex = 0;
            // 
            // buttonCalculation
            // 
            buttonCalculation.BackColor = SystemColors.WindowFrame;
            buttonCalculation.ForeColor = SystemColors.ControlLight;
            buttonCalculation.Location = new Point(976, 503);
            buttonCalculation.Name = "buttonCalculation";
            buttonCalculation.Size = new Size(205, 61);
            buttonCalculation.TabIndex = 3;
            buttonCalculation.Text = "Вычислить ";
            buttonCalculation.UseVisualStyleBackColor = false;
            buttonCalculation.Click += buttonCalculation_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 589);
            Controls.Add(buttonCalculation);
            Controls.Add(groupBoxOutput);
            Controls.Add(groupBoxInput);
            Controls.Add(groupBoxConditions);
            Name = "Form1";
            Text = "Спринт № 6 | Таск №0 | Вариант 19 | ИИПб-24-2 Милюков Л.О.";
            Load += Form1_Load;
            groupBoxConditions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureFormula).EndInit();
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            groupBoxOutput.ResumeLayout(false);
            groupBoxOutput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxConditions;
        private Label labelConditions;
        private PictureBox pictureFormula;
        private GroupBox groupBoxInput;
        private Label labelInputX;
        private TextBox textBoxInputx;
        private GroupBox groupBoxOutput;
        private TextBox textBoxResult;
        private Label labelResult;
        private Button buttonCalculation;
    }
}
