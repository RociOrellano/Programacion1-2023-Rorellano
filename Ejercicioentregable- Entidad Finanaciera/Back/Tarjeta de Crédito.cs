using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class Tarjeta_de_Crédito
    {
        public int idTarjetaCredito { get; set; }
        public int numerotarjeta { get; set; }
        public double limiteCredito { get; set; }
        public string estado { get; set; } // Activa,Pausada,Bloqueada
    }
}
