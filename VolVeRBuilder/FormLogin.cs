using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace VolVeRBuilder
{
    public partial class FormLogin : Form
    {
        public static Laucher.api KeyAuthApp = new Laucher.api(
    name: "Miner",
    ownerid: "MadarwX7Gm",
    secret: "7ba0432fd68c54117a191f2861639f66966e4afeeabc3ced7a",
    version: "1.0"
);

        public FormLogin()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void paneltitle(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        string path = Environment.GetEnvironmentVariable("AppData") + "\\TheKeyAut21";
        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (KeyAuthApp.license(textBox10.Text))
            {
                MessageBox.Show("Active");
                Form1 main = new Form1();
                main.Show();
                this.Hide();


                Directory.CreateDirectory(path);

                File.WriteAllText(path + "\\TestFile.txt", textBox10.Text);

            }

        }
 
            private void FormLogin_Load(object sender, EventArgs e)
        {

            string text = "";

            if (File.Exists(path + "\\TestFile.txt"))
            {
                
                using (StreamReader fs = new StreamReader(path + "\\TestFile.txt"))
                {
                    while (true)
                    {

                        string temp = fs.ReadLine();


                        if (temp == null) break;


                        text += temp;
                    }
                }
                KeyAuthApp.init();
                textBox10.Text = text;
 



            }
            else
            {
                KeyAuthApp.init();
            }






        }
    }
}
