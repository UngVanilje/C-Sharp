using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_5_6
{
    internal interface IAnimal
    {
        bool isDog();

    }

    public class Animal : IAnimal
    {
        public string Species { get; set; }

        public Animal (string species)
        {
            this.Species = species;
        }
        public bool isDog()
        {
            if(this.Species == "Dog")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
   
}
