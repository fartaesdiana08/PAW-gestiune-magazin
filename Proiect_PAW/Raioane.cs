using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    public class Raioane
    {
        public int codRaion;
        public string denumire;
        public string sefRaion;

        public Raioane()
        {
            this.codRaion = 0;
            this.denumire = "necunsocut";
            this.sefRaion = "anonim";
        }

        public Raioane(int codRaion, string denumire, string sefRaion)
        {
            this.codRaion = codRaion;
            this.denumire = denumire;
            this.sefRaion = sefRaion;
        }
    }
}
