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


        private double lastNumber = 0;
        private char lastOperator = '\0';
        private bool isNewNumber = true;

        private void WhatWasClicked(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;
            char input = clicked.Text[0];

            if (char.IsDigit(input))
            {
                if (isNewNumber)
                {
                    textBox1.Text = "";
                    isNewNumber = false;
                }
                textBox1.Text += input;
            }
            else
            {
                if (!isNewNumber)
                {
                    CalculateResult();
                }

                lastOperator = input;
                isNewNumber = true;
            }
        }

        
        private void CalculateResult()
        {
            double currentNumber = double.Parse(textBox1.Text);

            if (lastOperator != '\0')
            {
                switch (lastOperator)
                {
                    case '+': 
                        lastNumber += currentNumber; 
                        break;

                    case '-': 
                        lastNumber -= currentNumber; 
                        break;

                    case '*': 
                        lastNumber *= currentNumber; 
                        break;

                    case '%':
                        if (currentNumber != 0)
                            lastNumber /= currentNumber;
                        else
                        {
                            MessageBox.Show("Error");
                            return;
                        }
                        break;
                }
            }
            else
            {
                lastNumber = currentNumber;
            }

            textBox1.Text = lastNumber.ToString();
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            CalculateResult();
            lastOperator = '\0';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WhatWasClicked(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WhatWasClicked(sender, e);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            WhatWasClicked(sender, e);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            WhatWasClicked(sender, e);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            WhatWasClicked(sender, e);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            WhatWasClicked(sender, e);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            WhatWasClicked(sender, e);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            WhatWasClicked(sender, e);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            WhatWasClicked(sender, e);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            WhatWasClicked(sender, e);

        }

        private void button13_Click(object sender, EventArgs e)
        {
            WhatWasClicked(sender, e);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            WhatWasClicked(sender, e);

        }

        private void button11_Click(object sender, EventArgs e)
        {
            WhatWasClicked(sender, e);

        }

        private void button14_Click(object sender, EventArgs e)
        {
            WhatWasClicked(sender, e);

        }

        private void button15_Click(object sender, EventArgs e)
        {
            WhatWasClicked(sender, e);

        }
    }
}
