using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasessApp
{
    public class Producto : Carrito
    {
        public string Codigo_producto { get; set; }
        public string Marca_producto { get; set; }
        public double Precio_producto { get; set; }
        public double dameCosto()
        { 
            return Precio_producto; 
        }
    }
}
