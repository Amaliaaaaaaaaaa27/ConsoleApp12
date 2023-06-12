using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Pacient
    {

        private readonly string nume;
        private readonly string prenume;
        private readonly int varsta;
        private readonly int cnp;


        public Pacient(string nume, string prenume, int varsta, int cnp)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.varsta = varsta;
            this.cnp = cnp;
        }
        public void Text()
        {
            Console.WriteLine($"Numele dumneavoastra este {nume} {prenume} , varsta {varsta} ");
        }
        public void VerificareVarsta(int varsta)
        {
            if (varsta < 18)
            {
                Console.WriteLine("!!! Trb sa fiti insotit de un reprezentant legal si sa aveti la dumneavoastra copie dupa certificatul de nastere  ");
            }
            else
            {
                Console.WriteLine("!!! Sa aveti la dumneavoastra o copie dupa buletin");
            }
        }
        public int VerificareCnp(int cnp)
        {
            int counter = 0;
            int i = 1;

            while (i < 15)
            {

                cnp = cnp % 10;
                cnp = cnp / 10;

                counter++;

                i++;
            }
            if (counter == 13)
            {
                Console.WriteLine($"Cnp ul a fost introdus corect are {counter} cifre");
            }
            else if (counter < 13)
            {
                Console.WriteLine($"Cnp ul dumneavoastra este prea scurt are {counter} cifre  , va rog verificati inca o data ");
            }
            else
            {
                Console.WriteLine("Cnp ul contine prea multe cifre verificati inca o data");
            }

            return counter;
        }


    }

}
