using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_TRPO
{
    public partial class Form1 : Form
    {
        public string operation;
        public string firstNumber;
        public bool ifSecondNumber;
        public bool ifSecondOperator = false ;
        public bool isDotPressed;
        public double doubleN1, doubleN2, result = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
           
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "0";
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;

            if (ifSecondOperator)
            {
                doubleN1 = Convert.ToDouble(firstNumber);
                doubleN2 = Convert.ToDouble(richTextBox1.Text);
                if (operation == "+")
                {
                    result = doubleN1 + doubleN2;
                }
                if (operation == "-")
                {
                    result = doubleN1 - doubleN2;
                }
                if (operation == "*")
                {
                    result = doubleN1 * doubleN2;
                }
                if (operation == "/")
                {
                    result = doubleN1 / doubleN2;
                }
                richTextBox1.Text = Convert.ToString(result); 
                firstNumber = Convert.ToString(result);
                Clipboard.SetText(firstNumber);
            }
            else
                firstNumber = richTextBox1.Text;
            ifSecondNumber = true;
            if (!ifSecondOperator)
                ifSecondOperator = true;
            operation = B.Text;

        }

        private void resultButton_Click(object sender, EventArgs e)
        {

            doubleN1 = Convert.ToDouble(firstNumber);
            doubleN2 = Convert.ToDouble(richTextBox1.Text);
            if (operation == "+")
            {
                result = doubleN1 + doubleN2;
            }
            if (operation == "-")
            {
                result = doubleN1 - doubleN2;
            }
            if (operation == "*")
            {
                result = doubleN1 * doubleN2;
            }
            if (operation == "/")
            {
                result = doubleN1 / doubleN2;
            }
            //if (ifSecondNumber)
            operation = "=";
            ifSecondNumber = true;
            richTextBox1.Text = Convert.ToString(result);
            Clipboard.SetText(Convert.ToString(result));
            ifSecondOperator = false;
        }

        private void dotButton_Click(object sender, EventArgs e)
        {
             isDotPressed = true;
             if (!richTextBox1.Text.Contains(",") && !ifSecondNumber)
                richTextBox1.Text = richTextBox1.Text + ",";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //this.KeyPreview = true;
        }
        private void b7_Click(object sender, EventArgs e)
        {
            if (ifSecondNumber)
            {
                ifSecondNumber = false;
                if (isDotPressed)
                {
                    richTextBox1.Text = "0,";
                }
                else
                    richTextBox1.Text = "0";
            }
            Button B = (Button)sender;
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = B.Text;
            }
            else
                richTextBox1.Text = richTextBox1.Text + B.Text;
            isDotPressed = false;
        }

        private void dotButton_Click_1(object sender, EventArgs e)
        {
            isDotPressed = true;
            if (ifSecondNumber)
                richTextBox1.Text = "0,";
            else if (!richTextBox1.Text.Contains(",") && !ifSecondNumber)
                richTextBox1.Text = richTextBox1.Text + ",";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.D)
                resultButton.PerformClick();
            if (e.KeyValue == (char)Keys.D1)
                b1.PerformClick();
            if (e.KeyValue == (char)Keys.D2)
                b2.PerformClick();
            if (e.KeyValue == (char)Keys.D3)
                b3.PerformClick();
            if (e.KeyValue == (char)Keys.D4)
                b4.PerformClick();
            if (e.KeyValue == (char)Keys.D5)
                b5.PerformClick();
            if (e.KeyValue == (char)Keys.D6)
                b6.PerformClick();
            if (e.KeyValue == (char)Keys.D7)
                b7.PerformClick();
            if (e.KeyValue == (char)Keys.D8)
                b8.PerformClick();
            if (e.KeyValue == (char)Keys.D9)
                b9.PerformClick();
            if (e.KeyValue == (char)Keys.D0)
                b0.PerformClick();
            if (e.KeyValue == (char)Keys.Oemplus)
                plusButton.PerformClick();
            if (e.KeyValue == (char)Keys.Divide)
                divButton.PerformClick();
            if (e.KeyValue == (char)Keys.Multiply)
                multiplyButton.PerformClick();
            if (e.KeyValue == (char)Keys.OemMinus)
                minusButton.PerformClick();
            if (e.KeyValue == (char)Keys.C)
                clearButton.PerformClick();
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
