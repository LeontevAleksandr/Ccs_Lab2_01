namespace Ccs_Lab2_01
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
            InputSumBox = new TextBox();
            InputWord1Box = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            InputWord2Box = new TextBox();
            OutputSumButton = new Button();
            OutputResultButton = new Button();
            SuspendLayout();
            // 
            // InputSumBox
            // 
            InputSumBox.Location = new Point(12, 36);
            InputSumBox.Name = "InputSumBox";
            InputSumBox.Size = new Size(179, 27);
            InputSumBox.TabIndex = 0;
            InputSumBox.TextChanged += InputSumBox_TextChanged;
            // 
            // InputWord1Box
            // 
            InputWord1Box.Location = new Point(12, 111);
            InputWord1Box.Name = "InputWord1Box";
            InputWord1Box.Size = new Size(179, 27);
            InputWord1Box.TabIndex = 1;
            InputWord1Box.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 2;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(276, 20);
            label2.TabIndex = 3;
            label2.Text = "Введите стоимость товара в копейках:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 88);
            label3.Name = "label3";
            label3.Size = new Size(284, 20);
            label3.TabIndex = 4;
            label3.Text = "Найти буквы первого слова во втором:";
            label3.Click += label3_Click;
            // 
            // InputWord2Box
            // 
            InputWord2Box.Location = new Point(12, 144);
            InputWord2Box.Name = "InputWord2Box";
            InputWord2Box.Size = new Size(179, 27);
            InputWord2Box.TabIndex = 5;
            InputWord2Box.TextChanged += InputWord2Box_TextChanged;
            // 
            // OutputSumButton
            // 
            OutputSumButton.Location = new Point(213, 35);
            OutputSumButton.Name = "OutputSumButton";
            OutputSumButton.Size = new Size(94, 29);
            OutputSumButton.TabIndex = 6;
            OutputSumButton.Text = "Рассчитать";
            OutputSumButton.UseVisualStyleBackColor = true;
            OutputSumButton.Click += OutputSumButton_Click;
            // 
            // OutputResultButton
            // 
            OutputResultButton.Location = new Point(213, 127);
            OutputResultButton.Name = "OutputResultButton";
            OutputResultButton.Size = new Size(94, 29);
            OutputResultButton.TabIndex = 7;
            OutputResultButton.Text = "Рассчитать";
            OutputResultButton.UseVisualStyleBackColor = true;
            OutputResultButton.Click += OutputResultButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 184);
            Controls.Add(OutputResultButton);
            Controls.Add(OutputSumButton);
            Controls.Add(InputWord2Box);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(InputWord1Box);
            Controls.Add(InputSumBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InputSumBox;
        private TextBox InputWord1Box;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox InputWord2Box;
        private Button OutputSumButton;
        private Button OutputResultButton;
    }
}
