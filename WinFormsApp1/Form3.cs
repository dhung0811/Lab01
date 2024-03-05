using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1;
            string str1 = "";
            if (Int32.TryParse(textBox1.Text, out num1))
            {
                num1 = Int32.Parse(textBox1.Text.ToString().Trim());
                switch (num1)
                {
                    case 0:
                        str1 = "không";
                        break;
                    case 1:
                        str1 = "một";
                        break;
                    case 2:
                        str1 = "hai";
                        break;
                    case 3:
                        str1 = "ba";
                        break;
                    case 4:
                        str1 = "bốn";
                        break;
                    case 5:
                        str1 = "năm";
                        break;
                    case 6:
                        str1 = "sáu";
                        break;
                    case 7:
                        str1 = "bảy";
                        break;
                    case 8:
                        str1 = "tám";
                        break;
                    case 9:
                        str1 = "chín";
                        break;
                    default:
                        MessageBox.Show("Vui lòng nhập số từ 0-9", "Thông báo", MessageBoxButtons.OK);
                        break;
                }
                textBox2.Text = str1;

            }
            else
            {
                MessageBox.Show("Vui lòng nhập số từ 0-9", "Thông báo", MessageBoxButtons.OK);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
