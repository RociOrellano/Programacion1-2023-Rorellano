using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class Transacciones
    {
        [Key]
        public DateTime fechaHora { get; set; }
        public string concepto { get; set; }
        public double monto { get; set; }
    }
}
