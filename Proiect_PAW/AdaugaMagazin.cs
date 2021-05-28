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

namespace Proiect_PAW
{
    public partial class AdaugaMagazin : Form
    {
        private List<Magazine> listamagazine;
        public AdaugaMagazin()
        {
            InitializeComponent();
            listamagazine = new List<Magazine>();
        }

        private void buttonInapoi_Click(object sender, EventArgs e)
        {
            Meniu menu = new Meniu();
            this.Hide();
            menu.Show();
        }

        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            Magazine m = new Magazine();
            bool adaugaok = true;
            try
            {
                m.idMagazin = Convert.ToInt32(tbID.Text);
            }
            catch
            {
                adaugaok = false;
                MessageBox.Show("Eroare conversie!", "Mesaj", MessageBoxButtons.RetryCancel);
            }
            m.denumire = tbDenumire.Text;
            m.locatie = tbLocatie.Text;
            m.program = tbProgram.Text;
            try
            {
                m.nrAngajati = Convert.ToInt32(tbNrAng.Text);
            }
            catch
            {
                adaugaok = false;
                MessageBox.Show("Eroare conversie!", "Mesaj", MessageBoxButtons.RetryCancel);
            }
            m.parcare = cbParcare.Text;

            //ERROR PROVIDER;
            if (tbDenumire.Text == "")
            {
                tbDenumire.Focus();
                errorProvider1.SetError(tbDenumire, "Completeaza câmpul denumire!");
                adaugaok = false;

            }

            if (adaugaok) adaugaremagazin(m);
        }

        private void adaugaremagazin(Magazine m)
        {
            listamagazine.Add(m);

        }

        private void buttonVeziMagazin_Click(object sender, EventArgs e)
        {
            Form vezimag = new VeziMagazin(listamagazine);
            vezimag.ShowDialog();
        }


    }
}
