using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class AdaugaRaion : Form
    {
        private List<Raioane> listaraioane;
        public AdaugaRaion()
        {
            InitializeComponent();
            listaraioane = new List<Raioane>();
        }

        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            Raioane r = new Raioane();
            bool adaugaok = true;
            try
            {
                r.codRaion = Convert.ToInt32(tbCod.Text);
            }
            catch
            {
                adaugaok = false;
                MessageBox.Show("Eroare conversie!", "Mesaj", MessageBoxButtons.RetryCancel);
            }
            r.denumire = tbDenumire.Text;
            r.sefRaion = tbSef.Text;

            if (adaugaok) adaugareraion(r);
        }

        private void adaugareraion(Raioane r)
        {
            listaraioane.Add(r);
        }

        private void buttonVeziRaion_Click(object sender, EventArgs e)
        {
            Form vezirai = new VeziRaion(listaraioane);
            vezirai.ShowDialog();
        }

        private void buttonInapoi_Click(object sender, EventArgs e)
        {
            Meniu menu = new Meniu();
            this.Hide();
            menu.Show();
        }
    }
}
