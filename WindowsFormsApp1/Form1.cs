using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string a;
        private string b;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        public bool OnlyHexInString(string test)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(test, @"\A\b[0-9a-fA-F]+\b\Z");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (OnlyHexInString(textBox1.Text)) label11.Text = textBox1.Text.ToUpper(); else label11.Text = "złe dane";
            if (OnlyHexInString(textBox2.Text)) label14.Text = textBox2.Text.ToUpper(); else label14.Text = "złe dane";
            if (OnlyHexInString(textBox3.Text)) label18.Text = textBox3.Text.ToUpper(); else label18.Text = "złe dane";
            if (OnlyHexInString(textBox4.Text)) label16.Text = textBox4.Text.ToUpper(); else label16.Text = "złe dane";
            if (OnlyHexInString(textBox8.Text)) label26.Text = textBox8.Text.ToUpper(); else label26.Text = "złe dane";
            if (OnlyHexInString(textBox7.Text)) label24.Text = textBox7.Text.ToUpper(); else label24.Text = "złe dane";
            if (OnlyHexInString(textBox6.Text)) label22.Text = textBox6.Text.ToUpper(); else label22.Text = "złe dane";
            if (OnlyHexInString(textBox5.Text)) label20.Text = textBox5.Text.ToUpper(); else label20.Text = "złe dane";
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label11.Text = $"{GetRandomHexNumber(2)}";
            label14.Text = $"{GetRandomHexNumber(2)}";
            label18.Text = $"{GetRandomHexNumber(2)}";
            label16.Text = $"{GetRandomHexNumber(2)}";
            label26.Text = $"{GetRandomHexNumber(2)}";
            label24.Text = $"{GetRandomHexNumber(2)}";
            label22.Text = $"{GetRandomHexNumber(2)}";
            label20.Text = $"{GetRandomHexNumber(2)}";
        }

        private static Random random = new Random();

        public static string GetRandomHexNumber(int digits)
        {
            byte[] buffer = new byte[digits / 2];
            random.NextBytes(buffer);
            string result = String.Concat(buffer.Select(x => x.ToString("X2")).ToArray());
            if (digits % 2 == 0)
                return result;
            return result + random.Next(16).ToString("X");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label11.Text = $"{GetRandomHexNumber(2)}";
            label14.Text = $"{GetRandomHexNumber(2)}";
            label18.Text = $"{GetRandomHexNumber(2)}";
            label16.Text = $"{GetRandomHexNumber(2)}";
            label26.Text = $"{GetRandomHexNumber(2)}";
            label24.Text = $"{GetRandomHexNumber(2)}";
            label22.Text = $"{GetRandomHexNumber(2)}";
            label20.Text = $"{GetRandomHexNumber(2)}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label11.Text = "0";
            label14.Text = "0";
            label18.Text = "0";
            label16.Text = "0";
            label26.Text = "0";
            label24.Text = "0";
            label22.Text = "0";
            label20.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label11.Text = "SIEMA";
            label14.Text = b;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                a = label11.Text;
            }

            if (comboBox1.SelectedIndex == 1)
            {
                a = label14.Text;
            }

            if (comboBox1.SelectedIndex == 2)
            {
                a = label18.Text;
            }

            if (comboBox1.SelectedIndex == 3)
            {
                a = label16.Text;
            }

            if (comboBox1.SelectedIndex == 4)
            {
                a = label26.Text;
            }

            if (comboBox1.SelectedIndex == 5)
            {
                a = label24.Text;
            }

            if (comboBox1.SelectedIndex == 6)
            {
                a = label22.Text;
            }

            if (comboBox1.SelectedIndex == 7)
            {
                a = label20.Text;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                b = label11.Text;
            }

            if (comboBox2.SelectedIndex == 1)
            {
                b = label14.Text;
            }

            if (comboBox2.SelectedIndex == 2)
            {
                b = label18.Text;
            }

            if (comboBox2.SelectedIndex == 3)
            {
                b = label16.Text;
            }

            if (comboBox2.SelectedIndex == 4)
            {
                b = label26.Text;
            }

            if (comboBox2.SelectedIndex == 5)
            {
                b = label24.Text;
            }

            if (comboBox2.SelectedIndex == 6)
            {
                b = label22.Text;
            }

            if (comboBox2.SelectedIndex == 7)
            {
                b = label20.Text;
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label12_Click(object sender, EventArgs e)
        {
        }

        private void label13_Click(object sender, EventArgs e)
        {
        }

        private void label17_Click(object sender, EventArgs e)
        {
        }

        private void label15_Click(object sender, EventArgs e)
        {
        }

        private void label25_Click(object sender, EventArgs e)
        {
        }

        private void label28_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == comboBox2.SelectedIndex || comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Podaj inny rejestr");
                return;
            }

            if (comboBox2.SelectedIndex == 0)
            {
                label11.Text = a;
            }

            if (comboBox2.SelectedIndex == 1)
            {
                label14.Text = a;
            }

            if (comboBox2.SelectedIndex == 2)
            {
                label18.Text = a;
            }

            if (comboBox2.SelectedIndex == 3)
            {
                label16.Text = a;
            }

            if (comboBox2.SelectedIndex == 4)
            {
                label26.Text = a;
            }

            if (comboBox2.SelectedIndex == 5)
            {
                label24.Text = a;
            }

            if (comboBox2.SelectedIndex == 6)
            {
                label22.Text = a;
            }

            if (comboBox2.SelectedIndex == 7)
            {
                label20.Text = a;
            }
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Podaj inny rejestr");
                return;
            }
            if (comboBox2.SelectedIndex == 0)
            {
                label11.Text = a;
            }

            if (comboBox2.SelectedIndex == 1)
            {
                label14.Text = a;
            }

            if (comboBox2.SelectedIndex == 2)
            {
                label18.Text = a;
            }

            if (comboBox2.SelectedIndex == 3)
            {
                label16.Text = a;
            }

            if (comboBox2.SelectedIndex == 4)
            {
                label26.Text = a;
            }

            if (comboBox2.SelectedIndex == 5)
            {
                label24.Text = a;
            }

            if (comboBox2.SelectedIndex == 6)
            {
                label22.Text = a;
            }

            if (comboBox2.SelectedIndex == 7)
            {
                label20.Text = a;
            }

            if (comboBox1.SelectedIndex == 0)
            {
                label11.Text = b;
            }

            if (comboBox1.SelectedIndex == 1)
            {
                label14.Text = b;
            }

            if (comboBox1.SelectedIndex == 2)
            {
                label18.Text = b;
            }

            if (comboBox1.SelectedIndex == 3)
            {
                label16.Text = b;
            }

            if (comboBox1.SelectedIndex == 4)
            {
                label26.Text = b;
            }

            if (comboBox1.SelectedIndex == 5)
            {
                label24.Text = b;
            }

            if (comboBox1.SelectedIndex == 6)
            {
                label22.Text = b;
            }

            if (comboBox1.SelectedIndex == 7)
            {
                label20.Text = b;
            }
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label11.Text = (int.Parse(label11.Text, System.Globalization.NumberStyles.HexNumber) + 1).ToString("X");
            }

            if (comboBox1.SelectedIndex == 1)
            {
                label14.Text = (int.Parse(label14.Text, System.Globalization.NumberStyles.HexNumber) + 1).ToString("X");
            }

            if (comboBox1.SelectedIndex == 2)
            {
                label18.Text = (int.Parse(label18.Text, System.Globalization.NumberStyles.HexNumber) + 1).ToString("X");
            }

            if (comboBox1.SelectedIndex == 3)
            {
                label16.Text = (int.Parse(label16.Text, System.Globalization.NumberStyles.HexNumber) + 1).ToString("X");
            }

            if (comboBox1.SelectedIndex == 4)
            {
                label26.Text = (int.Parse(label26.Text, System.Globalization.NumberStyles.HexNumber) + 1).ToString("X");
            }

            if (comboBox1.SelectedIndex == 5)
            {
                label24.Text = (int.Parse(label24.Text, System.Globalization.NumberStyles.HexNumber) + 1).ToString("X");
            }

            if (comboBox1.SelectedIndex == 6)
            {
                label22.Text = (int.Parse(label22.Text, System.Globalization.NumberStyles.HexNumber) + 1).ToString("X");
            }

            if (comboBox1.SelectedIndex == 7)
            {
                label20.Text = (int.Parse(label20.Text, System.Globalization.NumberStyles.HexNumber) + 1).ToString("X");
            }
        }
    }
}