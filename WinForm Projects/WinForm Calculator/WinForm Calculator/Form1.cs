namespace WinForm_Calculator
{
    public partial class Calculator : Form
    {
        private double number1;
        private double number2;
        private string selectedOperator;

        public Calculator()
        {
            InitializeComponent();

            btnAdd.Click += btnAdd_Click;
            btnSubtract.Click += btnSubtract_Click;
            btnMultiply.Click += btnMultiply_Click;
            btnDivide.Click += btnDivide_Click;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            selectedOperator = "+";
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            selectedOperator = "-";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            selectedOperator = "*";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            selectedOperator = "/";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double number1 = double.Parse(txtNumber1.Text);
                double number2 = double.Parse(txtNumber2.Text);

                double result = 0;

                switch (selectedOperator)
                {
                    case "+":
                        result = number1 + number2;
                        break;
                    case "-":
                        result = number1 - number2;
                        break;
                    case "*":
                        result = number1 * number2;
                        break;
                    case "/":
                        if (number2 != 0)
                            result = number1 / number2;
                        else
                            MessageBox.Show("Cannot divide by zero. Please enter valid numbers.");
                        break;
                }

                lblResult.Text = result.ToString();

            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}