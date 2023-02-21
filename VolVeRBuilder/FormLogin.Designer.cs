namespace VolVeRBuilder
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(357, 1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 37);
            this.button4.TabIndex = 2;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(286, -1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 37);
            this.button3.TabIndex = 3;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox10
            // 
            this.textBox10.AccessibleDescription = "Login";
            this.textBox10.AccessibleName = "";
            this.textBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox10.ForeColor = System.Drawing.Color.Gray;
            this.textBox10.Location = new System.Drawing.Point(12, 55);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(406, 27);
            this.textBox10.TabIndex = 11;
            this.textBox10.Tag = "";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.iconButton1.IconColor = System.Drawing.Color.Gold;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(141, 98);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(156, 37);
            this.iconButton1.TabIndex = 12;
            this.iconButton1.Text = "Activate the key";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(430, 144);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paneltitle);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox10;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}