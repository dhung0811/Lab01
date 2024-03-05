using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        void error()
        {
            MessageBox.Show("Vui long nhap dung dinh dang", "thong bao", MessageBoxButtons.OK);
        }

        public static string BinaryStringToHexString(string binary)
        {
            if (string.IsNullOrEmpty(binary))
                return binary;

            StringBuilder result = new StringBuilder(binary.Length / 8 + 1);

            // TODO: check all 1's or 0's... throw otherwise

            int mod4Len = binary.Length % 8;
            if (mod4Len != 0)
            {
                // pad to length multiple of 8
                binary = binary.PadLeft(((binary.Length / 8) + 1) * 8, '0');
            }

            for (int i = 0; i < binary.Length; i += 8)
            {
                string eightBits = binary.Substring(i, 8);
                result.AppendFormat("{0:X2}", Convert.ToByte(eightBits, 2));
            }

            return result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1;
            string result = "";
            string bin = @"\b[01]+\b", dec = @"^-?\d+(,\d+)*(\.\d+(e\d+)?)?$", hex = @"[0-9a-fA-F]+";
            Regex rehex = new Regex(hex);
            Regex re = new Regex(bin);
            Regex redec = new Regex(dec);
            /// cái khúc check xem có phải hex ko t chưa làm được :(((
            if (comboBox1.Text.ToString() == "Hexadecimal")              
            {
                string num2 = textBox1.Text;
                num1 = num2.ToString().Length;
                if (rehex.IsMatch(num2))
                {
                    if (comboBox2.Text.ToString() == "Binary")
                    {
                        result = Convert.ToString(num1, 2);
                    }
                    else if (comboBox2.Text.ToString() == "Decimal")
                    {
                        result = Convert.ToInt32(num1.ToString(), 2).ToString();
                    }

                }
                else error();
            }            
            else if (comboBox1.Text.ToString() == "Binary")
            {
                num1 = int.Parse(textBox1.Text.Trim());
                if (re.IsMatch(num1.ToString()))
                {
                    if (comboBox2.Text.ToString() == "Decimal")
                        result = Convert.ToInt32(num1.ToString(), 2).ToString();
                    else if (comboBox2.Text.ToString() == "Hexadecimal")
                    {
                        result = BinaryStringToHexString(num1.ToString());
                    }
                }
                else error();
            }
            else if (comboBox1.Text.ToString() == "Decimal")
            {
                num1 = int.Parse(textBox1.Text.Trim());
                if (redec.IsMatch(num1.ToString()))
                {
                    if (comboBox2.Text.ToString() == "Binary")
                    {
                        result = Convert.ToString(num1, 2);
                    }
                    else if (comboBox2.Text.ToString() == "Hexadecimal")
                    {
                        result = BinaryStringToHexString(Convert.ToString(num1, 2).ToString());
                    }
                }
                else { error(); }
            }                      
            else
            {
                error();
            }
            textBox2.Text = result.ToString();
        }
    }
}
