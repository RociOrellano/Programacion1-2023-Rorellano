using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class Tarjeta_de_Crédito
    {
        [Key]
        public int idTarjetaCredito { get; set; } //autonumerico
        public int numerotarjeta { get; set; }
        public double limiteCredito { get; set; }
        public string estado { get; set; } // Activa,Pausada,Bloqueada
        public double montoDeuda { get; set; }
        public Cliente titular { get; set; }
        List<Transacciones> listaTransacciones { get; set;}


    }
}
