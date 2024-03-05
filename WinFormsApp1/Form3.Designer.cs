namespace WinFormsApp1
{
    partial class Form3
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 68);
            label1.Name = "label1";
            label1.Size = new Size(210, 17);
            label1.TabIndex = 0;
            label1.Text = "Nhập vào số nguyên từ 0 đến 9";
            // 
            // button1
            // 
            button1.Location = new Point(569, 63);
            button1.Name = "button1";
            button1.Size = new Size(119, 25);
            button1.TabIndex = 1;
            button1.Text = "Đọc";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(569, 113);
            button2.Name = "button2";
            button2.Size = new Size(119, 25);
            button2.TabIndex = 1;
            button2.Text = "Xoá";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(569, 159);
            button3.Name = "button3";
            button3.Size = new Size(119, 25);
            button3.TabIndex = 1;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 266);
            label3.Name = "label3";
            label3.Size = new Size(62, 17);
            label3.TabIndex = 0;
            label3.Text = "Kết quả:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(295, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 25);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(50, 305);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(161, 25);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(56, 17);
            label2.Name = "label2";
            label2.Size = new Size(286, 26);
            label2.TabIndex = 3;
            label2.Text = "Phát âm số nguyên từ 0 - 9";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Bài 3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
    }
}