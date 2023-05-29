namespace WinFormsApp_01_Calculator
    {
    public partial class Form1 : Form
        {
        public Form1 ()
            {
            InitializeComponent();
            }

        int number01, number02;
        double result;
        string str;

        private void button1_Click ( object sender, EventArgs e )
            {
            //textBox1.Text += 1.ToString();
            }

        private void button10_Click ( object sender, EventArgs e )
            {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
            }

        private void BTNplus_Click ( object sender, EventArgs e )
            {
            number01 = int.Parse(textBox1.Text);
            textBox1.Text = string.Empty;
            str = "+";
            }

        private void BTNsubtract_Click ( object sender, EventArgs e )
            {
            number01 = int.Parse(textBox1.Text);
            textBox1.Text = string.Empty;
            str = "-";
            }

        private void BTNMultiply_Click ( object sender, EventArgs e )
            {
            number01 = int.Parse(textBox1.Text);
            textBox1.Text = string.Empty;
            str = "*";
            }

        private void BTNDivide_Click ( object sender, EventArgs e )
            {
            number01 = int.Parse(textBox1.Text);
            textBox1.Text = string.Empty;
            str = "/";
            }

        private void btnEEqaual_Click ( object sender, EventArgs e )
            {
            number02 = int.Parse(textBox1.Text);
            switch (str)
                {
                case "+":
                    result = number01 + number02;
                    break;
                case "-":
                    result = number01 - number02;
                    break;
                case "*":
                    result = number01 * number02;
                    break;
                case "/":
                    result = number01 / (double)number02;
                    break;
                }
            textBox1.Text = result.ToString();
            }

        private void BTNClear_Click ( object sender, EventArgs e )
            {
            textBox1.Text = string.Empty;
            }
        }
    }