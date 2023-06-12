using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class CabinetMedical
    {
        private readonly string numeCabinet = "Cabinet Bella";
        private readonly string adresaCabinet = " Bulevardul Titu Maiorescu , nr 9 ,Cluj , Judetul Cluj ";
        private readonly int oraDeschidere = 8;
        private readonly int oraInchidere = 16;

        public CabinetMedical(string numeCabinet, string adresaCabinet, int oraDeschidere, int oraInchidere)
        {
            this.numeCabinet = (numeCabinet);
            this.adresaCabinet = (adresaCabinet);
            this.oraDeschidere = (oraDeschidere);
            this.oraInchidere = (oraInchidere);

        }
        public void Text()
        {
            Console.WriteLine($"{this.numeCabinet} este situat pe strada {this.adresaCabinet} .Program : ora deschidere {this.oraDeschidere} - ora inchidere {this.oraInchidere}");

        }
    }
}
