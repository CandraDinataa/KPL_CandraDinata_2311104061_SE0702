﻿namespace TPMODUL3__2311104061
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
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.buttonGetNama = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(312, 113);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(100, 20);
            this.textBoxNama.TabIndex = 0;
            // 
            // buttonGetNama
            // 
            this.buttonGetNama.Location = new System.Drawing.Point(447, 113);
            this.buttonGetNama.Name = "buttonGetNama";
            this.buttonGetNama.Size = new System.Drawing.Size(75, 23);
            this.buttonGetNama.TabIndex = 1;
            this.buttonGetNama.Text = "GetName";
            this.buttonGetNama.UseVisualStyleBackColor = true;
            this.buttonGetNama.Click += new System.EventHandler(this.buttonGetNama_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGetNama);
            this.Controls.Add(this.textBoxNama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Button buttonGetNama;
    }
}

