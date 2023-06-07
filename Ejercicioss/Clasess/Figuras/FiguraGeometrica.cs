using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasess
{
    public abstract class FiguraGeometrica
    {
        public string Nombre { get; set; }
        public abstract double CalcularArea();

        public string DecimeQuienSos()
        {
            return "Hola, me llamo " + Nombre + " y mi area es: " + CalcularArea();
        }


    }
}
