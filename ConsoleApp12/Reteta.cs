using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Reteta
    {

        private string medicament1 = "CalmCardio";
        private string medicament2 = "stopTensiune";

        private string numeDoctor = "Denisa Lescaie";

        public Reteta(string medicament1, string medicament2)
        {
            this.medicament1 = medicament1;
            this.medicament2 = medicament2;
        }
        public Reteta(string numeDoctor)
        {
            this.numeDoctor = numeDoctor;

        }

        public void Text()
        {
            Console.WriteLine($"Reteta a fost emisa de catre doctorul {this.numeDoctor} iar medicamentele sunt {medicament1} si {medicament2} ");
        }
    }
}
