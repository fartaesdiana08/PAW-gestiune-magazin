﻿namespace Proiect_PAW
{
    partial class VeziMagazin
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
            this.components = new System.ComponentModel.Container();
            this.listViewMagazin = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDenumire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLocatie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderProgram = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNrang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderParcare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificăToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ștergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fisierTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewMagazin
            // 
            this.listViewMagazin.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderDenumire,
            this.columnHeaderLocatie,
            this.columnHeaderProgram,
            this.columnHeaderNrang,
            this.columnHeaderParcare});
            this.listViewMagazin.ContextMenuStrip = this.contextMenuStrip1;
            this.listViewMagazin.FullRowSelect = true;
            this.listViewMagazin.GridLines = true;
            this.listViewMagazin.HideSelection = false;
            this.listViewMagazin.Location = new System.Drawing.Point(60, 47);
            this.listViewMagazin.Name = "listViewMagazin";
            this.listViewMagazin.Size = new System.Drawing.Size(488, 222);
            this.listViewMagazin.TabIndex = 0;
            this.listViewMagazin.UseCompatibleStateImageBehavior = false;
            this.listViewMagazin.View = System.Windows.Forms.View.Details;
            this.listViewMagazin.SelectedIndexChanged += new System.EventHandler(this.listViewMagazin_SelectedIndexChanged);
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            // 
            // columnHeaderDenumire
            // 
            this.columnHeaderDenumire.Text = "Denumire";
            this.columnHeaderDenumire.Width = 97;
            // 
            // columnHeaderLocatie
            // 
            this.columnHeaderLocatie.Text = "Locatie";
            this.columnHeaderLocatie.Width = 104;
            // 
            // columnHeaderProgram
            // 
            this.columnHeaderProgram.Text = "Program";
            this.columnHeaderProgram.Width = 78;
            // 
            // columnHeaderNrang
            // 
            this.columnHeaderNrang.Text = "Numar angajati";
            this.columnHeaderNrang.Width = 84;
            // 
            // columnHeaderParcare
            // 
            this.columnHeaderParcare.Text = "Parcare";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificăToolStripMenuItem,
            this.ștergeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // modificăToolStripMenuItem
            // 
            this.modificăToolStripMenuItem.Name = "modificăToolStripMenuItem";
            this.modificăToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificăToolStripMenuItem.Text = "Modifică";
            this.modificăToolStripMenuItem.Click += new System.EventHandler(this.modificăToolStripMenuItem_Click);
            // 
            // ștergeToolStripMenuItem
            // 
            this.ștergeToolStripMenuItem.Name = "ștergeToolStripMenuItem";
            this.ștergeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ștergeToolStripMenuItem.Text = "Șterge";
            this.ștergeToolStripMenuItem.Click += new System.EventHandler(this.ștergeToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierTextToolStripMenuItem,
            this.printareToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(608, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fisierTextToolStripMenuItem
            // 
            this.fisierTextToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salveazaToolStripMenuItem,
            this.incarcaToolStripMenuItem});
            this.fisierTextToolStripMenuItem.Name = "fisierTextToolStripMenuItem";
            this.fisierTextToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.fisierTextToolStripMenuItem.Text = "Fișier text";
            // 
            // salveazaToolStripMenuItem
            // 
            this.salveazaToolStripMenuItem.Name = "salveazaToolStripMenuItem";
            this.salveazaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salveazaToolStripMenuItem.Text = "Salvează";
            this.salveazaToolStripMenuItem.Click += new System.EventHandler(this.salveazaToolStripMenuItem_Click);
            // 
            // incarcaToolStripMenuItem
            // 
            this.incarcaToolStripMenuItem.Name = "incarcaToolStripMenuItem";
            this.incarcaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.incarcaToolStripMenuItem.Text = "Încarcă";
            this.incarcaToolStripMenuItem.Click += new System.EventHandler(this.incarcaToolStripMenuItem_Click);
            // 
            // printareToolStripMenuItem
            // 
            this.printareToolStripMenuItem.Name = "printareToolStripMenuItem";
            this.printareToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.printareToolStripMenuItem.Text = "Printare";
            this.printareToolStripMenuItem.Click += new System.EventHandler(this.printareToolStripMenuItem_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // VeziMagazin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 334);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.listViewMagazin);
            this.Name = "VeziMagazin";
            this.Text = "VeziMagazin";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewMagazin;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderDenumire;
        private System.Windows.Forms.ColumnHeader columnHeaderLocatie;
        private System.Windows.Forms.ColumnHeader columnHeaderProgram;
        private System.Windows.Forms.ColumnHeader columnHeaderNrang;
        private System.Windows.Forms.ColumnHeader columnHeaderParcare;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fisierTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incarcaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modificăToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ștergeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printareToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}