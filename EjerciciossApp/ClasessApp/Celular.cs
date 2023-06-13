using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasessApp
{
    public class Celular : Carrito
    {
        public int precio { get; set; }
        public string numero { get; set; }
        public MarcaCelular marca { get; set; }
        // composicion de clases ("un objeto dentro de otro")

        public double dameCosto()
        {
            return precio;
        }
    }
}
