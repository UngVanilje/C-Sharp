using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave3._1
{
    internal class Synsmand: Mekaniker
    {
        private int antalSyn;
        private double ugeLøn;

        public Synsmand(String navn, Adresse adresse, cprNr cpr, int årstal, double timeloen, int antalSyn, double ugeLøn) : 
            base(navn, adresse, cpr, årstal, timeloen)
        {
            this.antalSyn = antalSyn;
            this.ugeLøn = 290 * antalSyn;
        }

        public int AntalSyn
        {
            get { return antalSyn; }
            set { antalSyn = value; }
        }

        public double UgeLøn
        {
            get { return ugeLøn; }
        }


        public override double BeregnLøn()
        {
            return 37 * Timeloen + ugeLøn;
        }
    }
}
