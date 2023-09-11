using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave3._1
{
    internal class Mekaniker: Medarbejder
    {
        private int årstal;
        private double timeloen;

    public Mekaniker(String navn, Adresse adresse,cprNr cpr, int årstal, double timeloen) :
            base(navn, adresse, cpr)
        {
            this.årstal = årstal;
            this.timeloen = timeloen;
        }

        public int Årstal
        {
            get { return årstal; }
            set { årstal = value; }
        }

        public double Timeloen
        {
            get { return timeloen; }
            set { timeloen = value; }
        }

        public override double BeregnLøn()
        {
            return 37 * timeloen;
        }

        
    }
}
