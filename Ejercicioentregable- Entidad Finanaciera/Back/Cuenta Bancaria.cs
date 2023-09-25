using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class Cuenta_Bancaria
    {
        public int idCuentaBancaria { get; set; }
        public int numeroCuenta { get; set; }
        public double saldo { get; set; }
        public string tipo { get; set; }//ver si debo crear las clases de Corriente o Ahorro
        public Cliente titular { get; set; }
    }
}
