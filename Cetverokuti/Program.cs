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

            //Prvi cetverokut(3, 4), Drugi(5, 5)

            //Cetverokut sa dva para razlicitih stranica
            int prvia = 3;
            int prvib = 4;

            //Ispitivanje dali ima razlicite ili jednake stranice
            if (prvia != prvib)
            {
                Console.WriteLine("Cetverokut ima razlicite stranice i sigurno nije kvadrat. Povrsina je: " + (prvia * prvib));
            }
            else
            {
                Console.WriteLine("Cetverokut ima jednake stranice i sigurno nije pravokutnik. Povrsina: " + (prvia * prvia));
            }


                //Cetverokut sa svim stranicama jednake duljine
            int drugia = 5;
            int drugib = 5;

            if (drugia != drugib)
            {
                Console.WriteLine("Cetverokut ima razlicite stranice i sigurno nije kvadrat. Povrsina je: " + (drugia * drugib));
            }
            else
            {
                Console.WriteLine("Cetverokut ima jednake stranice i sigurno nije pravokutnik. Povrsina: " + (drugia*drugib));
            }


            /*
             * Koliki je potencijal ovog rješenja da se jednostavno primijeni za podatke novih 10 cetverokuta?
             * Novih 20 cetverokuta? Novih 100 cetverokuta? 1000 cetverokuta? ....
             * Kolika je mogućnost primjene ovog rješenja uz porast količine podataka 
             * tj. posla koji on mora odraditi? 
             * Kolika je skalabilnost? 
             */
        }
    }
}
