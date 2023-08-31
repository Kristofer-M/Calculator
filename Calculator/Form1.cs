using System.Data;
using org.matheval;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public String input;
        public String expression;
        public Dictionary<String, String> operators = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
            operators.Add("×", "*");
            operators.Add("÷", "/");
        }


        private void buttonEquals_Click(object sender, EventArgs e)
        {
            string output = "NONE";

            try
            {
                //double result = Convert.ToDouble(new DataTable().Compute(expression, null));
                var mathExpression = new Expression(expression);
                output = mathExpression.Eval().ToString();
            }
            catch (System.Data.SyntaxErrorException)
            {
                output = "ERROR";
            }
            finally
            {
                updateOutput(output);
            }
        }

        private void updateInput(String text)
        {
            if (operators.ContainsKey(text))
            {
                expression += operators[text];
            }
            else
            {
                expression += text;
            }
            input += text;

            tbInput.Text = input;
        }

        private void updateOutput(String text)
        {
            tbInput.Text = text;
            if (text != "ERROR")
            {
                input = text;
            }
            else
            {
                input = "";
            }

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            expression = expression.Remove(expression.Length - 1);
            input = input.Remove(input.Length - 1);
            tbInput.Text = input;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            expression = "";
            input = "";
            tbInput.Text = input;
        }

        private void number1_Click(object sender, EventArgs e)
        {
            updateInput("1");
        }


        private void number2_Click(object sender, EventArgs e)
        {
            updateInput("2");
        }

        private void number3_Click(object sender, EventArgs e)
        {
            updateInput("3");
        }

        private void number4_Click(object sender, EventArgs e)
        {
            updateInput("4");
        }

        private void number5_Click(object sender, EventArgs e)
        {
            updateInput("5");
        }

        private void number6_Click(object sender, EventArgs e)
        {
            updateInput("6");
        }

        private void number7_Click(object sender, EventArgs e)
        {
            updateInput("7");
        }

        private void number8_Click(object sender, EventArgs e)
        {
            updateInput("8");
        }

        private void number9_Click(object sender, EventArgs e)
        {
            updateInput("9");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            updateInput("0");
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            updateInput("×");
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            updateInput("-");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            updateInput("+");
        }

        private void buttonDIv_Click(object sender, EventArgs e)
        {
            updateInput("÷");
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            updateInput(".");
        }

        private void buttonPower_Click(object sender, EventArgs e)
        {
            updateInput("^");
        }

        private void buttonOpenBracket_Click(object sender, EventArgs e)
        {
            updateInput("(");
        }

        private void buttonCloseBracket_Click(object sender, EventArgs e)
        {
            updateInput(")");
        }
    }
}