using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Medic
    {
        private readonly string numeDoctor = "Denisa Lescaie";
        private readonly int varstaDoctor = 35;
        private readonly string specializare = "cardiologie";


        public Medic(string numeDoctor, int varstaDoctor, string specializare)
        {
            this.numeDoctor = numeDoctor;
            this.varstaDoctor = varstaDoctor;
            this.specializare = specializare;
        }
        public void Text()
        {
            Console.WriteLine($"Doctorul {this.numeDoctor} cu varsta{this.varstaDoctor} are specializarea de {this.specializare}");
        }



    }
}

