namespace KapitalBank
{
    public partial class Form3 : Form
    {
        private decimal balans;
        public Form3(decimal gelenBalans)
        {
            InitializeComponent();
            balans = gelenBalans;
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {



            balanslbl.Visible = true;
            balanslbl2.Visible = true;
            balanslbl2.Text = balans.ToString();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                decimal inputAzn = Convert.ToDecimal(textBox1.Text);

                if (inputAzn <= balans)
                {
                    ugurlulbl.Visible = true;
                    textBox1.Text = "";
                    balanslbl.Visible = false;
                    balanslbl2.Visible = false;
                    balans -= inputAzn;
                    balanslbl2.Text = $"{balans}";
                    ugurlulbl.Text = "Emeliyyat ugurla heyata kecirildi";
                }
                else if (balans == 0)
                {
                    ugurlulbl.Visible = true;
                    ugurlulbl.Text = "           Balansiniz 0 AZN - dir";
                    textBox1.Text = "";
                }
                else
                {
                    ugurlulbl.Visible = true;
                    ugurlulbl.Text = "Balansda yeterli vesait yoxdur";
                    textBox1.Text = "";
                    balanslbl.Visible = false;
                    balanslbl2.Visible = false;
                }
            }
            catch (FormatException)
            {
                ugurlulbl.Visible = true;
                ugurlulbl.Text = "Duzgun mebleg daxil edin";
                textBox1.Text = "";
            }
        }
    }
}
