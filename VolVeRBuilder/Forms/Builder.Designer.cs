
namespace VolVeRBuilder.Forms
{
    partial class Builder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Builder));
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.CommentDots;
            this.iconButton1.IconColor = System.Drawing.Color.YellowGreen;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(21, 21);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(331, 49);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.Text = "Wallets";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.iconButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Globe;
            this.iconButton2.IconColor = System.Drawing.Color.YellowGreen;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(348, 21);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(337, 49);
            this.iconButton2.TabIndex = 5;
            this.iconButton2.Text = "Misc";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.iconButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.iconButton3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Sun;
            this.iconButton3.IconColor = System.Drawing.Color.YellowGreen;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(682, 21);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(331, 49);
            this.iconButton3.TabIndex = 6;
            this.iconButton3.Text = "Build";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(8, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1012, 581);
            this.panel3.TabIndex = 7;
            // 
            // Builder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(1025, 652);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Builder";
            this.Text = "Builder";
            this.Load += new System.EventHandler(this.Builder_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.Panel panel3;
    }
}