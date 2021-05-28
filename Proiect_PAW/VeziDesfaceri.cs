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
    public partial class VeziDesfaceri : Form
    {
        //pentru printare
        private Font arial10Font;
        private StreamReader reader;

        public VeziDesfaceri(List<Desfaceri> listadesfaceri)
        {
            InitializeComponent();
            foreach (Desfaceri d in listadesfaceri)
            {
                ListViewItem lvi = new ListViewItem(d.modalitate);
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, d.incasariMin.ToString()));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, d.incasariMax.ToString()));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, d.tva.ToString()));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, d.lucratorcomercial));
                lvi.Tag = d;

                listViewDesfaceri.Items.Add(lvi);
            }
        }

        private void listViewDesfaceri_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            List<Desfaceri> lista = new List<Desfaceri>();

            try
            {
                StreamReader sr = new StreamReader(fisier);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string modalitate = line.Split(',')[0];
                    int incasariMin = Convert.ToInt32(line.Split(',')[1]);
                    int incasariMax = Convert.ToInt32(line.Split(',')[2]);
                    double tva = Convert.ToDouble(line.Split(',')[3]);
                    string lucratorcomercial = line.Split(',')[4];
                    lista.Add(new Desfaceri(modalitate, incasariMin, incasariMax, tva, lucratorcomercial));
                }
                sr.Close();
            }
            catch
            {
                MessageBox.Show("Eroare");
            }

            foreach (Desfaceri d in lista)
            {
                ListViewItem lvi = new ListViewItem(d.modalitate);
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, d.incasariMin.ToString()));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, d.incasariMax.ToString()));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, d.tva.ToString()));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, d.lucratorcomercial));
                lvi.Tag = d;

                listViewDesfaceri.Items.Add(lvi);
            }
        }

        private void salveazăToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "(*.txt)|.txt";
            sf.ShowDialog();
            string fisier = sf.FileName;


            StreamWriter sw = new StreamWriter(fisier);
            foreach (ListViewItem lvi in listViewDesfaceri.Items)
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
            listViewDesfaceri.SelectedItems[0].Remove();
        }

        private void modificăToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Desfaceri d = (Desfaceri)listViewDesfaceri.SelectedItems[0].Tag;
            ModifDes mdf = new ModifDes(d);
            mdf.ShowDialog();

            if (mdf.DialogResult == DialogResult.OK)
            {
                ListViewItem lvi = listViewDesfaceri.SelectedItems[0];
                lvi.Text = d.modalitate;
                lvi.SubItems[1].Text = d.incasariMin.ToString();
                lvi.SubItems[2].Text = d.incasariMax.ToString();
                lvi.SubItems[3].Text = d.tva.ToString();
                lvi.SubItems[4].Text = d.lucratorcomercial;
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
    }
}
