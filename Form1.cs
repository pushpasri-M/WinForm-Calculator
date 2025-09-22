namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        double value = 0;
        string operation = "";
        bool operationPressed = false;

        public Form1()
        {
            InitializeComponent();
        }
        // Number button clicked
        public void button_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (operationPressed))
                textBox1.Clear();
            operationPressed = false;
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + b.Text;
        }
        // Operator button clicked
        public void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;                  
            value = Double.Parse(textBox1.Text); 
            operationPressed = true;
        }

        // Equals button clicked
        public void buttonEquals_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBox1.Text = (value + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (value - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (value * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (value / Double.Parse(textBox1.Text)).ToString();
                    break;
            }
            operationPressed = false;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            
            //Addition
          
            operator_Click(sender, e);


        }

        private void button16_Click(object sender, EventArgs e)
        {
            //Multiplication
              
            operator_Click(sender, e);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //division
           
            operator_Click(sender, e);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //Equals

            buttonEquals_Click(sender, e);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Subtraction
           
            operator_Click(sender, e);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //Clear
            textBox1.Text = "0";
        }


       /* System.Data.DataTable dt = new System.Data.DataTable();

            try
            {
                textBox1.Text = dt.Compute(textBox1.Text, "").ToString();
    }
            catch (DivideByZeroException)
            {
                textBox1.Text = "Error: Division by zero";
            }
            catch (Exception)
            {
    textBox1.Text = "Error";
}*/
    }


}
