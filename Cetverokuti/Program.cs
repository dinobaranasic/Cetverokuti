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

            Cetverokut c1 = new Cetverokut();
            c1.PostaviVrstu("Pravokutnik");
            c1.PostaviDuzinaA(3);
            c1.PostaviDuzinaB(4);
            c1.ispisVrstaDuzinaADuzinaB();

            Cetverokut c2 = new Cetverokut();
            c2.PostaviVrstu("Kvadrat");
            c2.PostaviDuzinaA(5);
            c2.PostaviDuzinaB(5);
            c2.ispisVrstaDuzinaADuzinaB();

            List<Cetverokut> cetverokuti = new List<Cetverokut>();
            cetverokuti.Add(c1);
            cetverokuti.Add(c2);

        }
    }
}
