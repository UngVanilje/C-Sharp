using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave3._1
{
    internal abstract class Medarbejder : IHarAdresse
    {
        private Adresse adresse;
        private string navn;
        public cprNr cpr;

        public Medarbejder(String navn, Adresse adr, cprNr cpr)
        {
            this.navn = navn;
            this.adresse = adr;
            this.cpr = cpr;
        }

        public string Navn
        {
            get { return navn; }
            set { navn = value; }
        }

        public Adresse Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }

        public override string ToString()
        {
            return navn + " " + adresse + " " + cpr.ToString() + " " + BeregnLøn();
        }

        public abstract double BeregnLøn();
    }
}
