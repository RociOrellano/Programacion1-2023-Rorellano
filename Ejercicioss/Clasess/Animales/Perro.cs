using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasess
{
    public class Perro : Animal
    { 
        public string raza { get; set; } 
        public override string hacerSonido()
        {
            return "guau";
        }
    }
}
