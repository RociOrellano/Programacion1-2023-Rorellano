using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class Cliente
    {
        [Key]
        public int idCliente { get; set; } //autonumérico
        public string nombre { get; set; }
        public string apellido { get; set;}
        public int dni { get; set; }
       
    }
}
