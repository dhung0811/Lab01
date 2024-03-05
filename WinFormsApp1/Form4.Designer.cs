namespace WinFormsApp1
{
    partial class Form4
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(69, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(422, 179);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập thông tin";
            // 
            // button1
            // 
            button1.Location = new Point(127, 117);
            button1.Name = "button1";
            button1.Size = new Size(248, 29);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Binary", "Decimal", "Hexadecimal" });
            comboBox2.Location = new Point(278, 86);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(97, 25);
            comboBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Binary", "Decimal", "Hexadecimal" });
            comboBox1.Location = new Point(127, 86);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(97, 25);
            comboBox1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(230, 89);
            label3.Name = "label3";
            label3.Size = new Size(42, 17);
            label3.TabIndex = 1;
            label3.Text = "Sang";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 94);
            label2.Name = "label2";
            label2.Size = new Size(43, 17);
            label2.TabIndex = 1;
            label2.Text = "Chọn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 53);
            label1.Name = "label1";
            label1.Size = new Size(91, 17);
            label1.TabIndex = 1;
            label1.Text = "Nhập một số";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(127, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(248, 25);
            textBox1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 288);
            label4.Name = "label4";
            label4.Size = new Size(62, 17);
            label4.TabIndex = 1;
            label4.Text = "Kết quả:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(178, 280);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(251, 25);
            textBox2.TabIndex = 2;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Name = "Form4";
            Text = "Bài 4";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label4;
        private TextBox textBox2;
        private ComboBox comboBox2;
    }
}