﻿namespace WinFormsApp1
{
    partial class Form2
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 101);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(148, 25);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(236, 101);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(148, 25);
            textBox2.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(468, 101);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(148, 25);
            textBox3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(267, 81);
            label1.Name = "label1";
            label1.Size = new Size(75, 17);
            label1.TabIndex = 1;
            label1.Text = "Số thứ hai";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(509, 81);
            label2.Name = "label2";
            label2.Size = new Size(72, 17);
            label2.TabIndex = 1;
            label2.Text = "Số thứ ba";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 81);
            label3.Name = "label3";
            label3.Size = new Size(84, 17);
            label3.TabIndex = 1;
            label3.Text = "Số thứ nhất";
            // 
            // button1
            // 
            button1.Location = new Point(64, 155);
            button1.Name = "button1";
            button1.Size = new Size(86, 28);
            button1.TabIndex = 2;
            button1.Text = "Tìm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(267, 155);
            button2.Name = "button2";
            button2.Size = new Size(86, 28);
            button2.TabIndex = 2;
            button2.Text = "Xoá";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(495, 155);
            button3.Name = "button3";
            button3.Size = new Size(86, 28);
            button3.TabIndex = 2;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(155, 231);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(127, 25);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(155, 262);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(127, 25);
            textBox5.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 233);
            label4.Name = "label4";
            label4.Size = new Size(83, 17);
            label4.TabIndex = 4;
            label4.Text = "Số lớn nhất";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 270);
            label5.Name = "label5";
            label5.Size = new Size(78, 17);
            label5.TabIndex = 4;
            label5.Text = "Số bé nhất";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(30, 16);
            label6.Name = "label6";
            label6.Size = new Size(318, 26);
            label6.TabIndex = 5;
            label6.Text = "Tìm số lớn nhất và số bé nhất";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form2";
            Text = "Bài 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}