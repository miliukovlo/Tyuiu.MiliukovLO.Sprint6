namespace Tyuiu.MiliukovLO.Sprint6.Task7.V2
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxCondition = new GroupBox();
            labelCondition = new Label();
            panelInput = new Panel();
            groupBoxInput = new GroupBox();
            dataGridViewInput = new DataGridView();
            panelOutput = new Panel();
            groupBoxOutput = new GroupBox();
            dataGridViewOutput = new DataGridView();
            groupBoxControl = new GroupBox();
            buttonQuestion = new Button();
            buttonDone = new Button();
            buttonSave = new Button();
            buttonOpenFile = new Button();
            toolTip = new ToolTip(components);
            openFileDialogGet = new OpenFileDialog();
            panelControl = new Panel();
            panelCondition = new Panel();
            splitter1 = new Splitter();
            saveFileDialog1 = new SaveFileDialog();
            groupBoxCondition.SuspendLayout();
            panelInput.SuspendLayout();
            groupBoxInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput).BeginInit();
            panelOutput.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput).BeginInit();
            groupBoxControl.SuspendLayout();
            panelControl.SuspendLayout();
            panelCondition.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition
            // 
            groupBoxCondition.Controls.Add(labelCondition);
            groupBoxCondition.Dock = DockStyle.Fill;
            groupBoxCondition.Location = new Point(0, 0);
            groupBoxCondition.Name = "groupBoxCondition";
            groupBoxCondition.Size = new Size(1158, 100);
            groupBoxCondition.TabIndex = 0;
            groupBoxCondition.TabStop = false;
            groupBoxCondition.Text = "Условие";
            groupBoxCondition.Enter += groupBoxCondition_Enter;
            // 
            // labelCondition
            // 
            labelCondition.Dock = DockStyle.Fill;
            labelCondition.Location = new Point(3, 19);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(1152, 78);
            labelCondition.TabIndex = 0;
            labelCondition.Text = resources.GetString("labelCondition.Text");
            // 
            // panelInput
            // 
            panelInput.Controls.Add(groupBoxInput);
            panelInput.Dock = DockStyle.Left;
            panelInput.Location = new Point(0, 200);
            panelInput.Name = "panelInput";
            panelInput.Size = new Size(574, 345);
            panelInput.TabIndex = 2;
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(dataGridViewInput);
            groupBoxInput.Dock = DockStyle.Fill;
            groupBoxInput.Location = new Point(0, 0);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(574, 345);
            groupBoxInput.TabIndex = 0;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод данных";
            // 
            // dataGridViewInput
            // 
            dataGridViewInput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInput.Dock = DockStyle.Fill;
            dataGridViewInput.Location = new Point(3, 19);
            dataGridViewInput.Name = "dataGridViewInput";
            dataGridViewInput.Size = new Size(568, 323);
            dataGridViewInput.TabIndex = 0;
            // 
            // panelOutput
            // 
            panelOutput.Controls.Add(groupBoxOutput);
            panelOutput.Dock = DockStyle.Fill;
            panelOutput.Location = new Point(574, 200);
            panelOutput.Name = "panelOutput";
            panelOutput.Size = new Size(584, 345);
            panelOutput.TabIndex = 3;
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(dataGridViewOutput);
            groupBoxOutput.Dock = DockStyle.Fill;
            groupBoxOutput.Location = new Point(0, 0);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(584, 345);
            groupBoxOutput.TabIndex = 1;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод данных";
            groupBoxOutput.Enter += groupBoxOutput_Enter;
            // 
            // dataGridViewOutput
            // 
            dataGridViewOutput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput.Dock = DockStyle.Fill;
            dataGridViewOutput.Location = new Point(3, 19);
            dataGridViewOutput.Name = "dataGridViewOutput";
            dataGridViewOutput.Size = new Size(578, 323);
            dataGridViewOutput.TabIndex = 0;
            // 
            // groupBoxControl
            // 
            groupBoxControl.Controls.Add(buttonQuestion);
            groupBoxControl.Controls.Add(buttonDone);
            groupBoxControl.Controls.Add(buttonSave);
            groupBoxControl.Controls.Add(buttonOpenFile);
            groupBoxControl.Dock = DockStyle.Fill;
            groupBoxControl.Location = new Point(0, 0);
            groupBoxControl.Name = "groupBoxControl";
            groupBoxControl.Size = new Size(1158, 100);
            groupBoxControl.TabIndex = 1;
            groupBoxControl.TabStop = false;
            groupBoxControl.Text = "Управление";
            // 
            // buttonQuestion
            // 
            buttonQuestion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonQuestion.BackColor = Color.Transparent;
            buttonQuestion.Image = (Image)resources.GetObject("buttonQuestion.Image");
            buttonQuestion.Location = new Point(1098, 22);
            buttonQuestion.Margin = new Padding(0, 0, 10, 0);
            buttonQuestion.MaximumSize = new Size(50, 50);
            buttonQuestion.MinimumSize = new Size(50, 50);
            buttonQuestion.Name = "buttonQuestion";
            buttonQuestion.RightToLeft = RightToLeft.Yes;
            buttonQuestion.Size = new Size(50, 50);
            buttonQuestion.TabIndex = 3;
            buttonQuestion.UseVisualStyleBackColor = false;
            buttonQuestion.Click += buttonQuestion_Click;
            buttonQuestion.MouseEnter += buttonQuestion_MouseEnter;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.Transparent;
            buttonDone.Enabled = false;
            buttonDone.Image = (Image)resources.GetObject("buttonDone.Image");
            buttonDone.Location = new Point(69, 22);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(57, 48);
            buttonDone.TabIndex = 2;
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.Transparent;
            buttonSave.Enabled = false;
            buttonSave.Image = (Image)resources.GetObject("buttonSave.Image");
            buttonSave.Location = new Point(132, 22);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(57, 48);
            buttonSave.TabIndex = 1;
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.BackColor = Color.Transparent;
            buttonOpenFile.Image = (Image)resources.GetObject("buttonOpenFile.Image");
            buttonOpenFile.Location = new Point(6, 22);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(57, 48);
            buttonOpenFile.TabIndex = 0;
            buttonOpenFile.UseVisualStyleBackColor = false;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // toolTip
            // 
            toolTip.IsBalloon = true;
            toolTip.ToolTipTitle = "Подсказка";
            toolTip.Popup += toolTip_Popup;
            // 
            // openFileDialogGet
            // 
            openFileDialogGet.FileName = "openFileDialogGet";
            // 
            // panelControl
            // 
            panelControl.Controls.Add(groupBoxControl);
            panelControl.Dock = DockStyle.Top;
            panelControl.Location = new Point(0, 0);
            panelControl.Name = "panelControl";
            panelControl.Size = new Size(1158, 100);
            panelControl.TabIndex = 0;
            // 
            // panelCondition
            // 
            panelCondition.Controls.Add(groupBoxCondition);
            panelCondition.Dock = DockStyle.Top;
            panelCondition.Location = new Point(0, 100);
            panelCondition.Name = "panelCondition";
            panelCondition.Size = new Size(1158, 100);
            panelCondition.TabIndex = 1;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(574, 200);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(10, 345);
            splitter1.TabIndex = 4;
            splitter1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 545);
            Controls.Add(splitter1);
            Controls.Add(panelOutput);
            Controls.Add(panelInput);
            Controls.Add(panelCondition);
            Controls.Add(panelControl);
            MinimumSize = new Size(800, 450);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 2 | ИИПб-24-2 Милюков Л.О.";
            groupBoxCondition.ResumeLayout(false);
            panelInput.ResumeLayout(false);
            groupBoxInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput).EndInit();
            panelOutput.ResumeLayout(false);
            groupBoxOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput).EndInit();
            groupBoxControl.ResumeLayout(false);
            panelControl.ResumeLayout(false);
            panelCondition.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition;
        private GroupBox groupBoxControl;
        private Button buttonOpenFile;
        private Button buttonQuestion;
        private Button buttonDone;
        private Button buttonSave;
        private ToolTip toolTip;
        private OpenFileDialog openFileDialogGet;
        private Panel panelControl;
        private Panel panelCondition;
        private Label labelCondition;
        private Panel panelInput;
        private Panel panelOutput;
        private GroupBox groupBoxOutput;
        private GroupBox groupBoxInput;
        private Splitter splitter1;
        private DataGridView dataGridViewInput;
        private DataGridView dataGridViewOutput;
        private SaveFileDialog saveFileDialog1;
    }
}
