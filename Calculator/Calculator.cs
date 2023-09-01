using System.Data;
using org.matheval;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public String input;
        public String expression;
        public Dictionary<String, String> operators = new Dictionary<string, string>()
        {
            {"×", "*" },
            {"÷", "/" },
            {"√(", "sqrt(" },
            {"%", "/100" }
        };
        public String memory = null;
        public Calculator()
        {
            InitializeComponent();
        }

        // MATH EVALUATION
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            string output = "";

            try
            {
                //double result = Convert.ToDouble(new DataTable().Compute(expression, null));
                if (!string.IsNullOrEmpty(expression))
                {
                    var mathExpression = new Expression(expression);
                    double number;
                    output = mathExpression.Eval().ToString();

                    if (double.TryParse(output, out number))
                    {
                        if (number % 1 == 0)
                        {
                            int wholeNumber = (int)number;
                            output = wholeNumber.ToString();
                        }
                    }
                }
            }
            catch (Exception)
            {
                output = "ERROR";
            }
            finally
            {
                updateOutput(output);
            }
        }

        // I/O
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
                expression = text;
            }
            else
            {
                input = "";
                expression = "";
            }

        }

        // DELETION
        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(expression))
            {
                expression = "";
                input = "";
                tbInput.Text = "";
            }
            else
            {
                expression = expression.Remove(expression.Length - 1);
                input = input.Remove(input.Length - 1);
                tbInput.Text = input;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            expression = "";
            input = "";
            tbInput.Text = input;
        }


        // MEMORY
        private void buttonMemoryPlus_Click(object sender, EventArgs e)
        {
            memoryOperation("+");
        }

        private void buttonMemoryMinus_Click(object sender, EventArgs e)
        {
            memoryOperation("-");
        }

        private void memoryOperation(string op)
        {
            if (!int.TryParse(expression, out _))
            {
                tbInput.Text = "ERROR";
                input = "";
                expression = "";
            }
            else
            {
                if (string.IsNullOrEmpty(memory))
                {
                    memory = expression;
                    tbMemory.Text = memory;
                }
                else
                {
                    var mathExpression = new Expression(expression + op + memory);
                    string output = mathExpression.Eval().ToString();
                    updateOutput(output);
                }
            }
        }

        private void buttonMemoryClear_Click(object sender, EventArgs e)
        {
            memory = null;
            tbMemory.Text = null;   
        }

        // PERCENT
        private void buttonPercent_Click(object sender, EventArgs e)
        {
            int start = expression.LastIndexOf("(");
            if (start == -1) { start = 0; }
            else { start++; }
            int end = expression.Length - 1;
            while (int.TryParse(expression[end].ToString(), out _) && end != 0)
            {
                end--;
            }
            if (end == start)
            {
                tbInput.Text = "ERROR";
                input = "";
                expression = "";
            }
            else
            {
                //end--;
                updateInput("%");
                var subExpression = new Expression(expression.Substring(start, end - start));
                string subResult = subExpression.Eval().ToString();
                expression = expression.Replace(expression.Substring(start, end - start), subResult);
                expression += "*" + subResult + ")";
                expression = expression.Insert(end+1, "(");
            }
        }


        // NUMBERS AND OPERATIONS
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

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            updateInput("√(");
        }

        private void tbInput_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            int maxLength = 26;
            int minFontSize = 12;
            int maxFontSize = 36;

            float fontSize = maxFontSize - (textBox.Text.Length * (maxFontSize - minFontSize) / maxLength);

            if (fontSize < minFontSize)
            {
                fontSize = minFontSize;
            }
            else if (fontSize > maxFontSize)
            {
                fontSize = maxFontSize;
            }

            textBox.Font = new Font(textBox.Font.FontFamily, fontSize);
        }
    }
}