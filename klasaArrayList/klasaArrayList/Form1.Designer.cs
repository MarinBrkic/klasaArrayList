﻿namespace klasaArrayList
{
    partial class Form1
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
            this.buttonNovi = new System.Windows.Forms.Button();
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.buttonUnesi = new System.Windows.Forms.Button();
            this.textBoxNovi = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonNovi
            // 
            this.buttonNovi.Location = new System.Drawing.Point(12, 12);
            this.buttonNovi.Name = "buttonNovi";
            this.buttonNovi.Size = new System.Drawing.Size(184, 32);
            this.buttonNovi.TabIndex = 0;
            this.buttonNovi.Text = "Novi Automobil";
            this.buttonNovi.UseVisualStyleBackColor = true;
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.Location = new System.Drawing.Point(12, 350);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(184, 30);
            this.buttonObrisi.TabIndex = 1;
            this.buttonObrisi.Text = "Obrisi Listu";
            this.buttonObrisi.UseVisualStyleBackColor = true;
            // 
            // buttonUnesi
            // 
            this.buttonUnesi.Location = new System.Drawing.Point(276, 60);
            this.buttonUnesi.Name = "buttonUnesi";
            this.buttonUnesi.Size = new System.Drawing.Size(106, 33);
            this.buttonUnesi.TabIndex = 2;
            this.buttonUnesi.Text = "Unesi";
            this.buttonUnesi.UseVisualStyleBackColor = true;
            this.buttonUnesi.Click += new System.EventHandler(this.buttonUnesi_Click);
            // 
            // textBoxNovi
            // 
            this.textBoxNovi.Location = new System.Drawing.Point(12, 63);
            this.textBoxNovi.Name = "textBoxNovi";
            this.textBoxNovi.Size = new System.Drawing.Size(217, 26);
            this.textBoxNovi.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 121);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(370, 206);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBoxNovi);
            this.Controls.Add(this.buttonUnesi);
            this.Controls.Add(this.buttonObrisi);
            this.Controls.Add(this.buttonNovi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNovi;
        private System.Windows.Forms.Button buttonObrisi;
        private System.Windows.Forms.Button buttonUnesi;
        private System.Windows.Forms.TextBox textBoxNovi;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

