namespace KapitalBank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        


        private void button1_Click(object sender, EventArgs e)
        {
            int[] pinCode = {1994,1998,1996 };
            int input = Convert.ToInt16(textBox1.Text);

            if (input == pinCode[0] | input == pinCode[1] | input == pinCode[2])
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Visible = false;
            }
            else
            {
                yalnislbl.Visible = true;
            }

        }
    }
}
