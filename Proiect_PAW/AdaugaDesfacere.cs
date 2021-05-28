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
    public partial class AdaugaDesfacere : Form
    {
        private List<Desfaceri> listadesfaceri;
        public AdaugaDesfacere()
        {
            InitializeComponent();
            listadesfaceri = new List<Desfaceri>();
        }

        private void buttonInapoi_Click(object sender, EventArgs e)
        {
            Meniu menu = new Meniu();
            this.Hide();
            menu.Show();
        }

        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            Desfaceri d = new Desfaceri();
            bool adaugaok = true;
            d.modalitate = cbModalitate.Text;
            try
            {
                d.incasariMin = Convert.ToInt32(tbIncasariMin.Text);
            }
            catch
            {
                adaugaok = false;
                MessageBox.Show("Eroare conversie!", "Mesaj", MessageBoxButtons.RetryCancel);
            }
            try
            {
                d.incasariMax = Convert.ToInt32(tbIncasariMax.Text);
            }
            catch
            {
                adaugaok = false;
                MessageBox.Show("Eroare conversie!", "Mesaj", MessageBoxButtons.RetryCancel);
            }
            try
            {
                d.tva = Convert.ToDouble(tbTva.Text);
            }
            catch
            {
                adaugaok = false;
                MessageBox.Show("Eroare conversie!", "Mesaj", MessageBoxButtons.RetryCancel);
            }
            d.lucratorcomercial = tbLucratorCom.Text;
            if (adaugaok) adaugaredesfacere(d);
        }

        private void adaugaredesfacere(Desfaceri d)
        {
            listadesfaceri.Add(d);
        }

        private void buttonVeziDesf_Click(object sender, EventArgs e)
        {
            Form vezidesf = new VeziDesfaceri(listadesfaceri);
            vezidesf.ShowDialog();
        }

        private void buttonGrafic_Click(object sender, EventArgs e)
        {
            GraficVanzari gf = new GraficVanzari();
            gf.Show();
        }
    }
}
