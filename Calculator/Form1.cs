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
    }
}