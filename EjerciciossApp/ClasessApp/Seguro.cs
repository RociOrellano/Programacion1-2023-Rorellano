using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasessApp
{
    public class Seguro : Carrito
    {
        public int numeroPoliza { get; set; }
        public double Premio { get; set; } // seria el precio pero en seguros 
                                           // se dice de esa forma

        public double dameCosto()
        {
            return Premio; 
        }

    }
}
