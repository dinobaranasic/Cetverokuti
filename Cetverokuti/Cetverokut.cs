using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cetverokuti
{
    class Cetverokut
    {
        //Sakrivanje podataka,onemugucanje pristupa
        private string Vrsta;
        private int DuzinaA;
        private int DuzinaB;

        // Izraditi razred tako da ...
        // Sadrži konstruktor kojim se postavljaju podaci, 
        // onemogućiti stvaranje objekta bez podataka.
        /*
        public Cetverokut()
        {
            // Onemogućavanje stvaranja objekta bez podataka -->
            // izostaviti podrazumijevani konstruktor iz koda 
            //  i izraditi drugi(e) konstruktore
        }
        */

        //Konstruktor koji prima 3 parametra(Vrsta, DuzinaA, DuzinaB)
        public Cetverokut(string Vrsta, int DuzinaA, int DuzinaB)
        {
            this.Vrsta = Vrsta;
            this.DuzinaA = DuzinaA;
            this.DuzinaB = DuzinaB;
        }

        //Svojstvo Vrsta
        public string vrsta
        {
            get
            {
                return Vrsta;
            }

            set
            {
                Vrsta = value;
            }
        }

        //Svojstvo marka moze pisati i na nacin:
        //public string vrsta { get => Vrsta; set => Vrsta = value; }

        //Svojstvo DuzinaA
        //public int duzinaA
        //{
        //    get
        //    {
        //        return DuzinaA;
        //    }

        //    set
        //    {
        //        DuzinaA = value;
        //    }
        //}

        //Svojstvo DuzinaA moze pisati i na nacin:
        public int duzinaA { get => DuzinaA; set => DuzinaA = value; }

        //Svojstvo DuzinaB
        public int duzinaB { get => DuzinaB; set => DuzinaB = value; }

        //Metoda za postavljanje podataka "Vrsta"
        public void PostaviVrstu(string Vrsta)
        {
            this.Vrsta = Vrsta;
        }

        //Metoda za dohvat podatak "Vrsta"
        public string DohvatiVrstu()
        {
            return Vrsta;
        }

        //Metoda za postavljanje podataka "DuzinaA"
        public void PostaviDuzinaA(int DuzinaA)
        {
            this.DuzinaA = DuzinaA;
        }

        //Metoda za dohvat podataka "DuzinaA"
        public int DohvatiDuzinaA()
        {
            return DuzinaA;
        }

        //Metoda za postavljanje podataka "DuzinaB"
        public void PostaviDuzinaB(int DuzinaB)
        {
            this.DuzinaB = DuzinaB;
        }

        //Metoda za dohvat podataka "DuzinaB"
        public int DohvatiDuzinaB()
        {
            return DuzinaB;
        }

        //Metoda za ispis podatak "Vrsta, DuzinaA, DuzinaB"
        public void ispisVrstaDuzinaADuzinaB()
        {
            Console.WriteLine("Vrsta cetverokuta: {0}, Duzina stranice a: {1}, Duzina stranice b: {2}", Vrsta, DuzinaA, DuzinaB);
        }

    }
}
