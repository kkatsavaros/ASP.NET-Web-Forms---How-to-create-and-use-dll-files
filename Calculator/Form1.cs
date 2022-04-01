using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _46.Maths;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int operand1 = int.Parse(textBox1.Text);
            int operand2 = int.Parse(textBox3.Text);

            char operation = textBox2.Text.ToCharArray()[0];

            int result = 0;

            ArithmeticOperations operations = new ArithmeticOperations();

            switch (operation)
            {
                case '+':
                    //result = operand1 + operand2;
                    result = operations.Add(operand1, operand2);
                    break;

                case '-':
                    result = operations.Substract(operand1, operand2);
                    break;

                case '*':
                    result = operations.Multiply(operand1, operand2);
                    break;

                case '/':
                    result = operations.Devide(operand1, operand2);
                    break;

                default:
                    break;
            }

            textBox4.Text = result.ToString();
        }
    }
}
