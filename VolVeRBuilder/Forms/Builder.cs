using System;
using System.Windows.Forms;

namespace VolVeRBuilder.Forms
{
    public partial class Builder : Form
    {
        public Builder()
        {
            InitializeComponent();
        }

        private Form activeForm;

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
             activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(childForm);
            this.panel3.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
             // lblTitle.Text = childForm.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void iconButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Build.Wallets(), sender);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Build.Misc(), sender);
        }

        private void Builder_Load(object sender, EventArgs e)
        {
            OpenChildForm(new Build.Wallets(), sender);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Build.Build(), sender);
        }
    }
}
