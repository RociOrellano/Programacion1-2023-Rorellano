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
    public partial class PagoTarjeta : Form
    {
        Principal principal = new Principal();
        public PagoTarjeta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            principal.PagarTarjetaCredito(double.Parse(txtMontoPago.Text));
            //Agregar a transacciones

        }
    }
}
