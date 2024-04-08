using System;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double Result;
        string Operator = "";
        bool isOperator;

        public Form1()
        {
            InitializeComponent();
        }

        private void EnterNumbers(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            if (Output.Text == "0" || isOperator)
            {
                Output.Text = "";
            }

            if (num.Text == ".")
            {
                if (!Output.Text.Contains("."))
                {
                    Output.Text += num.Text;
                    OutputTracker.Text += Output.Text;
                }
            }
            else
            {
                Output.Text += num.Text;
                OutputTracker.Text += num.Text;
                isOperator = false;
            }

        }

        private void operations(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            Result = Convert.ToDouble(Output.Text);
            Operator = num.Text;
            OutputTracker.Text += num.Text;
            isOperator = true;
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {

            switch (Operator)
            {
                case "+":
                    Output.Text = (Result + double.Parse(Output.Text)).ToString();
                    break;
                case "-":
                    Output.Text = (Result - double.Parse(Output.Text)).ToString();
                    break;
                case "X":
                    Output.Text = (Result * double.Parse(Output.Text)).ToString();
                    break;
                case "/":
                    Output.Text = (Result / double.Parse(Output.Text)).ToString();
                    break;
                case "%":
                    Output.Text = (Result % double.Parse(Output.Text)).ToString();
                    break;
                default:
                    break;
            }
            OutputTracker.Text = Output.Text;

        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            Output.Text = "0";
            Result = 0;
            OutputTracker.Text = "";
        }

        private void Delete_Character_Click(object sender, EventArgs e)
        {
            if ((Button)sender is not null)
            {
                Output.Text = OutputTracker.Text = removeFinalChar(Output.Text);



            }
        }
        private string removeFinalChar(string text)
        {
            if (text != string.Empty)
            {               
                return text.Substring(0, text.Length - 1);
            }
            else
            {
                return string.Empty;
            }
        }
    }
}