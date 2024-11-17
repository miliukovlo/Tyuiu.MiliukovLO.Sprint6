namespace Tyuiu.MiliukovLO.Sprint6.Task7.V2
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelHelp = new Label();
            buttonClose = new Button();
            SuspendLayout();
            // 
            // labelHelp
            // 
            labelHelp.Location = new Point(12, 9);
            labelHelp.Name = "labelHelp";
            labelHelp.Size = new Size(410, 338);
            labelHelp.TabIndex = 0;
            labelHelp.Text = "Выполнил Милюков Л. О. Группа ИИПб-24-2";
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(347, 371);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 1;
            buttonClose.Text = "Закрыть";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 411);
            ControlBox = false;
            Controls.Add(buttonClose);
            Controls.Add(labelHelp);
            MaximumSize = new Size(450, 450);
            MinimumSize = new Size(450, 450);
            Name = "FormAbout";
            Text = "Помощь";
            ResumeLayout(false);
        }

        #endregion

        private Label labelHelp;
        private Button buttonClose;
    }
}