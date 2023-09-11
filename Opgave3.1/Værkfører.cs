using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave3._1
{
    internal class Værkfører: Mekaniker
    {
        private int udnævnelsesår;
        private double tillæg;

        public Værkfører(String navn, Adresse adresse, cprNr cpr, int årstal, double timeloen, int udnævnelsesår, double tillæg) : 
            base(navn, adresse, cpr, årstal, timeloen)
        {
            this.udnævnelsesår = udnævnelsesår;
            this.tillæg = tillæg;
        }

        public double Udnævnelsesår
        {
            get { return udnævnelsesår; }
            set { udnævnelsesår = (int)value; }
        }

        public double Tillæg
        {
            get { return tillæg; }
            set { tillæg = value; }
        }

        public override double BeregnLøn()
        {
            return 37 * Timeloen + tillæg;
        }

    }
   
}
