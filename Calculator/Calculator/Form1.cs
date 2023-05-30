using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        string first = "";
        string second = "";
        char function;
        double result = 0.0;
        string userInput = "";
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += "1";
            CalculatorDisplay.Text += userInput;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += "2";
            CalculatorDisplay.Text += userInput;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += "3";
            CalculatorDisplay.Text += userInput;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += "4";
            CalculatorDisplay.Text += userInput;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += "5";
            CalculatorDisplay.Text += userInput;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += "6";
            CalculatorDisplay.Text += userInput;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += "7";
            CalculatorDisplay.Text += userInput;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += "8";
            CalculatorDisplay.Text += userInput;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += "9";
            CalculatorDisplay.Text += userInput;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += "0";
            CalculatorDisplay.Text += userInput;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text += "";
            userInput += ".";
            CalculatorDisplay.Text += userInput;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            function = '+';
            first = userInput;
            userInput = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            function = '-';
            first = userInput;
            userInput = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            function = '*';
            first = userInput;
            userInput = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            function = '/';
            first = userInput;
            userInput = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            second = userInput;
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(first);
            secondNum = Convert.ToDouble(second);
            //Penjumlahan
            if(function == '+')
            {
                result = firstNum + secondNum;
                CalculatorDisplay.Text = result.ToString();
            }
            //Pengulangan
            else if(function == '-')
            {
                result = firstNum - secondNum;
                CalculatorDisplay.Text = result.ToString();
            }
            //Perkalian
            else if(function == '*')
            {
                result = firstNum * secondNum;
                CalculatorDisplay.Text = result.ToString();
            }
            //Pembagian
            else if(function == '/')
            {
                if (secondNum == 0)
                {
                    CalculatorDisplay.Text = "Tak Terdefinisi";
                }
                else
                {
                    result = firstNum / secondNum;
                    CalculatorDisplay.Text = result.ToString();
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            first = "";
            second = "";
            userInput = "";
            result = 0.0;
            CalculatorDisplay.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
