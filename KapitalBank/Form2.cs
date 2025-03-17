namespace KapitalBank
{
    public partial class Form2 : Form
    {
        private decimal balans;
        public Form2(decimal gelenBalans)
        {
            InitializeComponent();
            balans = gelenBalans;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(balans);
            form3.Show();
            this.Visible = false;

        }
    }
}
