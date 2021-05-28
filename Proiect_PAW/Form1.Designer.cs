namespace Proiect_PAW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonIncepe = new System.Windows.Forms.Button();
            this.tbRegistru = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonIncepe
            // 
            this.buttonIncepe.Location = new System.Drawing.Point(243, 211);
            this.buttonIncepe.Name = "buttonIncepe";
            this.buttonIncepe.Size = new System.Drawing.Size(103, 33);
            this.buttonIncepe.TabIndex = 0;
            this.buttonIncepe.Text = "Începe!";
            this.buttonIncepe.UseVisualStyleBackColor = true;
            this.buttonIncepe.Click += new System.EventHandler(this.buttonIncepe_Click);
            // 
            // tbRegistru
            // 
            this.tbRegistru.Location = new System.Drawing.Point(243, 164);
            this.tbRegistru.Name = "tbRegistru";
            this.tbRegistru.Size = new System.Drawing.Size(100, 20);
            this.tbRegistru.TabIndex = 1;
            this.tbRegistru.Text = "Registru magazine";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(597, 316);
            this.Controls.Add(this.tbRegistru);
            this.Controls.Add(this.buttonIncepe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIncepe;
        private System.Windows.Forms.TextBox tbRegistru;
    }
}

