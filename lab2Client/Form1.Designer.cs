namespace lab2Client
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
            reverseBtn = new Button();
            inputField = new TextBox();
            label1 = new Label();
            label2 = new Label();
            outputLabelWords = new Label();
            outputLabelChars = new Label();
            SuspendLayout();
            // 
            // reverseBtn
            // 
            reverseBtn.Location = new Point(277, 129);
            reverseBtn.Name = "reverseBtn";
            reverseBtn.Size = new Size(243, 45);
            reverseBtn.TabIndex = 0;
            reverseBtn.Text = "REVERSE";
            reverseBtn.UseVisualStyleBackColor = true;
            reverseBtn.Click += reverseBtn_Click;
            // 
            // inputField
            // 
            inputField.Location = new Point(277, 89);
            inputField.Name = "inputField";
            inputField.Size = new Size(243, 23);
            inputField.TabIndex = 1;
            inputField.Text = "Введите ваш текст...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 221);
            label1.Name = "label1";
            label1.Size = new Size(236, 15);
            label1.TabIndex = 2;
            label1.Text = "Перевернуты только слова с символами:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 282);
            label2.Name = "label2";
            label2.Size = new Size(159, 15);
            label2.TabIndex = 3;
            label2.Text = "Перевернуты все символы:";
            // 
            // outputLabelWords
            // 
            outputLabelWords.AutoSize = true;
            outputLabelWords.Location = new Point(295, 221);
            outputLabelWords.Name = "outputLabelWords";
            outputLabelWords.Size = new Size(16, 15);
            outputLabelWords.TabIndex = 4;
            outputLabelWords.Text = "...";
            // 
            // outputLabelChars
            // 
            outputLabelChars.AutoSize = true;
            outputLabelChars.Location = new Point(295, 282);
            outputLabelChars.Name = "outputLabelChars";
            outputLabelChars.Size = new Size(16, 15);
            outputLabelChars.TabIndex = 5;
            outputLabelChars.Text = "...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(outputLabelChars);
            Controls.Add(outputLabelWords);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(inputField);
            Controls.Add(reverseBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button reverseBtn;
        private TextBox inputField;
        private Label label1;
        private Label label2;
        private Label outputLabelWords;
        private Label outputLabelChars;
    }
}
