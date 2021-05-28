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
    public partial class Meniu : Form
    {
        public Meniu()
        {
            InitializeComponent();
        }

        private void buttonMagazine_Click(object sender, EventArgs e)
        {
            AdaugaMagazin admag = new AdaugaMagazin();
            admag.Show();
            this.Hide();
        }

        private void buttonRaioane_Click(object sender, EventArgs e)
        {
            AdaugaRaion adrai = new AdaugaRaion();
            adrai.Show();
            this.Hide();
        }

        private void buttonDesfaceri_Click(object sender, EventArgs e)
        {
            AdaugaDesfacere addes = new AdaugaDesfacere();
            addes.Show();
            this.Hide();
        }

        private void Meniu_Load(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonInapoi_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }
    }
}
