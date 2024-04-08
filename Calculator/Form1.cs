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



        /* 
            enter Numbers method is used to enter numbers into the text box
            if the text box is empty or the operator is pressed, the text box will be cleared
            if the text box contains a dot, the dot will not be added again
            if the text box does not contain a dot, the dot will be added
         */

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



        /* 
         *   operations method is used to perform the operations
         *   the operator is stored in the Operator variable
         *   the text box is updated with the operator pressed by the user
         *   the isOperator variable is set to true to clear the text box when a operator button is pressed
        */

        private void operations(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            Result = Convert.ToDouble(Output.Text);
            Operator = num.Text;
            OutputTracker.Text += num.Text;
            isOperator = true;
        }



        /* 
         *   BtnEqual_Click method is used to perform the operations
         *   the switch statement is used to perform the operations based on the operator
         *   the result is stored in the text box
         *   the OutputTracker text box is updated with the result
         *                                        */

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



        /* 
         *   BtnRemove_Click method is used to clear the text box
         *   the Output text box is set to 0
         *   the Result variable is set to 0
         *   the OutputTracker text box is set to empty
         *     */

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            Output.Text = "0";
            Result = 0;
            OutputTracker.Text = "";
        }



        /* 
         *   Delete_Character_Click method is used to delete the last character in the text box
         *   the removeFinalChar method is used to remove the last character
         *   the Output text box is updated with the new text
         *   the OutputTracker text box is updated with the new text
         *        */

        private void Delete_Character_Click(object sender, EventArgs e)
        {
            if ((Button)sender is not null)
            {
                Output.Text = OutputTracker.Text = removeFinalChar(Output.Text);



            }
        }



        /* 
         *   removeFinalChar method is used to remove the last character in the text box
         *   if the text box is not empty, the last character is removed
         *   if the text box is empty, the text box is set to empty
         *   the new text is returned
         *           */

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