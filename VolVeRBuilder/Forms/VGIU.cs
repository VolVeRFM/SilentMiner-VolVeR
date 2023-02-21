using System;
using System.Windows.Forms;

namespace VolVeRBuilder.Forms
{
    public partial class VGIU : Form
    {
        public VGIU()
        {
            InitializeComponent();

            label4.Text = DateTime.Now.ToString("dd.MM.yyyy");
            

        }

        private void VGIU_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label5.Text = DateTime.Now.ToLongTimeString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

 

        private void label4_Click(object sender, EventArgs e)
        {
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();

        }
    }
}
