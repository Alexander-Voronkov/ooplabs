namespace lab1oop
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
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 287);
            button1.Name = "button1";
            button1.Size = new Size(395, 60);
            button1.TabIndex = 0;
            button1.Text = "Історія №1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(352, 90);
            label1.Name = "label1";
            label1.Size = new Size(725, 81);
            label1.TabIndex = 1;
            label1.Text = "Тихіше їдеш - далі будеш";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button2
            // 
            button2.Location = new Point(506, 287);
            button2.Name = "button2";
            button2.Size = new Size(395, 60);
            button2.TabIndex = 2;
            button2.Text = "Історія №2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(999, 287);
            button3.Name = "button3";
            button3.Size = new Size(395, 60);
            button3.TabIndex = 3;
            button3.Text = "Історія №3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(506, 391);
            button4.Name = "button4";
            button4.Size = new Size(395, 60);
            button4.TabIndex = 4;
            button4.Text = "Історія №5";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(12, 391);
            button5.Name = "button5";
            button5.Size = new Size(395, 60);
            button5.TabIndex = 5;
            button5.Text = "Історія №4";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(978, 564);
            button6.Name = "button6";
            button6.Size = new Size(395, 60);
            button6.TabIndex = 6;
            button6.Text = "Завершити роботу";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1416, 653);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Вас вітає студент групи ПІ223Б Воронков Олександр Сергійович";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}
