namespace Proiect_PAW
{
    partial class VeziRaion
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
            this.listViewRaion = new System.Windows.Forms.ListView();
            this.columnHeaderCod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDenumire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSef = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificăToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ștergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fisierTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazăToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.încarcăToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printeazăToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewRaion
            // 
            this.listViewRaion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCod,
            this.columnHeaderDenumire,
            this.columnHeaderSef});
            this.listViewRaion.ContextMenuStrip = this.contextMenuStrip1;
            this.listViewRaion.FullRowSelect = true;
            this.listViewRaion.GridLines = true;
            this.listViewRaion.HideSelection = false;
            this.listViewRaion.Location = new System.Drawing.Point(112, 56);
            this.listViewRaion.Name = "listViewRaion";
            this.listViewRaion.Size = new System.Drawing.Size(354, 210);
            this.listViewRaion.TabIndex = 0;
            this.listViewRaion.UseCompatibleStateImageBehavior = false;
            this.listViewRaion.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderCod
            // 
            this.columnHeaderCod.Text = "Cod raion";
            // 
            // columnHeaderDenumire
            // 
            this.columnHeaderDenumire.Text = "Denumire";
            this.columnHeaderDenumire.Width = 90;
            // 
            // columnHeaderSef
            // 
            this.columnHeaderSef.Text = "Sef raion";
            this.columnHeaderSef.Width = 200;
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
            this.fisierTextToolStripMenuItem,
            this.printeazăToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(585, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fisierTextToolStripMenuItem
            // 
            this.fisierTextToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salveazăToolStripMenuItem,
            this.încarcăToolStripMenuItem});
            this.fisierTextToolStripMenuItem.Name = "fisierTextToolStripMenuItem";
            this.fisierTextToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.fisierTextToolStripMenuItem.Text = "Fișier text";
            // 
            // salveazăToolStripMenuItem
            // 
            this.salveazăToolStripMenuItem.Name = "salveazăToolStripMenuItem";
            this.salveazăToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salveazăToolStripMenuItem.Text = "Salvează";
            this.salveazăToolStripMenuItem.Click += new System.EventHandler(this.salveazăToolStripMenuItem_Click);
            // 
            // încarcăToolStripMenuItem
            // 
            this.încarcăToolStripMenuItem.Name = "încarcăToolStripMenuItem";
            this.încarcăToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.încarcăToolStripMenuItem.Text = "Încarcă";
            this.încarcăToolStripMenuItem.Click += new System.EventHandler(this.încarcăToolStripMenuItem_Click);
            // 
            // printeazăToolStripMenuItem
            // 
            this.printeazăToolStripMenuItem.Name = "printeazăToolStripMenuItem";
            this.printeazăToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.printeazăToolStripMenuItem.Text = "Printare";
            this.printeazăToolStripMenuItem.Click += new System.EventHandler(this.printeazăToolStripMenuItem_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // VeziRaion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 337);
            this.Controls.Add(this.listViewRaion);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VeziRaion";
            this.Text = "VeziRaion";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewRaion;
        private System.Windows.Forms.ColumnHeader columnHeaderCod;
        private System.Windows.Forms.ColumnHeader columnHeaderDenumire;
        private System.Windows.Forms.ColumnHeader columnHeaderSef;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fisierTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazăToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem încarcăToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modificăToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ștergeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printeazăToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}