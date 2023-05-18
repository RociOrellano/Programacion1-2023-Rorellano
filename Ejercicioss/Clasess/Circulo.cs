using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasess
{
    public class Circulo : FiguraGeometrica
    {
        public double radio { get; set; }
        public override double CalcularArea()
        {
            return 3.14 * (radio * radio);
            //Math.PI* Math.Pow(radio,2)
        
        }
    }
}
