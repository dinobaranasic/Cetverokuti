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
