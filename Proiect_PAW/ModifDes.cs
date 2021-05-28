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
    public partial class ModifDes : Form
    {
        Desfaceri d;
        List<Desfaceri> listadesfaceri = new List<Desfaceri>();

        public ModifDes(Desfaceri des)
        {
            InitializeComponent();
            d = des;

            if (d.modalitate.Length > 0)
            {
                cbModalitate.Text = d.modalitate;
                tbIncasariMin.Text = d.incasariMin.ToString();
                tbIncasariMax.Text = d.incasariMax.ToString();
                tbTva.Text = d.tva.ToString();
                tbLucratorCom.Text = d.lucratorcomercial;
            }
        }

        private void buttonModifica_Click(object sender, EventArgs e)
        {
            d.modalitate = cbModalitate.Text;
            d.incasariMin = Convert.ToInt32(tbIncasariMin.Text);
            d.incasariMax = Convert.ToInt32(tbIncasariMax.Text);
            d.tva = Convert.ToDouble(tbTva.Text);
            d.lucratorcomercial = tbLucratorCom.Text;

            DialogResult = DialogResult.OK;
        }
    }
}
