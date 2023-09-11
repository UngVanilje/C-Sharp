using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave3._1
{
    internal class cprNr
    {

        private String dato;
        private String nr;

        public cprNr(String dato, String nr)
        {
            this.dato = dato;
            this.nr = nr;
        }
        public String getDato() { return dato; }
        public String getNr() { return nr; }

        public override string ToString()
        {
            return nr;
        }
    }
}
