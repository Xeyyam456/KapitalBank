namespace KapitalBank
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            yalnislbl = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(479, 476);
            button1.Name = "button1";
            button1.Size = new Size(271, 66);
            button1.TabIndex = 0;
            button1.Text = "Tesdiq edin";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(338, 30);
            label1.Name = "label1";
            label1.Size = new Size(546, 51);
            label1.TabIndex = 1;
            label1.Text = "Kapital Banka Xos Gelmisiniz.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(321, 261);
            label2.Name = "label2";
            label2.Size = new Size(592, 51);
            label2.TabIndex = 2;
            label2.Text = "Xahis edirik PIN kodu daxil edin";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Crimson;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(421, 361);
            textBox1.MaxLength = 4;
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.PlaceholderText = "PIN ";
            textBox1.Size = new Size(373, 32);
            textBox1.TabIndex = 3;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(421, 144);
            label3.Name = "label3";
            label3.Size = new Size(329, 51);
            label3.TabIndex = 4;
            label3.Text = "Hormetli musteri";
            // 
            // yalnislbl
            // 
            yalnislbl.AutoSize = true;
            yalnislbl.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            yalnislbl.ForeColor = SystemColors.ControlLightLight;
            yalnislbl.Location = new Point(522, 396);
            yalnislbl.Name = "yalnislbl";
            yalnislbl.Size = new Size(171, 25);
            yalnislbl.TabIndex = 5;
            yalnislbl.Text = "PIN kod yalnisdir!";
            yalnislbl.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Crimson;
            ClientSize = new Size(1198, 586);
            Controls.Add(yalnislbl);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Margin = new Padding(5);
            MaximumSize = new Size(1214, 625);
            MinimumSize = new Size(1214, 625);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label yalnislbl;
    }
}
