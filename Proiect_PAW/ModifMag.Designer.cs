namespace Proiect_PAW
{
    partial class ModifMag
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
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.tbLocatie = new System.Windows.Forms.TextBox();
            this.tbProgram = new System.Windows.Forms.TextBox();
            this.tbNrAng = new System.Windows.Forms.TextBox();
            this.labelParcare = new System.Windows.Forms.Label();
            this.labelNrang = new System.Windows.Forms.Label();
            this.labelProgram = new System.Windows.Forms.Label();
            this.labelLocatie = new System.Windows.Forms.Label();
            this.labelDenumire = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.cbParcare = new System.Windows.Forms.ComboBox();
            this.buttonModifica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(150, 23);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 20);
            this.tbID.TabIndex = 30;
            // 
            // tbDenumire
            // 
            this.tbDenumire.Location = new System.Drawing.Point(150, 62);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(100, 20);
            this.tbDenumire.TabIndex = 29;
            // 
            // tbLocatie
            // 
            this.tbLocatie.Location = new System.Drawing.Point(150, 97);
            this.tbLocatie.Name = "tbLocatie";
            this.tbLocatie.Size = new System.Drawing.Size(100, 20);
            this.tbLocatie.TabIndex = 28;
            // 
            // tbProgram
            // 
            this.tbProgram.Location = new System.Drawing.Point(150, 134);
            this.tbProgram.Name = "tbProgram";
            this.tbProgram.Size = new System.Drawing.Size(100, 20);
            this.tbProgram.TabIndex = 27;
            // 
            // tbNrAng
            // 
            this.tbNrAng.Location = new System.Drawing.Point(150, 171);
            this.tbNrAng.Name = "tbNrAng";
            this.tbNrAng.Size = new System.Drawing.Size(100, 20);
            this.tbNrAng.TabIndex = 26;
            // 
            // labelParcare
            // 
            this.labelParcare.AutoSize = true;
            this.labelParcare.Location = new System.Drawing.Point(81, 212);
            this.labelParcare.Name = "labelParcare";
            this.labelParcare.Size = new System.Drawing.Size(47, 13);
            this.labelParcare.TabIndex = 25;
            this.labelParcare.Text = "Parcare:";
            // 
            // labelNrang
            // 
            this.labelNrang.AutoSize = true;
            this.labelNrang.Location = new System.Drawing.Point(47, 178);
            this.labelNrang.Name = "labelNrang";
            this.labelNrang.Size = new System.Drawing.Size(81, 13);
            this.labelNrang.TabIndex = 24;
            this.labelNrang.Text = "Numar angajati:";
            // 
            // labelProgram
            // 
            this.labelProgram.AutoSize = true;
            this.labelProgram.Location = new System.Drawing.Point(79, 141);
            this.labelProgram.Name = "labelProgram";
            this.labelProgram.Size = new System.Drawing.Size(49, 13);
            this.labelProgram.TabIndex = 23;
            this.labelProgram.Text = "Program:";
            // 
            // labelLocatie
            // 
            this.labelLocatie.AutoSize = true;
            this.labelLocatie.Location = new System.Drawing.Point(81, 104);
            this.labelLocatie.Name = "labelLocatie";
            this.labelLocatie.Size = new System.Drawing.Size(45, 13);
            this.labelLocatie.TabIndex = 22;
            this.labelLocatie.Text = "Locatie:";
            // 
            // labelDenumire
            // 
            this.labelDenumire.AutoSize = true;
            this.labelDenumire.Location = new System.Drawing.Point(71, 69);
            this.labelDenumire.Name = "labelDenumire";
            this.labelDenumire.Size = new System.Drawing.Size(55, 13);
            this.labelDenumire.TabIndex = 21;
            this.labelDenumire.Text = "Denumire:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(96, 30);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(21, 13);
            this.labelID.TabIndex = 20;
            this.labelID.Text = "ID:";
            // 
            // cbParcare
            // 
            this.cbParcare.FormattingEnabled = true;
            this.cbParcare.Items.AddRange(new object[] {
            "Da",
            "Nu"});
            this.cbParcare.Location = new System.Drawing.Point(150, 209);
            this.cbParcare.Name = "cbParcare";
            this.cbParcare.Size = new System.Drawing.Size(100, 21);
            this.cbParcare.TabIndex = 19;
            // 
            // buttonModifica
            // 
            this.buttonModifica.Location = new System.Drawing.Point(114, 259);
            this.buttonModifica.Name = "buttonModifica";
            this.buttonModifica.Size = new System.Drawing.Size(75, 23);
            this.buttonModifica.TabIndex = 31;
            this.buttonModifica.Text = "Modifică";
            this.buttonModifica.UseVisualStyleBackColor = true;
            this.buttonModifica.Click += new System.EventHandler(this.buttonModifica_Click);
            // 
            // ModifMag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 294);
            this.Controls.Add(this.buttonModifica);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.tbDenumire);
            this.Controls.Add(this.tbLocatie);
            this.Controls.Add(this.tbProgram);
            this.Controls.Add(this.tbNrAng);
            this.Controls.Add(this.labelParcare);
            this.Controls.Add(this.labelNrang);
            this.Controls.Add(this.labelProgram);
            this.Controls.Add(this.labelLocatie);
            this.Controls.Add(this.labelDenumire);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.cbParcare);
            this.Name = "ModifMag";
            this.Text = "ModifMag";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.TextBox tbLocatie;
        private System.Windows.Forms.TextBox tbProgram;
        private System.Windows.Forms.TextBox tbNrAng;
        private System.Windows.Forms.Label labelParcare;
        private System.Windows.Forms.Label labelNrang;
        private System.Windows.Forms.Label labelProgram;
        private System.Windows.Forms.Label labelLocatie;
        private System.Windows.Forms.Label labelDenumire;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.ComboBox cbParcare;
        private System.Windows.Forms.Button buttonModifica;
    }
}