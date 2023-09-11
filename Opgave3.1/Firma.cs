using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave3._1
{
    internal class Firma : IHarAdresse
    {
        private String navn;
        private Adresse adr;

        public Firma(String navn, Adresse adr)
        {
            this.navn = navn;
            this.adr = adr;
        }

        public String Navn
        {
            get { return navn; }
            set { navn = value; }
        }

        public Adresse Adresse
        {
            get { return adr; }
            set { adr = value; }
        }


        public override string ToString()
        {
            return "Firmanavn og adr. : " + navn + " " + adr;
        }
    }


}
