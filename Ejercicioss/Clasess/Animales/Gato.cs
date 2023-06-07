using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasess
{
    public class Gato : Animal
    {
        public string pelaje { get; set; }
        public override string hacerSonido()
        {
            return "miau";
        }
    }
}
