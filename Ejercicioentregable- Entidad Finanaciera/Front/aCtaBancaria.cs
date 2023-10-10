using Back;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front
{
    public partial class aCtaBancaria : Form
    {
        Principal principal = new Principal();
        public aCtaBancaria()
        {
            InitializeComponent();
        }

        private void butGuardar_Click(object sender, EventArgs e)
        {
            Cuenta_Bancaria nuevaCuenta = new Cuenta_Bancaria();
            nuevaCuenta.numeroCuenta = int.Parse(txtnumcuenta.Text);
            //nuevaCuenta.titular = (Cliente)txttitular.Text; 
            nuevaCuenta.tipo = txttipo.Text;
            nuevaCuenta.saldo = double.Parse(txtsaldo.Text);

            principal.CrearCuentaBancaria(nuevaCuenta);
        }
    }
}
