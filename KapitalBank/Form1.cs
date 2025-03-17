namespace KapitalBank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }





        public void button1_Click(object sender, EventArgs e)
        {
            int[] pinCode = { 1531, 7789, 0903 };
            int input = Convert.ToInt16(textBox1.Text);
            decimal balans = 0;

            if (input == pinCode[0])
            {
                balans = 700;
                Form2 form2 = new Form2(balans);
                form2.Show();
                this.Visible = false;
            }
            else if (input == pinCode[1])
            {
                balans = 1500;
                Form2 form2 = new Form2(balans);
                form2.Show();
                this.Visible = false;
            }
            if (input == pinCode[2])
            {
                balans = 950;
                Form2 form2 = new Form2(balans);
                form2.Show();
                this.Visible = false;
            }
            else
            {
                yalnislbl.Visible = true;
                return;
            }





        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button buttonOne = (Button)sender;
            textBox1.Text += buttonOne.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button buttonTwo = (Button)sender;
            textBox1.Text += buttonTwo.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button buttonThree = (Button)sender;
            textBox1.Text += buttonThree.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button buttonFour = (Button)sender;
            textBox1.Text += buttonFour.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button buttonFive = (Button)sender;
            textBox1.Text += buttonFive.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button buttonSix = (Button)sender;
            textBox1.Text += buttonSix.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button buttonSeven = (Button)sender;
            textBox1.Text += buttonSeven.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button buttonEight = (Button)sender;
            textBox1.Text += buttonEight.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button buttonNine = (Button)sender;
            textBox1.Text += buttonNine.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button buttonZero = (Button)sender;
            textBox1.Text += buttonZero.Text;
        }
    }
}
//3 user 1531 700 azn
// 7789       1500azn
//0903           950 azn