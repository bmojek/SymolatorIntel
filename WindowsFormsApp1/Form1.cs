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
            
        }
        static Random random = new Random();
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
    }
}
