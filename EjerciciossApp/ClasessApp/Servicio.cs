using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasessApp
{
    public class Servicio : Carrito
    {
        public string Codigo_servicio { get; set; }
        public string Nombre_servicio { get; set; }
        public double Importe { get; set; }
        public double dameCosto()
        {
            return Importe;
        }
    }
}
