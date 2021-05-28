using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class VeziRaion : Form
    {
        //pentru printare
        private Font arial10Font;
        private StreamReader reader;

        public VeziRaion(List<Raioane> listaraiaone)
        {
            InitializeComponent();
            foreach(Raioane r in listaraiaone)
            {
                ListViewItem lvi = new ListViewItem(r.codRaion.ToString());
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, r.denumire));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, r.sefRaion));
                lvi.Tag = r;

                listViewRaion.Items.Add(lvi);

            }
        }

        private void încarcăToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();

            string fisier = fd.FileName;

            CitesteDate(fisier);
        }

        private void CitesteDate(string fisier)
        {
            List<Raioane> lista = new List<Raioane>();

            try
            {
                StreamReader sr = new StreamReader(fisier);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    int codRaion = Convert.ToInt32(line.Split(',')[0]);
                    string denumire = line.Split(',')[1];
                    string sefRaion = line.Split(',')[2];
                    lista.Add(new Raioane(codRaion, denumire, sefRaion));
                }
                sr.Close();
            }
            catch
            {
                MessageBox.Show("Eroare");
            }

            foreach (Raioane r in lista)
            {
                ListViewItem lvi = new ListViewItem(r.codRaion.ToString());
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, r.denumire));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, r.sefRaion));
                lvi.Tag = r;

                listViewRaion.Items.Add(lvi);
            }
        }

        private void salveazăToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "(*.txt)|.txt";
            sf.ShowDialog();
            string fisier = sf.FileName;


            StreamWriter sw = new StreamWriter(fisier);
            foreach (ListViewItem lvi in listViewRaion.Items)
            {
                for (int i = 0; i < lvi.SubItems.Count; i++)
                {
                    sw.Write(lvi.SubItems[i].Text);
                    if (i != lvi.SubItems.Count - 1)
                        sw.Write(",");
                }
                sw.WriteLine();
            }
            sw.Close();
            MessageBox.Show("Fisierul s-a salvat ca: " + fisier);
        }

        private void ștergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewRaion.SelectedItems[0].Remove();
        }

        private void modificăToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raioane r = (Raioane)listViewRaion.SelectedItems[0].Tag;
            ModifRai mdf = new ModifRai(r);
            mdf.ShowDialog();

            if (mdf.DialogResult == DialogResult.OK)
            {
                ListViewItem lvi = listViewRaion.SelectedItems[0];
                lvi.Text = r.codRaion.ToString();
                lvi.SubItems[1].Text = r.denumire;
                lvi.SubItems[2].Text = r.sefRaion;
            }
        }

        private void printeazăToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                OpenFileDialog openfd = new OpenFileDialog();
                if (openfd.ShowDialog() == DialogResult.OK)
                {
                    string path = openfd.InitialDirectory + openfd.FileName;
                    reader = new StreamReader(path);
                    arial10Font = new Font("Arial", 10);

                    PrintDocument pd = new PrintDocument();
                    pd.PrintPage += new PrintPageEventHandler(this.PrintTextFileHandler);
                    pd.Print();
                    if (reader != null)
                        reader.Close();

                }
            }
        }

        private void PrintTextFileHandler(object sender, PrintPageEventArgs ppe)
        {
            Graphics g = ppe.Graphics;
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            //marginile paginii
            float leftMargin = ppe.MarginBounds.Left;
            float topMargin = ppe.MarginBounds.Top;
            string line = null;

            linesPerPage = ppe.MarginBounds.Height / arial10Font.GetHeight(g);

            while (count < linesPerPage && ((line = reader.ReadLine()) != null))
            {
                yPos = topMargin + (count * arial10Font.GetHeight(g));
                g.DrawString(line, arial10Font, Brushes.Black, leftMargin, yPos, new StringFormat());
                count++;
            }

            //pentru multiple pagini
            if (line != null)
            {
                ppe.HasMorePages = true;
            }
            else
            {
                ppe.HasMorePages = false;
            }
        }
    }
}
