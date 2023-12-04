namespace Calculator
{
    public partial class Form1 : Form
    {
        double Result;
        string Operator = "";
        bool isOPeraten = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void EnterNumbers(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            if (Output.Text == "0" || isOPeraten)
                Output.Text = "";
            {
                if (num.Text == ".")
                {
                    if (!Output.Text.Contains("."))
                    {
                        Output.Text = Output.Text + num.Text;
                    }
                }
                else
                {
                    Output.Text = Output.Text + num.Text;
                    isOPeraten = false;
                }
            }
        }

        private void operations(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            Result = Convert.ToDouble(Output.Text);
            Operator = num.Text;
            isOPeraten = true;
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

        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            Output.Text = "0";
            Result = 0;
        }
    }
}