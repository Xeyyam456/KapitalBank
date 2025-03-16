﻿namespace KapitalBank
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        decimal balans = 2000M;
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            balanslbl.Visible = true;

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
            decimal inputAzn = Convert.ToDecimal(textBox1.Text);



            if (inputAzn <= balans)
            {
                ugurlulbl.Visible = true;
                textBox1.Text = "";
                balanslbl.Visible = false;
                balanslbl.Text = $"Balans: {balans -= inputAzn}";
                ugurlulbl.Text = "Emeliyyat ugurla heyata kecirildi";

            }
            else if (balans == 0)
            {
                ugurlulbl.Text = "                 Balansiniz 0 - dir";
                textBox1.Text = "";
            }
            else
            {
                ugurlulbl.Text = "Balansda yeterli vesait yoxdur";
                textBox1.Text = "";
                balanslbl.Visible = false;
            }


        }
    }
}
