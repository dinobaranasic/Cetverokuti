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
            c1.Vrsta = "Pravokutnik";
            c1.DuzinaA = 3;
            c1.DuzinaB = 4;

            Cetverokut c2 = new Cetverokut();
            c2.Vrsta = "Pravokutnik";
            c2.DuzinaA = 5;
            c2.DuzinaB = 5;

            List<Cetverokut> cetverokuti = new List<Cetverokut>();
            cetverokuti.Add(c1);
            cetverokuti.Add(c2);

        }
    }
}
