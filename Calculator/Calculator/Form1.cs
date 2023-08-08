namespace Calculator
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String opPerformed = "";
        bool isopPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void n_click(object sender, EventArgs e)
        {
            if ((textBox.Text == "0") || (isopPerformed))
                textBox.Clear();
            isopPerformed = false;
            Button n = (Button)sender;
            if (n.Text == "." ) 
            {
                if(!textBox.Text.Contains("."))
                    textBox.Text = textBox.Text + n.Text;

            }else
            textBox.Text = textBox.Text + n.Text;

        }

        private void op_click(object sender, EventArgs e)
        {
            Button n = (Button)sender;
            if (resultValue != 0)
            {
                nequal.PerformClick();
                opPerformed = n.Text;

                lcurrentOp.Text = resultValue + "" + opPerformed;
                isopPerformed = true;
            }
            else
            {
                opPerformed = n.Text;
                resultValue = Double.Parse(textBox.Text);
                lcurrentOp.Text = resultValue + "" + opPerformed;
                isopPerformed = true;
            }
        }

        private void nce_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
        }

        private void nc_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            resultValue = 0;
        }

        private void nequal_Click(object sender, EventArgs e)
        {
            switch (opPerformed)
            {
                case " + ":
                    textBox.Text = (resultValue + Double.Parse(textBox.Text)).ToString();
                    break;
                case " - ":
                    textBox.Text = (resultValue - Double.Parse(textBox.Text)).ToString();
                    break;
                case " * ":
                    textBox.Text = (resultValue * Double.Parse(textBox.Text)).ToString();
                    break;
                case " / ":
                    textBox.Text = (resultValue / Double.Parse(textBox.Text)).ToString();
                    break;
                default:
                    break;
            }

            resultValue = Double.Parse(textBox.Text);
            lcurrentOp.Text = "";
        }
    }
}