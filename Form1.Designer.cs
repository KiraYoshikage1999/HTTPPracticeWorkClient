namespace HTTPPracticeWorkClient
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
            EnterURITextBox = new TextBox();
            label1 = new Label();
            button1 = new Button();
            AnswerTextBox = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // EnterURITextBox
            // 
            EnterURITextBox.Location = new Point(28, 51);
            EnterURITextBox.Name = "EnterURITextBox";
            EnterURITextBox.Size = new Size(225, 27);
            EnterURITextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 19);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 1;
            label1.Text = "Text box for URI";
            // 
            // button1
            // 
            button1.Location = new Point(28, 102);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Send";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AnswerTextBox
            // 
            AnswerTextBox.Location = new Point(310, 51);
            AnswerTextBox.Multiline = true;
            AnswerTextBox.Name = "AnswerTextBox";
            AnswerTextBox.ReadOnly = true;
            AnswerTextBox.Size = new Size(451, 186);
            AnswerTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(310, 19);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 4;
            label2.Text = "Answer";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(AnswerTextBox);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(EnterURITextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox EnterURITextBox;
        private Label label1;
        private Button button1;
        private TextBox AnswerTextBox;
        private Label label2;
    }
}
