using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cetverokuti
{
    class Cetverokut
    {
        public string Vrsta;
        public int DuzinaA;
        public int DuzinaB;

        public void ispisVrstaDuzinaADuzinaB()
        {
            Console.WriteLine("Vrsta cetverokuta: {0}, Duzina stranice a: {1}, Duzina stranice b: {2}", Vrsta, DuzinaA, DuzinaB);
        }

    }
}
