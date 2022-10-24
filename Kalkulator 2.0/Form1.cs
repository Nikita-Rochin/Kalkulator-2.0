namespace Kalkulator_2._0
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        double num1;
        string oper;
        int i;
        string[] num = new string[2];
        private void Btn_num(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;
        }
        private void Btn_oper(object sender, EventArgs e)
        {
            if (i == 1)
            {
                num = textBox1.Text.Split(",");
                num1 = Convert.ToDouble(num[0]) + Convert.ToDouble(num[1]) / Math.Pow(10, Convert.ToDouble(num[1].Length));
            }
            else
            {
                num1 = Convert.ToDouble(textBox1.Text);
            }
            oper = ((Button)sender).Text;
            i = 0;
            textBox1.Clear();
        }
        private void btn_zpt(object sender, EventArgs e)
        {
            if (i < 1)
            {
                textBox1.Text += ((Button)sender).Text;
                i++;
            }
        }
        
        private void button15_Click(object sender, EventArgs e)
        {
            double num2;
            if (i == 1)
            {
                num = textBox1.Text.Split(",");
                num2 = Convert.ToDouble(num[0]) + Convert.ToDouble(num[1]) / Math.Pow(10, Convert.ToDouble(num[1].Length));
            }
            else
            {
                num2 = Convert.ToDouble(textBox1.Text);
            }
            switch (oper)
            {
                case "+":
                    textBox1.Text = Convert.ToString(num1 += num2);
                    break;
                case "-":
                    textBox1.Text = Convert.ToString(num1 -= num2);
                    break;
                case "*":
                    textBox1.Text = Convert.ToString(num1 *= num2);
                    break;
                case "/":
                    textBox1.Text = Convert.ToString(num1 /= num2);
                    break;
            }
            oper = null;
            i = 0;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
            
}
