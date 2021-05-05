using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        string znak;
        double nr1;
        double nr2;

        bool startNewNumber = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            NumberC_click("0");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            NumberC_click("1");
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            NumberC_click("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NumberC_click("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NumberC_click("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NumberC_click("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NumberC_click("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NumberC_click("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NumberC_click("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            NumberC_click("9");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void NumberC_click(string number)
        {
            if (startNewNumber == false)
            {
                textBox1.Text += number;
            }
            else
            {
                textBox1.Text = number;
                startNewNumber = false;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Operation("+");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Operation("*");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Operation("-");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Operation("/");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            nr2 = Convert.ToDouble(textBox1.Text);
            label1.Text = string.Empty;
            switch(znak)
            {
                case "+":
                    textBox1.Text = Convert.ToString(nr1 + nr2);
                break;
                case "-":
                    textBox1.Text = Convert.ToString(nr1 - nr2);
                    break;
                case "*":
                    textBox1.Text = Convert.ToString(nr1 * nr2);
                    break;
                case "/":
                    if (nr2 == 0)
                    {
                        label1.Text = "NIe dziel przez 0 cholero";
                    }
                    else
                    {
                        textBox1.Text = Convert.ToString(nr1 / nr2);
                    }
                    break;
            }
            znak = string.Empty;
            startNewNumber = true;

        }
        

        private void Operation(string znak)
        {
            nr1 = Convert.ToDouble(textBox1.Text);
            label1.Text = textBox1.Text;
            label1.Text += znak;
            this.znak = znak;
            startNewNumber = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf(',') == -1)
            {
                textBox1.Text += ",";
                startNewNumber = false;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = String.Empty;
            znak = String.Empty;
            startNewNumber = true;

        }
    }
}
