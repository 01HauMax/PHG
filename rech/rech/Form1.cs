using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace rech
{
    public partial class Form1 : Form
    {
        string a = "";
        int b=0;
        int c=0;
        char d;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = "";
            a = a + "1";
            textBox1.Text = textBox1.Text + a;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = "";
            a = a + "2";
            textBox1.Text = textBox1.Text + a;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = "";
            a = a + "3";
            textBox1.Text = textBox1.Text + a;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a = "";
            a = a + "4";
            textBox1.Text = textBox1.Text + a;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            a = "";
            a = a + "5";
            textBox1.Text = textBox1.Text + a;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            a = "";
            a = a + "6";
            textBox1.Text = textBox1.Text + a;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            a = "";
            a = a + "7";
            textBox1.Text = textBox1.Text + a;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            a = "";
            a = a + "8";
            textBox1.Text = textBox1.Text + a;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            a = "";
            a = a + "9";
            textBox1.Text = textBox1.Text + a;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            a = "";
            a = a + "0";
            textBox1.Text = textBox1.Text + a;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //=
            switch (d)
            {
                case '+':
                    c = b + Convert.ToInt32(a);
                    break;
                case '-':
                    c = b - Convert.ToInt32(a);
                    break;
                case '*':
                    c = b * Convert.ToInt32(a);
                    break;
                case '%':
                    c = b / Convert.ToInt32(a);
                    break;
            }
            a = "";
            a = a + "=" + c;
            textBox1.Text = textBox1.Text + a;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //+
            d = '+';
            b = Convert.ToInt32(a);
            a = "";
            c = b + c;
            a = a + "+";
            textBox1.Text = textBox1.Text + a;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //-
            d = '-';
            b = Convert.ToInt32(a);
            a = "";
            c = c-b;
            a = a + "-";
            textBox1.Text = textBox1.Text + a;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //*
            d = '*';
            b = Convert.ToInt32(a);
            a = "";
            c = b * c;
            a = a + "x";
            textBox1.Text = textBox1.Text + a;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //%
            d = '%';
            b = Convert.ToInt32(a);
            a = "";
            c = c/b;
            a = a + "/";
            textBox1.Text = textBox1.Text + a;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //Cls
            a = "";
            textBox1.Text = "";
        }
    }
}
