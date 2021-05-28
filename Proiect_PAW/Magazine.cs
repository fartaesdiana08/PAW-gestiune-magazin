using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    [Serializable]
    public class Magazine
    {
        public int idMagazin;
        public string denumire;
        public string locatie;
        public string program;
        public int nrAngajati;
        public string parcare;


        public Magazine()
        {
            this.idMagazin = 0;
            this.denumire = "anonim";
            this.locatie = "necunsocut";
            this.program = "nespecificat";
            this.nrAngajati = 0;
            this.parcare = "necunoscut";
        }

        public Magazine(int idMagazin, string denumire, string locatie, string program, int nrAngajati, string parcare)
        {
            this.idMagazin = idMagazin;
            this.denumire = denumire;
            this.locatie = locatie;
            this.program = program;
            this.nrAngajati = nrAngajati;
            this.parcare = parcare;
        }
    }
}
