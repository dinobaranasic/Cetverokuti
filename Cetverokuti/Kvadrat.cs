using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cetverokuti
{
    class Kvadrat : Cetverokut
    {
        public Kvadrat(string Vrsta, int DuzinaA) : base(Vrsta, DuzinaA)
        {
            //napisani konstruktor koji prima dva parametra isto kao i u baznom razredu
        }

        public override string IzracunajPovrsinu()
        {
            return "Povrsina Kvadrata je:" + (DuzinaA*DuzinaA);
        }
    }
}
