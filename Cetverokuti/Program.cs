using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cetverokuti
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ZADATAK
             * Stvoriti popis cetverokuta; programsku podršku
             * za razne primjene gdje je potreban popis cetverokuta
             */

            //Nije moguce stvoriti objekt Cetverokut bez konstruktora
            //Cetverokut c1 = new Cetverokut();
            //c1.PostaviVrstu("Pravokutnik");
            //c1.PostaviDuzinaA(3);
            //c1.PostaviDuzinaB(4);
            //c1.ispisVrstaDuzinaADuzinaB();

            //Nije moguce stvoriti objekt Cetverokut bez konstruktora
            //Cetverokut c2 = new Cetverokut();
            //c2.PostaviVrstu("Kvadrat");
            //c2.PostaviDuzinaA(5);
            //c2.PostaviDuzinaB(5);
            //c2.ispisVrstaDuzinaADuzinaB();

            //Nije moguce stvoriti objekt Cetverokut bez konstruktora
            //Cetverokut c3 = new Cetverokut();
            //c3.vrsta = "Romb";
            //c3.duzinaA = 3;
            //c3.duzinaB = 3;
            //c3.ispisVrstaDuzinaADuzinaB();

            Cetverokut c1 = new Cetverokut("Pravokutnik", 3, 4);
            c1.ispisVrstaDuzinaADuzinaB();
            Cetverokut c2 = new Cetverokut("Kvadrat", 5, 5);
            c2.ispisVrstaDuzinaADuzinaB();
            Cetverokut c3 = new Cetverokut("Romb", 3, 3);
            c3.ispisVrstaDuzinaADuzinaB();

            List<Cetverokut> cetverokuti = new List<Cetverokut>();
            cetverokuti.Add(c1);
            cetverokuti.Add(c2);
            cetverokuti.Add(c3);

        }
    }
}
