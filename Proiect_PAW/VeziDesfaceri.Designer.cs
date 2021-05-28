namespace Proiect_PAW
{
    partial class VeziDesfaceri
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
            this.listViewDesfaceri = new System.Windows.Forms.ListView();
            this.columnHeaderModalitate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderIncMin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderIncMax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTva = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLucr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificăToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ștergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fișierTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazăToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.încarcăToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewDesfaceri
            // 
            this.listViewDesfaceri.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderModalitate,
            this.columnHeaderIncMin,
            this.columnHeaderIncMax,
            this.columnHeaderTva,
            this.columnHeaderLucr});
            this.listViewDesfaceri.ContextMenuStrip = this.contextMenuStrip1;
            this.listViewDesfaceri.FullRowSelect = true;
            this.listViewDesfaceri.GridLines = true;
            this.listViewDesfaceri.HideSelection = false;
            this.listViewDesfaceri.Location = new System.Drawing.Point(51, 43);
            this.listViewDesfaceri.Name = "listViewDesfaceri";
            this.listViewDesfaceri.Size = new System.Drawing.Size(419, 207);
            this.listViewDesfaceri.TabIndex = 0;
            this.listViewDesfaceri.UseCompatibleStateImageBehavior = false;
            this.listViewDesfaceri.View = System.Windows.Forms.View.Details;
            this.listViewDesfaceri.SelectedIndexChanged += new System.EventHandler(this.listViewDesfaceri_SelectedIndexChanged);
            // 
            // columnHeaderModalitate
            // 
            this.columnHeaderModalitate.Text = "Modalitate";
            this.columnHeaderModalitate.Width = 69;
            // 
            // columnHeaderIncMin
            // 
            this.columnHeaderIncMin.Text = "Incasari Minime";
            this.columnHeaderIncMin.Width = 92;
            // 
            // columnHeaderIncMax
            // 
            this.columnHeaderIncMax.Text = "Incasari maxime";
            this.columnHeaderIncMax.Width = 91;
            // 
            // columnHeaderTva
            // 
            this.columnHeaderTva.Text = "TVA";
            this.columnHeaderTva.Width = 47;
            // 
            // columnHeaderLucr
            // 
            this.columnHeaderLucr.Text = "Lucrator Comercial";
            this.columnHeaderLucr.Width = 113;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificăToolStripMenuItem,
            this.ștergeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 48);
            // 
            // modificăToolStripMenuItem
            // 
            this.modificăToolStripMenuItem.Name = "modificăToolStripMenuItem";
            this.modificăToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.modificăToolStripMenuItem.Text = "Modifică";
            this.modificăToolStripMenuItem.Click += new System.EventHandler(this.modificăToolStripMenuItem_Click);
            // 
            // ștergeToolStripMenuItem
            // 
            this.ștergeToolStripMenuItem.Name = "ștergeToolStripMenuItem";
            this.ștergeToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.ștergeToolStripMenuItem.Text = "Șterge";
            this.ștergeToolStripMenuItem.Click += new System.EventHandler(this.ștergeToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fișierTextToolStripMenuItem,
            this.printareToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(554, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fișierTextToolStripMenuItem
            // 
            this.fișierTextToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salveazăToolStripMenuItem,
            this.încarcăToolStripMenuItem});
            this.fișierTextToolStripMenuItem.Name = "fișierTextToolStripMenuItem";
            this.fișierTextToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.fișierTextToolStripMenuItem.Text = "Fișier text";
            // 
            // salveazăToolStripMenuItem
            // 
            this.salveazăToolStripMenuItem.Name = "salveazăToolStripMenuItem";
            this.salveazăToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.salveazăToolStripMenuItem.Text = "Salvează";
            this.salveazăToolStripMenuItem.Click += new System.EventHandler(this.salveazăToolStripMenuItem_Click);
            // 
            // încarcăToolStripMenuItem
            // 
            this.încarcăToolStripMenuItem.Name = "încarcăToolStripMenuItem";
            this.încarcăToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.încarcăToolStripMenuItem.Text = "Încarcă";
            this.încarcăToolStripMenuItem.Click += new System.EventHandler(this.încarcăToolStripMenuItem_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printareToolStripMenuItem
            // 
            this.printareToolStripMenuItem.Name = "printareToolStripMenuItem";
            this.printareToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.printareToolStripMenuItem.Text = "Printare";
            this.printareToolStripMenuItem.Click += new System.EventHandler(this.printareToolStripMenuItem_Click);
            // 
            // VeziDesfaceri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 313);
            this.Controls.Add(this.listViewDesfaceri);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VeziDesfaceri";
            this.Text = "VeziDesfaceri";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewDesfaceri;
        private System.Windows.Forms.ColumnHeader columnHeaderModalitate;
        private System.Windows.Forms.ColumnHeader columnHeaderIncMin;
        private System.Windows.Forms.ColumnHeader columnHeaderIncMax;
        private System.Windows.Forms.ColumnHeader columnHeaderTva;
        private System.Windows.Forms.ColumnHeader columnHeaderLucr;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fișierTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazăToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem încarcăToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modificăToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ștergeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printareToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}