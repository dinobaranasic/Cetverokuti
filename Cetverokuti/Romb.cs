using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cetverokuti
{
    class Romb : Cetverokut
    {
        public int StupnjeviKutaAlfa;

        //Svojstvo kuta alfe
        public int kutalfa { get => StupnjeviKutaAlfa; set => StupnjeviKutaAlfa = value; }

        //konstruktor u kojem se upisuje i stranica b
        public Romb(string Vrsta, int DuzinaA, int StupnjeviKutaAlfa) : base(Vrsta, DuzinaA)
        {
            this.StupnjeviKutaAlfa = StupnjeviKutaAlfa;
        }

        public override string IzracunajPovrsinu()
        {
            double visina = DuzinaA * Math.Sin(StupnjeviKutaAlfa);
            return "Povrsina Romba je:" + (DuzinaA * visina);
        }
    }
}
