namespace Proiect_PAW
{
    partial class Meniu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Meniu));
            this.buttonMagazine = new System.Windows.Forms.Button();
            this.buttonRaioane = new System.Windows.Forms.Button();
            this.buttonDesfaceri = new System.Windows.Forms.Button();
            this.buttonInapoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMagazine
            // 
            this.buttonMagazine.Location = new System.Drawing.Point(246, 112);
            this.buttonMagazine.Name = "buttonMagazine";
            this.buttonMagazine.Size = new System.Drawing.Size(100, 29);
            this.buttonMagazine.TabIndex = 0;
            this.buttonMagazine.Text = "Magazine";
            this.buttonMagazine.UseVisualStyleBackColor = true;
            this.buttonMagazine.Click += new System.EventHandler(this.buttonMagazine_Click);
            // 
            // buttonRaioane
            // 
            this.buttonRaioane.Location = new System.Drawing.Point(246, 160);
            this.buttonRaioane.Name = "buttonRaioane";
            this.buttonRaioane.Size = new System.Drawing.Size(100, 30);
            this.buttonRaioane.TabIndex = 1;
            this.buttonRaioane.Text = "Raioane";
            this.buttonRaioane.UseVisualStyleBackColor = true;
            this.buttonRaioane.Click += new System.EventHandler(this.buttonRaioane_Click);
            // 
            // buttonDesfaceri
            // 
            this.buttonDesfaceri.Location = new System.Drawing.Point(246, 216);
            this.buttonDesfaceri.Name = "buttonDesfaceri";
            this.buttonDesfaceri.Size = new System.Drawing.Size(100, 31);
            this.buttonDesfaceri.TabIndex = 2;
            this.buttonDesfaceri.Text = "Desfaceri";
            this.buttonDesfaceri.UseVisualStyleBackColor = true;
            this.buttonDesfaceri.Click += new System.EventHandler(this.buttonDesfaceri_Click);
            // 
            // buttonInapoi
            // 
            this.buttonInapoi.Location = new System.Drawing.Point(246, 272);
            this.buttonInapoi.Name = "buttonInapoi";
            this.buttonInapoi.Size = new System.Drawing.Size(100, 29);
            this.buttonInapoi.TabIndex = 3;
            this.buttonInapoi.Text = "Inapoi";
            this.buttonInapoi.UseVisualStyleBackColor = true;
            this.buttonInapoi.Click += new System.EventHandler(this.buttonInapoi_Click);
            // 
            // Meniu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(596, 325);
            this.Controls.Add(this.buttonInapoi);
            this.Controls.Add(this.buttonDesfaceri);
            this.Controls.Add(this.buttonRaioane);
            this.Controls.Add(this.buttonMagazine);
            this.Name = "Meniu";
            this.Text = "Meniu";
            this.Load += new System.EventHandler(this.Meniu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMagazine;
        private System.Windows.Forms.Button buttonRaioane;
        private System.Windows.Forms.Button buttonDesfaceri;
        private System.Windows.Forms.Button buttonInapoi;
    }
}