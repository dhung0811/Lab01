namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(180, 110);
            button1.Name = "button1";
            button1.Size = new Size(100, 51);
            button1.TabIndex = 0;
            button1.Text = "Tính tổng";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(146, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(133, 25);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(146, 79);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(133, 25);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(146, 167);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(133, 25);
            textBox3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 55);
            label1.Name = "label1";
            label1.Size = new Size(64, 17);
            label1.TabIndex = 4;
            label1.Text = "Số thứ 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 79);
            label2.Name = "label2";
            label2.Size = new Size(64, 17);
            label2.TabIndex = 5;
            label2.Text = "Số thứ 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 175);
            label3.Name = "label3";
            label3.Size = new Size(58, 17);
            label3.TabIndex = 5;
            label3.Text = "Kết quả";
            // 
            // button2
            // 
            button2.Location = new Point(293, 167);
            button2.Name = "button2";
            button2.Size = new Size(125, 25);
            button2.TabIndex = 6;
            button2.Text = "Xoá";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(293, 196);
            button3.Name = "button3";
            button3.Size = new Size(125, 28);
            button3.TabIndex = 7;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(19, 15);
            label4.Name = "label4";
            label4.Size = new Size(160, 26);
            label4.TabIndex = 8;
            label4.Text = "Tính tổng 2 số";
            // 
            // Form1
            // 
            ClientSize = new Size(574, 392);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Bài 1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2;
            int sum = 0;
            if (int.TryParse(textBox1.Text.Trim().ToString(), out num1) && int.TryParse(textBox2.Text.Trim().ToString(), out num2))
            {
                num1 = Int32.Parse(textBox1.Text.Trim());
                num2 = Int32.Parse(textBox2.Text.Trim());
                sum = num1 + num2;
            }
            else
            {
                MessageBox.Show("Vui long nhap lai", "Thong Bao", MessageBoxButtons.OK);
            }
            textBox3.Text = sum.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ///
        }
    }
}