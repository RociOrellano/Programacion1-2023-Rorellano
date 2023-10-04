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
    public partial class MenuEntidad : Form
    {
        public MenuEntidad()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aCliente form = new aCliente();
            form.Show();
            this.Hide();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // mostrar la tabla de clientes
        }

        private void nuevaCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aCtaBancaria form = new aCtaBancaria();
            form.Show();
            this.Hide();
        }

        private void cuentasBancariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // mostrar tabla
        }

        private void emitirNuevaTarjetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aTarjetaCredito form = new aTarjetaCredito();
            form.Show();
            this.Hide();
        }
    }
}
