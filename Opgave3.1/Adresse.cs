using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave3._1
{
    internal class Adresse
    {
        private string navn;
        private int husNr;

        public Adresse(string navn, int husNr)
        {
            this.navn = navn;
            this.husNr = husNr;
        }

        public override string ToString()
        {
            return navn + " " + husNr;
        }
        
    }
}
