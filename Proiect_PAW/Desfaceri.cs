using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    public class Desfaceri
    {
        public string modalitate; //online sau fizic
        public int incasariMin;
        public int incasariMax;
        public double tva;
        public string lucratorcomercial;

        public Desfaceri()
        {
            this.modalitate = "necunsocut";
            this.incasariMin = 0;
            this.incasariMax = 0;
            this.tva = 0;
            this.lucratorcomercial = "anonim";
        }

        public Desfaceri(string modalitate, int incasariMin, int incasariMax, double tva, string lucratorcomercial)
        {
            this.modalitate = modalitate;
            this.incasariMin = incasariMin;
            this.incasariMax = incasariMax;
            this.tva = tva;
            this.lucratorcomercial = lucratorcomercial;
        }
    }
}
