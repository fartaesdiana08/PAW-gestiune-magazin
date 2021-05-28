using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace Proiect_PAW
{
    public partial class VeziMagazin : Form
    {
        //pentru printare
        private Font arial10Font;
        private StreamReader reader;

        public VeziMagazin(List<Magazine> listamagazine)
        {
            InitializeComponent();
            foreach (Magazine m in listamagazine)
            {
                ListViewItem lvi = new ListViewItem(m.idMagazin.ToString());
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, m.denumire));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, m.locatie));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, m.program));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, m.nrAngajati.ToString()));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, m.parcare));
                lvi.Tag = m;

                listViewMagazin.Items.Add(lvi);
            }
        }

        private void listViewMagazin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void salveazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "(*.txt)|.txt";
            sf.ShowDialog();
            string fisier = sf.FileName;


            StreamWriter sw = new StreamWriter(fisier);
            foreach (ListViewItem lvi in listViewMagazin.Items)
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

        private void incarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();

            string fisier = fd.FileName;

            CitesteDate(fisier);

        }

        private void CitesteDate(string fisier)
        {
            List<Magazine> lista = new List<Magazine>();

            try
            {
                StreamReader sr = new StreamReader(fisier);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    int idMagazin = Convert.ToInt32(line.Split(',')[0]);
                    string denumire = line.Split(',')[1];
                    string locatie = line.Split(',')[2];
                    string program = line.Split(',')[3];
                    int nrAngajati = Convert.ToInt32(line.Split(',')[4]);
                    string parcare = line.Split(',')[5];
                    lista.Add(new Magazine(idMagazin, denumire, locatie, program, nrAngajati, parcare));
                }
                sr.Close();
            }
            catch
            {
                MessageBox.Show("Eroare");
            }

            foreach (Magazine m in lista)
            {
                ListViewItem lvi = new ListViewItem(m.idMagazin.ToString());
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, m.denumire));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, m.locatie));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, m.program));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, m.nrAngajati.ToString()));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, m.parcare));
                lvi.Tag = m;

                listViewMagazin.Items.Add(lvi);
            }
        }

        private void ștergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewMagazin.SelectedItems[0].Remove();
        }

        private void modificăToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Magazine m = (Magazine)listViewMagazin.SelectedItems[0].Tag;
            ModifMag mdf = new ModifMag(m);
            mdf.ShowDialog();

            if (mdf.DialogResult == DialogResult.OK)
            {
                ListViewItem lvi = listViewMagazin.SelectedItems[0];
                lvi.Text = m.idMagazin.ToString();
                lvi.SubItems[1].Text = m.denumire;
                lvi.SubItems[2].Text = m.locatie;
                lvi.SubItems[3].Text = m.program;
                lvi.SubItems[4].Text = m.nrAngajati.ToString();
                lvi.SubItems[5].Text = m.parcare;
            }
         
        }

        private void printareToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
     
