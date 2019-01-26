using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cetverokuti
{
    class Pravokutnik: Cetverokut
    {
        public int DuzinaB;
        //Svojstvo duzina stranice b
        public int duzinab { get => DuzinaB; set => DuzinaB = value; }

        //konstruktor u kojem se upisuje i stranica b
        public Pravokutnik(string Vrsta, int DuzinaA, int DuzinaB) : base(Vrsta,DuzinaA)
        {
            this.DuzinaB = DuzinaB;
        }

    }
}
