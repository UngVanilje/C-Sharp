using Lektion8;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave8_1.Model
{
    [Table("ejere")]
    public class Ejer
    {
        
        public int EjerID { get; set; }
        public string Ejernavn { get; set; }
        public virtual List<Bil> Biler { get;} = new List<Bil>();


        public Ejer(string ejerNavn): this()
        {
            Ejernavn = ejerNavn;
        }
        public Ejer ()
        {
            Biler = new List<Bil>();
        }
        public override string ToString()
        {
            return Ejernavn;
        }
    }
}
