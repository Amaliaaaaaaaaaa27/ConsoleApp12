using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class ProgramarePacient
    {
        private int data;
        private int luna;
        private int an = 2023;

        private string numeDoctor;


        public ProgramarePacient(int data, int luna, int an)
        {
            this.data = data;
            this.luna = luna;
            this.an = an;

        }
        public ProgramarePacient(string numeDoctor)
        {
            this.numeDoctor = numeDoctor;

        }
        public int ConditieSarbatori()
        {
            if ((this.data == 25 && this.luna == 9) || (this.data == 16 && this.luna == 4) || (this.data == 1 && this.luna == 6))
            {
                Console.WriteLine("Cabientul este inchis .Schimbati data sau luna !!!");
            }
            return 1;
        }
        public int Programari()
        {

            int[] zileTrecute = { 1, 2, 3, 4, 5 }; // aceste zile sunt ocupate 
            for (int i = 0; i < zileTrecute.Length; i++)// foreach parcurge zilele
            {
                if (luna == 6 && data == zileTrecute[i])
                {
                    Console.WriteLine(" Aceste zile au fost ocupate .Va rugam sa introduceti alta data !!!!");
                    break;
                }
                else if (luna != 6 && data != zileTrecute[i])
                {
                    Console.WriteLine($" Programarea s a realizat cu succes . Aveti programare in data {this.data} , luna {this.luna}  la doctorul {this.numeDoctor}");
                }

            }
            return zileTrecute.Length;
        }

    }
}

