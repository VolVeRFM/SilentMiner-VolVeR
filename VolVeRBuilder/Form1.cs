using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using VolVeRBuilder.Forms;

namespace VolVeRBuilder
{
    public partial class Form1 : Form
    {

        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        

        public Form1()
        {
            InitializeComponent();
            random = new Random();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                
           
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);



        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(childForm);
            this.panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
  
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            OpenChildForm(new VGIU(), sender);



        }
   


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Reset();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new VGIU(), sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Application.Exit();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void paneltitle(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Panel(), sender);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Builder(), sender);
        }    }
}
