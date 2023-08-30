using System.Data;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public String input;
        public Form1()
        {
            InitializeComponent();
        }

        private void number1_Click(object sender, EventArgs e)
        {
            input += "1";
            updateInput();
        }

        private void updateInput()
        {
            tbInput.Text = input;
        }

        private void number2_Click(object sender, EventArgs e)
        {
            input += "2";
            updateInput();
        }

        private void number3_Click(object sender, EventArgs e)
        {
            input += "3";
            updateInput();
        }

        private void number4_Click(object sender, EventArgs e)
        {
            input += "4";
            updateInput();
        }

        private void number5_Click(object sender, EventArgs e)
        {
            input += "5";
            updateInput();
        }

        private void number6_Click(object sender, EventArgs e)
        {
            input += "6";
            updateInput();
        }

        private void number7_Click(object sender, EventArgs e)
        {
            input += "7";
            updateInput();
        }

        private void number8_Click(object sender, EventArgs e)
        {
            input += "8";
            updateInput();
        }

        private void number9_Click(object sender, EventArgs e)
        {
            input += "9";
            updateInput();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            input += "0";
            updateInput();
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            input += "*";
            updateInput();
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            input += "-";
            updateInput();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            input += "+";
            updateInput();
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            try
            {
                double result = Convert.ToDouble(new DataTable().Compute(input, null));
                input = result.ToString();
            } catch (System.Data.SyntaxErrorException)
            {
                input = "ERROR";
            }
            finally
            {
                updateInput();
            }
        }
    }
}