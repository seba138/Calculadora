using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private string input = "";
        private string operation = "";
        private double result = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {

            try

            {

                double num1 = Convert.ToDouble(txtNum1.Text);

                double num2 = Convert.ToDouble(txtNum2.Text);

                double suma = num1 + num2;

                lblResultado.Text = "Resultado: " + suma.ToString();

            }

            catch (FormatException)

            {

                MessageBox.Show("Por favor, ingrese valores numéricos válidos.");

            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            input += "3";
            textBoxResult.Text = input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            input += "5";
            textBoxResult.Text = input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            input += "8";
            textBoxResult.Text = input;
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            input += "0";
            textBoxResult.Text = input;
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            input += "1";
            textBoxResult.Text = input;
        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
            if (double.TryParse(input, out double number))
            {
                switch (operation)
                {
                    case "+":
                        result += number;
                        break;
                    case "-":
                        result -= number;
                        break;
                    case "*":
                        result *= number;
                        break;
                    case "/":
                        if (number != 0) result /= number;
                        break;
                }
                textBoxResult.Text = result.ToString();
                input = "";
                operation = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            input += "2";
            textBoxResult.Text = input;
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            input += "4";
            textBoxResult.Text = input;
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            input += "6";
            textBoxResult.Text = input;
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            input += "7";
            textBoxResult.Text = input;
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            input += "9";
            textBoxResult.Text = input;
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (double.TryParse(input, out double number))
            {
                result = number;
                input = "";
                operation = "+";
            }
        
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            if (double.TryParse(input, out double number))
            {
                result = number;
                input = "";
                operation = "-";
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(input, out double number))
            {
                result = number;
                input = "";
                operation = "*";
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (double.TryParse(input, out double number))
            {
                result = number;
                input = "";
                operation = "/";
            }
        }

        private void btnComa_Click(object sender, EventArgs e)
        {
            if (!input.Contains(","))
            {
                input += ",";
                textBoxResult.Text = input;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            input = "";
            result = 0;
            operation = "";
            textBoxResult.Clear();
        
    }
    }
 }
