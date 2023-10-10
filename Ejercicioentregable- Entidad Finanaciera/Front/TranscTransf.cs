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
    public partial class TranscTransf : Form
    {
        Principal principal = new Principal();
        public TranscTransf()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            principal.RealizarTransferencia((Cuenta_Bancaria)txtCuentadestino, double.Parse(txtMontoTrf.Text);
            // resolver y agregar a las transacciones
        }
    }
}
